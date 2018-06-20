using BLL;
using BLL.Entities;
using System;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class AgreementsRepo
    {
        public static Agreement GetByID(int Id)
        {
            Agreement agreement = new Agreement();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT TOP 1 Uwagi, EdycjaData, EdycjaUzytkownik, Zaliczka, Autor, Tytul, TytulOryginal, ZaliczkaData FROM [Umowa] WHERE [Id] = '{0}' ", Id);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        agreement.AgreementID = Id;
                        agreement.Comments = reader.GetString(reader.GetOrdinal("Uwagi"));
                        agreement.EditedDate = reader.GetDateTime(reader.GetOrdinal("EdycjaData"));
                        agreement.EditetBy = reader.GetInt32(reader.GetOrdinal("EdycjaUzytkownik"));
                        agreement.Advance = reader.GetDecimal(reader.GetOrdinal("Zaliczka"));                        
                        agreement.ReportAuthor = reader.GetString(reader.GetOrdinal("Autor"));
                        agreement.ReportTitle = reader.GetString(reader.GetOrdinal("Tytul"));
                        agreement.Title = reader.GetString(reader.GetOrdinal("TytulOryginal"));
                        agreement.AdvanceDate = reader.IsDBNull(reader.GetOrdinal("ZaliczkaData")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("ZaliczkaData"));                                        
                    }
                }
            }

            return agreement;
        }
    }
}
