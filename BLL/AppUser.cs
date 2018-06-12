using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BLL
{
    public class AppUser
    {
        public string UserName { get; set; }
        public string Password { get; set; }    
        public bool IsLoggedIn { get; set; }
        public bool IsAdmin { get; set; }

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
            this.IsAdmin = false;
        }

        public void LogIn(string userName, string password)
        {
            this.UserName = userName;
            this.Password = RSACoder.Encryption(password);

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT [Haslo] FROM [Uzytkownicy] WHERE [Login] = '{0}' ", this.UserName);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        if (RSACoder.Decryption(reader.GetString(reader.GetOrdinal("Haslo"))) == RSACoder.Decryption(this.Password))
                        {
                            AppUser.Instance.IsLoggedIn = true;
                        }
                    }
                }
            }
        }
        public void LogOut()
        {
            _instance = null;
        }

    }
}
