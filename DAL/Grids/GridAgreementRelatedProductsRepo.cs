using BLL;
using BLL.Entities;
using Janus.Windows.GridEX;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridAgreementRelatedProductsRepo 
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
            cmdSelect.CommandText = string.Format("SELECT * FROM [dbo].[ProduktPowiazany] WHERE PozycjaUmowyId = {0}", positionId);
            dataAdapter.SelectCommand = cmdSelect;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = dbConnection.Connection;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = string.Format("UPDATE [ProduktPowiazany] " +
                "SET Deskryptor = @deskryptor, KTM = @ktm, " +
                "EdycjaUzytkownik = @edycjaUzytkownik " +
                "WHERE [id] = @id");
            cmdUpdate.Parameters.Add("@id", SqlDbType.Int, 6, "Id");           
            cmdUpdate.Parameters.Add("@deskryptor", SqlDbType.VarChar, 50, "Deskryptor");
            cmdUpdate.Parameters.Add("@ktm", SqlDbType.VarChar, 50, "KTM");            
            cmdUpdate.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.UpdateCommand = cmdUpdate;

            SqlCommand cmdInsert = new SqlCommand();
            cmdInsert.Connection = dbConnection.Connection;
            cmdInsert.CommandType = CommandType.Text;
            cmdInsert.CommandText = string.Format("INSERT INTO [ProduktPowiazany] (PozycjaUmowyId, Deskryptor, KTM, WprowadzenieUzytkownik) " +
                "VALUES (@pozycjaUmowyId, @deskryptor, @ktm, @wprowadzenieUzytkownik)");
            cmdInsert.Parameters.Add("@pozycjaUmowyId", SqlDbType.Int, 6, "PozycjaUmowyId");
            cmdInsert.Parameters.Add("@deskryptor", SqlDbType.VarChar, 50, "Deskryptor");
            cmdInsert.Parameters.Add("@ktm", SqlDbType.VarChar, 50, "KTM");            
            cmdInsert.Parameters.Add("@wprowadzenieUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
            dataAdapter.InsertCommand = cmdInsert;

            SqlCommand cmdDelete = new SqlCommand();
            cmdDelete.Connection = dbConnection.Connection;
            cmdDelete.CommandType = CommandType.Text;
            cmdDelete.CommandText = string.Format("DELETE FROM [ProduktPowiazany] WHERE Id = @id");
            cmdDelete.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            dataAdapter.DeleteCommand = cmdDelete;

            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }

        public void Update()
        {
            this.dataAdapter.Update(this.dataTable);
        }

        public void AddRow(RelatedProduct newProduct)
        {
            DataRow newRow = dataTable.NewRow();
            newRow.SetField("pozycjaUmowyId", newProduct.AgreementPositionId);
            newRow.SetField("KTM", newProduct.KTM);
            newRow.SetField("Deskryptor", newProduct.Descriptor);            

            this.dataTable.Rows.Add(newRow);
        }
    }
}
