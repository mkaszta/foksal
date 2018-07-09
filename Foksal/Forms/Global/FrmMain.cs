using BLL;
using Foksal.Forms.Agreements;
using Foksal.Forms.Dictonaries;
using Foksal.Forms.Settings;
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
                this.TransformControls();
            }
        }

        private void TransformControls()
        {
            bool isLoggedIn = AppUser.Instance.IsLoggedIn;

            btnLogIn.Visible = !isLoggedIn;
            btnLogOut.Visible = isLoggedIn;
            ribbonPanelBasic.Enabled = isLoggedIn;
            ribbonTabDictionaries.Visible = isLoggedIn;
            ribbonTabReports.Visible = isLoggedIn;
            ribbonTabSettings.Visible = isLoggedIn;

            ribbonPanelSettings_Users.Enabled = AppUser.Instance.IsAdmin;
        }

        private void UserLogOut()
        {
            if (MessageBox.Show("Czy na pewno chcesz się wylogować?\r\nWszelkie niezapisane zmiany zostaną utracone.", "Wyloguj", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                AppUser.Instance.LogOut();
                this.CloseAllChildForms();

                this.TransformControls();
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

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            this.UserLogIn();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.UserLogOut();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAgreements_Click(object sender, EventArgs e)
        {
            FrmAgreementsList frmAgreementsList = new FrmAgreementsList
            {
                MdiParent = this
            };

            frmAgreementsList.Show();
        }

        private void BtnSettingsChangePassword_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmChangePassword = new FrmChangePassword();
            frmChangePassword.ShowDialog();
        }

        private void btnSettingsUsers_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers
            {
                MdiParent = this
            };

            frmUsers.Show();
        }

        private void btnDictCurrencies_Click(object sender, EventArgs e)
        {
            FrmDictCurrencies frmDictCurrencies = new FrmDictCurrencies()
            {
                MdiParent = this
            };

            frmDictCurrencies.Show();
        }

        private void btnDictLicensors_Click(object sender, EventArgs e)
        {
            FrmDictLicensors frmDictLicensors = new FrmDictLicensors()
            {
                MdiParent = this
            };

            frmDictLicensors.Show();
        }
    }
}
