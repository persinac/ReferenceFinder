using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReferenceFinder
{
    class ExcelUtility
    {
        Microsoft.Office.Interop.Excel.Application xlApp;
        object misValue;
        Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
        Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
        public ExcelUtility()
        {
            xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }
            misValue = System.Reflection.Missing.Value;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = null;
            xlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            xlWorkSheet.Cells[1, 1] = "SP Name";
            xlWorkSheet.Cells[1, 2] = "Product Reference?";
            xlWorkSheet.Cells[1, 3] = "Has Exec?";
            xlWorkSheet.Cells[1, 4] = "DLL";
        }

        public Boolean SaveTableToExcel(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                xlWorkSheet.Cells[i + 2, 1] = table.Rows[i][0].ToString();
                xlWorkSheet.Cells[i + 2, 2] = table.Rows[i][1];
                xlWorkSheet.Cells[i + 2, 3] = table.Rows[i][2];
                xlWorkSheet.Cells[i + 2, 4] = table.Rows[i][3];
            }

            xlWorkBook.SaveAs("c:\\SVN\\csharp-Excel.xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);

            MessageBox.Show("Excel file created , you can find the file c:\\SVN\\csharp-Excel.xls");
            return false;
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }
    }
}
