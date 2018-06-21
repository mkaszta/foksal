using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmAgreement : Form
    {
        private Agreement agreement;
        public FrmAgreement(int agreementID)
        {
            InitializeComponent();

            this.PrepareForm();            

            this.agreement = AgreementsRepo.GetByID(agreementID);
            this.GetHeader();            

            GridAgreementPositionsRepo gridRepo = new GridAgreementPositionsRepo();
            gridRepo.BindDataSet(gridExPositions, agreementID);
        }

        private void PrepareForm()
        {
            cboBillingPeriod.DataSource = BillingPeriod.GetBillingPeriods();
            cboBillingPeriod.DisplayMember = "Name";
            cboBillingPeriod.ValueMember = "PeriodId";

            cboCurrency.DataSource = CurrenciesRepo.GetAll();
            cboCurrency.DisplayMember = "Name";
            cboCurrency.ValueMember = "Id";

            cboSettlementModel.DataSource = SettlementModelsRepo.GetAll();
            cboSettlementModel.DisplayMember = "Name";
            cboSettlementModel.ValueMember = "Id";
        }

        private void GetHeader()
        {
            lblAgreement.Text = agreement.AgreementID.ToString();
            txtComments.Text = agreement.Comments;
            txtReportAuthor.Text = agreement.ReportAuthor;
            txtReportTitle.Text = agreement.ReportTitle;
            txtTitle.Text = agreement.Title;
            numAdvance.Value = agreement.Advance;

            if (agreement.Advance > 0)
            {
                DateTime dtTempDate = agreement.AdvanceDate.GetValueOrDefault();
                if (dtTempDate < dtAdvanceDate.MinDate)
                    dtTempDate = dtAdvanceDate.MinDate;

                dtAdvanceDate.Enabled = true;
                dtAdvanceDate.Value = dtTempDate;
            }
        }

        private void GetPositionDetails(int positionId)
        {
            AgreementPosition position = AgreementPositionsRepo.GetByID(positionId);            

            txtKTM.Text = position.KTM;
            txtDescriptor.Text = position.Descriptor;
            numFreeCopies.Value = position.FreeCopies;
            dtAgreementExpiration.Value = position.AgreementExpirationDate;
            cboBillingPeriod.SelectedValue = position.BillingPeriod;
            dtBillingPeriodFrom.Value = position.BillingPeriodStart;
            dtBillingPeriodTo.Value = position.BillingPeriodEnd;
            chkFirstSale.Checked = position.IsChargedFromFirstSale;
            chkIndefinitePeriod.Checked = position.IsIndifinitePeriod;
            cboCurrency.SelectedValue = position.CurrencyId;
            cboSettlementModel.SelectedValue = position.SettlementModelId;
        }

        private void gridExPositions_SelectionChanged(object sender, EventArgs e)
        {
            int positionId = (int)gridExPositions.CurrentRow.Cells["id"].Value;
            this.GetPositionDetails(positionId);
        }
    }
}
