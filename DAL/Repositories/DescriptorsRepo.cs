using BLL;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class DescriptorsRepo
    {
        public void ChangeDescriptor(int positionID, int descriptorChangeID)
        {
            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlProcedure = "[dbo].[ChangeDescryptor]";

                using (SqlCommand command = new SqlCommand(sqlProcedure, dbConnection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idpozycja", positionID);
                    command.Parameters.AddWithValue("@idDescryptor", descriptorChangeID);

                    command.ExecuteNonQuery();                    
                }
            }
        }
    }
}
