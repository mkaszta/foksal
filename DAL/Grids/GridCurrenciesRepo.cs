using BLL;
using Janus.Windows.GridEX;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridCurrenciesRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = string.Format("SELECT * FROM [Waluta] WHERE Waluta <> 'PLN' ");
            dataAdapter.SelectCommand = cmdSelect;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = dbConnection.Connection;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = string.Format("UPDATE [Waluta] SET Waluta = @waluta WHERE [id] = @id");
            cmdUpdate.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            cmdUpdate.Parameters.Add("@waluta", SqlDbType.VarChar, 5, "Waluta");            
            dataAdapter.UpdateCommand = cmdUpdate;

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = dbConnection.Connection;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = string.Format("INSERT INTO [Waluta] (Waluta) VALUES (UPPER(@waluta))");
            cmdInsert.Parameters.Add("@waluta", SqlDbType.VarChar, 5, "Waluta");            
            dataAdapter.InsertCommand = cmdInsert;

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = dbConnection.Connection;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = string.Format("DELETE FROM [Waluta] WHERE Id = @id");
            cmdDelete.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            dataAdapter.DeleteCommand = cmdDelete;

            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }

        public void Update()
        {
            this.dataAdapter.Update(this.dataTable);
        }
    }
}
