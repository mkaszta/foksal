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
            this.ribbon1 = new Janus.Windows.Ribbon.Ribbon();
            this.ribbonTabMain = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroupMain = new Janus.Windows.Ribbon.RibbonGroup();
            this.ribbonStatusBar1 = new Janus.Windows.Ribbon.RibbonStatusBar();
            this.buttonCommandUmowy = new Janus.Windows.Ribbon.ButtonCommand();
            this.buttonCommandProdukty = new Janus.Windows.Ribbon.ButtonCommand();
            this.buttonCommandRozliczenia = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonTabSlowniki = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroupSlowniki = new Janus.Windows.Ribbon.RibbonGroup();
            this.buttonCommandLicencjodawcy = new Janus.Windows.Ribbon.ButtonCommand();
            this.buttonCommandWaluty = new Janus.Windows.Ribbon.ButtonCommand();
            this.buttonCommandDeskryptor = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonTabSettings = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroupUsers = new Janus.Windows.Ribbon.RibbonGroup();
            this.buttonCommandUsers = new Janus.Windows.Ribbon.ButtonCommand();
            this.ribbonGroupPersonal = new Janus.Windows.Ribbon.RibbonGroup();
            this.buttonCommandChangePassword = new Janus.Windows.Ribbon.ButtonCommand();
            this.Reports = new Janus.Windows.Ribbon.RibbonTab();
            this.ribbonGroupReportsAgreements = new Janus.Windows.Ribbon.RibbonGroup();
            this.ribbonGroupReportsSettlements = new Janus.Windows.Ribbon.RibbonGroup();
            this.ribbonGroupReportsGeneral = new Janus.Windows.Ribbon.RibbonGroup();
            this.buttonCommand1 = new Janus.Windows.Ribbon.ButtonCommand();
            this.buttonCommand2 = new Janus.Windows.Ribbon.ButtonCommand();
            this.buttonCommand3 = new Janus.Windows.Ribbon.ButtonCommand();
            this.buttonCommand4 = new Janus.Windows.Ribbon.ButtonCommand();
            this.dropDownCommand1 = new Janus.Windows.Ribbon.DropDownCommand();
            this.ribbonGroupUser = new Janus.Windows.Ribbon.RibbonGroup();
            this.buttonCommandLogIn = new Janus.Windows.Ribbon.ButtonCommand();
            this.buttonCommandLogOut = new Janus.Windows.Ribbon.ButtonCommand();
            this.buttonCommandExit = new Janus.Windows.Ribbon.ButtonCommand();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.BackstageMenuData = "<?xml version=\"1.0\" encoding=\"utf-8\"?><BackstageMenu><ImageKey /><Key /><Text>Fil" +
    "e</Text></BackstageMenu>";
            this.ribbon1.ControlBoxMenu.LeftCommands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.dropDownCommand1});
            // 
            // 
            // 
            this.ribbon1.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("ribbon1.HelpButton.Image")));
            this.ribbon1.HelpButton.Key = "HelpButton";
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Name = "ribbon1";
            this.ribbon1.Size = new System.Drawing.Size(899, 146);
            // 
            // 
            // 
            this.ribbon1.SuperTipComponent.AutoPopDelay = 2000;
            this.ribbon1.SuperTipComponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ribbon1.SuperTipComponent.ImageList = null;
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.AddRange(new Janus.Windows.Ribbon.RibbonTab[] {
            this.ribbonTabMain,
            this.ribbonTabSlowniki,
            this.Reports,
            this.ribbonTabSettings});
            this.ribbon1.Text = "";
            // 
            // ribbonTabMain
            // 
            this.ribbonTabMain.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.ribbonGroupUser,
            this.ribbonGroupMain});
            this.ribbonTabMain.Key = "ribbonTab1";
            this.ribbonTabMain.Name = "ribbonTabMain";
            this.ribbonTabMain.Text = "Narzędzia główne";
            // 
            // ribbonGroupMain
            // 
            this.ribbonGroupMain.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommandUmowy,
            this.buttonCommandProdukty,
            this.buttonCommandRozliczenia,
            this.buttonCommandDeskryptor});
            this.ribbonGroupMain.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroupMain;
            this.ribbonGroupMain.Enabled = false;
            this.ribbonGroupMain.Key = "ribbonGroup1";
            this.ribbonGroupMain.Name = "ribbonGroupMain";
            this.ribbonGroupMain.Text = "Podstawowe";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 497);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Size = new System.Drawing.Size(899, 23);
            // 
            // 
            // 
            this.ribbonStatusBar1.SuperTipComponent.AutoPopDelay = 2000;
            this.ribbonStatusBar1.SuperTipComponent.ImageList = null;
            this.ribbonStatusBar1.TabIndex = 2;
            this.ribbonStatusBar1.Text = "ribbonStatusBar1";
            // 
            // buttonCommandUmowy
            // 
            this.buttonCommandUmowy.Key = "buttonCommand1";
            this.buttonCommandUmowy.Name = "buttonCommandUmowy";
            this.buttonCommandUmowy.Text = "Umowy";
            // 
            // buttonCommandProdukty
            // 
            this.buttonCommandProdukty.Key = "buttonCommand1";
            this.buttonCommandProdukty.Name = "buttonCommandProdukty";
            this.buttonCommandProdukty.Text = "Produkty i towary";
            // 
            // buttonCommandRozliczenia
            // 
            this.buttonCommandRozliczenia.Key = "buttonCommand1";
            this.buttonCommandRozliczenia.Name = "buttonCommandRozliczenia";
            this.buttonCommandRozliczenia.Text = "Rozliczenia";
            // 
            // ribbonTabSlowniki
            // 
            this.ribbonTabSlowniki.Enabled = false;
            this.ribbonTabSlowniki.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.ribbonGroupSlowniki});
            this.ribbonTabSlowniki.Key = "ribbonTab1";
            this.ribbonTabSlowniki.Name = "ribbonTabSlowniki";
            this.ribbonTabSlowniki.Text = "Słowniki";
            // 
            // ribbonGroupSlowniki
            // 
            this.ribbonGroupSlowniki.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommandLicencjodawcy,
            this.buttonCommandWaluty});
            this.ribbonGroupSlowniki.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroupSlowniki;
            this.ribbonGroupSlowniki.Key = "ribbonGroup1";
            this.ribbonGroupSlowniki.Name = "ribbonGroupSlowniki";
            this.ribbonGroupSlowniki.Text = "Słowniki";
            // 
            // buttonCommandLicencjodawcy
            // 
            this.buttonCommandLicencjodawcy.Key = "buttonCommand1";
            this.buttonCommandLicencjodawcy.Name = "buttonCommandLicencjodawcy";
            this.buttonCommandLicencjodawcy.Text = "Licencjodawcy";
            // 
            // buttonCommandWaluty
            // 
            this.buttonCommandWaluty.Key = "buttonCommand1";
            this.buttonCommandWaluty.Name = "buttonCommandWaluty";
            this.buttonCommandWaluty.Text = "Waluty";
            // 
            // buttonCommandDeskryptor
            // 
            this.buttonCommandDeskryptor.Key = "buttonCommand1";
            this.buttonCommandDeskryptor.Name = "buttonCommandDeskryptor";
            this.buttonCommandDeskryptor.Text = "Zmiany deskryptora";
            // 
            // ribbonTabSettings
            // 
            this.ribbonTabSettings.Enabled = false;
            this.ribbonTabSettings.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.ribbonGroupPersonal,
            this.ribbonGroupUsers});
            this.ribbonTabSettings.Key = "ribbonTab1";
            this.ribbonTabSettings.Name = "ribbonTabSettings";
            this.ribbonTabSettings.Text = "Ustawienia";
            // 
            // ribbonGroupUsers
            // 
            this.ribbonGroupUsers.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommandUsers});
            this.ribbonGroupUsers.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroupUsers;
            this.ribbonGroupUsers.Key = "ribbonGroup1";
            this.ribbonGroupUsers.Name = "ribbonGroupUsers";
            this.ribbonGroupUsers.Text = "Użytkownicy";
            // 
            // buttonCommandUsers
            // 
            this.buttonCommandUsers.Key = "buttonCommand1";
            this.buttonCommandUsers.Name = "buttonCommandUsers";
            this.buttonCommandUsers.Text = "Użytkownicy i uprawnienia";
            // 
            // ribbonGroupPersonal
            // 
            this.ribbonGroupPersonal.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommandChangePassword});
            this.ribbonGroupPersonal.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroupPersonal;
            this.ribbonGroupPersonal.Key = "ribbonGroup1";
            this.ribbonGroupPersonal.Name = "ribbonGroupPersonal";
            this.ribbonGroupPersonal.Text = "Moje";
            // 
            // buttonCommandChangePassword
            // 
            this.buttonCommandChangePassword.Key = "buttonCommand1";
            this.buttonCommandChangePassword.Name = "buttonCommandChangePassword";
            this.buttonCommandChangePassword.Text = "Zmień hasło";
            // 
            // Reports
            // 
            this.Reports.Enabled = false;
            this.Reports.Groups.AddRange(new Janus.Windows.Ribbon.RibbonGroup[] {
            this.ribbonGroupReportsGeneral,
            this.ribbonGroupReportsAgreements,
            this.ribbonGroupReportsSettlements});
            this.Reports.Key = "ribbonTab1";
            this.Reports.Name = "Reports";
            this.Reports.Text = "Raporty";
            // 
            // ribbonGroupReportsAgreements
            // 
            this.ribbonGroupReportsAgreements.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommand2});
            this.ribbonGroupReportsAgreements.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroupReportsAgreements;
            this.ribbonGroupReportsAgreements.Key = "ribbonGroup1";
            this.ribbonGroupReportsAgreements.Name = "ribbonGroupReportsAgreements";
            this.ribbonGroupReportsAgreements.Text = "Umowy";
            // 
            // ribbonGroupReportsSettlements
            // 
            this.ribbonGroupReportsSettlements.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommand4,
            this.buttonCommand3});
            this.ribbonGroupReportsSettlements.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroupReportsSettlements;
            this.ribbonGroupReportsSettlements.Key = "ribbonGroup1";
            this.ribbonGroupReportsSettlements.Name = "ribbonGroupReportsSettlements";
            this.ribbonGroupReportsSettlements.Text = "Rozliczenia";
            // 
            // ribbonGroupReportsGeneral
            // 
            this.ribbonGroupReportsGeneral.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommand1});
            this.ribbonGroupReportsGeneral.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroupReportsGeneral;
            this.ribbonGroupReportsGeneral.Key = "ribbonGroup1";
            this.ribbonGroupReportsGeneral.Name = "ribbonGroupReportsGeneral";
            this.ribbonGroupReportsGeneral.Text = "Ogólne";
            // 
            // buttonCommand1
            // 
            this.buttonCommand1.Key = "buttonCommand1";
            this.buttonCommand1.Name = "buttonCommand1";
            this.buttonCommand1.Text = "Raport końcowy";
            // 
            // buttonCommand2
            // 
            this.buttonCommand2.Key = "buttonCommand2";
            this.buttonCommand2.Name = "buttonCommand2";
            this.buttonCommand2.Text = "Podsumowanie umów";
            // 
            // buttonCommand3
            // 
            this.buttonCommand3.Key = "buttonCommand3";
            this.buttonCommand3.Name = "buttonCommand3";
            this.buttonCommand3.Text = "Harmonogram wypłat zaliczki";
            // 
            // buttonCommand4
            // 
            this.buttonCommand4.Key = "buttonCommand4";
            this.buttonCommand4.Name = "buttonCommand4";
            this.buttonCommand4.Text = "Lista rozliczeń";
            // 
            // dropDownCommand1
            // 
            this.dropDownCommand1.Key = "dropDownCommand1";
            this.dropDownCommand1.Name = "dropDownCommand1";
            // 
            // ribbonGroupUser
            // 
            this.ribbonGroupUser.Commands.AddRange(new Janus.Windows.Ribbon.CommandBase[] {
            this.buttonCommandLogIn,
            this.buttonCommandLogOut,
            this.buttonCommandExit});
            this.ribbonGroupUser.DialogButtonSuperTipSettings.ImageListProvider = this.ribbonGroupUser;
            this.ribbonGroupUser.Key = "ribbonGroup1";
            this.ribbonGroupUser.Name = "ribbonGroupUser";
            this.ribbonGroupUser.Text = "Użytkownik";
            // 
            // buttonCommandLogIn
            // 
            this.buttonCommandLogIn.Key = "buttonCommand5";
            this.buttonCommandLogIn.Name = "buttonCommandLogIn";
            this.buttonCommandLogIn.Text = "Zaloguj";
            this.buttonCommandLogIn.Click += new Janus.Windows.Ribbon.CommandEventHandler(this.buttonCommandLogIn_Click);
            // 
            // buttonCommandLogOut
            // 
            this.buttonCommandLogOut.Key = "buttonCommand5";
            this.buttonCommandLogOut.Name = "buttonCommandLogOut";
            this.buttonCommandLogOut.Text = "Wyloguj";
            this.buttonCommandLogOut.Visible = false;
            // 
            // buttonCommandExit
            // 
            this.buttonCommandExit.Key = "buttonCommand5";
            this.buttonCommandExit.Name = "buttonCommandExit";
            this.buttonCommandExit.Text = "Zamknij";
            this.buttonCommandExit.Click += new Janus.Windows.Ribbon.CommandEventHandler(this.buttonCommandExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 520);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbon1);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Foksal project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.Ribbon.Ribbon ribbon1;
        private Janus.Windows.Ribbon.RibbonTab ribbonTabMain;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroupMain;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandUmowy;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandProdukty;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandRozliczenia;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandDeskryptor;
        private Janus.Windows.Ribbon.RibbonTab ribbonTabSlowniki;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroupSlowniki;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandLicencjodawcy;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandWaluty;
        private Janus.Windows.Ribbon.RibbonTab Reports;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroupReportsGeneral;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommand1;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroupReportsAgreements;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommand2;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroupReportsSettlements;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommand4;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommand3;
        private Janus.Windows.Ribbon.RibbonTab ribbonTabSettings;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroupPersonal;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandChangePassword;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroupUsers;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandUsers;
        private Janus.Windows.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private Janus.Windows.Ribbon.DropDownCommand dropDownCommand1;
        private Janus.Windows.Ribbon.RibbonGroup ribbonGroupUser;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandLogIn;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandLogOut;
        private Janus.Windows.Ribbon.ButtonCommand buttonCommandExit;
    }
}

