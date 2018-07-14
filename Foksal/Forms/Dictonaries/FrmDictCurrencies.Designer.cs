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
            this.imgListIconsMin = new System.Windows.Forms.ImageList(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemoveCurrency = new System.Windows.Forms.Button();
            this.btnAddCurrency = new System.Windows.Forms.Button();
            this.btnRemoveRate = new System.Windows.Forms.Button();
            this.BtnAddRate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridExCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExCurrencyRates)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.gridExCurrencies.Location = new System.Drawing.Point(6, 55);
            this.gridExCurrencies.Name = "gridExCurrencies";
            this.gridExCurrencies.NewRowFormatStyle.BackColor = System.Drawing.Color.Honeydew;
            this.gridExCurrencies.NewRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.gridExCurrencies.NewRowFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.gridExCurrencies.Size = new System.Drawing.Size(72, 396);
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
            this.gridExCurrencyRates.Location = new System.Drawing.Point(6, 55);
            this.gridExCurrencyRates.Name = "gridExCurrencyRates";
            this.gridExCurrencyRates.NewRowFormatStyle.BackColor = System.Drawing.Color.Honeydew;
            this.gridExCurrencyRates.NewRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.gridExCurrencyRates.NewRowFormatStyle.ForeColor = System.Drawing.Color.White;
            this.gridExCurrencyRates.Size = new System.Drawing.Size(216, 396);
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
            this.btnGetNBPRate.ImageList = this.imgListIconsMin;
            this.btnGetNBPRate.Location = new System.Drawing.Point(192, 19);
            this.btnGetNBPRate.Name = "btnGetNBPRate";
            this.btnGetNBPRate.Size = new System.Drawing.Size(30, 30);
            this.btnGetNBPRate.TabIndex = 64;
            this.toolTip.SetToolTip(this.btnGetNBPRate, "Pobierz kursy NBP");
            this.btnGetNBPRate.UseVisualStyleBackColor = true;
            this.btnGetNBPRate.Click += new System.EventHandler(this.btnGetNBPRate_Click);
            // 
            // imgListIconsMin
            // 
            this.imgListIconsMin.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIconsMin.ImageStream")));
            this.imgListIconsMin.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListIconsMin.Images.SetKeyName(0, "icon-add.png");
            this.imgListIconsMin.Images.SetKeyName(1, "icon-delete.png");
            this.imgListIconsMin.Images.SetKeyName(2, "icon-download.png");
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icon-download.png");
            // 
            // btnRemoveCurrency
            // 
            this.btnRemoveCurrency.ImageKey = "icon-delete.png";
            this.btnRemoveCurrency.ImageList = this.imgListIconsMin;
            this.btnRemoveCurrency.Location = new System.Drawing.Point(49, 19);
            this.btnRemoveCurrency.Name = "btnRemoveCurrency";
            this.btnRemoveCurrency.Size = new System.Drawing.Size(30, 30);
            this.btnRemoveCurrency.TabIndex = 70;
            this.btnRemoveCurrency.UseVisualStyleBackColor = true;
            this.btnRemoveCurrency.Click += new System.EventHandler(this.btnRemoveCurrency_Click);
            // 
            // btnAddCurrency
            // 
            this.btnAddCurrency.ImageKey = "icon-add.png";
            this.btnAddCurrency.ImageList = this.imgListIconsMin;
            this.btnAddCurrency.Location = new System.Drawing.Point(6, 19);
            this.btnAddCurrency.Name = "btnAddCurrency";
            this.btnAddCurrency.Size = new System.Drawing.Size(30, 30);
            this.btnAddCurrency.TabIndex = 69;
            this.btnAddCurrency.UseVisualStyleBackColor = true;
            this.btnAddCurrency.Click += new System.EventHandler(this.btnAddCurrency_Click);
            // 
            // btnRemoveRate
            // 
            this.btnRemoveRate.ImageKey = "icon-delete.png";
            this.btnRemoveRate.ImageList = this.imgListIconsMin;
            this.btnRemoveRate.Location = new System.Drawing.Point(156, 19);
            this.btnRemoveRate.Name = "btnRemoveRate";
            this.btnRemoveRate.Size = new System.Drawing.Size(30, 30);
            this.btnRemoveRate.TabIndex = 72;
            this.btnRemoveRate.UseVisualStyleBackColor = true;
            this.btnRemoveRate.Click += new System.EventHandler(this.btnRemoveRate_Click);
            // 
            // BtnAddRate
            // 
            this.BtnAddRate.ImageKey = "icon-add.png";
            this.BtnAddRate.ImageList = this.imgListIconsMin;
            this.BtnAddRate.Location = new System.Drawing.Point(120, 19);
            this.BtnAddRate.Name = "BtnAddRate";
            this.BtnAddRate.Size = new System.Drawing.Size(30, 30);
            this.BtnAddRate.TabIndex = 71;
            this.BtnAddRate.UseVisualStyleBackColor = true;
            this.BtnAddRate.Click += new System.EventHandler(this.btnAddRate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridExCurrencies);
            this.groupBox1.Controls.Add(this.btnAddCurrency);
            this.groupBox1.Controls.Add(this.btnRemoveCurrency);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(85, 458);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Waluty";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridExCurrencyRates);
            this.groupBox2.Controls.Add(this.btnGetNBPRate);
            this.groupBox2.Controls.Add(this.btnRemoveRate);
            this.groupBox2.Controls.Add(this.BtnAddRate);
            this.groupBox2.Location = new System.Drawing.Point(103, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 458);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kursy";
            // 
            // FrmDictCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 478);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDictCurrencies";
            this.Text = "Waluty";
            ((System.ComponentModel.ISupportInitialize)(this.gridExCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExCurrencyRates)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExCurrencies;
        private Janus.Windows.GridEX.GridEX gridExCurrencyRates;
        private System.Windows.Forms.Button btnGetNBPRate;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnRemoveCurrency;
        private System.Windows.Forms.Button btnAddCurrency;
        private System.Windows.Forms.ImageList imgListIconsMin;
        private System.Windows.Forms.Button btnRemoveRate;
        private System.Windows.Forms.Button BtnAddRate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}