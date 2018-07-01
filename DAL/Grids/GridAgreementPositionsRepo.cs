using BLL;
using Janus.Windows.GridEX;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridAgreementPositionsRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid, int agreementId)
        {
            this.dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = string.Format("SELECT * FROM [dbo].[vPozycjeUmowy] WHERE UmowaId = {0}", agreementId);
            this.dataAdapter.SelectCommand = cmdSelect;

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = dbConnection.Connection;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = string.Format("INSERT INTO [PozycjaUmowy] (UmowaId, WprowadzenieUzytkownik) " +
                "VALUES (@umowaId, @wprowadzenieUzytkownik)");
            cmdInsert.Parameters.Add("@umowaId", SqlDbType.Int, 6, "UmowaId");
            cmdInsert.Parameters.Add("@wprowadzenieUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            this.dataAdapter.InsertCommand = cmdInsert;

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = dbConnection.Connection;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = string.Format("DELETE FROM [PozycjaUmowy] WHERE Id = @id");
            cmdDelete.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            this.dataAdapter.DeleteCommand = cmdDelete;

            this.dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }

        public void Update()
        {
            this.dataAdapter.Update(this.dataTable);
        }

        public void AddRow(int agreementId)
        {
            DataRow newRow = dataTable.NewRow();
            newRow.SetField("id", 0);
            newRow.SetField("umowaId", agreementId);

            this.dataTable.Rows.Add(newRow);
        }

        public void DeleteRow(int rowPosition)
        {
            this.dataTable.Rows[rowPosition].Delete();
            this.dataAdapter.Update(this.dataTable);
        }
    }
}
