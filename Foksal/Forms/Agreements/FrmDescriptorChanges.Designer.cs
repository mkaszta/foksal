namespace Foksal.Forms.Agreements
{
    partial class FrmDescriptorChanges
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
            Janus.Windows.GridEX.GridEXLayout gridExDescriptorChanges_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDescriptorChanges));
            Janus.Windows.GridEX.GridEXLayout gridExAgreementsListGrouped_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.gridExDescriptorChanges = new Janus.Windows.GridEX.GridEX();
            this.gridExAgreementsListGrouped = new Janus.Windows.GridEX.GridEX();
            this.btnChange = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridExDescriptorChanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsListGrouped)).BeginInit();
            this.SuspendLayout();
            // 
            // gridExDescriptorChanges
            // 
            this.gridExDescriptorChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExDescriptorChanges.ColumnAutoResize = true;
            this.gridExDescriptorChanges.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExDescriptorChanges_DesignTimeLayout.LayoutString = resources.GetString("gridExDescriptorChanges_DesignTimeLayout.LayoutString");
            this.gridExDescriptorChanges.DesignTimeLayout = gridExDescriptorChanges_DesignTimeLayout;
            this.gridExDescriptorChanges.DynamicFiltering = true;
            this.gridExDescriptorChanges.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridExDescriptorChanges.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExDescriptorChanges.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExDescriptorChanges.GroupByBoxVisible = false;
            this.gridExDescriptorChanges.Location = new System.Drawing.Point(12, 12);
            this.gridExDescriptorChanges.Name = "gridExDescriptorChanges";
            this.gridExDescriptorChanges.NewRowFormatStyle.BackColor = System.Drawing.Color.Honeydew;
            this.gridExDescriptorChanges.NewRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.gridExDescriptorChanges.NewRowFormatStyle.ForeColor = System.Drawing.Color.White;
            this.gridExDescriptorChanges.Size = new System.Drawing.Size(931, 224);
            this.gridExDescriptorChanges.TabIndex = 36;
            this.gridExDescriptorChanges.SelectionChanged += new System.EventHandler(this.gridExDescriptorChanges_SelectionChanged);
            // 
            // gridExAgreementsListGrouped
            // 
            this.gridExAgreementsListGrouped.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExAgreementsListGrouped.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExAgreementsListGrouped.ColumnAutoResize = true;
            this.gridExAgreementsListGrouped.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExAgreementsListGrouped_DesignTimeLayout.LayoutString = resources.GetString("gridExAgreementsListGrouped_DesignTimeLayout.LayoutString");
            this.gridExAgreementsListGrouped.DesignTimeLayout = gridExAgreementsListGrouped_DesignTimeLayout;
            this.gridExAgreementsListGrouped.DynamicFiltering = true;
            this.gridExAgreementsListGrouped.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridExAgreementsListGrouped.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExAgreementsListGrouped.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExAgreementsListGrouped.GroupByBoxVisible = false;
            this.gridExAgreementsListGrouped.GroupExpandBoxStyle = Janus.Windows.GridEX.ExpandBoxStyle.Arrows;
            this.gridExAgreementsListGrouped.Location = new System.Drawing.Point(12, 271);
            this.gridExAgreementsListGrouped.Name = "gridExAgreementsListGrouped";
            this.gridExAgreementsListGrouped.Size = new System.Drawing.Size(931, 325);
            this.gridExAgreementsListGrouped.TabIndex = 37;
            this.gridExAgreementsListGrouped.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridExAgreementsListGrouped_RowDoubleClick);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.Location = new System.Drawing.Point(12, 242);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(931, 23);
            this.btnChange.TabIndex = 38;
            this.btnChange.Text = "Zastosuj zmianę dla zaznaczonych";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // FrmDescriptorChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 608);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.gridExAgreementsListGrouped);
            this.Controls.Add(this.gridExDescriptorChanges);
            this.Name = "FrmDescriptorChanges";
            this.Text = "Lista zmian deskryptora";
            ((System.ComponentModel.ISupportInitialize)(this.gridExDescriptorChanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsListGrouped)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExDescriptorChanges;
        private Janus.Windows.GridEX.GridEX gridExAgreementsListGrouped;
        private System.Windows.Forms.Button btnChange;
    }
}