namespace Foksal.Forms.Agreements
{
    partial class FrmProductsAndArticles
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
            Janus.Windows.GridEX.GridEXLayout gridExProductsAndArticles_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductsAndArticles));
            Janus.Windows.GridEX.GridEXLayout gridExAgreementsListGrouped_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.gridExProductsAndArticles = new Janus.Windows.GridEX.GridEX();
            this.gridExAgreementsListGrouped = new Janus.Windows.GridEX.GridEX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbDescriptor = new System.Windows.Forms.RadioButton();
            this.rdbKTM = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridExProductsAndArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsListGrouped)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridExProductsAndArticles
            // 
            this.gridExProductsAndArticles.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExProductsAndArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExProductsAndArticles.ColumnAutoResize = true;
            this.gridExProductsAndArticles.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExProductsAndArticles_DesignTimeLayout.LayoutString = resources.GetString("gridExProductsAndArticles_DesignTimeLayout.LayoutString");
            this.gridExProductsAndArticles.DesignTimeLayout = gridExProductsAndArticles_DesignTimeLayout;
            this.gridExProductsAndArticles.DynamicFiltering = true;
            this.gridExProductsAndArticles.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridExProductsAndArticles.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExProductsAndArticles.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExProductsAndArticles.GroupByBoxVisible = false;
            this.gridExProductsAndArticles.Location = new System.Drawing.Point(12, 32);
            this.gridExProductsAndArticles.Name = "gridExProductsAndArticles";
            this.gridExProductsAndArticles.Size = new System.Drawing.Size(1150, 278);
            this.gridExProductsAndArticles.TabIndex = 1;
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
            this.gridExAgreementsListGrouped.GroupExpandBoxStyle = Janus.Windows.GridEX.ExpandBoxStyle.Arrows;
            this.gridExAgreementsListGrouped.Location = new System.Drawing.Point(12, 367);
            this.gridExAgreementsListGrouped.Name = "gridExAgreementsListGrouped";
            this.gridExAgreementsListGrouped.Size = new System.Drawing.Size(1150, 282);
            this.gridExAgreementsListGrouped.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAll);
            this.groupBox1.Controls.Add(this.rdbDescriptor);
            this.groupBox1.Controls.Add(this.rdbKTM);
            this.groupBox1.Location = new System.Drawing.Point(12, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtruj umowy";
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Checked = true;
            this.rdbAll.Location = new System.Drawing.Point(145, 19);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(73, 17);
            this.rdbAll.TabIndex = 7;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Wszystkie";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rdbDescriptor
            // 
            this.rdbDescriptor.AutoSize = true;
            this.rdbDescriptor.Location = new System.Drawing.Point(63, 19);
            this.rdbDescriptor.Name = "rdbDescriptor";
            this.rdbDescriptor.Size = new System.Drawing.Size(76, 17);
            this.rdbDescriptor.TabIndex = 6;
            this.rdbDescriptor.Text = "Deskryptor";
            this.rdbDescriptor.UseVisualStyleBackColor = true;
            this.rdbDescriptor.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // rdbKTM
            // 
            this.rdbKTM.AutoSize = true;
            this.rdbKTM.Location = new System.Drawing.Point(6, 19);
            this.rdbKTM.Name = "rdbKTM";
            this.rdbKTM.Size = new System.Drawing.Size(48, 17);
            this.rdbKTM.TabIndex = 5;
            this.rdbKTM.Text = "KTM";
            this.rdbKTM.UseVisualStyleBackColor = true;
            this.rdbKTM.CheckedChanged += new System.EventHandler(this.radioButtons_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(675, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 45);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Przypisz jako";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pozycja umowy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Towar powiązany";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(366, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Towar powiązany";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 16);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Pozycja umowy";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // FrmProductsAndArticles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridExAgreementsListGrouped);
            this.Controls.Add(this.gridExProductsAndArticles);
            this.Name = "FrmProductsAndArticles";
            this.Text = "Lista produktów i towarów niepowiązanych";
            ((System.ComponentModel.ISupportInitialize)(this.gridExProductsAndArticles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsListGrouped)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExProductsAndArticles;
        private Janus.Windows.GridEX.GridEX gridExAgreementsListGrouped;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbDescriptor;
        private System.Windows.Forms.RadioButton rdbKTM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}