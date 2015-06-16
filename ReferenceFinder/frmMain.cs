using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Sdk.Sfc;

namespace ReferenceFinder
{
    public partial class frmMain : Form
    {
        Stream myStream = null;
        public XMLUtility util;
        public DataTableUtility dtu;
        public DataTable table;
        DataTable master;
        FileSearcher fs;
        DataTable listOfCatSPs = null;
        DataTable listOfSPsToExclude = null;
        public String databaseToUse = "";
        String dllName = "";

        public frmMain()
        {
            InitializeComponent();
            util = new XMLUtility();
            dtu = new DataTableUtility();
            master = new DataTable();

            int columns = 4;
            for (int i = 0; i < columns; i++)
            {
                master.Columns.Add();
            }
            master.Columns[0].ColumnName = "spName";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\SVN\\SalesMarketing\\DLLs\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                try {
                    if ((myStream = openFileDialog1.OpenFile()) != null) {
                        
                        FileStream fileStream = myStream as FileStream;
                        if (fileStream != null) {
                            txtFileName.Text = fileStream.Name;
                            if (fileStream.Name.IndexOf("CRUD\\") > 0)
                            {
                                this.dllName = fileStream.Name.Substring(fileStream.Name.IndexOf("CRUD\\") + 5);
                            }
                            else if (fileStream.Name.IndexOf("Maps\\") > 0)
                            {
                                this.dllName = fileStream.Name.Substring(fileStream.Name.IndexOf("Maps\\") + 5);
                            }
                            else if (fileStream.Name.IndexOf("Exists\\") > 0)
                            {
                                this.dllName = fileStream.Name.Substring(fileStream.Name.IndexOf("Exists\\") + 7);
                            }
                            
                        }
                    }
                }
                catch (Exception ex) {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void btnParseFile_Click(object sender, EventArgs e)
        {
            util.ParseXMLFile(myStream);
            List<String> listOfColNames = new List<String>();
            
            listOfColNames.Add("SP Name");
            listOfColNames.Add("Product Ref");
            listOfColNames.Add("Has Exec");
            listOfColNames.Add("DLL");
            table = dtu.ConvertListToDataTable(util.GetListOfSPs(listOfSPsToExclude), 4, listOfColNames);
            this.dataGridView1.DataSource = table;
            ResizeColumns();
        }

        private void ResizeColumns() {
            this.dataGridView1.AutoResizeColumns();
            this.dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            myStream = null;
            util = new XMLUtility();
            dtu = new DataTableUtility();
            txtFileName.Text = "";
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            String spName = table.Rows[e.RowIndex][0].ToString();
        }

        private void btnFindProduct_Click(object sender, EventArgs e)
        {
            string s = "";
            int[] prodRef;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                s = table.Rows[i][0].ToString();
                fs = new FileSearcher(s, this.databaseToUse);
                prodRef = fs.SearchFile();
                if (prodRef[0] == 9){ table.Rows[i][1] = "FnF"; }
                else if (prodRef[0] == 0) { table.Rows[i][1] = "No"; }
                else if (prodRef[0] == 1) { table.Rows[i][1] = "Yes"; }

                if (prodRef[1] == 9) { table.Rows[i][2] = "FnF"; }
                else if (prodRef[1] == 0) { table.Rows[i][2] = "No"; }
                else if (prodRef[1] == 1) { table.Rows[i][2] = "Yes"; }
                table.Rows[i][3] = this.dllName;
                this.dataGridView1.Update();
                fs = null;
            }
        
        }

        private void btnToXLS_Click(object sender, EventArgs e)
        {
            ExcelUtility xlsUtil = new ExcelUtility();
            xlsUtil.SaveTableToExcel(master);
        }

        private void btnMasterSave_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in table.Rows) {
                if (FindValue(dr[0].ToString()))
                {
                    master.Rows.Add(dr.ItemArray);
                }
            }
            grdMasterDLLs.Rows.Add(this.dllName);
        }
        private bool FindValue(string s)
        {
            bool val = false;
            DataRow[] foundRow = master.Select("spName = '"+s+"'");

            if (foundRow.Length < 1)
            {
                val = true;
            }
            else
            {
                val = false;
            }

            return val;
        }

        private void btnOpenDB_Click(object sender, EventArgs e)
        {
            frmDBObjects dbo = new frmDBObjects(this);
            dbo.Show();
        }

        private void btnSPsToExclude_Click(object sender, EventArgs e)
        {
            frmSPsToExclude spte = new frmSPsToExclude(this);
            spte.Show();
        }

        public void SetListOfCatSPs(DataTable listOfSPs)
        {
            this.listOfCatSPs = listOfSPs;
        }

        public void SetListOfSPsToExclude(DataTable listOfSPs)
        {
            this.listOfSPsToExclude = listOfSPs;
        }

        public void SetDatabaseToUse(String db)
        {
            this.databaseToUse = db;
        }

        
    }
}
