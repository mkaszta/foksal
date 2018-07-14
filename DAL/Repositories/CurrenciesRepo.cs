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

        public static void Insert(CurrencyRate rate, int currencyId)
        {
            List<Currency> lstCurrencies = new List<Currency>();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string formattedDate = rate.Date.ToString("yyyy-MM-dd");

                string sqlQuery = string.Format("IF NOT EXISTS (SELECT id FROM [Kurs] WHERE WalutaId = '{0}' AND Data = '{1}') " +                                                
                                                "INSERT INTO [Kurs] (WalutaId, Data, Kurs, WprowadzenieUzytkownik) VALUES ({0}, '{1}', {2}, {3}) ",
                                                currencyId, formattedDate, rate.Rate.ToString().Replace(",", "."), AppUser.Instance.UserId);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.ExecuteNonQuery();
                }
            }            
        }
    }
}
