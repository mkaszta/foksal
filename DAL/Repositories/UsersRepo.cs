using BLL;
using BLL.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Repositories
{
    public class UsersRepo
    {
        public static User GetById(int userId)
        {
            User user = new User();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [Uzytkownicy] " +
                    "WHERE Id = @id ");                    

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int, 6).Value = userId;                                        

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        user.Id = userId;
                        user.Login = reader.GetString(reader.GetOrdinal("Login"));
                        user.Password = reader.GetString(reader.GetOrdinal("Haslo"));
                    }
                }
            }

            return user;
        }

        public static void Update(User user)
        {
            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("UPDATE [Uzytkownicy] " +
                    "SET Login = @login, Haslo = @haslo, EdycjaUzytkownik = @edycjaUzytkownik, EdycjaData = @edycjaData " +
                    "WHERE Id = @id");

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int, 6).Value = user.Id;
                    command.Parameters.Add("@login", SqlDbType.VarChar, 50).Value = user.Login;
                    command.Parameters.Add("@haslo", SqlDbType.VarChar, 256).Value = user.Password;
                    command.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
                    command.Parameters.Add("@edycjaData", SqlDbType.DateTime, 8).Value = DateTime.Now;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Insert(User user)
        {
            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("INSERT INTO [Uzytkownicy] (Login, Haslo, EdycjaUzytkownik, EdycjaData) " +
                    "VALUES  (@login, @haslo, @edycjaUzytkownik, @edycjaData) ");                    

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int, 6).Value = user.Id;
                    command.Parameters.Add("@login", SqlDbType.VarChar, 50).Value = user.Login;
                    command.Parameters.Add("@haslo", SqlDbType.VarChar, 256).Value = user.Password;
                    command.Parameters.Add("@edycjaUzytkownik", SqlDbType.Int, 6).Value = AppUser.Instance.UserId;
                    command.Parameters.Add("@edycjaData", SqlDbType.DateTime, 8).Value = DateTime.Now;

                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int userId)
        {
            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("DELETE FROM [Uzytkownicy] WHERE Id = @id");                    

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    command.Parameters.Add("@id", SqlDbType.Int, 6).Value = userId;                    

                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
