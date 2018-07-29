using BLL;
using BLL.Entities;
using Janus.Windows.GridEX;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridReportFlexibleRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid, Report reportType, DateTime? dateFrom, DateTime? dateTo)
        {
            dataTable.Clear();

            string whereClause = "";
            if (dateFrom != null || dateTo != null)
            {
                if (dateFrom == null || dateTo == null)
                {
                    whereClause = string.Format("DataFiltr = '{0}'", dateFrom == null ? dateTo.GetValueOrDefault().ToString("yyyy-MM-dd") : dateFrom.GetValueOrDefault().ToString("yyyy-MM-dd"));
                }
                else
                {
                    whereClause = string.Format("DataFiltr BETWEEN '{0}' AND '{1}'", dateFrom.GetValueOrDefault().ToString("yyyy-MM-dd"), dateTo.GetValueOrDefault().ToString("yyyy-MM-dd"));
                }
            }

            SqlCommand cmdSelect = new SqlCommand("[dbo].[Raport]");
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.StoredProcedure;

            cmdSelect.Parameters.AddWithValue("@RapId", reportType.Id);
            if (!string.IsNullOrEmpty(whereClause))
                cmdSelect.Parameters.AddWithValue("@where", whereClause);


            dataAdapter.SelectCommand = cmdSelect;
           
            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }
    }
}
