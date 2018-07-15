namespace Foksal.Forms.Reports
{
    partial class FrmReportFlexible
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
            Janus.Windows.GridEX.GridEXLayout gridExReport_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportFlexible));
            this.gridExReport = new Janus.Windows.GridEX.GridEX();
            this.btnExportToExcel = new System.Windows.Forms.Button();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridExReport)).BeginInit();
            this.SuspendLayout();
            // 
            // gridExReport
            // 
            this.gridExReport.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExReport.ColumnAutoResize = true;
            this.gridExReport.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExReport_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /></RootTable></GridEXLayoutData>";
            this.gridExReport.DesignTimeLayout = gridExReport_DesignTimeLayout;
            this.gridExReport.DynamicFiltering = true;
            this.gridExReport.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridExReport.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExReport.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExReport.GroupByBoxVisible = false;
            this.gridExReport.Location = new System.Drawing.Point(12, 59);
            this.gridExReport.Name = "gridExReport";
            this.gridExReport.Size = new System.Drawing.Size(1230, 543);
            this.gridExReport.TabIndex = 1;
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportToExcel.ImageKey = "icon-excel.png";
            this.btnExportToExcel.ImageList = this.imgLstIcons;
            this.btnExportToExcel.Location = new System.Drawing.Point(1144, 12);
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(98, 41);
            this.btnExportToExcel.TabIndex = 61;
            this.btnExportToExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.btnExportToExcel, "Eksportuj do Excela");
            this.btnExportToExcel.UseVisualStyleBackColor = true;
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "icon-excel.png");
            // 
            // FrmReportFlexible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 614);
            this.Controls.Add(this.btnExportToExcel);
            this.Controls.Add(this.gridExReport);
            this.Name = "FrmReportFlexible";
            this.Text = "Raport";
            ((System.ComponentModel.ISupportInitialize)(this.gridExReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExReport;
        private System.Windows.Forms.Button btnExportToExcel;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.ToolTip toolTip;
    }
}