using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foksal
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();            
        }

        private void UserLogIn()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();

            btnLogIn.Visible = false;
            btnLogOut.Visible = true;
        }

        private void UserLogOut()
        {
            AppUser.Instance.LogOut();

            btnLogIn.Visible = true;
            btnLogOut.Visible = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.UserLogIn();
        }

        private void buttonCommandLogIn_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            this.UserLogOut();
            this.UserLogIn();
        }
        private void btnLogOut_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            this.UserLogOut();
        }

        private void buttonCommandExit_Click(object sender, Janus.Windows.Ribbon.CommandEventArgs e)
        {
            Application.Exit();
        }       
    }
}
