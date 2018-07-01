using BLL;
using Janus.Windows.GridEX;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridAgreementScheduleRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid, int agreementId)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = string.Format("SELECT * FROM [Harmonogram] WHERE [UmowaId] = {0}", agreementId);
            dataAdapter.SelectCommand = cmdSelect;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = dbConnection.Connection;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = string.Format("UPDATE [Harmonogram] " +
                "SET Deskryptor = @deskryptor, Kwota = @kwota, WalutaId = @walutaId, Data = @data, Uwagi = @uwagi, " +
                "EdycjaUzytkownik = @edycjaUzytkownik " +
                "WHERE [id] = @id");
            cmdUpdate.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            cmdUpdate.Parameters.Add("@deskryptor", SqlDbType.VarChar, 50, "Deskryptor");
            cmdUpdate.Parameters.Add("@kwota", SqlDbType.Decimal, 10, "Kwota");
            cmdUpdate.Parameters.Add("@walutaId", SqlDbType.Int, 6, "WalutaId");
            cmdUpdate.Parameters.Add("@data", SqlDbType.DateTime, 10, "Data");
            cmdUpdate.Parameters.Add("@uwagi", SqlDbType.VarChar, 1000, "Uwagi");
            cmdUpdate.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.UpdateCommand = cmdUpdate;

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = dbConnection.Connection;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = string.Format("INSERT INTO [Harmonogram] (UmowaId, Deskryptor, Kwota, WalutaId, Data, Uwagi, WprowadzenieUzytkownik) " +
                "VALUES (@umowaId, @deskryptor, @kwota, @walutaId, @data, @uwagi, @wprowadzenieUzytkownik)");
            cmdInsert.Parameters.Add("@umowaId", SqlDbType.Int, 6, "umowaId");
            cmdInsert.Parameters.Add("@deskryptor", SqlDbType.VarChar, 50, "Deskryptor");
            cmdInsert.Parameters.Add("@kwota", SqlDbType.Decimal, 10, "Kwota");
            cmdInsert.Parameters.Add("@walutaId", SqlDbType.Int, 6, "WalutaId");
            cmdInsert.Parameters.Add("@data", SqlDbType.DateTime, 10, "Data");
            cmdInsert.Parameters.Add("@uwagi", SqlDbType.VarChar, 1000, "Uwagi");
            cmdInsert.Parameters.Add("@wprowadzenieUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.InsertCommand = cmdInsert;

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = dbConnection.Connection;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = string.Format("DELETE FROM [Harmonogram] WHERE Id = @id");
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
