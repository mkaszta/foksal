namespace Foksal.Forms.Agreements
{
    partial class FrmAgreement
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
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout gridExPositions_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgreement));
            this.label1 = new System.Windows.Forms.Label();
            this.txtReportTitle = new System.Windows.Forms.TextBox();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReportAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.numAdvance = new System.Windows.Forms.NumericUpDown();
            this.dtAdvanceDate = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPositions = new System.Windows.Forms.TabPage();
            this.cboBillingPeriod = new System.Windows.Forms.ComboBox();
            this.numFreeCopies = new System.Windows.Forms.NumericUpDown();
            this.dtAgreementExpiration = new System.Windows.Forms.DateTimePicker();
            this.dtBillingPeriodTo = new System.Windows.Forms.DateTimePicker();
            this.dtBillingPeriodFrom = new System.Windows.Forms.DateTimePicker();
            this.chkFirstSale = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkIndefinitePeriod = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gridExPositions = new Janus.Windows.GridEX.GridEX();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKTM = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescriptor = new System.Windows.Forms.TextBox();
            this.tabPageLicensors = new System.Windows.Forms.TabPage();
            this.tabPageSchedule = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.cboSettlementModel = new System.Windows.Forms.ComboBox();
            this.billingPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numAdvance)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFreeCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExPositions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingPeriodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Umowa:";
            // 
            // txtReportTitle
            // 
            this.txtReportTitle.Location = new System.Drawing.Point(23, 82);
            this.txtReportTitle.Name = "txtReportTitle";
            this.txtReportTitle.Size = new System.Drawing.Size(253, 20);
            this.txtReportTitle.TabIndex = 1;
            // 
            // lblAgreement
            // 
            this.lblAgreement.AutoSize = true;
            this.lblAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAgreement.Location = new System.Drawing.Point(98, 18);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(103, 20);
            this.lblAgreement.TabIndex = 2;
            this.lblAgreement.Text = "lblAgreement";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tytuł do raportu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tytuł oryginału";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(23, 123);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(253, 20);
            this.txtTitle.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Autor do raportu";
            // 
            // txtReportAuthor
            // 
            this.txtReportAuthor.Location = new System.Drawing.Point(23, 162);
            this.txtReportAuthor.Name = "txtReportAuthor";
            this.txtReportAuthor.Size = new System.Drawing.Size(253, 20);
            this.txtReportAuthor.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Wypłacona zaliczka";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Uwagi";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(290, 123);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(369, 59);
            this.txtComments.TabIndex = 14;
            this.txtComments.Text = "";
            // 
            // numAdvance
            // 
            this.numAdvance.Location = new System.Drawing.Point(287, 83);
            this.numAdvance.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numAdvance.Name = "numAdvance";
            this.numAdvance.Size = new System.Drawing.Size(161, 20);
            this.numAdvance.TabIndex = 15;
            // 
            // dtAdvanceDate
            // 
            this.dtAdvanceDate.CustomFormat = "";
            this.dtAdvanceDate.Enabled = false;
            this.dtAdvanceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAdvanceDate.Location = new System.Drawing.Point(497, 83);
            this.dtAdvanceDate.Name = "dtAdvanceDate";
            this.dtAdvanceDate.Size = new System.Drawing.Size(162, 20);
            this.dtAdvanceDate.TabIndex = 16;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPositions);
            this.tabControl1.Controls.Add(this.tabPageLicensors);
            this.tabControl1.Controls.Add(this.tabPageSchedule);
            this.tabControl1.Location = new System.Drawing.Point(12, 226);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(658, 270);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPositions
            // 
            this.tabPositions.Controls.Add(this.cboSettlementModel);
            this.tabPositions.Controls.Add(this.cboCurrency);
            this.tabPositions.Controls.Add(this.cboBillingPeriod);
            this.tabPositions.Controls.Add(this.numFreeCopies);
            this.tabPositions.Controls.Add(this.dtAgreementExpiration);
            this.tabPositions.Controls.Add(this.dtBillingPeriodTo);
            this.tabPositions.Controls.Add(this.dtBillingPeriodFrom);
            this.tabPositions.Controls.Add(this.chkFirstSale);
            this.tabPositions.Controls.Add(this.label8);
            this.tabPositions.Controls.Add(this.label17);
            this.tabPositions.Controls.Add(this.label12);
            this.tabPositions.Controls.Add(this.chkIndefinitePeriod);
            this.tabPositions.Controls.Add(this.label13);
            this.tabPositions.Controls.Add(this.label14);
            this.tabPositions.Controls.Add(this.gridExPositions);
            this.tabPositions.Controls.Add(this.txtKTM);
            this.tabPositions.Controls.Add(this.label9);
            this.tabPositions.Controls.Add(this.label15);
            this.tabPositions.Controls.Add(this.label10);
            this.tabPositions.Controls.Add(this.label11);
            this.tabPositions.Controls.Add(this.txtDescriptor);
            this.tabPositions.Location = new System.Drawing.Point(4, 22);
            this.tabPositions.Name = "tabPositions";
            this.tabPositions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPositions.Size = new System.Drawing.Size(650, 244);
            this.tabPositions.TabIndex = 1;
            this.tabPositions.Text = "Pozycje";
            this.tabPositions.UseVisualStyleBackColor = true;
            // 
            // cboBillingPeriod
            // 
            this.cboBillingPeriod.FormattingEnabled = true;
            this.cboBillingPeriod.Location = new System.Drawing.Point(481, 56);
            this.cboBillingPeriod.Name = "cboBillingPeriod";
            this.cboBillingPeriod.Size = new System.Drawing.Size(162, 21);
            this.cboBillingPeriod.TabIndex = 48;
            // 
            // numFreeCopies
            // 
            this.numFreeCopies.Location = new System.Drawing.Point(269, 174);
            this.numFreeCopies.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numFreeCopies.Name = "numFreeCopies";
            this.numFreeCopies.Size = new System.Drawing.Size(162, 20);
            this.numFreeCopies.TabIndex = 47;
            // 
            // dtAgreementExpiration
            // 
            this.dtAgreementExpiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAgreementExpiration.Location = new System.Drawing.Point(269, 213);
            this.dtAgreementExpiration.Name = "dtAgreementExpiration";
            this.dtAgreementExpiration.Size = new System.Drawing.Size(162, 20);
            this.dtAgreementExpiration.TabIndex = 46;
            // 
            // dtBillingPeriodTo
            // 
            this.dtBillingPeriodTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBillingPeriodTo.Location = new System.Drawing.Point(481, 109);
            this.dtBillingPeriodTo.Name = "dtBillingPeriodTo";
            this.dtBillingPeriodTo.Size = new System.Drawing.Size(162, 20);
            this.dtBillingPeriodTo.TabIndex = 45;
            // 
            // dtBillingPeriodFrom
            // 
            this.dtBillingPeriodFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBillingPeriodFrom.Location = new System.Drawing.Point(481, 83);
            this.dtBillingPeriodFrom.Name = "dtBillingPeriodFrom";
            this.dtBillingPeriodFrom.Size = new System.Drawing.Size(162, 20);
            this.dtBillingPeriodFrom.TabIndex = 44;
            // 
            // chkFirstSale
            // 
            this.chkFirstSale.AutoSize = true;
            this.chkFirstSale.Location = new System.Drawing.Point(479, 216);
            this.chkFirstSale.Name = "chkFirstSale";
            this.chkFirstSale.Size = new System.Drawing.Size(166, 17);
            this.chkFirstSale.TabIndex = 43;
            this.chkFirstSale.Text = "Nalicz od pierwszej sprzedaży";
            this.chkFirstSale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "od:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(267, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(141, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Data zakończenia kontraktu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(266, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Liczba egzemplarzy bez opłat";
            // 
            // chkIndefinitePeriod
            // 
            this.chkIndefinitePeriod.AutoSize = true;
            this.chkIndefinitePeriod.Location = new System.Drawing.Point(479, 193);
            this.chkIndefinitePeriod.Name = "chkIndefinitePeriod";
            this.chkIndefinitePeriod.Size = new System.Drawing.Size(164, 17);
            this.chkIndefinitePeriod.TabIndex = 40;
            this.chkIndefinitePeriod.Text = "Umowa na czas nieokreśolny";
            this.chkIndefinitePeriod.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(478, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Okres rozliczeniowy";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(453, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "do:";
            // 
            // gridExPositions
            // 
            this.gridExPositions.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExPositions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExPositions.ColumnAutoResize = true;
            this.gridExPositions.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExPositions_DesignTimeLayout.LayoutString = resources.GetString("gridExPositions_DesignTimeLayout.LayoutString");
            this.gridExPositions.DesignTimeLayout = gridExPositions_DesignTimeLayout;
            this.gridExPositions.DynamicFiltering = true;
            this.gridExPositions.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExPositions.GroupByBoxVisible = false;
            this.gridExPositions.Location = new System.Drawing.Point(3, 3);
            this.gridExPositions.Name = "gridExPositions";
            this.gridExPositions.Size = new System.Drawing.Size(257, 231);
            this.gridExPositions.TabIndex = 2;
            this.gridExPositions.SelectionChanged += new System.EventHandler(this.gridExPositions_SelectionChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(266, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Model rozliczenia";
            // 
            // txtKTM
            // 
            this.txtKTM.Location = new System.Drawing.Point(269, 57);
            this.txtKTM.Name = "txtKTM";
            this.txtKTM.Size = new System.Drawing.Size(162, 20);
            this.txtKTM.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(266, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Waluta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "KTM";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(266, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Deskryptor";
            // 
            // txtDescriptor
            // 
            this.txtDescriptor.Location = new System.Drawing.Point(269, 96);
            this.txtDescriptor.Name = "txtDescriptor";
            this.txtDescriptor.Size = new System.Drawing.Size(162, 20);
            this.txtDescriptor.TabIndex = 24;
            // 
            // tabPageLicensors
            // 
            this.tabPageLicensors.Location = new System.Drawing.Point(4, 22);
            this.tabPageLicensors.Name = "tabPageLicensors";
            this.tabPageLicensors.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLicensors.Size = new System.Drawing.Size(650, 244);
            this.tabPageLicensors.TabIndex = 2;
            this.tabPageLicensors.Text = "Licencjodawcy";
            this.tabPageLicensors.UseVisualStyleBackColor = true;
            // 
            // tabPageSchedule
            // 
            this.tabPageSchedule.Location = new System.Drawing.Point(4, 22);
            this.tabPageSchedule.Name = "tabPageSchedule";
            this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSchedule.Size = new System.Drawing.Size(650, 244);
            this.tabPageSchedule.TabIndex = 3;
            this.tabPageSchedule.Text = "Harmonogram";
            this.tabPageSchedule.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(494, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Data zaliczki";
            // 
            // cboCurrency
            // 
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Location = new System.Drawing.Point(269, 135);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(162, 21);
            this.cboCurrency.TabIndex = 49;
            // 
            // cboSettlementModel
            // 
            this.cboSettlementModel.FormattingEnabled = true;
            this.cboSettlementModel.Location = new System.Drawing.Point(269, 18);
            this.cboSettlementModel.Name = "cboSettlementModel";
            this.cboSettlementModel.Size = new System.Drawing.Size(374, 21);
            this.cboSettlementModel.TabIndex = 50;
            // 
            // billingPeriodBindingSource
            // 
            this.billingPeriodBindingSource.DataSource = typeof(BLL.Entities.BillingPeriod);
            // 
            // FrmAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 507);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtAdvanceDate);
            this.Controls.Add(this.numAdvance);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReportAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAgreement);
            this.Controls.Add(this.txtReportTitle);
            this.Controls.Add(this.label1);
            this.Name = "FrmAgreement";
            this.Text = "Umowa";
            ((System.ComponentModel.ISupportInitialize)(this.numAdvance)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPositions.ResumeLayout(false);
            this.tabPositions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFreeCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExPositions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingPeriodBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReportTitle;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReportAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtComments;
        private System.Windows.Forms.NumericUpDown numAdvance;
        private System.Windows.Forms.DateTimePicker dtAdvanceDate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPositions;
        private System.Windows.Forms.TabPage tabPageLicensors;
        private System.Windows.Forms.TabPage tabPageSchedule;
        private Janus.Windows.GridEX.GridEX gridExPositions;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDescriptor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKTM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtAgreementExpiration;
        private System.Windows.Forms.DateTimePicker dtBillingPeriodTo;
        private System.Windows.Forms.DateTimePicker dtBillingPeriodFrom;
        private System.Windows.Forms.CheckBox chkFirstSale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkIndefinitePeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboBillingPeriod;
        private System.Windows.Forms.NumericUpDown numFreeCopies;
        private System.Windows.Forms.BindingSource billingPeriodBindingSource;
        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.ComboBox cboSettlementModel;
    }
}