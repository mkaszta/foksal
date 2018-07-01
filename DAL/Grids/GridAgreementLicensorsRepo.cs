using BLL;
using Janus.Windows.GridEX;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridAgreementLicensorsRepo
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
            cmdSelect.CommandText = string.Format("SELECT * FROM [vUmowaLicencjodawca] WHERE [UmowaId] = {0}", agreementId);
            dataAdapter.SelectCommand = cmdSelect;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = dbConnection.Connection;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = string.Format("UPDATE [UmowaLicencjodawca] " +
                "SET LicencjodawcaId = @licencjodawcaId, LicencjodawcaIdCareOf = @licencjodawcaIdCareOf, UdzialProcent = @udzialprocent, " +
                "EdycjaUzytkownik = @edycjaUzytkownik " +
                "WHERE [id] = @id");
            cmdUpdate.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            cmdUpdate.Parameters.Add("@licencjodawcaId", SqlDbType.Int, 6, "LicencjodawcaId");
            cmdUpdate.Parameters.Add("@licencjodawcaIdCareOf", SqlDbType.Int, 6, "LicencjodawcaIdCareOf");
            cmdUpdate.Parameters.Add("@udzialprocent", SqlDbType.Decimal, 10, "Udzialprocent");
            cmdUpdate.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.UpdateCommand = cmdUpdate;

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = dbConnection.Connection;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = string.Format("INSERT INTO [UmowaLicencjodawca] (UmowaId, LicencjodawcaId, LicencjodawcaIdCareOf, UdzialProcent, WprowadzenieUzytkownik) " +
                "VALUES (@umowaId, @licencjodawcaId, @licencjodawcaIdCareOf, @udzialprocent, @wprowadzenieUzytkownik)");
            cmdInsert.Parameters.Add("@umowaId", SqlDbType.Int, 6, "umowaId");
            cmdInsert.Parameters.Add("@licencjodawcaId", SqlDbType.Int, 6, "LicencjodawcaId");
            cmdInsert.Parameters.Add("@licencjodawcaIdCareOf", SqlDbType.Int, 6, "LicencjodawcaIdCareOf");
            cmdInsert.Parameters.Add("@udzialprocent", SqlDbType.Decimal, 10, "Udzialprocent");            
            cmdInsert.Parameters.Add("@wprowadzenieUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.InsertCommand = cmdInsert;

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = dbConnection.Connection;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = string.Format("DELETE FROM [UmowaLicencjodawca] WHERE Id = @id");
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
