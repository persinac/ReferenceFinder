using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceFinder
{
    public partial class frmSPsToExclude : Form
    {
        List<String> list = null;
        DataTable tableOfSPsToExclude;
        DataTableUtility dtu;

        private frmMain mainForm = null;

        public frmSPsToExclude()
        {
            InitializeComponent();
            dtu = new DataTableUtility();
        }

        public frmSPsToExclude(Form callingForm)
        {
            mainForm = callingForm as frmMain;
            InitializeComponent();
            dtu = new DataTableUtility();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            PasteInData(ref this.grdListToExclude);
        }

        private void PasteInData(ref DataGridView dgv)
        {
            char[] rowSplitter = { '\n', '\r' };  // Cr and Lf.
            char columnSplitter = '\t';         // Tab.
            list = new List<String>();
            IDataObject dataInClipboard = Clipboard.GetDataObject();

            string stringInClipboard =
                dataInClipboard.GetData(DataFormats.Text).ToString();

            string[] rowsInClipboard = stringInClipboard.Split(rowSplitter,
                StringSplitOptions.RemoveEmptyEntries);

            int r = dgv.SelectedCells[0].RowIndex;
            int c = dgv.SelectedCells[0].ColumnIndex;

            if (dgv.Rows.Count < (r + rowsInClipboard.Length))
                dgv.Rows.Add(r + rowsInClipboard.Length - dgv.Rows.Count);

            // Loop through lines:

            int iRow = 0;
            while (iRow < rowsInClipboard.Length)
            {
                // Split up rows to get individual cells:

                string[] valuesInRow =
                    rowsInClipboard[iRow].Split(columnSplitter);

                // Cycle through cells.
                // Assign cell value only if within columns of grid:

                int jCol = 0;
                while (jCol < valuesInRow.Length)
                {
                    if ((dgv.ColumnCount - 1) >= (c + jCol))
                    {
                        dgv.Rows[r + iRow].Cells[c + jCol].Value =
                        valuesInRow[jCol];
                        list.Add(dgv.Rows[r + iRow].Cells[c + jCol].Value.ToString());
                    }
                    jCol += 1;
                } // end while

                iRow += 1;
            } // end while
        } // PasteInData

        private void btnSaveList_Click(object sender, EventArgs e)
        {
            List<String> listOfColNames = new List<String>();
            listOfColNames.Add("SPs");
            tableOfSPsToExclude = dtu.ConvertListToDataTable(list, 1, listOfColNames);
            SetListOfSPsToExclude();
        }

        private void SetListOfSPsToExclude()
        {
            //throw new NotImplementedException();
            this.mainForm.SetListOfSPsToExclude(tableOfSPsToExclude);
        } 
    }
}
