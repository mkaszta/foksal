namespace Foksal.Forms.Agreements
{
    partial class FrmSettlements
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
            Janus.Windows.GridEX.GridEXLayout gridExSettlementsList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSettlements));
            Janus.Windows.GridEX.GridEXLayout gridExSettlementsDetails_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.gridExSettlementsList = new Janus.Windows.GridEX.GridEX();
            this.gridExSettlementsDetails = new Janus.Windows.GridEX.GridEX();
            this.btnReportSettlement = new System.Windows.Forms.Button();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRecalculate = new System.Windows.Forms.Button();
            this.btnReportSettlementDetails = new System.Windows.Forms.Button();
            this.btnReportShort = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridExSettlementsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExSettlementsDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridExSettlementsList
            // 
            this.gridExSettlementsList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExSettlementsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExSettlementsList.ColumnAutoResize = true;
            this.gridExSettlementsList.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExSettlementsList_DesignTimeLayout.LayoutString = resources.GetString("gridExSettlementsList_DesignTimeLayout.LayoutString");
            this.gridExSettlementsList.DesignTimeLayout = gridExSettlementsList_DesignTimeLayout;
            this.gridExSettlementsList.DynamicFiltering = true;
            this.gridExSettlementsList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridExSettlementsList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExSettlementsList.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExSettlementsList.GroupByBoxVisible = false;
            this.gridExSettlementsList.Location = new System.Drawing.Point(12, 75);
            this.gridExSettlementsList.Name = "gridExSettlementsList";
            this.gridExSettlementsList.Size = new System.Drawing.Size(1274, 184);
            this.gridExSettlementsList.TabIndex = 1;
            this.gridExSettlementsList.RowCheckStateChanged += new Janus.Windows.GridEX.RowCheckStateChangeEventHandler(this.gridExSettlementsList_RowCheckStateChanged);
            this.gridExSettlementsList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridExSettlementsList_RowDoubleClick);
            // 
            // gridExSettlementsDetails
            // 
            this.gridExSettlementsDetails.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExSettlementsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExSettlementsDetails.AutomaticSort = false;
            this.gridExSettlementsDetails.ColumnAutoResize = true;
            this.gridExSettlementsDetails.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExSettlementsDetails_DesignTimeLayout.LayoutString = resources.GetString("gridExSettlementsDetails_DesignTimeLayout.LayoutString");
            this.gridExSettlementsDetails.DesignTimeLayout = gridExSettlementsDetails_DesignTimeLayout;
            this.gridExSettlementsDetails.DynamicFiltering = true;
            this.gridExSettlementsDetails.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExSettlementsDetails.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExSettlementsDetails.GroupByBoxVisible = false;
            this.gridExSettlementsDetails.GroupRowFormatStyle.BackColor = System.Drawing.Color.Empty;
            this.gridExSettlementsDetails.GroupTotalRowFormatStyle.BackColor = System.Drawing.Color.Cyan;
            this.gridExSettlementsDetails.Location = new System.Drawing.Point(12, 265);
            this.gridExSettlementsDetails.Name = "gridExSettlementsDetails";
            this.gridExSettlementsDetails.Size = new System.Drawing.Size(1274, 278);
            this.gridExSettlementsDetails.TabIndex = 2;
            this.gridExSettlementsDetails.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            // 
            // btnReportSettlement
            // 
            this.btnReportSettlement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportSettlement.Enabled = false;
            this.btnReportSettlement.ImageKey = "icon-excel.png";
            this.btnReportSettlement.ImageList = this.imgLstIcons;
            this.btnReportSettlement.Location = new System.Drawing.Point(1292, 75);
            this.btnReportSettlement.Name = "btnReportSettlement";
            this.btnReportSettlement.Size = new System.Drawing.Size(51, 41);
            this.btnReportSettlement.TabIndex = 62;
            this.btnReportSettlement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnReportSettlement, "Generuj raport");
            this.btnReportSettlement.UseVisualStyleBackColor = true;
            this.btnReportSettlement.Click += new System.EventHandler(this.btnReportSettlementDetails_Click);
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "icon-excel.png");
            this.imgLstIcons.Images.SetKeyName(1, "icon-edit.png");
            this.imgLstIcons.Images.SetKeyName(2, "icon-refresh.png");
            this.imgLstIcons.Images.SetKeyName(3, "icon-pdf.png");
            this.imgLstIcons.Images.SetKeyName(4, "icon-mail.png");
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.ImageKey = "icon-edit.png";
            this.btnEdit.ImageList = this.imgLstIcons;
            this.btnEdit.Location = new System.Drawing.Point(1178, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(51, 41);
            this.btnEdit.TabIndex = 72;
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnEdit, "Edytuj rozliczenie");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRecalculate
            // 
            this.btnRecalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecalculate.ImageKey = "icon-refresh.png";
            this.btnRecalculate.ImageList = this.imgLstIcons;
            this.btnRecalculate.Location = new System.Drawing.Point(1235, 28);
            this.btnRecalculate.Name = "btnRecalculate";
            this.btnRecalculate.Size = new System.Drawing.Size(51, 41);
            this.btnRecalculate.TabIndex = 73;
            this.btnRecalculate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnRecalculate, "Przelicz");
            this.btnRecalculate.UseVisualStyleBackColor = true;
            this.btnRecalculate.Click += new System.EventHandler(this.btnRecalculate_Click);
            // 
            // btnReportSettlementDetails
            // 
            this.btnReportSettlementDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportSettlementDetails.Enabled = false;
            this.btnReportSettlementDetails.ImageKey = "icon-excel.png";
            this.btnReportSettlementDetails.ImageList = this.imgLstIcons;
            this.btnReportSettlementDetails.Location = new System.Drawing.Point(1292, 265);
            this.btnReportSettlementDetails.Name = "btnReportSettlementDetails";
            this.btnReportSettlementDetails.Size = new System.Drawing.Size(51, 41);
            this.btnReportSettlementDetails.TabIndex = 76;
            this.btnReportSettlementDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnReportSettlementDetails, "Generuj raport");
            this.btnReportSettlementDetails.UseVisualStyleBackColor = true;
            // 
            // btnReportShort
            // 
            this.btnReportShort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportShort.Enabled = false;
            this.btnReportShort.ImageKey = "icon-pdf.png";
            this.btnReportShort.ImageList = this.imgLstIcons;
            this.btnReportShort.Location = new System.Drawing.Point(1292, 312);
            this.btnReportShort.Name = "btnReportShort";
            this.btnReportShort.Size = new System.Drawing.Size(51, 41);
            this.btnReportShort.TabIndex = 77;
            this.btnReportShort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnReportShort, "Generuj raport");
            this.btnReportShort.UseVisualStyleBackColor = true;
            this.btnReportShort.Click += new System.EventHandler(this.btnReportShort_Click);
            // 
            // btnMail
            // 
            this.btnMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMail.Enabled = false;
            this.btnMail.ImageKey = "icon-mail.png";
            this.btnMail.ImageList = this.imgLstIcons;
            this.btnMail.Location = new System.Drawing.Point(1292, 359);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(51, 41);
            this.btnMail.TabIndex = 78;
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnMail, "Generuj raport");
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "od:";
            // 
            // dtTo
            // 
            this.dtTo.Checked = false;
            this.dtTo.CustomFormat = "MMMM yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(122, 32);
            this.dtTo.Name = "dtTo";
            this.dtTo.ShowCheckBox = true;
            this.dtTo.Size = new System.Drawing.Size(108, 20);
            this.dtTo.TabIndex = 66;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "od:";
            // 
            // dtFrom
            // 
            this.dtFrom.Checked = false;
            this.dtFrom.CustomFormat = "MMMM yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(8, 32);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.ShowCheckBox = true;
            this.dtFrom.Size = new System.Drawing.Size(108, 20);
            this.dtFrom.TabIndex = 64;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtTo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 57);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Okres";
            // 
            // FrmSettlements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 555);
            this.Controls.Add(this.btnMail);
            this.Controls.Add(this.btnReportShort);
            this.Controls.Add(this.btnReportSettlementDetails);
            this.Controls.Add(this.btnRecalculate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReportSettlement);
            this.Controls.Add(this.gridExSettlementsDetails);
            this.Controls.Add(this.gridExSettlementsList);
            this.Name = "FrmSettlements";
            this.Text = "Rozliczenia";
            ((System.ComponentModel.ISupportInitialize)(this.gridExSettlementsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExSettlementsDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExSettlementsList;
        private Janus.Windows.GridEX.GridEX gridExSettlementsDetails;
        private System.Windows.Forms.Button btnReportSettlement;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRecalculate;
        private System.Windows.Forms.Button btnReportSettlementDetails;
        private System.Windows.Forms.Button btnReportShort;
        private System.Windows.Forms.Button btnMail;
    }
}