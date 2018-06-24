using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            lblTitle.Text = agreement.Title;
            numAdvance.Value = agreement.Advance;

            if (agreement.AdvanceDate == null)
            {
                dtAdvanceDate.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtAdvanceDate.Format = DateTimePickerFormat.Short;
                dtAdvanceDate.Value = agreement.AdvanceDate.GetValueOrDefault();
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
            chkFirstSale.Checked = position.IsChargedFromFirstSale;
            chkIndefinitePeriod.Checked = position.IsIndifinitePeriod;
            cboCurrency.SelectedValue = position.CurrencyId;
            cboSettlementModel.SelectedValue = position.SettlementModelId;
            cboBillingPeriod.SelectedValue = position.BillingPeriod;
            lblWFMagDevileryDate.Text = position.WFMagDeliveryDate.GetValueOrDefault().ToShortDateString();
            lblWFMagFirstSaleDate.Text = position.WFMagFirstSaleDate.GetValueOrDefault().ToShortDateString();
            lblWFMagNetto.Text = position.WFMagNetto.ToString();
            lblWFMagBrutto.Text = position.WFMagBrutto.ToString();
            lblWFMagPZ.Text = position.WFMagPZ.ToString();
            numModelFixedPrice.Value = position.ModelFixedPrice;
            numModelPercent.Value = position.ModelPercent;

            if (position.AgreementExpirationDate == null)
            {
                dtAgreementExpiration.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtAgreementExpiration.Format = DateTimePickerFormat.Short;
                dtAgreementExpiration.Value = position.AgreementExpirationDate.GetValueOrDefault();
            }

            if (position.BillingPeriodStart == null)
            {
                dtBillingPeriodFrom.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtBillingPeriodFrom.Format = DateTimePickerFormat.Short;
                dtBillingPeriodFrom.Value = position.BillingPeriodStart.GetValueOrDefault();
            }

            if (position.BillingPeriodEnd == null)
            {
                dtBillingPeriodTo.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtBillingPeriodTo.Format = DateTimePickerFormat.Short;
                dtBillingPeriodTo.Value = position.BillingPeriodEnd.GetValueOrDefault();
            }

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

        private void cboSettlementModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(cboSettlementModel.SelectedValue.ToString(), out int selectedModelId);

            if (selectedModelId > 0)
            {
                Model selectedModel = ModelsRepo.GetByID(selectedModelId);

                if (selectedModel.LabelPercent != string.Empty)
                {
                    lblModelPercent.Visible = true;
                    numModelPercent.Visible = true;
                    lblModelPercent.Text = string.Format("{0}:", selectedModel.LabelPercent);
                }
                else
                {
                    lblModelPercent.Visible = false;
                    numModelPercent.Visible = false;
                }

                if (selectedModel.LabelFixedPrice != string.Empty)
                {
                    lblModelFixedPrice.Visible = true;
                    numModelFixedPrice.Visible = true;
                    lblModelFixedPrice.Text = string.Format("{0}:", selectedModel.LabelFixedPrice);

                    if (!lblModelPercent.Visible)
                    {
                        lblModelFixedPrice.Location = lblModelPercent.Location;
                        numModelFixedPrice.Location = numModelPercent.Location;
                    }
                    else
                    {
                        lblModelFixedPrice.Location = new Point(lblModelPercent.Location.X, lblModelPercent.Location.Y + 39);
                        numModelFixedPrice.Location = new Point(numModelPercent.Location.X, numModelPercent.Location.Y + 39);
                    }
                }
                else
                {
                    lblModelFixedPrice.Visible = false;
                    numModelFixedPrice.Visible = false;
                }                                    
            }                        
        }
    }
}
