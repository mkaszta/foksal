using BLL;
using BLL.Entities;
using DAL.Repositories;
using Foksal.Forms.Agreements;
using Foksal.Forms.Dictonaries;
using Foksal.Forms.Reports;
using Foksal.Forms.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
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
            ribbonTabSettings.Visible = isLoggedIn;
            ribbonPanelSettings_Users.Enabled = AppUser.Instance.IsAdmin;

            btnAgreements.Enabled = AppUser.Instance.CanReadAgreements;
            btnProducts.Enabled = AppUser.Instance.CanReadProductsAndArticles;
            btnSettlements.Enabled = AppUser.Instance.CanReadSettlements;
            btnDescriptorChanges.Enabled = AppUser.Instance.CanReadDescriptorChanges;
            btnDictCurrencies.Enabled = AppUser.Instance.CanReadDictCurrencies;
            btnDictLicensors.Enabled = AppUser.Instance.CanReadDictLicensors;
            ribbonTabReports.Visible = AppUser.Instance.CanReadReports;

            this.CreateReportsList();
        }

        private void CreateReportsList()
        {
            List<Report> lstReports = ReportsRepo.GetAll();

            foreach (var report in lstReports)
            {
                RibbonButton newButton = new RibbonButton()
                {
                    Name = string.Format("btnReport{0}", report.Name),
                    Text = report.Name,
                    Value = report.Id.ToString()
                };
                newButton.Click += new EventHandler(this.btnReport_Click);

                ribbonPanelReports.Items.Add(newButton);
            }
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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            FrmProductsAndArticles frmProductsAndArticles = new FrmProductsAndArticles()
            {
                MdiParent = this
            };

            frmProductsAndArticles.Show();
        }

        private void btnDescriptorChanges_Click(object sender, EventArgs e)
        {
            FrmDescriptorChanges frmDescriptorChanges = new FrmDescriptorChanges()
            {
                MdiParent = this
            };

            frmDescriptorChanges.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            RibbonButton senderButton = sender as RibbonButton;
            Report report = ReportsRepo.GetById(Convert.ToInt16(senderButton.Value));

            FrmReportFlexible frmReportFlexible = new FrmReportFlexible(report)
            {
                MdiParent = this
            };

            frmReportFlexible.Show();
        }

        private void btnSettlements_Click(object sender, EventArgs e)
        {
            FrmSettlements frmSettlements = new FrmSettlements()
            {
                MdiParent = this
            };

            frmSettlements.Show();
        }
    }
}
