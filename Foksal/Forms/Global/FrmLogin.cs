using BLL;
using System;
using System.Windows.Forms;

namespace Foksal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();            
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {                        
            AppUser.Instance.LogIn(txtUsername.Text, txtPassword.Text);

            if (AppUser.Instance.IsLoggedIn)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Niepoprawna nazwa użytkownika i/lub hasło.", "Nieudane logowanie", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }
    }
}
