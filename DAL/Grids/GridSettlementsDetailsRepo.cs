using BLL;
using Janus.Windows.GridEX;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridSettlementsDetailsRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid, List<int> lstRozliczenieUmowyID)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = string.Format("SELECT * FROM [dbo].[vRozliczeniaAll] WHERE tRozliczenieUmowyId IN ({0}) ORDER BY tUmowaid, tOkres, tLicencjodawcaCafreOfId, typ, lp ",
                string.Join(",", lstRozliczenieUmowyID.ToArray()));
            this.dataAdapter.SelectCommand = cmdSelect;

            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }
    }
}
