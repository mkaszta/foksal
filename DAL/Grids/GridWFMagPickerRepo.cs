using BLL;
using Janus.Windows.GridEX;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridWFMagPickerRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet_Related(GridEX grid)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = "SELECT * FROM vProduktyPowiazane";
            this.dataAdapter.SelectCommand = cmdSelect;            

            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }

        public void BindDataSet_Unrelated(GridEX grid, DateTime? dateFrom, DateTime? dateTo)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand("[dbo].[ProcProduktyNiepowiazane]");
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.StoredProcedure;

            cmdSelect.Parameters.AddWithValue("@DataOd", dateFrom);
            cmdSelect.Parameters.AddWithValue("@DataDo", dateTo);            

            this.dataAdapter.SelectCommand = cmdSelect;

            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }
    }
}
