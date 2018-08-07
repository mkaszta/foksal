namespace Foksal.Forms.Agreements
{
    partial class FrmSettlementEdit
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
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.lblAgreement = new System.Windows.Forms.Label();
            this.dtPeriod = new System.Windows.Forms.DateTimePicker();
            this.dtDispatch = new System.Windows.Forms.DateTimePicker();
            this.dtCerificate = new System.Windows.Forms.DateTimePicker();
            this.dtGeneration = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.chkIsLocked = new System.Windows.Forms.CheckBox();
            this.txtComments = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInvoiceName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numInvoiceAmount = new System.Windows.Forms.NumericUpDown();
            this.numTaxPercent = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(17, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Okres:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 71;
            this.label1.Text = "Umowa:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPeriod.Location = new System.Drawing.Point(76, 26);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(62, 16);
            this.lblPeriod.TabIndex = 74;
            this.lblPeriod.Text = "lblPeriod";
            // 
            // lblAgreement
            // 
            this.lblAgreement.AutoSize = true;
            this.lblAgreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAgreement.Location = new System.Drawing.Point(76, 9);
            this.lblAgreement.Name = "lblAgreement";
            this.lblAgreement.Size = new System.Drawing.Size(88, 16);
            this.lblAgreement.TabIndex = 73;
            this.lblAgreement.Text = "lblAgreement";
            // 
            // dtPeriod
            // 
            this.dtPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPeriod.Location = new System.Drawing.Point(20, 98);
            this.dtPeriod.Name = "dtPeriod";
            this.dtPeriod.Size = new System.Drawing.Size(123, 20);
            this.dtPeriod.TabIndex = 75;
            // 
            // dtDispatch
            // 
            this.dtDispatch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDispatch.Location = new System.Drawing.Point(20, 215);
            this.dtDispatch.Name = "dtDispatch";
            this.dtDispatch.ShowCheckBox = true;
            this.dtDispatch.Size = new System.Drawing.Size(123, 20);
            this.dtDispatch.TabIndex = 76;
            // 
            // dtCerificate
            // 
            this.dtCerificate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCerificate.Location = new System.Drawing.Point(20, 176);
            this.dtCerificate.Name = "dtCerificate";
            this.dtCerificate.ShowCheckBox = true;
            this.dtCerificate.Size = new System.Drawing.Size(123, 20);
            this.dtCerificate.TabIndex = 77;
            // 
            // dtGeneration
            // 
            this.dtGeneration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtGeneration.Location = new System.Drawing.Point(20, 137);
            this.dtGeneration.Name = "dtGeneration";
            this.dtGeneration.Size = new System.Drawing.Size(123, 20);
            this.dtGeneration.TabIndex = 78;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(168, 20);
            this.txtEmail.TabIndex = 79;
            // 
            // chkIsLocked
            // 
            this.chkIsLocked.AutoSize = true;
            this.chkIsLocked.Location = new System.Drawing.Point(20, 62);
            this.chkIsLocked.Name = "chkIsLocked";
            this.chkIsLocked.Size = new System.Drawing.Size(143, 17);
            this.chkIsLocked.TabIndex = 80;
            this.chkIsLocked.Text = "Zablokowanie przeliczeń";
            this.chkIsLocked.UseVisualStyleBackColor = true;
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(20, 254);
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(299, 96);
            this.txtComments.TabIndex = 85;
            this.txtComments.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Okres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Data wygenerowania:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Data wysyłki:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Data certyfikatu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 91;
            this.label7.Text = "Adres email:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Numer faktury:";
            // 
            // txtInvoiceName
            // 
            this.txtInvoiceName.Location = new System.Drawing.Point(151, 98);
            this.txtInvoiceName.Name = "txtInvoiceName";
            this.txtInvoiceName.Size = new System.Drawing.Size(168, 20);
            this.txtInvoiceName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 95;
            this.label9.Text = "Kwota faktury:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 97;
            this.label10.Text = "% podatku u źródła:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 98;
            this.label11.Text = "Uwagi:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(163, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 99;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(244, 372);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 100;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numInvoiceAmount
            // 
            this.numInvoiceAmount.Location = new System.Drawing.Point(151, 137);
            this.numInvoiceAmount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numInvoiceAmount.Name = "numInvoiceAmount";
            this.numInvoiceAmount.Size = new System.Drawing.Size(168, 20);
            this.numInvoiceAmount.TabIndex = 101;
            // 
            // numTaxPercent
            // 
            this.numTaxPercent.Location = new System.Drawing.Point(151, 176);
            this.numTaxPercent.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numTaxPercent.Name = "numTaxPercent";
            this.numTaxPercent.Size = new System.Drawing.Size(168, 20);
            this.numTaxPercent.TabIndex = 102;
            // 
            // FrmSettlementEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(338, 418);
            this.Controls.Add(this.numTaxPercent);
            this.Controls.Add(this.numInvoiceAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtInvoiceName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.chkIsLocked);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dtGeneration);
            this.Controls.Add(this.dtCerificate);
            this.Controls.Add(this.dtDispatch);
            this.Controls.Add(this.dtPeriod);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.lblAgreement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSettlementEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rozliczenie";
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTaxPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label lblAgreement;
        private System.Windows.Forms.DateTimePicker dtPeriod;
        private System.Windows.Forms.DateTimePicker dtDispatch;
        private System.Windows.Forms.DateTimePicker dtCerificate;
        private System.Windows.Forms.DateTimePicker dtGeneration;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckBox chkIsLocked;
        private System.Windows.Forms.RichTextBox txtComments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInvoiceName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numInvoiceAmount;
        private System.Windows.Forms.NumericUpDown numTaxPercent;
    }
}