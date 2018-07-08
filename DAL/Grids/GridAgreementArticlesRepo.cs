using BLL;
using BLL.Entities;
using Janus.Windows.GridEX;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridAgreementArticlesRepo
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
            cmdSelect.CommandText = string.Format("SELECT * FROM [Towary] WHERE [UmowaId] = {0}", agreementId);
            dataAdapter.SelectCommand = cmdSelect;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = dbConnection.Connection;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = string.Format("UPDATE [Towary] " +
                "SET KTM = @ktm, Deskryptor = @deskryptor, Uwagi = @uwagi, " +
                "EdycjaUzytkownik = @edycjaUzytkownik " +
                "WHERE [id] = @id");
            cmdUpdate.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            cmdUpdate.Parameters.Add("@ktm", SqlDbType.VarChar, 50, "KTM");
            cmdUpdate.Parameters.Add("@deskryptor", SqlDbType.VarChar, 50, "Deskryptor");
            cmdUpdate.Parameters.Add("@uwagi", SqlDbType.VarChar, 1000, "Uwagi");
            cmdUpdate.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.UpdateCommand = cmdUpdate;

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = dbConnection.Connection;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = string.Format("INSERT INTO [Towary] (UmowaId, KTM, Deskryptor, Uwagi, WprowadzenieUzytkownik) " +
                "VALUES (@umowaId, @ktm, @deskryptor, @uwagi, @wprowadzenieUzytkownik)");
            cmdInsert.Parameters.Add("@umowaId", SqlDbType.Int, 6, "UmowaId");
            cmdInsert.Parameters.Add("@ktm", SqlDbType.VarChar, 50, "KTM");
            cmdInsert.Parameters.Add("@deskryptor", SqlDbType.VarChar, 50, "Deskryptor");
            cmdInsert.Parameters.Add("@uwagi", SqlDbType.VarChar, 1000, "Uwagi");
            cmdInsert.Parameters.Add("@wprowadzenieUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.InsertCommand = cmdInsert;

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = dbConnection.Connection;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = string.Format("DELETE FROM [Towary] WHERE Id = @id");
            cmdDelete.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            dataAdapter.DeleteCommand = cmdDelete;

            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }

        public void Update()
        {
            this.dataAdapter.Update(this.dataTable);
        }

        public void AddRow(RelatedArticle newArticle)
        {
            DataRow newRow = dataTable.NewRow();            
            newRow.SetField("umowaId", newArticle.AgreementId);
            newRow.SetField("KTM", newArticle.KTM);
            newRow.SetField("Deskryptor", newArticle.Descriptor);
            newRow.SetField("Uwagi", "");

            this.dataTable.Rows.Add(newRow);
        }
    }
}
