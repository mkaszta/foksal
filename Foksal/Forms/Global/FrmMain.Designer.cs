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
            this.ribbonTabMain = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelMain_User = new System.Windows.Forms.RibbonPanel();
            this.btnLogIn = new System.Windows.Forms.RibbonButton();
            this.btnLogOut = new System.Windows.Forms.RibbonButton();
            this.btnExit = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelBasic = new System.Windows.Forms.RibbonPanel();
            this.btnAgreements = new System.Windows.Forms.RibbonButton();
            this.btnProducts = new System.Windows.Forms.RibbonButton();
            this.btnSettlements = new System.Windows.Forms.RibbonButton();
            this.btnDescriptorChanges = new System.Windows.Forms.RibbonButton();
            this.ribbonTabDictionaries = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelDictionaries = new System.Windows.Forms.RibbonPanel();
            this.btnDictCurrencies = new System.Windows.Forms.RibbonButton();
            this.btnDictLicensors = new System.Windows.Forms.RibbonButton();
            this.ribbonTabReports = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelReports = new System.Windows.Forms.RibbonPanel();
            this.ribbonTabSettings = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelSettings_Mine = new System.Windows.Forms.RibbonPanel();
            this.btnSettingsChangePassword = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelSettings_Users = new System.Windows.Forms.RibbonPanel();
            this.btnSettingsUsers = new System.Windows.Forms.RibbonButton();
            this.ribbonMain = new System.Windows.Forms.Ribbon();
            this.SuspendLayout();
            // 
            // ribbonTabMain
            // 
            this.ribbonTabMain.Name = "ribbonTabMain";
            this.ribbonTabMain.Panels.Add(this.ribbonPanelMain_User);
            this.ribbonTabMain.Panels.Add(this.ribbonPanelBasic);
            this.ribbonTabMain.Text = "Narzędzia główne";
            // 
            // ribbonPanelMain_User
            // 
            this.ribbonPanelMain_User.ButtonMoreEnabled = false;
            this.ribbonPanelMain_User.ButtonMoreVisible = false;
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
            this.btnLogIn.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnLogIn.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnLogIn.SmallImage")));
            this.btnLogIn.Text = "Zaloguj";
            this.btnLogIn.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.LargeImage")));
            this.btnLogOut.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnLogOut.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.SmallImage")));
            this.btnLogOut.Text = "Wyloguj";
            this.btnLogOut.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.LargeImage")));
            this.btnExit.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnExit.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnExit.Name = "btnExit";
            this.btnExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnExit.SmallImage")));
            this.btnExit.Text = "Zamknij";
            this.btnExit.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ribbonPanelBasic
            // 
            this.ribbonPanelBasic.ButtonMoreEnabled = false;
            this.ribbonPanelBasic.ButtonMoreVisible = false;
            this.ribbonPanelBasic.Items.Add(this.btnAgreements);
            this.ribbonPanelBasic.Items.Add(this.btnProducts);
            this.ribbonPanelBasic.Items.Add(this.btnSettlements);
            this.ribbonPanelBasic.Items.Add(this.btnDescriptorChanges);
            this.ribbonPanelBasic.Name = "ribbonPanelBasic";
            this.ribbonPanelBasic.Text = "Podstawowe";
            // 
            // btnAgreements
            // 
            this.btnAgreements.Enabled = false;
            this.btnAgreements.Image = ((System.Drawing.Image)(resources.GetObject("btnAgreements.Image")));
            this.btnAgreements.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgreements.LargeImage")));
            this.btnAgreements.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnAgreements.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnAgreements.Name = "btnAgreements";
            this.btnAgreements.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAgreements.SmallImage")));
            this.btnAgreements.Text = "Umowy";
            this.btnAgreements.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btnAgreements.Click += new System.EventHandler(this.BtnAgreements_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Enabled = false;
            this.btnProducts.Image = ((System.Drawing.Image)(resources.GetObject("btnProducts.Image")));
            this.btnProducts.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.LargeImage")));
            this.btnProducts.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnProducts.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnProducts.SmallImage")));
            this.btnProducts.Text = "Niepowiązane WF MAG";
            this.btnProducts.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSettlements
            // 
            this.btnSettlements.Enabled = false;
            this.btnSettlements.Image = ((System.Drawing.Image)(resources.GetObject("btnSettlements.Image")));
            this.btnSettlements.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSettlements.LargeImage")));
            this.btnSettlements.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnSettlements.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnSettlements.Name = "btnSettlements";
            this.btnSettlements.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSettlements.SmallImage")));
            this.btnSettlements.Text = "Rozliczenia";
            this.btnSettlements.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btnSettlements.Click += new System.EventHandler(this.btnSettlements_Click);
            // 
            // btnDescriptorChanges
            // 
            this.btnDescriptorChanges.Enabled = false;
            this.btnDescriptorChanges.Image = ((System.Drawing.Image)(resources.GetObject("btnDescriptorChanges.Image")));
            this.btnDescriptorChanges.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDescriptorChanges.LargeImage")));
            this.btnDescriptorChanges.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnDescriptorChanges.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.btnDescriptorChanges.Name = "btnDescriptorChanges";
            this.btnDescriptorChanges.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDescriptorChanges.SmallImage")));
            this.btnDescriptorChanges.Text = "Zmiany deskryptora";
            this.btnDescriptorChanges.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Center;
            this.btnDescriptorChanges.Click += new System.EventHandler(this.btnDescriptorChanges_Click);
            // 
            // ribbonTabDictionaries
            // 
            this.ribbonTabDictionaries.Name = "ribbonTabDictionaries";
            this.ribbonTabDictionaries.Panels.Add(this.ribbonPanelDictionaries);
            this.ribbonTabDictionaries.Text = "Słowniki";
            // 
            // ribbonPanelDictionaries
            // 
            this.ribbonPanelDictionaries.Items.Add(this.btnDictCurrencies);
            this.ribbonPanelDictionaries.Items.Add(this.btnDictLicensors);
            this.ribbonPanelDictionaries.Name = "ribbonPanelDictionaries";
            this.ribbonPanelDictionaries.Text = "Słowniki";
            // 
            // btnDictCurrencies
            // 
            this.btnDictCurrencies.Image = ((System.Drawing.Image)(resources.GetObject("btnDictCurrencies.Image")));
            this.btnDictCurrencies.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDictCurrencies.LargeImage")));
            this.btnDictCurrencies.Name = "btnDictCurrencies";
            this.btnDictCurrencies.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDictCurrencies.SmallImage")));
            this.btnDictCurrencies.Text = "Waluty";
            this.btnDictCurrencies.Click += new System.EventHandler(this.btnDictCurrencies_Click);
            // 
            // btnDictLicensors
            // 
            this.btnDictLicensors.Image = ((System.Drawing.Image)(resources.GetObject("btnDictLicensors.Image")));
            this.btnDictLicensors.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDictLicensors.LargeImage")));
            this.btnDictLicensors.Name = "btnDictLicensors";
            this.btnDictLicensors.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDictLicensors.SmallImage")));
            this.btnDictLicensors.Text = "Licencjodawcy";
            this.btnDictLicensors.Click += new System.EventHandler(this.btnDictLicensors_Click);
            // 
            // ribbonTabReports
            // 
            this.ribbonTabReports.Name = "ribbonTabReports";
            this.ribbonTabReports.Panels.Add(this.ribbonPanelReports);
            this.ribbonTabReports.Text = "Raporty";
            // 
            // ribbonPanelReports
            // 
            this.ribbonPanelReports.Name = "ribbonPanelReports";
            this.ribbonPanelReports.Text = "Dostępne raporty";
            // 
            // ribbonTabSettings
            // 
            this.ribbonTabSettings.Name = "ribbonTabSettings";
            this.ribbonTabSettings.Panels.Add(this.ribbonPanelSettings_Mine);
            this.ribbonTabSettings.Panels.Add(this.ribbonPanelSettings_Users);
            this.ribbonTabSettings.Text = "Ustawienia";
            this.ribbonTabSettings.Visible = false;
            // 
            // ribbonPanelSettings_Mine
            // 
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
            this.btnSettingsChangePassword.Click += new System.EventHandler(this.BtnSettingsChangePassword_Click);
            // 
            // ribbonPanelSettings_Users
            // 
            this.ribbonPanelSettings_Users.Items.Add(this.btnSettingsUsers);
            this.ribbonPanelSettings_Users.Name = "ribbonPanelSettings_Users";
            this.ribbonPanelSettings_Users.Text = "Użytkownicy";
            // 
            // btnSettingsUsers
            // 
            this.btnSettingsUsers.Enabled = false;
            this.btnSettingsUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingsUsers.Image")));
            this.btnSettingsUsers.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSettingsUsers.LargeImage")));
            this.btnSettingsUsers.Name = "btnSettingsUsers";
            this.btnSettingsUsers.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnSettingsUsers.SmallImage")));
            this.btnSettingsUsers.Text = "Użytkownicy";
            this.btnSettingsUsers.Click += new System.EventHandler(this.btnSettingsUsers_Click);
            // 
            // ribbonMain
            // 
            this.ribbonMain.CaptionBarVisible = false;
            this.ribbonMain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbonMain.Location = new System.Drawing.Point(0, 0);
            this.ribbonMain.Minimized = false;
            this.ribbonMain.Name = "ribbonMain";
            // 
            // 
            // 
            this.ribbonMain.OrbDropDown.BorderRoundness = 8;
            this.ribbonMain.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbonMain.OrbDropDown.Name = "";
            this.ribbonMain.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbonMain.OrbDropDown.TabIndex = 0;
            this.ribbonMain.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbonMain.OrbVisible = false;
            this.ribbonMain.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbonMain.Size = new System.Drawing.Size(1225, 125);
            this.ribbonMain.TabIndex = 4;
            this.ribbonMain.Tabs.Add(this.ribbonTabMain);
            this.ribbonMain.Tabs.Add(this.ribbonTabDictionaries);
            this.ribbonMain.Tabs.Add(this.ribbonTabReports);
            this.ribbonMain.Tabs.Add(this.ribbonTabSettings);
            this.ribbonMain.TabsMargin = new System.Windows.Forms.Padding(6, 2, 20, 0);
            this.ribbonMain.TabSpacing = 3;
            this.ribbonMain.Text = "Ribbon";
            this.ribbonMain.ThemeColor = System.Windows.Forms.RibbonTheme.Blue_2010;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 581);
            this.Controls.Add(this.ribbonMain);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "Foksal SNOL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RibbonTab ribbonTabMain;
        private System.Windows.Forms.RibbonButton btnLogIn;
        private System.Windows.Forms.RibbonButton btnLogOut;
        private System.Windows.Forms.RibbonButton btnExit;
        private System.Windows.Forms.RibbonPanel ribbonPanelMain_Basic;
        private System.Windows.Forms.RibbonTab ribbonTabSettings;
        private System.Windows.Forms.RibbonPanel ribbonPanelDictionaries_Dict;
        private System.Windows.Forms.RibbonPanel ribbonPanelSettings_Mine;
        private System.Windows.Forms.RibbonButton btnSettingsChangePassword;
        private System.Windows.Forms.RibbonPanel ribbonPanelSettings_Users;
        private System.Windows.Forms.RibbonButton btnSettingsUsers;
        private System.Windows.Forms.RibbonPanel ribbonPanelBasic;
        private System.Windows.Forms.RibbonButton btnAgreements;
        private System.Windows.Forms.RibbonButton btnProducts;
        private System.Windows.Forms.RibbonButton btnSettlements;
        private System.Windows.Forms.RibbonButton btnDescriptorChanges;
        private System.Windows.Forms.RibbonTab ribbonTabDictionaries;
        private System.Windows.Forms.RibbonTab ribbonTabReports;
        internal System.Windows.Forms.RibbonPanel ribbonPanelMain_User;
        private System.Windows.Forms.Ribbon ribbonMain;
        private System.Windows.Forms.RibbonPanel ribbonPanelDictionaries;
        private System.Windows.Forms.RibbonButton btnDictCurrencies;
        private System.Windows.Forms.RibbonButton btnDictLicensors;
        private System.Windows.Forms.RibbonPanel ribbonPanelReports;
    }
}

