using BLL;
using BLL.Entities;
using System;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class ModelsRepo
    {
        public static Model GetByID(int Id)
        {
            Model model = new Model();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT TOP 1 * FROM [Model] WHERE [Id] = '{0}' ", Id);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        model.Id = Id;
                        model.IsActive = Convert.ToBoolean(reader.GetByte(reader.GetOrdinal("active")));
                        model.IsPercent = Convert.ToBoolean(reader.GetByte(reader.GetOrdinal("procent")));
                        model.IsThreshold = Convert.ToBoolean(reader.GetByte(reader.GetOrdinal("progi")));
                        model.Name = reader.GetString(reader.GetOrdinal("name"));
                        model.LabelFixedPrice = reader.IsDBNull(reader.GetOrdinal("StalaCenaNazwa")) ? "" : reader.GetString(reader.GetOrdinal("StalaCenaNazwa"));
                        model.LabelPercent = reader.IsDBNull(reader.GetOrdinal("StawkaNazwa")) ? "" : reader.GetString(reader.GetOrdinal("StawkaNazwa"));
                    }
                }
            }

            return model;
        }
    }
}
