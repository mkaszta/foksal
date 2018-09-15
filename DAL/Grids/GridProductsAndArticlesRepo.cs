using BLL;
using Janus.Windows.GridEX;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridProductsAndArticlesRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid, DateTime? dateFrom, DateTime? dateTo)
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
