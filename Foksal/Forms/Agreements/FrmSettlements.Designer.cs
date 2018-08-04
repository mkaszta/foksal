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
            this.gridExSettlementsList.Location = new System.Drawing.Point(12, 12);
            this.gridExSettlementsList.Name = "gridExSettlementsList";
            this.gridExSettlementsList.Size = new System.Drawing.Size(1130, 205);
            this.gridExSettlementsList.TabIndex = 1;
            this.gridExSettlementsList.RowCheckStateChanged += new Janus.Windows.GridEX.RowCheckStateChangeEventHandler(this.gridExSettlementsList_RowCheckStateChanged);
            // 
            // gridExSettlementsDetails
            // 
            this.gridExSettlementsDetails.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExSettlementsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gridExSettlementsDetails.Location = new System.Drawing.Point(12, 223);
            this.gridExSettlementsDetails.Name = "gridExSettlementsDetails";
            this.gridExSettlementsDetails.Size = new System.Drawing.Size(1130, 320);
            this.gridExSettlementsDetails.TabIndex = 2;
            this.gridExSettlementsDetails.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.ImageKey = "icon-excel.png";
            this.btnExportToExcel.ImageList = this.imgLstIcons;
            this.btnExportToExcel.Location = new System.Drawing.Point(1148, 223);
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
            // FrmSettlements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 555);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.gridExSettlementsDetails);
            this.Controls.Add(this.gridExSettlementsList);
            this.Name = "FrmSettlements";
            this.Text = "Rozliczenia";
            ((System.ComponentModel.ISupportInitialize)(this.gridExSettlementsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExSettlementsDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExSettlementsList;
        private Janus.Windows.GridEX.GridEX gridExSettlementsDetails;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.ToolTip toolTip;
    }
}