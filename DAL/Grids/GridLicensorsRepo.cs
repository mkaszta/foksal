using BLL;
using Janus.Windows.GridEX;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridLicensorsRepo
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
            cmdSelect.CommandText = string.Format("SELECT * FROM [Licencjodawca]");
            dataAdapter.SelectCommand = cmdSelect;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = dbConnection.Connection;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = string.Format("UPDATE [Licencjodawca] " +
                "SET Imie = @imie, Nazwisko = @nazwisko, Nazwa = @nazwa, OsosbaFizyczna = @osobaFizyczna, DataObowiazywaniaCertyfikatu = @dataObowiazywaniaCertyfikatu, " +
                "PodatekProcent = @podatekProcent, PodatekVAT = @podatekVAT, AdresEmail = @adresEmail, " +
                "EdycjaUzytkownik = @edycjaUzytkownik " +
                "WHERE [id] = @id");
            cmdUpdate.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            cmdUpdate.Parameters.Add("@imie", SqlDbType.VarChar, 50, "Imie");
            cmdUpdate.Parameters.Add("@nazwisko", SqlDbType.VarChar, 50, "Nazwisko");
            cmdUpdate.Parameters.Add("@nazwa", SqlDbType.VarChar, 50, "Nazwa");
            cmdUpdate.Parameters.Add("@osobaFizyczna", SqlDbType.Bit, 1, "OsosbaFizyczna");
            cmdUpdate.Parameters.Add("@dataObowiazywaniaCertyfikatu", SqlDbType.DateTime, 10, "DataObowiazywaniaCertyfikatu");
            cmdUpdate.Parameters.Add("@podatekProcent", SqlDbType.Decimal, 10, "PodatekProcent");
            cmdUpdate.Parameters.Add("@podatekVAT", SqlDbType.Decimal, 10, "PodatekVAT");
            cmdUpdate.Parameters.Add("@adresEmail", SqlDbType.VarChar, 150, "AdresEmail");
            cmdUpdate.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.UpdateCommand = cmdUpdate;

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = dbConnection.Connection;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = string.Format("INSERT INTO [Licencjodawca] (Imie, Nazwisko, Nazwa, OsosbaFizyczna, DataObowiazywaniaCertyfikatu, PodatekProcent, PodatekVAT, AdresEmail) " +
                "VALUES (@imie, @nazwisko, @nazwa, @osobaFizyczna, @dataObowiazywaniaCertyfikatu, @podatekProcent, @podatekVAT, @adresEmail)");
            cmdInsert.Parameters.Add("@imie", SqlDbType.VarChar, 50, "Imie");
            cmdInsert.Parameters.Add("@nazwisko", SqlDbType.VarChar, 50, "Nazwisko");
            cmdInsert.Parameters.Add("@nazwa", SqlDbType.VarChar, 50, "Nazwa");
            cmdInsert.Parameters.Add("@osobaFizyczna", SqlDbType.Bit, 1, "OsosbaFizyczna");
            cmdInsert.Parameters.Add("@dataObowiazywaniaCertyfikatu", SqlDbType.DateTime, 10, "DataObowiazywaniaCertyfikatu");
            cmdInsert.Parameters.Add("@podatekProcent", SqlDbType.Decimal, 10, "PodatekProcent");
            cmdInsert.Parameters.Add("@podatekVAT", SqlDbType.Decimal, 10, "PodatekVAT");
            cmdInsert.Parameters.Add("@adresEmail", SqlDbType.VarChar, 150, "AdresEmail");
            cmdInsert.Parameters.Add("@wprowadzenieUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.InsertCommand = cmdInsert;

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = dbConnection.Connection;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = string.Format("DELETE FROM [Licencjodawca] WHERE Id = @id");
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
