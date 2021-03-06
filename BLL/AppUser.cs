﻿using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

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
        public DateTime DateForReports { get; set; }

        // USER PERMISSIONS
        #region 
        public bool CanReadAgreements
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 1).First().PermissionLevel >= UserPermission.PermissionType.READ_ONLY);
            }
        }
        public bool CanReadProductsAndArticles
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 2).First().PermissionLevel >= UserPermission.PermissionType.READ_ONLY);
            }
        }
        public bool CanReadSettlements
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 3).First().PermissionLevel >= UserPermission.PermissionType.READ_ONLY);
            }
        }
        public bool CanReadDescriptorChanges
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 4).First().PermissionLevel >= UserPermission.PermissionType.READ_ONLY);
            }
        }
        public bool CanReadDictCurrencies
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 5).First().PermissionLevel >= UserPermission.PermissionType.READ_ONLY);
            }
        }
        public bool CanReadDictLicensors
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 6).First().PermissionLevel >= UserPermission.PermissionType.READ_ONLY);
            }
        }
        public bool CanReadReports
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 7).First().PermissionLevel >= UserPermission.PermissionType.READ_ONLY);
            }
        }
        public bool CanWriteAgreements
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 1).First().PermissionLevel >= UserPermission.PermissionType.READ_WRITE);
            }
        }
        public bool CanWriteProductsAndArticles
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 2).First().PermissionLevel >= UserPermission.PermissionType.READ_WRITE);
            }
        }
        public bool CanWriteSettlements
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 3).First().PermissionLevel >= UserPermission.PermissionType.READ_WRITE);
            }
        }
        public bool CanWriteDescriptorChanges
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 4).First().PermissionLevel >= UserPermission.PermissionType.READ_WRITE);
            }
        }
        public bool CanWriteDictCurrencies
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 5).First().PermissionLevel >= UserPermission.PermissionType.READ_WRITE);
            }
        }
        public bool CanWriteDictLicensors
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 6).First().PermissionLevel >= UserPermission.PermissionType.READ_WRITE);
            }
        }
        public bool CanWriteReports
        {
            get
            {
                return (this.IsLoggedIn && this.UserPermissions.Where(x => x.PermissionId == 7).First().PermissionLevel >= UserPermission.PermissionType.READ_WRITE);
            }
        }
        #endregion

        private List<UserPermission> UserPermissions { get; set; }
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
                            this.DateForReports = DateTime.Now;
                        }
                    }
                }
            }

            if (Instance.IsLoggedIn)
                this.GetUserPermissions();
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

        private void GetUserPermissions()
        {
            this.UserPermissions = new List<UserPermission>();

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [UzytkownicyUprawnienia] WHERE UzytkownikId = {0}", this.UserId);

                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        this.UserPermissions.Add(new UserPermission()
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            PermissionId = reader.GetInt32(reader.GetOrdinal("UprawnieniaId")),
                            PermissionLevel = (UserPermission.PermissionType)reader.GetInt32(reader.GetOrdinal("Poziom"))
                        });
                    }
                }
            }
        }
    }
}
