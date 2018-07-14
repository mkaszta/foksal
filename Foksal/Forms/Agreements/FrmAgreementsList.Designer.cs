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
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout gridExAgreementsList_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgreementsList));
            Janus.Windows.GridEX.GridEXLayout gridExAgreementsListGrouped_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.gridExAgreementsList = new Janus.Windows.GridEX.GridEX();
            this.btnAddAgreement = new System.Windows.Forms.Button();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnRemoveAgreement = new System.Windows.Forms.Button();
            this.btnSwitchGridMode = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.gridExAgreementsListGrouped = new Janus.Windows.GridEX.GridEX();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsListGrouped)).BeginInit();
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
            this.gridExAgreementsList.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExAgreementsList.GroupByBoxVisible = false;
            this.gridExAgreementsList.Location = new System.Drawing.Point(12, 61);
            this.gridExAgreementsList.Name = "gridExAgreementsList";
            this.gridExAgreementsList.Size = new System.Drawing.Size(937, 432);
            this.gridExAgreementsList.TabIndex = 0;
            this.gridExAgreementsList.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridExCurrentList_RowDoubleClick);
            // 
            // btnAddAgreement
            // 
            this.btnAddAgreement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAgreement.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAgreement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAgreement.ImageIndex = 0;
            this.btnAddAgreement.ImageList = this.imgLstIcons;
            this.btnAddAgreement.Location = new System.Drawing.Point(751, 12);
            this.btnAddAgreement.Name = "btnAddAgreement";
            this.btnAddAgreement.Size = new System.Drawing.Size(45, 43);
            this.btnAddAgreement.TabIndex = 1;
            this.toolTip.SetToolTip(this.btnAddAgreement, "Dodaj umowę");
            this.btnAddAgreement.UseVisualStyleBackColor = false;
            this.btnAddAgreement.Click += new System.EventHandler(this.btnAddAgreement_Click);
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.White;
            this.imgLstIcons.Images.SetKeyName(0, "icon-add.png");
            this.imgLstIcons.Images.SetKeyName(1, "icon-delete.png");
            this.imgLstIcons.Images.SetKeyName(2, "icon-refresh.png");
            this.imgLstIcons.Images.SetKeyName(3, "icon-structure.png");
            this.imgLstIcons.Images.SetKeyName(4, "icon-list.png");
            // 
            // btnRemoveAgreement
            // 
            this.btnRemoveAgreement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveAgreement.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveAgreement.ImageIndex = 1;
            this.btnRemoveAgreement.ImageList = this.imgLstIcons;
            this.btnRemoveAgreement.Location = new System.Drawing.Point(802, 12);
            this.btnRemoveAgreement.Name = "btnRemoveAgreement";
            this.btnRemoveAgreement.Size = new System.Drawing.Size(45, 43);
            this.btnRemoveAgreement.TabIndex = 2;
            this.toolTip.SetToolTip(this.btnRemoveAgreement, "Usuń umowę");
            this.btnRemoveAgreement.UseVisualStyleBackColor = false;
            this.btnRemoveAgreement.Click += new System.EventHandler(this.btnRemoveAgreement_Click);
            // 
            // btnSwitchGridMode
            // 
            this.btnSwitchGridMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSwitchGridMode.BackColor = System.Drawing.Color.Transparent;
            this.btnSwitchGridMode.ImageIndex = 3;
            this.btnSwitchGridMode.ImageList = this.imgLstIcons;
            this.btnSwitchGridMode.Location = new System.Drawing.Point(904, 12);
            this.btnSwitchGridMode.Name = "btnSwitchGridMode";
            this.btnSwitchGridMode.Size = new System.Drawing.Size(45, 43);
            this.btnSwitchGridMode.TabIndex = 4;
            this.toolTip.SetToolTip(this.btnSwitchGridMode, "Przełącz widok");
            this.btnSwitchGridMode.UseVisualStyleBackColor = false;
            this.btnSwitchGridMode.Click += new System.EventHandler(this.btnSwitchGridMode_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefreshList.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshList.ImageIndex = 2;
            this.btnRefreshList.ImageList = this.imgLstIcons;
            this.btnRefreshList.Location = new System.Drawing.Point(853, 12);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(45, 43);
            this.btnRefreshList.TabIndex = 3;
            this.toolTip.SetToolTip(this.btnRefreshList, "Odśwież listę");
            this.btnRefreshList.UseVisualStyleBackColor = false;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
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
            this.gridExAgreementsListGrouped.Location = new System.Drawing.Point(12, 61);
            this.gridExAgreementsListGrouped.Name = "gridExAgreementsListGrouped";
            this.gridExAgreementsListGrouped.Size = new System.Drawing.Size(937, 432);
            this.gridExAgreementsListGrouped.TabIndex = 1;
            this.gridExAgreementsListGrouped.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridExCurrentList_RowDoubleClick);
            this.gridExAgreementsListGrouped.DoubleClick += new System.EventHandler(this.gridExAgreementsListGrouped_DoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ImageList = this.imgLstIcons;
            this.button1.Location = new System.Drawing.Point(441, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "excel test";
            this.toolTip.SetToolTip(this.button1, "Dodaj umowę");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAgreementsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridExAgreementsListGrouped);
            this.Controls.Add(this.btnSwitchGridMode);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.btnRemoveAgreement);
            this.Controls.Add(this.btnAddAgreement);
            this.Controls.Add(this.gridExAgreementsList);
            this.Name = "FrmAgreementsList";
            this.Text = "Umowy";
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExAgreementsListGrouped)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExAgreementsList;
        private System.Windows.Forms.Button btnAddAgreement;
        private System.Windows.Forms.Button btnRemoveAgreement;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.Button btnSwitchGridMode;
        private System.Windows.Forms.Button btnRefreshList;
        private Janus.Windows.GridEX.GridEX gridExAgreementsListGrouped;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button button1;
    }
}