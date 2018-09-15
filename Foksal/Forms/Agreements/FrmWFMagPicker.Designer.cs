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
            ((System.ComponentModel.ISupportInitialize)(this.gridExWFMagPicker)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridExWFMagPicker
            // 
            this.gridExWFMagPicker.ColumnAutoResize = true;
            this.gridExWFMagPicker.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
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
            this.gridExWFMagPicker.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridExWFMagPicker_RowDoubleClick);
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
            // FrmWFMagPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 401);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gridExWFMagPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWFMagPicker";
            this.Text = "Wybierz produkt WFMAG";
            ((System.ComponentModel.ISupportInitialize)(this.gridExWFMagPicker)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExWFMagPicker;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbUnrelated;
        private System.Windows.Forms.RadioButton rdbRelated;
    }
}