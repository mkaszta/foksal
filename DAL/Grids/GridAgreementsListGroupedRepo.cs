using BLL;
using Janus.Windows.GridEX;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridAgreementsListGroupedRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand
            {
                Connection = dbConnection.Connection,
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM [vUmowyZPozycjamiLista]"
            };
            dataAdapter.SelectCommand = cmdSelect;

            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }
    }
}
