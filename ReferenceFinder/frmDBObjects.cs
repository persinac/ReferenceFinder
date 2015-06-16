using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Sdk.Sfc;

namespace ReferenceFinder
{
    public partial class frmDBObjects : Form
    {
        String sqlServerLogin = "";
        String password = "";
        String remoteSvrName = "";
        ServerConnection srvConn = null;
        Server srv = null;
        ScriptingOptions scripter = null;
        List<SqlSmoObject> list = null;
        DataTable table;
        DataTableUtility dtu;

        private frmMain mainForm = null;

        public frmDBObjects()
        {
            InitializeComponent();
            btnGetSMO.Enabled = false;
            dtu = new DataTableUtility();
            txtUsername.Text = "obssys";
            txtPass.Text = "obs2000";
            txtServerName.Text = "awcserver1";
        }

        public frmDBObjects(Form callingForm)
        {
            mainForm = callingForm as frmMain;
            InitializeComponent();
            btnGetSMO.Enabled = false;
            dtu = new DataTableUtility();
            txtUsername.Text = "obssys";
            txtPass.Text = "obs2000";
            txtServerName.Text = "awcserver1";
        }

        private void btnConnectToServer_Click(object sender, EventArgs e)
        {
            this.sqlServerLogin = txtUsername.Text;
            this.password = txtPass.Text;
            if (txtServerName.Text.Length < 1) { this.remoteSvrName = "AWCDEV1\\Server1";
            txtServerName.Text = "AWCDEV1\\Server1";
            } else { this.remoteSvrName = txtServerName.Text; }

            try {
                this.srvConn = new ServerConnection(remoteSvrName);
                this.srvConn.LoginSecure = false;
                this.srvConn.Login = sqlServerLogin;
                this.srvConn.Password = password;
                this.srv = new Server(this.srvConn);
                //Console.WriteLine(this.srv.Information.Version);   // connection is established
                this.srv.ConnectionContext.AutoDisconnectMode = AutoDisconnectMode.NoAutoDisconnect;
                rTxtInfo.AppendText("Connection successful\n");

                scripter = new ScriptingOptions();
                scripter.IncludeHeaders = true;
                scripter.SchemaQualify = true;
                scripter.ToFileOnly = true;
                rTxtInfo.AppendText("Set scripting options\n");
                rTxtInfo.Update();

                btnGetSMO.Enabled = true;
                list = new List<SqlSmoObject>();

                setupComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection unsuccessful - " + ex.ToString());
            }
            
        }

        private void setupComboBox()
        {
            foreach (Database db in this.srv.Databases) 
            {
                if (!db.IsSystemObject)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = db.Name;
                    item.Value = db.Name;
                    cboDatabase.Items.Add(item);
                }
            }
            cboDatabase.SelectedIndex = -1;
        }

        private void btnGetSMO_Click(object sender, EventArgs e)
        {
            String cboDB = cboDatabase.Text.Trim();
            Database db = this.srv.Databases[cboDB];
            List<String> frmOneList = new List<String>();
            DataTable dataTable = db.EnumObjects(DatabaseObjectTypes.StoredProcedure);
            rTxtInfo.AppendText("Retrieved Stored Procedures\n");
            rTxtInfo.Update();
            //gets list of SPs from the DLL
            frmOneList = this.mainForm.util.GetListOfSPs();
            Cursor.Current = Cursors.WaitCursor;
            foreach (DataRow row in dataTable.Rows)
            {
                string sName = (string)row["Name"];
                
                StoredProcedure sp = (StoredProcedure)this.srv.GetSmoObject(
                   new Urn((string)row["Urn"]));
                if (!sp.IsSystemObject)
                {
                    int index = IsSPInList(frmOneList, sName);
                    if (index > -1)
                    { 
                        list.Add(sp);
                        if (frmOneList.Count > 0)
                        {
                            frmOneList.RemoveAt(index);
                        }
                        
                        rTxtInfo.AppendText("Added " + sName + "to list\n");
                        
                    }
                    
                }
                else
                {
                    rTxtInfo.AppendText("System object - not added to list\n");
                    
                }  
            }
            Cursor.Current = Cursors.Default;
            rTxtInfo.Update();
            rTxtInfo.ScrollToCaret();
            populateGrid(list, 1);
            ResizeColumns();
            rTxtInfo.AppendText("Ready to script SPs\n");
            rTxtInfo.Update();
            
        }

        private void populateGrid(List<SqlSmoObject> t_list, int numColumns)
        {
            List<String> listOfColNames = new List<String>();
            listOfColNames.Add("SP");
            table = dtu.ConvertListToDataTable(list, numColumns, listOfColNames);
            SetListOfCatSPs();
            this.grdListOfSPs.DataSource = table;
        }

        private void dbObjects_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.srv.ConnectionContext.Disconnect();
            this.sqlServerLogin = "";
            this.password = "";
            this.remoteSvrName = "";
            this.srvConn = null;
            this.srv = null;
        }

        private void scriptSPs()
        {
            String folder = cboDatabase.Text.Trim();
            Cursor.Current = Cursors.WaitCursor;
            foreach (StoredProcedure sp in list)
            {
                scripter.FileName = @"C:\SVN\"+folder+"\\dbo." + sp.Name + ".StoredProcedure.sql";
                sp.Script(scripter);
                rTxtInfo.AppendText("Scripted SP: " + scripter.FileName.ToString() + "\n");
            }
            Cursor.Current = Cursors.Default;
            rTxtInfo.Update();
            SetDatabaseToUse();
            rTxtInfo.AppendText("Set database folder for frmMain");
            rTxtInfo.Update();
        }

        private void btnScriptSPs_Click(object sender, EventArgs e)
        {
            scriptSPs();
        }

        private void ResizeColumns()
        {
            this.grdListOfSPs.AutoResizeColumns();
            this.grdListOfSPs.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public int IsSPInList(List<String> listToSearch, String NameOfSP)
        {
            int retval = -1;
            if(listToSearch.Count > 0) {
                for (int i = 0; i < listToSearch.Count; i++)
                {
                    if (listToSearch[i].Equals(NameOfSP))
                    {
                        retval = i;
                        break;
                    }
                }
            }
            else
            {
                retval = 0;
            }
            

            return retval;
        }

        public void SetListOfCatSPs()
        {
            this.mainForm.SetListOfCatSPs(table);
        }

        public void SetDatabaseToUse()
        {
            this.mainForm.SetDatabaseToUse(cboDatabase.Text.Trim());
        }
    }
    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
