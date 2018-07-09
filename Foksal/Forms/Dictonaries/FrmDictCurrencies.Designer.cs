namespace Foksal.Forms.Dictonaries
{
    partial class FrmDictCurrencies
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
            Janus.Windows.GridEX.GridEXLayout gridExCurrencies_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDictCurrencies));
            Janus.Windows.GridEX.GridEXLayout gridExCurrencyRates_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.gridExCurrencies = new Janus.Windows.GridEX.GridEX();
            this.gridExCurrencyRates = new Janus.Windows.GridEX.GridEX();
            this.btnGetNBPRate = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridExCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExCurrencyRates)).BeginInit();
            this.SuspendLayout();
            // 
            // gridExCurrencies
            // 
            this.gridExCurrencies.ColumnAutoResize = true;
            this.gridExCurrencies.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExCurrencies_DesignTimeLayout.LayoutString = resources.GetString("gridExCurrencies_DesignTimeLayout.LayoutString");
            this.gridExCurrencies.DesignTimeLayout = gridExCurrencies_DesignTimeLayout;
            this.gridExCurrencies.DynamicFiltering = true;
            this.gridExCurrencies.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExCurrencies.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExCurrencies.GroupByBoxVisible = false;
            this.gridExCurrencies.Location = new System.Drawing.Point(12, 12);
            this.gridExCurrencies.Name = "gridExCurrencies";
            this.gridExCurrencies.NewRowFormatStyle.BackColor = System.Drawing.Color.Honeydew;
            this.gridExCurrencies.NewRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.gridExCurrencies.NewRowFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.gridExCurrencies.Size = new System.Drawing.Size(72, 432);
            this.gridExCurrencies.TabIndex = 33;
            this.gridExCurrencies.DeletingRecord += new Janus.Windows.GridEX.RowActionCancelEventHandler(this.gridExCurrencies_DeletingRecord);
            this.gridExCurrencies.RecordsDeleted += new System.EventHandler(this.gridExCurrencies_RecordsDeleted);
            this.gridExCurrencies.RecordUpdated += new System.EventHandler(this.gridExCurrencies_RecordUpdated);
            this.gridExCurrencies.RecordAdded += new System.EventHandler(this.gridExCurrencies_RecordAdded);
            this.gridExCurrencies.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridExCurrencies_UpdatingRecord);
            this.gridExCurrencies.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridExCurrencies_AddingRecord);
            this.gridExCurrencies.SelectionChanged += new System.EventHandler(this.gridExCurrencies_SelectionChanged);
            // 
            // gridExCurrencyRates
            // 
            this.gridExCurrencyRates.ColumnAutoResize = true;
            this.gridExCurrencyRates.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExCurrencyRates_DesignTimeLayout.LayoutString = resources.GetString("gridExCurrencyRates_DesignTimeLayout.LayoutString");
            this.gridExCurrencyRates.DesignTimeLayout = gridExCurrencyRates_DesignTimeLayout;
            this.gridExCurrencyRates.DynamicFiltering = true;
            this.gridExCurrencyRates.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExCurrencyRates.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExCurrencyRates.GroupByBoxVisible = false;
            this.gridExCurrencyRates.Location = new System.Drawing.Point(90, 12);
            this.gridExCurrencyRates.Name = "gridExCurrencyRates";
            this.gridExCurrencyRates.NewRowFormatStyle.BackColor = System.Drawing.Color.Honeydew;
            this.gridExCurrencyRates.NewRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.gridExCurrencyRates.NewRowFormatStyle.ForeColor = System.Drawing.Color.White;
            this.gridExCurrencyRates.Size = new System.Drawing.Size(221, 432);
            this.gridExCurrencyRates.TabIndex = 34;
            this.gridExCurrencyRates.DeletingRecord += new Janus.Windows.GridEX.RowActionCancelEventHandler(this.gridExCurrencyRates_DeletingRecord);
            this.gridExCurrencyRates.RecordsDeleted += new System.EventHandler(this.gridExCurrencyRates_RecordsDeleted);
            this.gridExCurrencyRates.RecordUpdated += new System.EventHandler(this.gridExCurrencyRates_RecordUpdated);
            this.gridExCurrencyRates.RecordAdded += new System.EventHandler(this.gridExCurrencyRates_RecordAdded);
            this.gridExCurrencyRates.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.gridExCurrencyRates_UpdatingRecord);
            this.gridExCurrencyRates.AddingRecord += new System.ComponentModel.CancelEventHandler(this.gridExCurrencyRates_AddingRecord);
            // 
            // btnGetNBPRate
            // 
            this.btnGetNBPRate.ImageKey = "icon-download.png";
            this.btnGetNBPRate.ImageList = this.imageList;
            this.btnGetNBPRate.Location = new System.Drawing.Point(317, 12);
            this.btnGetNBPRate.Name = "btnGetNBPRate";
            this.btnGetNBPRate.Size = new System.Drawing.Size(41, 34);
            this.btnGetNBPRate.TabIndex = 64;
            this.toolTip.SetToolTip(this.btnGetNBPRate, "Pobierz kursy NBP");
            this.btnGetNBPRate.UseVisualStyleBackColor = true;
            this.btnGetNBPRate.Click += new System.EventHandler(this.btnGetNBPRate_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icon-download.png");
            // 
            // FrmDictCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 457);
            this.Controls.Add(this.btnGetNBPRate);
            this.Controls.Add(this.gridExCurrencyRates);
            this.Controls.Add(this.gridExCurrencies);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FrmDictCurrencies";
            this.Text = "Waluty";
            ((System.ComponentModel.ISupportInitialize)(this.gridExCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExCurrencyRates)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExCurrencies;
        private Janus.Windows.GridEX.GridEX gridExCurrencyRates;
        private System.Windows.Forms.Button btnGetNBPRate;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolTip toolTip;
    }
}