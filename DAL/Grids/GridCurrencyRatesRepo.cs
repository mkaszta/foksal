using BLL;
using Janus.Windows.GridEX;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridCurrencyRatesRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid, int currencyId)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = string.Format("SELECT * FROM [Kurs] WHERE WalutaId = {0} ORDER BY Data DESC", currencyId);
            dataAdapter.SelectCommand = cmdSelect;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = dbConnection.Connection;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = string.Format("UPDATE [Kurs] " +
                "SET Data = @data, Kurs = @kurs, " +
                "EdycjaUzytkownik = @edycjaUzytkownik " +
                "WHERE [id] = @id");
            cmdUpdate.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            cmdUpdate.Parameters.Add("@data", SqlDbType.DateTime, 10, "Data");            
            cmdUpdate.Parameters.Add("@kurs", SqlDbType.Decimal, 10, "Kurs");
            cmdUpdate.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.UpdateCommand = cmdUpdate;

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = dbConnection.Connection;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = string.Format("INSERT INTO [Kurs] (WalutaId, Data, Kurs) VALUES (@walutaId, @data, @kurs)");
            cmdInsert.Parameters.Add("@walutaId", SqlDbType.Int, 6, "walutaId");
            cmdInsert.Parameters.Add("@data", SqlDbType.DateTime, 10, "Data");
            cmdInsert.Parameters.Add("@kurs", SqlDbType.Decimal, 10, "Kurs");
            cmdInsert.Parameters.Add("@wprowadzenieUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.InsertCommand = cmdInsert;

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = dbConnection.Connection;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = string.Format("DELETE FROM [Kurs] WHERE Id = @id");
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
