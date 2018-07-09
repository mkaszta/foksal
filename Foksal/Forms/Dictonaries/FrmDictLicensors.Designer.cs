namespace Foksal.Forms.Dictonaries
{
    partial class FrmDictLicensors
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
            Janus.Windows.GridEX.GridEXLayout gridExLicensors_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDictLicensors));
            this.gridExLicensors = new Janus.Windows.GridEX.GridEX();
            this.btnSave = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridExLicensors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridExLicensors
            // 
            this.gridExLicensors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridExLicensors.ColumnAutoResize = true;
            this.gridExLicensors.ColumnSetHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExLicensors_DesignTimeLayout.LayoutString = resources.GetString("gridExLicensors_DesignTimeLayout.LayoutString");
            this.gridExLicensors.DesignTimeLayout = gridExLicensors_DesignTimeLayout;
            this.gridExLicensors.DynamicFiltering = true;
            this.gridExLicensors.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.gridExLicensors.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.gridExLicensors.FilterRowFormatStyle.BackColor = System.Drawing.Color.LightCyan;
            this.gridExLicensors.GroupByBoxVisible = false;
            this.gridExLicensors.Location = new System.Drawing.Point(12, 88);
            this.gridExLicensors.Name = "gridExLicensors";
            this.gridExLicensors.NewRowFormatStyle.BackColor = System.Drawing.Color.Honeydew;
            this.gridExLicensors.NewRowFormatStyle.BackColorGradient = System.Drawing.Color.White;
            this.gridExLicensors.NewRowFormatStyle.ForeColor = System.Drawing.Color.White;
            this.gridExLicensors.Size = new System.Drawing.Size(1139, 425);
            this.gridExLicensors.TabIndex = 35;
            this.gridExLicensors.CellValueChanged += new Janus.Windows.GridEX.ColumnActionEventHandler(this.gridExLicensors_CellValueChanged);
            this.gridExLicensors.RecordsDeleted += new System.EventHandler(this.gridExLicensors_RecordsDeleted);
            this.gridExLicensors.RecordAdded += new System.EventHandler(this.gridExLicensors_RecordAdded);
            // 
            // btnSave
            // 
            this.btnSave.ImageKey = "icon-save.png";
            this.btnSave.ImageList = this.imageList;
            this.btnSave.Location = new System.Drawing.Point(104, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(41, 42);
            this.btnSave.TabIndex = 59;
            this.toolTip.SetToolTip(this.btnSave, "Zapisz zmiany");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "icon-save.png");
            this.imageList.Images.SetKeyName(1, "icon-delete.png");
            this.imageList.Images.SetKeyName(2, "icon-refresh.png");
            this.imageList.Images.SetKeyName(3, "icon-link.png");
            this.imageList.Images.SetKeyName(4, "icon-source.png");
            this.imageList.Images.SetKeyName(5, "icon-target.png");
            // 
            // btnRemove
            // 
            this.btnRemove.ImageKey = "icon-delete.png";
            this.btnRemove.ImageList = this.imageList;
            this.btnRemove.Location = new System.Drawing.Point(10, 19);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(41, 42);
            this.btnRemove.TabIndex = 61;
            this.toolTip.SetToolTip(this.btnRemove, "Usuń");
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.BackColor = System.Drawing.Color.Transparent;
            this.btnRefreshList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefreshList.ImageIndex = 2;
            this.btnRefreshList.ImageList = this.imageList;
            this.btnRefreshList.Location = new System.Drawing.Point(57, 19);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(41, 42);
            this.btnRefreshList.TabIndex = 62;
            this.toolTip.SetToolTip(this.btnRefreshList, "Odśwież listę");
            this.btnRefreshList.UseVisualStyleBackColor = false;
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "icon-source.png";
            this.button1.ImageList = this.imageList;
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 42);
            this.button1.TabIndex = 63;
            this.button1.Text = "źródło";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.button1, "Usuń");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.ImageKey = "icon-target.png";
            this.button2.ImageList = this.imageList;
            this.button2.Location = new System.Drawing.Point(57, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 42);
            this.button2.TabIndex = 64;
            this.button2.Text = "cel";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.button2, "Usuń");
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.ImageKey = "icon-link.png";
            this.button3.ImageList = this.imageList;
            this.button3.Location = new System.Drawing.Point(108, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 42);
            this.button3.TabIndex = 65;
            this.button3.Text = "scalaj!";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip.SetToolTip(this.button3, "Usuń");
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTarget);
            this.groupBox1.Controls.Add(this.lblSource);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 70);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scalanie licencjodawców";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnRefreshList);
            this.groupBox2.Location = new System.Drawing.Point(996, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 70);
            this.groupBox2.TabIndex = 67;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Słownik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(164, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(157, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(180, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Przenieś umowy...";
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSource.Location = new System.Drawing.Point(180, 32);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(70, 13);
            this.lblSource.TabIndex = 71;
            this.lblSource.Text = "(nie wybrano)";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTarget.Location = new System.Drawing.Point(180, 47);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(70, 13);
            this.lblTarget.TabIndex = 72;
            this.lblTarget.Text = "(nie wybrano)";
            // 
            // FrmDictLicensors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 525);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridExLicensors);
            this.MaximizeBox = false;
            this.Name = "FrmDictLicensors";
            this.Text = "Licencjodawcy";
            ((System.ComponentModel.ISupportInitialize)(this.gridExLicensors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridExLicensors;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}