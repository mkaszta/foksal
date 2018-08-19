namespace Foksal.Forms.Agreements
{
    partial class FrmWFMagPicker
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
            Janus.Windows.GridEX.GridEXLayout gridExWFMagPicker_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWFMagPicker));
            this.gridExWFMagPicker = new Janus.Windows.GridEX.GridEX();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPick = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbUnrelated = new System.Windows.Forms.RadioButton();
            this.rdbRelated = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.grpDates = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridExWFMagPicker)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridExWFMagPicker
            // 
            this.gridExWFMagPicker.ColumnAutoResize = true;
            this.gridExWFMagPicker.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExWFMagPicker.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            gridExWFMagPicker_DesignTimeLayout.LayoutString = resources.GetString("gridExWFMagPicker_DesignTimeLayout.LayoutString");
            this.gridExWFMagPicker.DesignTimeLayout = gridExWFMagPicker_DesignTimeLayout;
            this.gridExWFMagPicker.DynamicFiltering = true;
            this.gridExWFMagPicker.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridExWFMagPicker.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExWFMagPicker.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExWFMagPicker.GroupByBoxVisible = false;
            this.gridExWFMagPicker.Location = new System.Drawing.Point(12, 50);
            this.gridExWFMagPicker.Name = "gridExWFMagPicker";
            this.gridExWFMagPicker.NewRowFormatStyle.BackColor = System.Drawing.Color.Honeydew;
            this.gridExWFMagPicker.NewRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.gridExWFMagPicker.NewRowFormatStyle.ForeColor = System.Drawing.Color.White;
            this.gridExWFMagPicker.Size = new System.Drawing.Size(746, 339);
            this.gridExWFMagPicker.TabIndex = 31;
            this.gridExWFMagPicker.DoubleClick += new System.EventHandler(this.gridExWFMagPicker_DoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(683, 14);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPick
            // 
            this.btnPick.Location = new System.Drawing.Point(602, 14);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(75, 23);
            this.btnPick.TabIndex = 33;
            this.btnPick.Text = "Użyj";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbUnrelated);
            this.groupBox1.Controls.Add(this.rdbRelated);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 43);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // rdbUnrelated
            // 
            this.rdbUnrelated.AutoSize = true;
            this.rdbUnrelated.Checked = true;
            this.rdbUnrelated.Location = new System.Drawing.Point(89, 14);
            this.rdbUnrelated.Name = "rdbUnrelated";
            this.rdbUnrelated.Size = new System.Drawing.Size(92, 17);
            this.rdbUnrelated.TabIndex = 36;
            this.rdbUnrelated.TabStop = true;
            this.rdbUnrelated.Text = "Niepowiązane";
            this.rdbUnrelated.UseVisualStyleBackColor = true;
            this.rdbUnrelated.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // rdbRelated
            // 
            this.rdbRelated.AutoSize = true;
            this.rdbRelated.Location = new System.Drawing.Point(6, 14);
            this.rdbRelated.Name = "rdbRelated";
            this.rdbRelated.Size = new System.Drawing.Size(77, 17);
            this.rdbRelated.TabIndex = 35;
            this.rdbRelated.Text = "Powiązane";
            this.rdbRelated.UseVisualStyleBackColor = true;
            this.rdbRelated.CheckedChanged += new System.EventHandler(this.rdb_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "do:";
            // 
            // dtFrom
            // 
            this.dtFrom.Checked = false;
            this.dtFrom.CustomFormat = "MMMM yyyy";
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(31, 14);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(94, 20);
            this.dtFrom.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "od:";
            // 
            // dtTo
            // 
            this.dtTo.Checked = false;
            this.dtTo.CustomFormat = "MMMM yyyy";
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(159, 14);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(94, 20);
            this.dtTo.TabIndex = 70;
            // 
            // grpDates
            // 
            this.grpDates.Controls.Add(this.btnFilter);
            this.grpDates.Controls.Add(this.dtTo);
            this.grpDates.Controls.Add(this.dtFrom);
            this.grpDates.Controls.Add(this.label4);
            this.grpDates.Controls.Add(this.label2);
            this.grpDates.Location = new System.Drawing.Point(211, 1);
            this.grpDates.Name = "grpDates";
            this.grpDates.Size = new System.Drawing.Size(357, 43);
            this.grpDates.TabIndex = 37;
            this.grpDates.TabStop = false;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(270, 14);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 20);
            this.btnFilter.TabIndex = 72;
            this.btnFilter.Text = "Filtruj";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // FrmWFMagPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 401);
            this.ControlBox = false;
            this.Controls.Add(this.grpDates);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gridExWFMagPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWFMagPicker";
            this.Text = "FrmWFMagPicker";
            ((System.ComponentModel.ISupportInitialize)(this.gridExWFMagPicker)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpDates.ResumeLayout(false);
            this.grpDates.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExWFMagPicker;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbUnrelated;
        private System.Windows.Forms.RadioButton rdbRelated;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.GroupBox grpDates;
        private System.Windows.Forms.Button btnFilter;
    }
}