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
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridExSettlementsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExSettlementsDetails)).BeginInit();
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
            this.gridExSettlementsList.Size = new System.Drawing.Size(1156, 184);
            this.gridExSettlementsList.TabIndex = 1;
            this.gridExSettlementsList.RowCheckStateChanged += new Janus.Windows.GridEX.RowCheckStateChangeEventHandler(this.gridExSettlementsList_RowCheckStateChanged);
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
            this.gridExSettlementsDetails.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridExSettlementsDetails.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExSettlementsDetails.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExSettlementsDetails.GroupByBoxVisible = false;
            this.gridExSettlementsDetails.GroupRowFormatStyle.BackColor = System.Drawing.Color.Empty;
            this.gridExSettlementsDetails.GroupTotalRowFormatStyle.BackColor = System.Drawing.Color.Cyan;
            this.gridExSettlementsDetails.Location = new System.Drawing.Point(12, 265);
            this.gridExSettlementsDetails.Name = "gridExSettlementsDetails";
            this.gridExSettlementsDetails.Size = new System.Drawing.Size(1156, 278);
            this.gridExSettlementsDetails.TabIndex = 2;
            this.gridExSettlementsDetails.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.ImageKey = "icon-excel.png";
            this.btnExportToExcel.ImageList = this.imgLstIcons;
            this.btnExportToExcel.Location = new System.Drawing.Point(1261, 223);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(82, 41);
            this.btnExportToExcel.TabIndex = 62;
            this.btnExportToExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "icon-excel.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1261, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 63;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(969, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 67;
            this.label4.Text = "od:";
            // 
            // dtTo
            // 
            this.dtTo.CustomFormat = "MMMM yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtTo.Location = new System.Drawing.Point(997, 50);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(145, 20);
            this.dtTo.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(969, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "od:";
            // 
            // dtFrom
            // 
            this.dtFrom.CustomFormat = "MMMM yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFrom.Location = new System.Drawing.Point(997, 24);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(145, 20);
            this.dtFrom.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1205, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Umowa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1213, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Okres:";
            // 
            // FrmSettlements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 555);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.gridExSettlementsDetails);
            this.Controls.Add(this.gridExSettlementsList);
            this.Name = "FrmSettlements";
            this.Text = "Rozliczenia";
            ((System.ComponentModel.ISupportInitialize)(this.gridExSettlementsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExSettlementsDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExSettlementsList;
        private Janus.Windows.GridEX.GridEX gridExSettlementsDetails;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}