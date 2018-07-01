using BLL;
using Janus.Windows.GridEX;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridAgreementThresholdsRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid, int positionId)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = string.Format("SELECT * FROM [dbo].[Progi] WHERE PozycjaUmowyId = {0} ORDER BY [Od] DESC", positionId);
            dataAdapter.SelectCommand = cmdSelect;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = dbConnection.Connection;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = string.Format("UPDATE [Progi] " +
                "SET Od = @od, Do = @do, ProcentOplatyLicencyjnej = @procentOplatyLicencyjnej, StalaKwotaZaEgzemplarz = @stalaKwotaZaEgzemplarz, " +
                "EdycjaUzytkownik = @edycjaUzytkownik " +
                "WHERE [id] = @id");
            cmdUpdate.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            cmdUpdate.Parameters.Add("@od", SqlDbType.Int, 6, "Od");
            cmdUpdate.Parameters.Add("@do", SqlDbType.Int, 6, "Do");
            cmdUpdate.Parameters.Add("@procentOplatyLicencyjnej", SqlDbType.Decimal, 10, "ProcentOplatyLicencyjnej");
            cmdUpdate.Parameters.Add("@stalaKwotaZaEgzemplarz", SqlDbType.Decimal, 10, "StalaKwotaZaEgzemplarz");            
            cmdUpdate.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.UpdateCommand = cmdUpdate;

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = dbConnection.Connection;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = string.Format("INSERT INTO [Progi] (PozycjaUmowyId, Od, Do, ProcentOplatyLicencyjnej, StalaKwotaZaEgzemplarz, WprowadzenieUzytkownik) " +
                "VALUES (@pozycjaUmowyId, @od, @do, @procentOplatyLicencyjnej, @stalaKwotaZaEgzemplarz, @wprowadzenieUzytkownik)");
            cmdInsert.Parameters.Add("@pozycjaUmowyId", SqlDbType.Int, 6, "PozycjaUmowyId");
            cmdInsert.Parameters.Add("@od", SqlDbType.Int, 6, "Od");
            cmdInsert.Parameters.Add("@do", SqlDbType.Int, 6, "Do");
            cmdInsert.Parameters.Add("@procentOplatyLicencyjnej", SqlDbType.Decimal, 10, "ProcentOplatyLicencyjnej");
            cmdInsert.Parameters.Add("@stalaKwotaZaEgzemplarz", SqlDbType.Decimal, 10, "StalaKwotaZaEgzemplarz");
            cmdInsert.Parameters.Add("@wprowadzenieUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.InsertCommand = cmdInsert;

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = dbConnection.Connection;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = string.Format("DELETE FROM [Progi] WHERE Id = @id");
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
