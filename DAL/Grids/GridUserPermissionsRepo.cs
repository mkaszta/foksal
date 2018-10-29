using BLL;
using Janus.Windows.GridEX;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Grids
{
    public class GridUserPermissionsRepo
    {
        private DBConnection dbConnection = new DBConnection();
        private DataSet dataSet = new DataSet("dataSet");
        private DataTable dataTable = new DataTable("dataTable");
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();

        public void BindDataSet(GridEX grid, int userId)
        {
            dataTable.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = string.Format("SELECT uu.id, uu.UzytkownikId, uu.UprawnieniaId, uu.Poziom, up.Uprawnienie " +
                "FROM [UzytkownicyUprawnienia] uu " +
                "LEFT JOIN [Uprawnienia] up ON up.Id = uu.UprawnieniaId " +
                string.Format("WHERE uu.UzytkownikId = {0}", userId));
            dataAdapter.SelectCommand = cmdSelect;

            SqlCommand cmdUpdate = new SqlCommand();
            cmdUpdate.Connection = dbConnection.Connection;
            cmdUpdate.CommandType = CommandType.Text;
            cmdUpdate.CommandText = string.Format("UPDATE [UzytkownicyUprawnienia] SET Poziom = @poziom WHERE [id] = @id");
            cmdUpdate.Parameters.Add("@id", SqlDbType.Int, 6, "Id");
            cmdUpdate.Parameters.Add("@poziom", SqlDbType.VarChar, 5, "Poziom");
            dataAdapter.UpdateCommand = cmdUpdate;

            dataAdapter.Fill(dataTable);
            grid.DataSource = dataTable;
        }

        public void Update()
        {
            this.dataAdapter.Update(this.dataTable);
        }
    }
}
