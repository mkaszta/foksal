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
            this.ribbonPanelBasic = new System.Windows.Forms.RibbonPanel();
            this.btnAgreements = new System.Windows.Forms.RibbonButton();
            this.btnProducts = new System.Windows.Forms.RibbonButton();
            this.btnSettlements = new System.Windows.Forms.RibbonButton();
            this.btnDescriptorChanges = new System.Windows.Forms.RibbonButton();
            this.ribbonTabSettings = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelSettings_Mine = new System.Windows.Forms.RibbonPanel();
            this.btnSettingsChangePassword = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelSettings_Users = new System.Windows.Forms.RibbonPanel();
            this.btnSettingsUsers = new System.Windows.Forms.RibbonButton();
            this.ribbonTabDictionaries = new System.Windows.Forms.RibbonTab();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ribbonTabReports = new System.Windows.Forms.RibbonTab();
            this.groupBox1.SuspendLayout();
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
            this.ribbon1.Size = new System.Drawing.Size(1225, 147);
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
            this.ribbonTabMain.Panels.Add(this.ribbonPanelBasic);
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
            this.btnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.LargeImage")));
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.SmallImage")));
            this.btnLogOut.Text = "Wyloguj";
            this.btnLogOut.Visible = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExit.LargeImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnExit.SmallImage")));
            this.btnExit.Text = "Zamknij";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // ribbonPanelBasic
            // 
            this.ribbonPanelBasic.Items.Add(this.btnAgreements);
            this.ribbonPanelBasic.Items.Add(this.btnProducts);
            this.ribbonPanelBasic.Items.Add(this.btnSettlements);
            this.ribbonPanelBasic.Items.Add(this.btnDescriptorChanges);
            this.ribbonPanelBasic.Name = "ribbonPanelBasic";
            this.ribbonPanelBasic.Text = "Podstawowe";
            // 
            // btnAgreements
            // 
            this.btnAgreements.Image = ((System.Drawing.Image)(resources.GetObject("btnAgreements.Image")));
            this.btnAgreements.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAgreements.LargeImage")));
            this.btnAgreements.Name = "btnAgreements";
            this.btnAgreements.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnAgreements.SmallImage")));
            this.btnAgreements.Text = "Umowy";
            this.btnAgreements.Click += new System.EventHandler(this.BtnAgreements_Click);
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
            this.btnDescriptorChanges.Text = "Zmiany deskryptora";
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
            // 
            // ribbonTabDictionaries
            // 
            this.ribbonTabDictionaries.Name = "ribbonTabDictionaries";
            this.ribbonTabDictionaries.Text = "Słowniki";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(831, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 233);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Development process";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(185, 179);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(267, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "X";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(267, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "X";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(321, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Odebrane";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(258, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Testy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(162, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Development";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(102, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Raporty:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(20, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Formularz administracyjny:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lista zmian deskryptora:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Słownik walut:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rozliczenia:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Słownik licencjodawców:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lista produktów i towarów:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(22, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Logowanie / autoryzacja:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(104, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Umowy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Formularz z przypomnieniami:";
            // 
            // ribbonTabReports
            // 
            this.ribbonTabReports.Name = "ribbonTabReports";
            this.ribbonTabReports.Text = "Raporty";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 581);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "Foksal project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RibbonTab ribbonTabSettings;
        private System.Windows.Forms.RibbonPanel ribbonPanelDictionaries_Dict;
        private System.Windows.Forms.RibbonPanel ribbonPanelSettings_Mine;
        private System.Windows.Forms.RibbonButton btnSettingsChangePassword;
        private System.Windows.Forms.RibbonPanel ribbonPanelSettings_Users;
        private System.Windows.Forms.RibbonButton btnSettingsUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RibbonPanel ribbonPanelBasic;
        private System.Windows.Forms.RibbonButton btnAgreements;
        private System.Windows.Forms.RibbonButton btnProducts;
        private System.Windows.Forms.RibbonButton btnSettlements;
        private System.Windows.Forms.RibbonButton btnDescriptorChanges;
        private System.Windows.Forms.RibbonTab ribbonTabDictionaries;
        private System.Windows.Forms.RibbonTab ribbonTabReports;
    }
}

