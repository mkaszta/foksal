using BLL;
using BLL.Entities;
using Janus.Windows.GridEX;
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

        public void BindDataSet(GridEX grid, Report reportType)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = string.Format("SELECT * FROM {0} ORDER BY {1}", reportType.SqlViewName, reportType.SqlOrderBy);
            dataAdapter.SelectCommand = cmdSelect;
           
            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }
    }
}
