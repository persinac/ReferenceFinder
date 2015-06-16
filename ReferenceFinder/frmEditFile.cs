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

namespace ReferenceFinder
{
    public partial class frmEditFile : Form
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
        String fileName = "";


        public frmEditFile()
        {
            InitializeComponent();
            util = new XMLUtility();
            dtu = new DataTableUtility();
            master = new DataTable();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\SVN\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {

                        FileStream fileStream = myStream as FileStream;
                        if (fileStream != null)
                        {
                            if (fileStream.Name.IndexOf("OBS_Working\\") > 0)
                            {
                                this.fileName = fileStream.Name.Substring(fileStream.Name.IndexOf("OBS_Working\\") + 13);
                            }
                            else if (fileStream.Name.IndexOf("Product_Working\\") > 0)
                            {
                                this.fileName = fileStream.Name.Substring(fileStream.Name.IndexOf("Product_Working\\") + 17);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
