namespace Foksal.Forms.Agreements
{
    partial class agrList_TEST
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
            Janus.Windows.GridEX.GridEXLayout gridExAgreementsList_TEST_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agrList_TEST));
            this.gridExAgreementsList_TEST = new Janus.Windows.GridEX.GridEX();
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsList_TEST)).BeginInit();
            this.SuspendLayout();
            // 
            // gridExAgreementsList_TEST
            // 
            this.gridExAgreementsList_TEST.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.gridExAgreementsList_TEST.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExAgreementsList_TEST.ColumnAutoResize = true;
            this.gridExAgreementsList_TEST.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExAgreementsList_TEST_DesignTimeLayout.LayoutString = resources.GetString("gridExAgreementsList_TEST_DesignTimeLayout.LayoutString");
            this.gridExAgreementsList_TEST.DesignTimeLayout = gridExAgreementsList_TEST_DesignTimeLayout;
            this.gridExAgreementsList_TEST.DynamicFiltering = true;
            this.gridExAgreementsList_TEST.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridExAgreementsList_TEST.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExAgreementsList_TEST.Location = new System.Drawing.Point(12, 12);
            this.gridExAgreementsList_TEST.Name = "gridExAgreementsList_TEST";
            this.gridExAgreementsList_TEST.Size = new System.Drawing.Size(776, 426);
            this.gridExAgreementsList_TEST.TabIndex = 1;
            // 
            // agrList_TEST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridExAgreementsList_TEST);
            this.Name = "agrList_TEST";
            this.Text = "agrList_TEST";
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsList_TEST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExAgreementsList_TEST;
    }
}