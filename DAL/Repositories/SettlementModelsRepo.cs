using BLL;
using BLL.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class SettlementModelsRepo
    {
        public static List<SettlementModel> GetAll()
        {
            List<SettlementModel> lstModels = new List<SettlementModel>();           

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [Model]");

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lstModels.Add(new SettlementModel()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("name"))
                        });
                    }
                }
            }

            return lstModels;
        }
    }
}
