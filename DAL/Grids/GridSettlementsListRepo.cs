using BLL;
using Janus.Windows.GridEX;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridSettlementsListRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid, DateTime? periodFrom, DateTime? periodTo)
        {
            dataTable.Clear();

            string whereClause = "";
            if (periodFrom != null || periodTo != null)
            {
                if (periodFrom == null && periodTo != null)
                {
                    whereClause = string.Format("WHERE Okres <= '{0}'", periodFrom == null ? periodTo.GetValueOrDefault().ToString("yyyy-MM-dd") : periodFrom.GetValueOrDefault().ToString("yyyy-MM-dd"));
                }
                else if (periodFrom != null && periodTo == null)
                {
                    whereClause = string.Format("WHERE Okres >= '{0}'", periodFrom == null ? periodTo.GetValueOrDefault().ToString("yyyy-MM-dd") : periodFrom.GetValueOrDefault().ToString("yyyy-MM-dd"));
                }
                else
                {
                    whereClause = string.Format("WHERE Okres BETWEEN '{0}' AND '{1}'", periodFrom.GetValueOrDefault().ToString("yyyy-MM-dd"), periodTo.GetValueOrDefault().ToString("yyyy-MM-dd"));
                }
            }

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = string.Format("SELECT * FROM [dbo].[vListaRozliczen] {0} ", whereClause);
            this.dataAdapter.SelectCommand = cmdSelect;

            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }
    }
}
