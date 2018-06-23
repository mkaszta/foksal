using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
using Janus.Windows.GridEX;
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

            this.CreateHeader();
            this.CreateLicensorsTab();
            this.CreateScheduleTab();

            GridAgreementPositionsRepo gridRepo = new GridAgreementPositionsRepo();
            gridRepo.BindDataSet(gridExPositions, this.agreement.Id);
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

        private void CreateHeader()
        {
            lblAgreement.Text = agreement.Id.ToString();
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

            GridAgreementArticlesRepo gridArticlesRepo = new GridAgreementArticlesRepo();
            gridArticlesRepo.BindDataSet(gridExArticles, this.agreement.Id);
        }

        private void CreateLicensorsTab()
        {
            GridEXColumn colLicensor = gridExLicensors.RootTable.Columns["LicencjodawcaId"];
            GridEXColumn colLicensorCareOf = gridExLicensors.RootTable.Columns["LicencjodawcaIdCareOf"];
            colLicensor.HasValueList = true;
            colLicensorCareOf.HasValueList = true;

            GridEXValueListItemCollection valuesCboLicensor = colLicensor.ValueList;
            GridEXValueListItemCollection valuesCboLicensorCareOf = colLicensorCareOf.ValueList;

            List<Licensor> lstLicensors = LicensorsRepo.GetAll();

            foreach (var licensor in lstLicensors)
            {
                valuesCboLicensor.Add(licensor.Id, string.Format("{0} {1}", licensor.FirstName, licensor.LastName));
                valuesCboLicensorCareOf.Add(licensor.Id, string.Format("{0} {1}", licensor.FirstName, licensor.LastName));
            }

            colLicensor.EditType = Janus.Windows.GridEX.EditType.DropDownList;
            colLicensor.CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text;
            colLicensor.DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text;

            GridAgreementLicensorsRepo gridLicensorsRepo = new GridAgreementLicensorsRepo();
            gridLicensorsRepo.BindDataSet(gridExLicensors, agreement.Id);
        }

        private void CreateScheduleTab()
        {
            GridEXColumn colCurrency = gridExSchedule.RootTable.Columns["WalutaId"];
            colCurrency.HasValueList = true;

            GridEXValueListItemCollection valuesCboCurrency = colCurrency.ValueList;

            List<Currency> lstCurrencies = CurrenciesRepo.GetAll();

            foreach (var currency in lstCurrencies)
            {
                valuesCboCurrency.Add(currency.Id, currency.Name);
            }

            colCurrency.EditType = Janus.Windows.GridEX.EditType.DropDownList;
            colCurrency.CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text;
            colCurrency.DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text;

            GridAgreementScheduleRepo gridScheduleRepo = new GridAgreementScheduleRepo();
            gridScheduleRepo.BindDataSet(gridExSchedule, agreement.Id);
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

            GridAgreementThresholdsRepo gridThresholdsRepo = new GridAgreementThresholdsRepo();
            gridThresholdsRepo.BindDataSet(gridExThresholds, positionId);

            GridAgreementRelatedProductsRepo gridRelatedProductsRepo = new GridAgreementRelatedProductsRepo();
            gridRelatedProductsRepo.BindDataSet(gridExRelatedProducts, positionId);
        }

        private void gridExPositions_SelectionChanged(object sender, EventArgs e)
        {
            int positionId = (int)gridExPositions.CurrentRow.Cells["id"].Value;
            this.GetPositionDetails(positionId);
        }

        private void gridExLicensors_CellValueChanged(object sender, ColumnActionEventArgs e)
        {
            if (e.Column.DataMember == "LicencjodawcaId")
            {
                gridExLicensors.UpdateData();
                int selectedId = (int)gridExLicensors.CurrentRow.Cells["LicencjodawcaId"].Value;

                Licensor selectedLicensor = LicensorsRepo.GetById(selectedId);
                gridExLicensors.CurrentRow.Cells["AdresEmail"].Text = selectedLicensor.Email;
                gridExLicensors.CurrentRow.Cells["OsobaFizyczna"].Value = selectedLicensor.IsNaturalPerson;
                gridExLicensors.CurrentRow.Cells["PodatekProcent"].Value = selectedLicensor.TaxPercentage;
            }
        }
    }
}
