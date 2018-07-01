namespace Foksal
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTabMain = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelMain_User = new System.Windows.Forms.RibbonPanel();
            this.btnLogIn = new System.Windows.Forms.RibbonButton();
            this.btnLogOut = new System.Windows.Forms.RibbonButton();
            this.btnExit = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelMain_Basic = new System.Windows.Forms.RibbonPanel();
            this.btnAgreements = new System.Windows.Forms.RibbonButton();
            this.btnProducts = new System.Windows.Forms.RibbonButton();
            this.btnSettlements = new System.Windows.Forms.RibbonButton();
            this.btnDescriptorChanges = new System.Windows.Forms.RibbonButton();
            this.ribbonTabDictionaries = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelDictionaries_Dict = new System.Windows.Forms.RibbonPanel();
            this.btnLicensersDict = new System.Windows.Forms.RibbonButton();
            this.btnCurrencyDict = new System.Windows.Forms.RibbonButton();
            this.ribbonTabReports = new System.Windows.Forms.RibbonTab();
            this.ribbonTabSettings = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelSettings_Mine = new System.Windows.Forms.RibbonPanel();
            this.btnSettingsChangePassword = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelSettings_Users = new System.Windows.Forms.RibbonPanel();
            this.btnSettingsUsers = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(899, 147);
            this.ribbon1.TabIndex = 4;
            this.ribbon1.Tabs.Add(this.ribbonTabMain);
            this.ribbon1.Tabs.Add(this.ribbonTabDictionaries);
            this.ribbon1.Tabs.Add(this.ribbonTabReports);
            this.ribbon1.Tabs.Add(this.ribbonTabSettings);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTabMain
            // 
            this.ribbonTabMain.Name = "ribbonTabMain";
            this.ribbonTabMain.Panels.Add(this.ribbonPanelMain_User);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelMain_Basic);
            this.ribbonTabMain.Text = "Narzędzia główne";
            // 
            // ribbonPanelMain_User
            // 
            this.ribbonPanelMain_User.Items.Add(this.btnLogIn);
            this.ribbonPanelMain_User.Items.Add(this.btnLogOut);
            this.ribbonPanelMain_User.Items.Add(this.btnExit);
            this.ribbonPanelMain_User.Name = "ribbonPanelMain_User";
            this.ribbonPanelMain_User.Text = "Użytkownik";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLogIn.Image")));
            this.btnLogIn.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogIn.LargeImage")));
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnLogIn.SmallImage")));
            this.btnLogIn.Text = "Zaloguj";
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.LargeImage")));
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.SmallImage")));
            this.btnLogOut.Text = "Wyloguj";
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnExit.SmallImage")));
            this.btnExit.Text = "Zamknij";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ribbonPanelMain_Basic
            // 
            this.ribbonPanelMain_Basic.Items.Add(this.btnAgreements);
            this.ribbonPanelMain_Basic.Items.Add(this.btnProducts);
            this.ribbonPanelMain_Basic.Items.Add(this.btnSettlements);
            this.ribbonPanelMain_Basic.Items.Add(this.btnDescriptorChanges);
            this.ribbonPanelMain_Basic.Name = "ribbonPanelMain_Basic";
            this.ribbonPanelMain_Basic.Text = "Podstawowe";
            // 
            // btnAgreements
            // 
            this.btnAgreements.Image = ((System.Drawing.Image)(resources.GetObject("btnAgreements.Image")));
            this.btnAgreements.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgreements.LargeImage")));
            this.btnAgreements.Name = "btnAgreements";
            this.btnAgreements.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAgreements.SmallImage")));
            this.btnAgreements.Text = "Umowy";
            this.btnAgreements.Click += new System.EventHandler(this.btnAgreements_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Enabled = false;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.LargeImage")));
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.SmallImage")));
            this.btnProducts.Text = "Produkty i towary";
            // 
            // btnSettlements
            // 
            this.btnSettlements.Enabled = false;
            this.btnSettlements.Image = ((System.Drawing.Image)(resources.GetObject("btnSettlements.Image")));
            this.btnSettlements.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSettlements.LargeImage")));
            this.btnSettlements.Name = "btnSettlements";
            this.btnSettlements.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSettlements.SmallImage")));
            this.btnSettlements.Text = "Rozliczenia";
            // 
            // btnDescriptorChanges
            // 
            this.btnDescriptorChanges.Enabled = false;
            this.btnDescriptorChanges.Image = ((System.Drawing.Image)(resources.GetObject("btnDescriptorChanges.Image")));
            this.btnDescriptorChanges.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDescriptorChanges.LargeImage")));
            this.btnDescriptorChanges.Name = "btnDescriptorChanges";
            this.btnDescriptorChanges.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDescriptorChanges.SmallImage")));
            this.btnDescriptorChanges.Text = "ZmianyDeskryptora";
            // 
            // ribbonTabDictionaries
            // 
            this.ribbonTabDictionaries.Enabled = false;
            this.ribbonTabDictionaries.Name = "ribbonTabDictionaries";
            this.ribbonTabDictionaries.Panels.Add(this.ribbonPanelDictionaries_Dict);
            this.ribbonTabDictionaries.Text = "Słowniki";
            // 
            // ribbonPanelDictionaries_Dict
            // 
            this.ribbonPanelDictionaries_Dict.Enabled = false;
            this.ribbonPanelDictionaries_Dict.Items.Add(this.btnLicensersDict);
            this.ribbonPanelDictionaries_Dict.Items.Add(this.btnCurrencyDict);
            this.ribbonPanelDictionaries_Dict.Name = "ribbonPanelDictionaries_Dict";
            this.ribbonPanelDictionaries_Dict.Text = "Słowniki";
            // 
            // btnLicensersDict
            // 
            this.btnLicensersDict.Image = ((System.Drawing.Image)(resources.GetObject("btnLicensersDict.Image")));
            this.btnLicensersDict.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLicensersDict.LargeImage")));
            this.btnLicensersDict.Name = "btnLicensersDict";
            this.btnLicensersDict.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnLicensersDict.SmallImage")));
            this.btnLicensersDict.Text = "Licencjodawcy";
            // 
            // btnCurrencyDict
            // 
            this.btnCurrencyDict.Image = ((System.Drawing.Image)(resources.GetObject("btnCurrencyDict.Image")));
            this.btnCurrencyDict.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCurrencyDict.LargeImage")));
            this.btnCurrencyDict.Name = "btnCurrencyDict";
            this.btnCurrencyDict.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnCurrencyDict.SmallImage")));
            this.btnCurrencyDict.Text = "Waluty";
            // 
            // ribbonTabReports
            // 
            this.ribbonTabReports.Enabled = false;
            this.ribbonTabReports.Name = "ribbonTabReports";
            this.ribbonTabReports.Text = "Raporty";
            // 
            // ribbonTabSettings
            // 
            this.ribbonTabSettings.Enabled = false;
            this.ribbonTabSettings.Name = "ribbonTabSettings";
            this.ribbonTabSettings.Panels.Add(this.ribbonPanelSettings_Mine);
            this.ribbonTabSettings.Panels.Add(this.ribbonPanelSettings_Users);
            this.ribbonTabSettings.Text = "Ustawienia";
            // 
            // ribbonPanelSettings_Mine
            // 
            this.ribbonPanelSettings_Mine.Enabled = false;
            this.ribbonPanelSettings_Mine.Items.Add(this.btnSettingsChangePassword);
            this.ribbonPanelSettings_Mine.Name = "ribbonPanelSettings_Mine";
            this.ribbonPanelSettings_Mine.Text = "Moje";
            // 
            // btnSettingsChangePassword
            // 
            this.btnSettingsChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingsChangePassword.Image")));
            this.btnSettingsChangePassword.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSettingsChangePassword.LargeImage")));
            this.btnSettingsChangePassword.Name = "btnSettingsChangePassword";
            this.btnSettingsChangePassword.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSettingsChangePassword.SmallImage")));
            this.btnSettingsChangePassword.Text = "Zmień hasło";
            // 
            // ribbonPanelSettings_Users
            // 
            this.ribbonPanelSettings_Users.Enabled = false;
            this.ribbonPanelSettings_Users.Items.Add(this.btnSettingsUsers);
            this.ribbonPanelSettings_Users.Name = "ribbonPanelSettings_Users";
            this.ribbonPanelSettings_Users.Text = "Użytkownicy";
            // 
            // btnSettingsUsers
            // 
            this.btnSettingsUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingsUsers.Image")));
            this.btnSettingsUsers.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSettingsUsers.LargeImage")));
            this.btnSettingsUsers.Name = "btnSettingsUsers";
            this.btnSettingsUsers.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSettingsUsers.SmallImage")));
            this.btnSettingsUsers.Text = "Użytkownicy";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 488);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "Foksal project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTabMain;
        private System.Windows.Forms.RibbonPanel ribbonPanelMain_User;
        private System.Windows.Forms.RibbonButton btnLogIn;
        private System.Windows.Forms.RibbonButton btnLogOut;
        private System.Windows.Forms.RibbonButton btnExit;
        private System.Windows.Forms.RibbonPanel ribbonPanelMain_Basic;
        private System.Windows.Forms.RibbonTab ribbonTabDictionaries;
        private System.Windows.Forms.RibbonTab ribbonTabReports;
        private System.Windows.Forms.RibbonTab ribbonTabSettings;
        private System.Windows.Forms.RibbonButton btnAgreements;
        private System.Windows.Forms.RibbonButton btnProducts;
        private System.Windows.Forms.RibbonButton btnSettlements;
        private System.Windows.Forms.RibbonButton btnDescriptorChanges;
        private System.Windows.Forms.RibbonPanel ribbonPanelDictionaries_Dict;
        private System.Windows.Forms.RibbonButton btnLicensersDict;
        private System.Windows.Forms.RibbonButton btnCurrencyDict;
        private System.Windows.Forms.RibbonPanel ribbonPanelSettings_Mine;
        private System.Windows.Forms.RibbonButton btnSettingsChangePassword;
        private System.Windows.Forms.RibbonPanel ribbonPanelSettings_Users;
        private System.Windows.Forms.RibbonButton btnSettingsUsers;
    }
}

