using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
using System;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmAgreement : Form
    {
        private Agreement agreement;
        public FrmAgreement(int agreementID)
        {
            InitializeComponent();

            this.agreement = AgreementsRepo.GetByID(agreementID);
            FillControls();

            GridAgreementPositionsRepo gridRepo = new GridAgreementPositionsRepo();
            gridRepo.BindDataSet(gridExPositions, agreementID);
        }

        private void FillControls()
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
    }
}
