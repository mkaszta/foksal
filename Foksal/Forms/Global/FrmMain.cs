using BLL;
using Foksal.Forms.Agreements;
using System;
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

            if (AppUser.Instance.IsLoggedIn)
            {
                btnLogIn.Visible = false;
                btnLogOut.Visible = true;
            }
        }

        private void UserLogOut()
        {
            if (MessageBox.Show("Czy na pewno chcesz się wylogować?\r\nWszelkie niezapisane zmiany zostaną utracone.", "Wyloguj", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AppUser.Instance.LogOut();
                this.CloseAllChildForms();

                btnLogIn.Visible = true;
                btnLogOut.Visible = false;
            }
        }

        private void CloseAllChildForms()
        {
            foreach (var form in this.MdiChildren)
            {
                if (form != this)
                {
                    form.Dispose();
                    form.Close();
                }
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.UserLogIn();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.UserLogOut();
            this.UserLogIn();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.UserLogOut();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgreements_Click(object sender, EventArgs e)
        {
            FrmAgreementsList frmAgreementsList = new FrmAgreementsList();
            frmAgreementsList.MdiParent = this;
            frmAgreementsList.Show();
        }
    }
}
