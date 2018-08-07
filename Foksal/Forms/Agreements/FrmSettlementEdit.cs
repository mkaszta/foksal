using BLL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmSettlementEdit : Form
    {
        private Settlement settlement;
        private int agreementId;

        public FrmSettlementEdit(Settlement settlement, int agreementId)
        {
            InitializeComponent();

            this.settlement = settlement;
            this.agreementId = agreementId;

            this.LoadData();
        }

        private void LoadData()
        {
            lblAgreement.Text = this.agreementId.ToString();
            lblPeriod.Text = this.settlement.Period.ToShortDateString();

            chkIsLocked.Checked = this.settlement.IsLocked;
            dtPeriod.Value = this.settlement.Period;
            dtGeneration.Value = this.settlement.GenerationDate;
            txtInvoiceName.Text = this.settlement.InvoiceNumber;
            txtEmail.Text = this.settlement.Email;
            numInvoiceAmount.Value = this.settlement.InvoiceAmount ?? 0;
            numTaxPercent.Value = this.settlement.TaxPercent;

            dtCerificate.Checked = (this.settlement.CertificateDate != null);
            dtCerificate.Value = this.settlement.CertificateDate ?? DateTime.Now;
            dtDispatch.Checked = (this.settlement.DispatchDate != null);
            dtDispatch.Value = this.settlement.DispatchDate ?? DateTime.Now;
        }

        private void SaveSettlement()
        {
            this.settlement.IsLocked = chkIsLocked.Checked;
            this.settlement.Period = dtPeriod.Value;
            this.settlement.GenerationDate = dtGeneration.Value;
            this.settlement.InvoiceNumber = txtInvoiceName.Text;
            this.settlement.Email = txtEmail.Text;
            this.settlement.InvoiceAmount = numInvoiceAmount.Value;
            this.settlement.TaxPercent = numTaxPercent.Value;

            this.settlement.CertificateDate = dtCerificate.Checked ? dtCerificate.Value : (DateTime?)null;
            this.settlement.DispatchDate = dtDispatch.Checked ? dtDispatch.Value : (DateTime?)null;

            SettlementsRepo.Update(this.settlement);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć rozliczenie?\r\nNiezapisane zmiany zostaną utracone.", "Rozliczenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zapisać zmiany?", "Rozliczenie", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.SaveSettlement();
                MessageBox.Show("Rozliczenie poprawnie zapisane.", "Rozliczenie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }        
    }
}
