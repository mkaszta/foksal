﻿namespace Foksal.Forms.Agreements
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
            this.btnBindArticle = new System.Windows.Forms.Button();
            this.btnBindProduct = new System.Windows.Forms.Button();
            this.btnBindNewPosition = new System.Windows.Forms.Button();
            this.btnBindKTM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridExProductsAndArticles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsListGrouped)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridExProductsAndArticles
            // 
            this.gridExProductsAndArticles.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExProductsAndArticles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.gridExProductsAndArticles.Location = new System.Drawing.Point(12, 12);
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
            this.gridExAgreementsListGrouped.Location = new System.Drawing.Point(12, 347);
            this.gridExAgreementsListGrouped.Name = "gridExAgreementsListGrouped";
            this.gridExAgreementsListGrouped.Size = new System.Drawing.Size(1150, 302);
            this.gridExAgreementsListGrouped.TabIndex = 2;
            this.gridExAgreementsListGrouped.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridExAgreementsListGrouped_RowDoubleClick);
            this.gridExAgreementsListGrouped.DoubleClick += new System.EventHandler(this.gridExAgreementsListGrouped_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbAll);
            this.groupBox1.Controls.Add(this.rdbDescriptor);
            this.groupBox1.Controls.Add(this.rdbKTM);
            this.groupBox1.Location = new System.Drawing.Point(12, 296);
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
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBindArticle);
            this.groupBox2.Controls.Add(this.btnBindProduct);
            this.groupBox2.Controls.Add(this.btnBindNewPosition);
            this.groupBox2.Controls.Add(this.btnBindKTM);
            this.groupBox2.Location = new System.Drawing.Point(675, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 45);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Przypisz do umowy";
            // 
            // btnBindArticle
            // 
            this.btnBindArticle.Location = new System.Drawing.Point(366, 16);
            this.btnBindArticle.Name = "btnBindArticle";
            this.btnBindArticle.Size = new System.Drawing.Size(114, 23);
            this.btnBindArticle.TabIndex = 3;
            this.btnBindArticle.Text = "Towar powiązany";
            this.btnBindArticle.UseVisualStyleBackColor = true;
            this.btnBindArticle.Click += new System.EventHandler(this.btnBindArticle_Click);
            // 
            // btnBindProduct
            // 
            this.btnBindProduct.Location = new System.Drawing.Point(246, 16);
            this.btnBindProduct.Name = "btnBindProduct";
            this.btnBindProduct.Size = new System.Drawing.Size(114, 23);
            this.btnBindProduct.TabIndex = 2;
            this.btnBindProduct.Text = "Produkt powiązany";
            this.btnBindProduct.UseVisualStyleBackColor = true;
            this.btnBindProduct.Click += new System.EventHandler(this.btnBindProduct_Click);
            // 
            // btnBindNewPosition
            // 
            this.btnBindNewPosition.Location = new System.Drawing.Point(126, 16);
            this.btnBindNewPosition.Name = "btnBindNewPosition";
            this.btnBindNewPosition.Size = new System.Drawing.Size(114, 23);
            this.btnBindNewPosition.TabIndex = 1;
            this.btnBindNewPosition.Text = "Nowa pozycja";
            this.btnBindNewPosition.UseVisualStyleBackColor = true;
            this.btnBindNewPosition.Click += new System.EventHandler(this.btnBindNewPosition_Click);
            // 
            // btnBindKTM
            // 
            this.btnBindKTM.Location = new System.Drawing.Point(6, 16);
            this.btnBindKTM.Name = "btnBindKTM";
            this.btnBindKTM.Size = new System.Drawing.Size(114, 23);
            this.btnBindKTM.TabIndex = 0;
            this.btnBindKTM.Text = "Dopisz KTM";
            this.btnBindKTM.UseVisualStyleBackColor = true;
            this.btnBindKTM.Click += new System.EventHandler(this.btnBindKTM_Click);
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
        private System.Windows.Forms.Button btnBindNewPosition;
        private System.Windows.Forms.Button btnBindKTM;
        private System.Windows.Forms.Button btnBindArticle;
        private System.Windows.Forms.Button btnBindProduct;
    }
}