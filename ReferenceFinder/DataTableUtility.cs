using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceFinder
{
    public class DataTableUtility
    {
        public DataTable ConvertListToDataTable(List<string> list, int numOfColumns = 1
            , List<string> listOfColumnsNames = null, String dllName = "")
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = numOfColumns;

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();

            }

            if (listOfColumnsNames.Count > 0)
            {
                for (int i = 0; i < listOfColumnsNames.Count; i++)
                {
                    table.Columns[i].ColumnName = listOfColumnsNames[i].ToString();
                }
            }
            
            // Add rows.
            foreach (var item in list)
            {
                table.Rows.Add(item);
            }

            return table;
        }

        public DataTable ConvertListToDataTable(List<SqlSmoObject> list, int numOfColumns = 1
            , List<string> listOfColumnsNames = null)
        {
            // New table.
            DataTable table = new DataTable();

            // Get max columns.
            int columns = numOfColumns;

            // Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();

            }

            if (listOfColumnsNames.Count > 0)
            {
                for (int i = 0; i < listOfColumnsNames.Count; i++)
                {
                    table.Columns[i].ColumnName = listOfColumnsNames[i].ToString();
                }
            }

            // Add rows.
            foreach (var item in list)
            {
                table.Rows.Add(item);
            }

            return table;
        }
    }
}
