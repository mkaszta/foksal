using BLL;
using BLL.Entities;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class CurrenciesRepo
    {
        public static List<Currency> GetAll()
        {
            List<Currency> lstCurrencies = new List<Currency>();            

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [Waluta]");

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        lstCurrencies.Add(new Currency()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Name = reader.GetString(reader.GetOrdinal("Waluta"))
                        });
                    }
                }
            }

            return lstCurrencies;
        }
    }
}
