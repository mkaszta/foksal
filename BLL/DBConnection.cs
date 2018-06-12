using System.Data.SqlClient;
using System.Configuration;

namespace BLL
{
    public class DBConnection
    {
        private string dbServer = "";
        private string dbName = "";
        private string dbUser = "";
        private string dbPassword = "";

        public SqlConnection Connection;

        public DBConnection()
        {
            this.dbServer = ConfigurationSettings.AppSettings["SQL_Server"];
            this.dbName = ConfigurationSettings.AppSettings["SQL_DB"];
            this.dbUser = ConfigurationSettings.AppSettings["SQL_User"];
            this.dbPassword = ConfigurationSettings.AppSettings["SQL_Password"];

            this.Connection = new SqlConnection(string.Format("server={0};database={1};user id={2};password={3};Trusted_Connection=yes;Persist Security Info=False;Integrated Security=false;",
                this.dbServer, this.dbName, this.dbUser, this.dbPassword));

            this.Connection.Open();
        }
    }
}
