using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
using Foksal.Forms.Dictonaries;
using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmAgreement : Form
    {
        private FrmAgreementsList parentForm;
        private Agreement agreement;
        private AgreementPosition selectedPosition;
        private GridAgreementPositionsRepo gridPositionsRepo;
        private GridAgreementArticlesRepo gridArticlesRepo;
        private GridAgreementLicensorsRepo gridLicensorsRepo;
        private GridAgreementScheduleRepo gridScheduleRepo;
        private GridAgreementThresholdsRepo gridThresholdsRepo;
        private GridAgreementRelatedProductsRepo gridRelatedProductsRepo;
        private bool isAgreementSavePending;
        private bool isPositionSavePending;
        private bool isPositionAddPending;
        private bool isLoadingData;
        private bool isCancellingSelection;

        public FrmAgreement(int agreementID, int positionId, FrmAgreementsList parentForm = null)
        {
            InitializeComponent();

            this.gridPositionsRepo = new GridAgreementPositionsRepo();
            this.gridArticlesRepo = new GridAgreementArticlesRepo();
            this.gridLicensorsRepo = new GridAgreementLicensorsRepo();
            this.gridScheduleRepo = new GridAgreementScheduleRepo();
            this.gridThresholdsRepo = new GridAgreementThresholdsRepo();
            this.gridRelatedProductsRepo = new GridAgreementRelatedProductsRepo();
            this.parentForm = parentForm;

            this.agreement = agreementID > 0 ? AgreementsRepo.GetByID(agreementID) : new Agreement();

            this.PrepareForm();
            this.LoadData();

            this.SelectPositionById(positionId);
        }

        public void AddPosition(string ktm = "", string descriptor = "")
        {
            this.gridPositionsRepo.AddRow(this.agreement.Id);
            gridExPositions.Refetch();
            gridExPositions.MoveLast();
            gridExPositions.Focus();
            this.SetPositionChangesPending(true);
            this.isPositionAddPending = true;
            grbPositionDetails.Enabled = true;

            txtKTM.Text = ktm;
            txtDescriptor.Text = descriptor;
        }

        private void SelectPositionById(int positionId)
        {
            if (positionId == 0)
            {
                if (gridExPositions.RowCount > 0)
                    gridExPositions.Row = 0;
            }
            else
            {
                foreach (GridEXRow row in gridExPositions.GetRows())
                {
                    if ((int)row.Cells["id"].Value == positionId)
                    {
                        gridExPositions.Row = row.AbsolutePosition - 1;
                        return;
                    }
                }
            }
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

        private void LoadData()
        {
            int previouslySelectedPositionId = 0;
            if (this.selectedPosition != null)
                previouslySelectedPositionId = this.selectedPosition.Id;

            this.isLoadingData = true;

            this.LoadHeader();
            this.LoadLicensorsTab();
            this.LoadScheduleTab();

            tabControlAgreement.Enabled = (this.agreement.Id > 0) ? true : false;
            this.gridPositionsRepo.BindDataSet(gridExPositions, this.agreement.Id);

            if (gridExPositions.RowCount < 1)
            {
                this.selectedPosition = new AgreementPosition();
                this.LoadPositionDetails();
            }

            this.SetAgreementChangesPending(false);
            this.SetPositionChangesPending(false);
            this.isPositionAddPending = false;
            this.isLoadingData = false;

            if (previouslySelectedPositionId > 0)
                this.SelectPositionById(previouslySelectedPositionId);
        }

        private void LoadHeader()
        {
            lblAgreement.Text = agreement.Id.ToString();
            txtComments.Text = agreement.Comments;
            txtReportAuthor.Text = agreement.ReportAuthor;
            txtReportTitle.Text = agreement.ReportTitle;
            txtTitle.Text = agreement.Title;
            numAdvance.Value = agreement.Advance;

            if (agreement.AdvanceDate == null)
            {
                dtAdvanceDate.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtAdvanceDate.Format = DateTimePickerFormat.Short;
                if (this.agreement.AdvanceDate.HasValue)
                    dtAdvanceDate.Value = this.agreement.AdvanceDate.GetValueOrDefault();
            }

            this.gridArticlesRepo.BindDataSet(gridExArticles, this.agreement.Id);
        }

        private void LoadLicensorsTab()
        {
            GridEXColumn colLicensor = gridExLicensors.RootTable.Columns["LicencjodawcaId"];
            GridEXColumn colLicensorCareOf = gridExLicensors.RootTable.Columns["LicencjodawcaIdCareOf"];
            colLicensor.HasValueList = true;
            colLicensorCareOf.HasValueList = true;

            GridEXValueListItemCollection valuesCboLicensor = colLicensor.ValueList;
            GridEXValueListItemCollection valuesCboLicensorCareOf = colLicensorCareOf.ValueList;

            List<Licensor> lstLicensors = LicensorsRepo.GetAllForCombo();

            foreach (var licensor in lstLicensors)
            {
                valuesCboLicensor.Add(licensor.Id, licensor.Name);
                valuesCboLicensorCareOf.Add(licensor.Id, licensor.Name);
            }

            colLicensor.EditType = Janus.Windows.GridEX.EditType.DropDownList;
            colLicensor.CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text;
            colLicensor.DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text;

            this.gridLicensorsRepo.BindDataSet(gridExLicensors, agreement.Id);
        }

        private void LoadScheduleTab()
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

            this.gridScheduleRepo.BindDataSet(gridExSchedule, agreement.Id);
        }

        private void LoadPositionDetails()
        {
            numFreeCopies.Value = this.selectedPosition.FreeCopies;
            chkFirstSale.Checked = this.selectedPosition.IsChargedFromFirstSale;
            chkIndefinitePeriod.Checked = this.selectedPosition.IsIndifinitePeriod;
            cboCurrency.SelectedValue = this.selectedPosition.CurrencyId;
            cboSettlementModel.SelectedValue = this.selectedPosition.ModelId;
            cboBillingPeriod.SelectedValue = this.selectedPosition.BillingPeriod;
            lblWFMagDevileryDate.Text = this.selectedPosition.WFMagDeliveryDate == null ? "-" : this.selectedPosition.WFMagDeliveryDate.GetValueOrDefault().ToShortDateString();
            lblWFMagFirstSaleDate.Text = this.selectedPosition.WFMagFirstSaleDate == null ? "-" : this.selectedPosition.WFMagFirstSaleDate.GetValueOrDefault().ToShortDateString();
            lblWFMagNetto.Text = this.selectedPosition.WFMagNetto.ToString();
            lblWFMagBrutto.Text = this.selectedPosition.WFMagBrutto.ToString();
            lblWFMagPZ.Text = this.selectedPosition.WFMagPZ.ToString();
            numModelFixedPrice.Value = this.selectedPosition.ModelFixedPrice;
            numModelPercent.Value = this.selectedPosition.ModelPercent;
            txtPositionComments.Text = this.selectedPosition.Comments;
            txtKTM.Text = this.selectedPosition.KTM;
            txtDescriptor.Text = this.selectedPosition.Descriptor;

            if (this.selectedPosition.ExpirationDate == null)
            {
                dtExpiration.Checked = false;
                dtExpiration.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtExpiration.Checked = true;
                dtExpiration.Format = DateTimePickerFormat.Short;
                if (this.selectedPosition.ExpirationDate.HasValue)
                    dtExpiration.Value = this.selectedPosition.ExpirationDate.GetValueOrDefault();
            }

            if (this.selectedPosition.BillingPeriodEnd == null)
            {
                dtBillingPeriodTo.Checked = false;
                dtBillingPeriodTo.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtBillingPeriodTo.Checked = true;
                dtBillingPeriodTo.Format = DateTimePickerFormat.Short;
                if (this.selectedPosition.BillingPeriodEnd.HasValue)
                    dtBillingPeriodTo.Value = this.selectedPosition.BillingPeriodEnd.GetValueOrDefault();
            }

            this.gridThresholdsRepo.BindDataSet(gridExThresholds, this.selectedPosition.Id);
            this.gridRelatedProductsRepo.BindDataSet(gridExRelatedProducts, this.selectedPosition.Id);

            this.LoadModelDetails();
            this.SetPositionChangesPending(false);

            if (this.selectedPosition.Id > 0)
            {
                grbPositionDetails.Enabled = true;
            }
            else
            {
                grbPositionDetails.Enabled = false;
            }
        }

        private void LoadModelDetails()
        {
            int selectedModelId = 0;

            if (cboSettlementModel.SelectedValue != null)
            {
                int.TryParse(cboSettlementModel.SelectedValue.ToString(), out selectedModelId);
            }

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

                if (selectedModel.HasThresholds)
                {
                    grbThresholds.Visible = true;

                }
                else
                {
                    grbThresholds.Visible = false;
                }
            }
        }

        private bool IsAgreementDataValid()
        {
            if ((gridExLicensors.RowCount - ((int)gridExLicensors.RootTable.AllowAddNew - 1)) > 0 && (decimal)gridExLicensors.GetTotalRow().Cells["UdzialProcent"].Value != 100)
            {
                if (MessageBox.Show("Suma udziałów licencjodawców jest różna od 100%.\r\nCzy na pewno chcesz zapisać umowę?", "Walidacja danych", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsPositionDataValid()
        {
            if (gridExPositions.RowCount > 0)
            {
                if (cboCurrency.SelectedIndex == -1)
                {
                    MessageBox.Show("Wybierz walutę.", "Walidacja danych", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cboSettlementModel.SelectedIndex == -1)
                {
                    MessageBox.Show("Wybierz model rozliczenia.", "Walidacja danych", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (cboBillingPeriod.SelectedIndex == -1)
                {
                    MessageBox.Show("Wybierz okres rozliczeniowy.", "Walidacja danych", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                if (dtBillingPeriodFrom.Text == " ")
                {
                    MessageBox.Show("Wybierz początek okresu rozliczeniowego.", "Walidacja danych", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            return true;
        }

        private void SaveAgreement()
        {
            if (this.isPositionSavePending)
            {
                this.SavePosition();
            }

            if (!this.isPositionSavePending)
            {
                this.agreement.Title = txtTitle.Text;
                this.agreement.ReportTitle = txtReportTitle.Text;
                this.agreement.ReportAuthor = txtReportAuthor.Text;
                this.agreement.Advance = numAdvance.Value;
                this.agreement.Comments = txtComments.Text;
                this.agreement.AdvanceDate = (dtAdvanceDate.Text == " ") ? (DateTime?)null : dtAdvanceDate.Value;

                if (this.agreement.Id > 0)
                {
                    this.UpdateAgreement();
                }
                else
                {
                    this.InsertAgreement();
                }
            }
        }

        private void UpdateAgreement()
        {
            bool isFullySaved = true;

            try
            {
                AgreementsRepo.Update(this.agreement);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać nagłówka umowy.\r\nSpróbuj ponownie.", "Zapis umowy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isFullySaved = false;
            }

            try
            {
                this.gridArticlesRepo.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać towarów powiązanych.\r\nSpróbuj ponownie.", "Zapis umowy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isFullySaved = false;
            }

            try
            {
                this.gridLicensorsRepo.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać licencjodawców.\r\nSpróbuj ponownie.", "Zapis umowy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isFullySaved = false;
            }

            try
            {
                this.gridScheduleRepo.Update();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać harmonogramu.\r\nSpróbuj ponownie.", "Zapis umowy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isFullySaved = false;
            }

            if (isFullySaved)
            {
                MessageBox.Show("Umowa została poprawnie zapisana.", "Zapis umowy", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.SetAgreementChangesPending(false);
                this.LoadData();
            }
        }

        private void InsertAgreement()
        {
            try
            {
                AgreementsRepo.Insert(this.agreement);
                this.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać nowej umowy.\r\nSpróbuj ponownie.", "Zapis umowy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SavePosition()
        {
            if (this.IsPositionDataValid())
            {
                int selectedPositionId = 0;
                bool isFullySaved = true;

                selectedPosition.AgreementId = (int)gridExPositions.CurrentRow.Cells["umowaId"].Value;
                selectedPosition.KTM = txtKTM.Text;
                selectedPosition.CurrencyId = (int)cboCurrency.SelectedValue;
                selectedPosition.Descriptor = txtDescriptor.Text;
                selectedPosition.FreeCopies = (int)numFreeCopies.Value;
                selectedPosition.ExpirationDate = dtExpiration.Text == " " ? (DateTime?)null : dtExpiration.Value;
                selectedPosition.IsChargedFromFirstSale = chkFirstSale.Checked;
                selectedPosition.IsIndifinitePeriod = chkIndefinitePeriod.Checked;
                selectedPosition.Comments = txtPositionComments.Text;
                selectedPosition.ModelId = (int)cboSettlementModel.SelectedValue;
                selectedPosition.ModelPercent = numModelPercent.Visible ? numModelPercent.Value : 0;
                selectedPosition.ModelFixedPrice = numModelFixedPrice.Visible ? numModelFixedPrice.Value : 0;
                selectedPosition.BillingPeriod = (int)cboBillingPeriod.SelectedValue;
                selectedPosition.BillingPeriodStart = dtBillingPeriodFrom.Value;
                selectedPosition.BillingPeriodEnd = dtBillingPeriodTo.Text == " " ? (DateTime?)null : dtBillingPeriodTo.Value;

                try
                {
                    // update podstawowych danych zaznaczonej pozycji
                    AgreementPositionsRepo.InsertUpdate(this.selectedPosition);
                    selectedPositionId = selectedPosition.Id;

                    // update grida z programi dla zaznaczonej pozycji
                    this.gridThresholdsRepo.Update();

                    //update grida z produktami dla zaznaczonej pozycji
                    this.gridRelatedProductsRepo.Update();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Nie udało się zapisać bieżącej pozycji.\r\nSpróbuj ponownie", "Zapis pozycji", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isFullySaved = false;
                }

                if (isFullySaved)
                {
                    this.SetPositionChangesPending(false);

                    if (this.isPositionAddPending)
                        this.isPositionAddPending = false;

                    this.LoadData();
                    this.SelectPositionById(selectedPositionId);
                }
            }
        }

        private void SetAgreementChangesPending(bool isChangePending)
        {
            this.isAgreementSavePending = isChangePending;
            btnSaveAgreement.Enabled = isChangePending;
            btnDiscardChanges.Enabled = isChangePending;

            if (!isChangePending)
            {
                this.isPositionSavePending = isChangePending;
                btnSavePosition.Enabled = isChangePending;
            }
        }

        private void SetPositionChangesPending(bool isChangePending)
        {
            if (isChangePending)
            {
                btnSaveAgreement.Enabled = true;
                btnDiscardChanges.Enabled = true;
            }
            else if (!this.isAgreementSavePending)
            {
                btnSaveAgreement.Enabled = false;
                btnDiscardChanges.Enabled = false;
            }

            this.isPositionSavePending = isChangePending;
            btnSavePosition.Enabled = isChangePending;
            btnDiscardChanges.Enabled = isChangePending;
            btnAddPosition.Enabled = !isChangePending;
            btnPositionsWFMAG.Enabled = !isChangePending;
        }

        // CONTROLS EVENTS
        #region

        // BUTTONS
        #region
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveAgreement_Click(object sender, EventArgs e)
        {
            if (this.IsAgreementDataValid() && this.IsPositionDataValid())
            {
                this.SaveAgreement();
            }
        }

        private void btnSavePosition_Click(object sender, EventArgs e)
        {
            this.SavePosition();
        }

        private void btnAddPosition_Click(object sender, EventArgs e)
        {
            this.AddPosition();
        }        

        private void btnRemovePosition_Click(object sender, EventArgs e)
        {
            if (gridExPositions.Row > -1)
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczoną pozycję?\r\nTa operacja jest nieodwracalna!", "Uwaga", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    this.SetPositionChangesPending(false);
                    this.isPositionAddPending = false;
                    this.gridPositionsRepo.DeleteRow(gridExPositions.CurrentRow.RowIndex);
                    gridExPositions.Refetch();
                    this.LoadData();
                }
            }
        }

        private void btnDiscardChanges_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Masz niezapisane zmiany, które utracisz jeśli przeładujesz umowę.\r\nKliknij OK, aby przejść dalej lub Anuluj, aby wrócić i zapisać zmiany.", "Uwaga", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.LoadData();
                btnDiscardChanges.Enabled = false;
            }
        }

        private void btnArticlesWFMAG_Click(object sender, EventArgs e)
        {
            FrmWFMagPicker frmWFMagPicker = new FrmWFMagPicker();
            if (frmWFMagPicker.ShowDialog() == DialogResult.OK)
            {
                gridArticlesRepo.AddRow(new RelatedArticle()
                {
                    AgreementId = this.agreement.Id,
                    KTM = frmWFMagPicker.ChosenKTM,
                    Descriptor = frmWFMagPicker.ChosenDescriptor
                });
            }

            this.SetAgreementChangesPending(true);
        }

        private void btnProductsWFMAG_Click(object sender, EventArgs e)
        {
            FrmWFMagPicker frmWFMagPicker = new FrmWFMagPicker();
            if (frmWFMagPicker.ShowDialog() == DialogResult.OK)
            {
                gridRelatedProductsRepo.AddRow(new RelatedProduct()
                {
                    AgreementPositionId = this.selectedPosition.Id,
                    KTM = frmWFMagPicker.ChosenKTM,
                    Descriptor = frmWFMagPicker.ChosenDescriptor
                });
            }

            this.SetPositionChangesPending(true);
        }

        private void btnDictLicensors_Click(object sender, EventArgs e)
        {
            FrmDictLicensors frmDictLicensors = new FrmDictLicensors();
            frmDictLicensors.ShowDialog();
            this.LoadLicensorsTab();
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            gridExArticles.RootTable.AllowAddNew = InheritableBoolean.True;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            gridExRelatedProducts.RootTable.AllowAddNew = InheritableBoolean.True;
        }

        private void btnAddThreshold_Click(object sender, EventArgs e)
        {
            gridExThresholds.RootTable.AllowAddNew = InheritableBoolean.True;
        }

        private void btnRemoveArticle_Click(object sender, EventArgs e)
        {
            if (gridExArticles.CurrentRow != null && gridExArticles.CurrentRow.RowIndex > -1)
                gridExArticles.CurrentRow.Delete();

            this.SetAgreementChangesPending(true);
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            if (gridExRelatedProducts.CurrentRow != null && gridExRelatedProducts.CurrentRow.RowIndex > -1)
            {
                gridExRelatedProducts.CurrentRow.Delete();
                this.SetPositionChangesPending(true);
            }
        }

        private void btnRemoveThreshold_Click(object sender, EventArgs e)
        {
            if (gridExThresholds.CurrentRow != null && gridExThresholds.CurrentRow.RowIndex > -1)
            {
                this.SetPositionChangesPending(true);
                gridExThresholds.CurrentRow.Delete();
            }
        }

        private void btnAddLicensor_Click(object sender, EventArgs e)
        {
            gridExLicensors.RootTable.AllowAddNew = InheritableBoolean.True;
        }

        private void btnRemoveLicensor_Click(object sender, EventArgs e)
        {
            if (gridExLicensors.CurrentRow != null && gridExLicensors.CurrentRow.RowIndex > -1)
                gridExLicensors.CurrentRow.Delete();

            this.SetAgreementChangesPending(true);
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            gridExSchedule.RootTable.AllowAddNew = InheritableBoolean.True;
        }

        private void btnRemoveSchedule_Click(object sender, EventArgs e)
        {
            if (gridExSchedule.CurrentRow != null && gridExSchedule.CurrentRow.RowIndex > -1)
                gridExSchedule.CurrentRow.Delete();

            this.SetAgreementChangesPending(true);
        }
        #endregion

        // GRIDS
        #region
        private void gridExPositions_SelectionChanged(object sender, EventArgs e)
        {
            // IF SELECTED ROW
            if (!this.isLoadingData && gridExPositions.CurrentRow != null && gridExPositions.CurrentRow.RowIndex > -1)
            {
                if (this.selectedPosition.Id != (int)gridExPositions.CurrentRow.Cells["id"].Value && !this.isCancellingSelection)
                {
                    if (this.isPositionSavePending && !this.isPositionAddPending)
                    {
                        if (MessageBox.Show("Masz niezapisane zmiany na pozycji, które utracisz przechodząc do innej.\r\nKliknij OK, aby przejść dalej lub Anuluj, aby wrócić i zapisać zmiany.", "Uwaga", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            int positionId = (int)gridExPositions.CurrentRow.Cells["id"].Value;
                            this.selectedPosition = AgreementPositionsRepo.GetByID(positionId);
                            this.LoadPositionDetails();
                        }
                        else
                        {
                            this.isCancellingSelection = true;
                            this.SelectPositionById(this.selectedPosition.Id);
                            this.isCancellingSelection = false;
                        }
                    }
                    else
                    {
                        if (this.isPositionAddPending)
                        {
                            if (MessageBox.Show("Nowa pozycja nie została zapisana, utracisz ją jeśli przejdziesz dalej.\r\nKliknij OK, aby przejść dalej lub Anuluj, aby wrócić i zapisać zmiany.", "Uwaga", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                this.gridPositionsRepo.DeleteLastRow();

                                int positionId = (int)gridExPositions.CurrentRow.Cells["id"].Value;
                                this.selectedPosition = AgreementPositionsRepo.GetByID(positionId);
                                this.LoadPositionDetails();
                                this.isPositionAddPending = false;
                            }
                            else
                            {
                                this.isCancellingSelection = true;
                                gridExPositions.MoveLast();
                                this.isCancellingSelection = false;
                            }
                        }
                        else
                        {
                            int positionId = (int)gridExPositions.CurrentRow.Cells["id"].Value;
                            this.selectedPosition = AgreementPositionsRepo.GetByID(positionId);
                            this.LoadPositionDetails();
                        }
                    }
                }
            }
            else
            {
                if (gridExPositions.CurrentRow != null && gridExPositions.CurrentRow.RowIndex > -1)
                {
                    int positionId = (int)gridExPositions.CurrentRow.Cells["id"].Value;
                    this.selectedPosition = AgreementPositionsRepo.GetByID(positionId);
                    this.LoadPositionDetails();
                }
            }
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

            this.SetAgreementChangesPending(true);
        }

        private void gridExArticles_AddingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            gridExArticles.CurrentRow.Cells["UmowaId"].Value = this.agreement.Id;
            gridExArticles.RootTable.AllowAddNew = InheritableBoolean.False;
        }

        private void gridExLicensors_AddingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            gridExLicensors.CurrentRow.Cells["UmowaId"].Value = this.agreement.Id;
            gridExLicensors.RootTable.AllowAddNew = InheritableBoolean.False;
        }

        private void gridExSchedule_AddingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            gridExSchedule.CurrentRow.Cells["UmowaId"].Value = this.agreement.Id;
            gridExSchedule.RootTable.AllowAddNew = InheritableBoolean.False;
        }

        private void gridExThresholds_AddingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            gridExThresholds.CurrentRow.Cells["PozycjaUmowyId"].Value = this.selectedPosition.Id;
            gridExThresholds.RootTable.AllowAddNew = InheritableBoolean.False;
        }

        private void gridExRelatedProducts_AddingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            gridExRelatedProducts.CurrentRow.Cells["PozycjaUmowyId"].Value = this.selectedPosition.Id;
            gridExRelatedProducts.RootTable.AllowAddNew = InheritableBoolean.False;
        }

        private void gridExSchedule_CellValueChanged(object sender, ColumnActionEventArgs e)
        {
            this.SetAgreementChangesPending(true);
        }

        private void gridExPositions_CellValueChanged(object sender, ColumnActionEventArgs e)
        {
            this.SetPositionChangesPending(true);
        }
        #endregion

        private void FrmAgreement_Shown(object sender, EventArgs e)
        {
            gridExPositions.Focus();
        }

        private void FrmAgreement_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.isAgreementSavePending || this.isPositionSavePending)
            {
                e.Cancel = MessageBox.Show("Masz niezapisane zmiany - czy na pewno chcesz wyjść i je utracić?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No;
            }
        }

        private void FrmAgreement_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.parentForm != null)
                this.parentForm.LoadAgreementsList();
        }

        private void tabControlAgreement_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (this.isPositionAddPending || this.isPositionSavePending)
            {
                MessageBox.Show("Masz niezapisane zmiany na pozycji umowy.\r\nDokończ edycję pozycji przed przejściem do kolejnej zakładki.", "Dane pozycji", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = true;
            }
        }

        private void btnPositionsWFMAG_Click(object sender, EventArgs e)
        {
            this.AddPosition();

            FrmWFMagPicker frmWFMagPicker = new FrmWFMagPicker();
            if (frmWFMagPicker.ShowDialog() == DialogResult.OK)
            {
                gridExPositions.CurrentRow.Cells["Tytul"].Value = frmWFMagPicker.ChosenTitle;
                gridExPositions.CurrentRow.Cells["KTM"].Value = frmWFMagPicker.ChosenKTM;
                gridExPositions.CurrentRow.Cells["Deskryptor"].Value = frmWFMagPicker.ChosenDescriptor;

                txtKTM.Text = frmWFMagPicker.ChosenKTM;
                txtDescriptor.Text = frmWFMagPicker.ChosenDescriptor;
            }
        }

        private void dtExpiration_ValueChanged(object sender, EventArgs e)
        {
            if (dtExpiration.Checked)
            {
                dtExpiration.Format = DateTimePickerFormat.Short;
            }
            else
            {
                dtExpiration.Format = DateTimePickerFormat.Custom;
            }

            this.SetPositionChangesPending(true);
        }

        private void cboSettlementModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSettlementModel.SelectedIndex > -1)
            {
                this.LoadModelDetails();
                this.SetPositionChangesPending(true);
            }
        }

        private void dtAdvanceDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtAdvanceDate.Checked)
            {
                dtAdvanceDate.Format = DateTimePickerFormat.Short;
            }
            else
            {
                dtAdvanceDate.Format = DateTimePickerFormat.Custom;
            }

            this.SetAgreementChangesPending(true);
        }

        private void agreementControl_ValueChanged(object sender, EventArgs e)
        {
            this.SetAgreementChangesPending(true);
        }

        private void positionControl_ValueChanged(object sender, EventArgs e)
        {
            this.SetPositionChangesPending(true);
        }

        private void dtBillingPeriodFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtBillingPeriodFrom.Value == dtBillingPeriodFrom.MinDate)
            {
                dtBillingPeriodFrom.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                dtBillingPeriodFrom.Format = DateTimePickerFormat.Short;
            }

            this.SetPositionChangesPending(true);
        }

        private void dtBillingPeriodTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtBillingPeriodTo.Checked)
            {
                dtBillingPeriodTo.Format = DateTimePickerFormat.Short;
            }
            else
            {
                dtBillingPeriodTo.Format = DateTimePickerFormat.Custom;
            }

            this.SetPositionChangesPending(true);
        }
        #endregion        
    }
}
