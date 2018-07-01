using System;
using System.Data.SqlClient;

namespace BLL
{
    public class AppUser
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }    
        public bool IsLoggedIn { get; set; }
        public bool IsAdmin
        {
            get
            {
                return (this.IsLoggedIn && this.UserName == "admin") ? true : false;
            }
        }

        private static object singletonLock = new object();
        private static AppUser _instance;
        public static AppUser Instance
        {
            get
            {                
                if (_instance == null)
                {
                    lock (singletonLock)
                    {
                        _instance = new AppUser();
                    }                    
                }

                return _instance;
            }
        }
        protected AppUser()
        {
            this.IsLoggedIn = false;            
        }

        public void LogIn(string userName, string password)
        {
            this.UserName = userName;
            this.Password = RSACoder.Encryption(password);

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT [id], [Haslo] FROM [Uzytkownicy] WHERE [Login] = '{0}' ", this.UserName);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (RSACoder.Decryption(reader.GetString(reader.GetOrdinal("Haslo"))) == RSACoder.Decryption(this.Password))
                        {
                            Instance.IsLoggedIn = true;
                            this.UserId = reader.GetInt32(reader.GetOrdinal("id"));
                        }
                    }
                }
            }
        }
        public void LogOut()
        {
            _instance = null;
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            bool canChange = false;

            try
            {
                if (this.IsLoggedIn)
                {
                    using (SqlConnection dbConnection = new DBConnection().Connection)
                    {
                        string sqlQuery = string.Format("SELECT [id], [Haslo] FROM [Uzytkownicy] WHERE [id] = '{0}' ", this.UserId);

                        using (SqlCommand cmdSelect = new SqlCommand(sqlQuery, dbConnection))
                        {
                            using (SqlDataReader reader = cmdSelect.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    if (RSACoder.Decryption(reader.GetString(reader.GetOrdinal("Haslo"))) == oldPassword)
                                    {
                                        canChange = true;
                                    }
                                }
                            }                                
                        }

                        if (canChange)
                        {
                            sqlQuery = string.Format("UPDATE [Uzytkownicy] SET Haslo = '{0}' WHERE [id] = '{1}' ", RSACoder.Encryption(newPassword), this.UserId);

                            using (SqlCommand cmdUpdate = new SqlCommand(sqlQuery, dbConnection))
                            {
                                cmdUpdate.ExecuteNonQuery();
                            }

                            this.Password = RSACoder.Encryption(newPassword);
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }            
        }
    }
}
