using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foksal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            this.AcceptButton = btnLogin;
            this.CancelButton = btnCancelLogin;
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {            
            string login = txtUsername.Text;
            string password = RSACoder.Encryption(txtPassword.Text);

            using (SqlConnection dbConnection = new DBConnection().Connection)
            {
                string sqlQuery = string.Format("SELECT * FROM [Uzytkownicy] WHERE [Login] = '{0}' AND [Haslo] = '{1}'", login, password);
                using (SqlCommand command = new SqlCommand(sqlQuery, dbConnection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        AppUser.Instance.IsLoggedIn = true;
                    }
                }
            }

            if (!AppUser.Instance.IsLoggedIn)
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika i/lub hasło.", "Nieudane logowanie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }
    }
}
