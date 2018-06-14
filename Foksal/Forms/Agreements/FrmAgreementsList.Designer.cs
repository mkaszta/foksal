namespace Foksal.Forms.Agreements
{
    partial class FrmAgreementsList
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
            Janus.Windows.GridEX.GridEXLayout gridExAgreementsList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgreementsList));
            this.gridExAgreementsList = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsList)).BeginInit();
            this.SuspendLayout();
            // 
            // gridExAgreementsList
            // 
            this.gridExAgreementsList.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExAgreementsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExAgreementsList.ColumnAutoResize = true;
            this.gridExAgreementsList.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExAgreementsList_DesignTimeLayout.LayoutString = resources.GetString("gridExAgreementsList_DesignTimeLayout.LayoutString");
            this.gridExAgreementsList.DesignTimeLayout = gridExAgreementsList_DesignTimeLayout;
            this.gridExAgreementsList.DynamicFiltering = true;
            this.gridExAgreementsList.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridExAgreementsList.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExAgreementsList.GroupByBoxVisible = false;
            this.gridExAgreementsList.Location = new System.Drawing.Point(12, 12);
            this.gridExAgreementsList.Name = "gridExAgreementsList";
            this.gridExAgreementsList.Size = new System.Drawing.Size(776, 426);
            this.gridExAgreementsList.TabIndex = 0;
            // 
            // FrmAgreementsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridExAgreementsList);
            this.Name = "FrmAgreementsList";
            this.Text = "Umowy";
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExAgreementsList;
    }
}