using System;
using System.Collections.Generic;
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
    }
}
