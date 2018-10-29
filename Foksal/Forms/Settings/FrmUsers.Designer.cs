﻿namespace Foksal.Forms.Settings
{
    partial class FrmUsers
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
            Janus.Windows.GridEX.GridEXLayout gridExUsers_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            Janus.Windows.GridEX.GridEXLayout gridExUserPermissions_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.gridExUsers = new Janus.Windows.GridEX.GridEX();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.imgLstIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.gridExUserPermissions = new Janus.Windows.GridEX.GridEX();
            this.btnSavePermissions = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridExUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExUserPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // gridExUsers
            // 
            this.gridExUsers.ColumnAutoResize = true;
            this.gridExUsers.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExUsers_DesignTimeLayout.LayoutString = resources.GetString("gridExUsers_DesignTimeLayout.LayoutString");
            this.gridExUsers.DesignTimeLayout = gridExUsers_DesignTimeLayout;
            this.gridExUsers.DynamicFiltering = true;
            this.gridExUsers.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExUsers.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExUsers.FocusCellFormatStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridExUsers.FocusCellFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight;
            this.gridExUsers.GroupByBoxVisible = false;
            this.gridExUsers.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight;
            this.gridExUsers.Location = new System.Drawing.Point(12, 12);
            this.gridExUsers.Name = "gridExUsers";
            this.gridExUsers.NewRowFormatStyle.BackColor = System.Drawing.Color.PaleGreen;
            this.gridExUsers.NewRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.gridExUsers.NewRowFormatStyle.ForeColor = System.Drawing.Color.White;
            this.gridExUsers.SelectedInactiveFormatStyle.BackColor = System.Drawing.SystemColors.Highlight;
            this.gridExUsers.SelectedInactiveFormatStyle.BackColorGradient = System.Drawing.SystemColors.Highlight;
            this.gridExUsers.SelectedInactiveFormatStyle.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gridExUsers.Size = new System.Drawing.Size(262, 249);
            this.gridExUsers.TabIndex = 32;
            this.gridExUsers.SelectionChanged += new System.EventHandler(this.gridExUsers_SelectionChanged);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.ImageKey = "icon-delete.png";
            this.btnRemoveUser.ImageList = this.imgLstIcons;
            this.btnRemoveUser.Location = new System.Drawing.Point(280, 52);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(41, 34);
            this.btnRemoveUser.TabIndex = 62;
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // imgLstIcons
            // 
            this.imgLstIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstIcons.ImageStream")));
            this.imgLstIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstIcons.Images.SetKeyName(0, "icon-add.png");
            this.imgLstIcons.Images.SetKeyName(1, "icon-delete.png");
            this.imgLstIcons.Images.SetKeyName(2, "icon-save.png");
            this.imgLstIcons.Images.SetKeyName(3, "icon-refresh.png");
            this.imgLstIcons.Images.SetKeyName(4, "icon-edit.png");
            // 
            // btnAddUser
            // 
            this.btnAddUser.ImageKey = "icon-add.png";
            this.btnAddUser.ImageList = this.imgLstIcons;
            this.btnAddUser.Location = new System.Drawing.Point(280, 12);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(41, 34);
            this.btnAddUser.TabIndex = 61;
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.ImageKey = "icon-edit.png";
            this.btnEditUser.ImageList = this.imgLstIcons;
            this.btnEditUser.Location = new System.Drawing.Point(280, 92);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(41, 34);
            this.btnEditUser.TabIndex = 63;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // gridExUserPermissions
            // 
            this.gridExUserPermissions.ColumnAutoResize = true;
            this.gridExUserPermissions.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExUserPermissions_DesignTimeLayout.LayoutString = resources.GetString("gridExUserPermissions_DesignTimeLayout.LayoutString");
            this.gridExUserPermissions.DesignTimeLayout = gridExUserPermissions_DesignTimeLayout;
            this.gridExUserPermissions.DynamicFiltering = true;
            this.gridExUserPermissions.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExUserPermissions.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExUserPermissions.GroupByBoxVisible = false;
            this.gridExUserPermissions.Location = new System.Drawing.Point(12, 267);
            this.gridExUserPermissions.Name = "gridExUserPermissions";
            this.gridExUserPermissions.NewRowFormatStyle.BackColor = System.Drawing.Color.PaleGreen;
            this.gridExUserPermissions.NewRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.gridExUserPermissions.NewRowFormatStyle.ForeColor = System.Drawing.Color.White;
            this.gridExUserPermissions.Size = new System.Drawing.Size(262, 181);
            this.gridExUserPermissions.TabIndex = 64;
            // 
            // btnSavePermissions
            // 
            this.btnSavePermissions.ImageKey = "icon-save.png";
            this.btnSavePermissions.ImageList = this.imgLstIcons;
            this.btnSavePermissions.Location = new System.Drawing.Point(280, 267);
            this.btnSavePermissions.Name = "btnSavePermissions";
            this.btnSavePermissions.Size = new System.Drawing.Size(41, 42);
            this.btnSavePermissions.TabIndex = 65;
            this.btnSavePermissions.UseVisualStyleBackColor = true;
            this.btnSavePermissions.Click += new System.EventHandler(this.btnSavePermissions_Click);
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 460);
            this.Controls.Add(this.btnSavePermissions);
            this.Controls.Add(this.gridExUserPermissions);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.gridExUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmUsers";
            this.Text = "Użytkownicy";
            ((System.ComponentModel.ISupportInitialize)(this.gridExUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridExUserPermissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExUsers;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ImageList imgLstIcons;
        private System.Windows.Forms.Button btnEditUser;
        private Janus.Windows.GridEX.GridEX gridExUserPermissions;
        private System.Windows.Forms.Button btnSavePermissions;
    }
}