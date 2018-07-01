using BLL;
using BLL.Entities;
using System;
using System.Data;
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
                        agreement.Id = Id;
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

        public static void Update(Agreement agreement)
        {            
            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("UPDATE [Umowa] " +
                    "SET TytulOryginal = @tytulOryginal, Tytul = @tytul, Autor = @autor, Zaliczka = @zaliczka, ZaliczkaData = @zaliczkaData, " +                    
                    "Uwagi = @uwagi, EdycjaUzytkownik = @edycjaUzytkownik, EdycjaData = @edycjaData " +
                    "WHERE Id = @id");

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int, 6).Value = agreement.Id;
                    command.Parameters.Add("@tytulOryginal", SqlDbType.VarChar, 256).Value = agreement.Title;
                    command.Parameters.Add("@tytul", SqlDbType.VarChar, 256).Value = agreement.ReportTitle;
                    command.Parameters.Add("@autor", SqlDbType.VarChar, 256).Value = agreement.ReportAuthor;
                    command.Parameters.Add("@zaliczka", SqlDbType.Decimal, 10).Value = agreement.Advance;
                    command.Parameters.Add("@zaliczkaData", SqlDbType.DateTime, 8).Value = agreement.AdvanceDate ?? System.Data.SqlTypes.SqlDateTime.Null;
                    command.Parameters.Add("@uwagi", SqlDbType.VarChar, 1000).Value = agreement.Comments;

                    command.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
                    command.Parameters.Add("@edycjaData", SqlDbType.DateTime, 8).Value = DateTime.Now;

                    command.ExecuteNonQuery();
                }
            }            
        }

        public static void Insert(Agreement agreement)
        {
            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("INSERT INTO [Umowa] (TytulOryginal, Tytul, Autor, Zaliczka, ZaliczkaData, Uwagi, WprowadzenieUzytkownik, WalutaId) " +
                    "OUTPUT INSERTED.ID " +
                    "VALUES (@tytulOryginal, @tytul, @autor, @zaliczka, @zaliczkaData, @uwagi, @wprowadzenieUzytkownik, 1) ");

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {                    
                    command.Parameters.Add("@tytulOryginal", SqlDbType.VarChar, 256).Value = agreement.Title;
                    command.Parameters.Add("@tytul", SqlDbType.VarChar, 256).Value = agreement.ReportTitle;
                    command.Parameters.Add("@autor", SqlDbType.VarChar, 256).Value = agreement.ReportAuthor;
                    command.Parameters.Add("@zaliczka", SqlDbType.Decimal, 10).Value = agreement.Advance;
                    command.Parameters.Add("@zaliczkaData", SqlDbType.DateTime, 8).Value = agreement.AdvanceDate ?? System.Data.SqlTypes.SqlDateTime.Null;
                    command.Parameters.Add("@uwagi", SqlDbType.VarChar, 1000).Value = agreement.Comments;
                    command.Parameters.Add("@wprowadzenieUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;

                    agreement.Id = (int)command.ExecuteScalar();
                }
            }
        }
    }
}
