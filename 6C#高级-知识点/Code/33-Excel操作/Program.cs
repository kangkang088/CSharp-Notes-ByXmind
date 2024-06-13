using System;
using System.Data;
using System.Data.OleDb;

namespace _33_Excel操作
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "装备信息.xls";

            string connectionStr  = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + fileName + ";" + ";Extended Properties=\"Excel 8.0;HDR=YES;IMEX=1\"";

            OleDbConnection oleConnection = new OleDbConnection(connectionStr);

            oleConnection.Open();

            string sql = "select * from [Sheet1$]";

            OleDbDataAdapter oleAdapter = new OleDbDataAdapter(sql, oleConnection);

            DataSet excelData = new DataSet();

            oleAdapter.Fill(excelData);

            oleConnection.Close();

            DataTableCollection tableCollection = excelData.Tables;

            DataTable table = tableCollection[0];

            DataRowCollection rowCollection = table.Rows;

            foreach(DataRow row in rowCollection)
            {
                for(int i = 0; i < 8; i++)
                {
                    Console.Write(row[i] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
