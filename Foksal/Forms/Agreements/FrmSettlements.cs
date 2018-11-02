using BLL;
using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmSettlements : Form
    {
        private GridSettlementsListRepo gridSettlementsListRepo;
        private GridSettlementsDetailsRepo gridSettlementsDetailsRepo;
        private DateTime? datePeriodFrom;
        private DateTime? datePeriodTo;

        public FrmSettlements()
        {
            InitializeComponent();

            datePeriodFrom = null;
            datePeriodTo = null;

            this.ApplyPermissions();
            this.LoadData();
        }

        private void ApplyPermissions()
        {
            btnEdit.Enabled = AppUser.Instance.CanWriteSettlements;
            btnRecalculate.Enabled = AppUser.Instance.CanWriteSettlements;
        }

        private void LoadData()
        {
            this.LoadSettlementsList();
            this.LoadSettlementsDetails();
        }

        private void LoadSettlementsList()
        {
            this.gridSettlementsListRepo = new GridSettlementsListRepo();
            gridSettlementsListRepo.BindDataSet(gridExSettlementsList, this.datePeriodFrom, this.datePeriodTo);
        }

        private void LoadSettlementsDetails()
        {
            List<int> lstRozliczenieUmowyID = new List<int>();

            if (gridExSettlementsList.HasCheckedRows)
            {
                foreach (var checkedRow in gridExSettlementsList.GetCheckedRows())
                {
                    lstRozliczenieUmowyID.Add((int)checkedRow.Cells["id"].Value);
                }
            }
            else
            {
                lstRozliczenieUmowyID.Add(-1);
            }

            this.gridSettlementsDetailsRepo = new GridSettlementsDetailsRepo();
            gridSettlementsDetailsRepo.BindDataSet(gridExSettlementsDetails, lstRozliczenieUmowyID);

            this.ApplyRowFormatting();
        }

        private void ShowSettlementEditForm()
        {
            int agreementId = (int)gridExSettlementsList.CurrentRow.Cells["Umowa"].Value;
            int settlemenetId = (int)gridExSettlementsList.CurrentRow.Cells["id"].Value;
            Settlement settlement = SettlementsRepo.GetById(settlemenetId);

            FrmSettlementEdit frmSettlementEdit = new FrmSettlementEdit(settlement, agreementId);
            frmSettlementEdit.ShowDialog();

            int currentRowId = (int)gridExSettlementsList.CurrentRow.RowIndex;
            this.LoadSettlementsList();
            gridExSettlementsList.MoveToRowIndex(currentRowId);
        }

        private void ApplyRowFormatting()
        {
            foreach (var row in gridExSettlementsDetails.GetDataRows())
            {
                if ((int)row.Cells["typ"].Value == 1)
                {
                    row.RowStyle = new GridEXFormatStyle() { BackColor = Color.Honeydew };
                }
            }
        }

        private void GenerateReport_Settlement(bool createSumRow)
        {
            SaveFileDialog saveDialog = new SaveFileDialog { Filter = "Xls File (*.xls)|*.xls|All Files (*.*)|*.*" };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelHelper.CreateReport_SettlementsDetails(gridExSettlementsDetails, saveDialog.FileName, createSumRow);
                MessageBox.Show("Eksport danych do pliku został zakończony.", "Eksport do pliku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GenerateReport_Short()
        {
            SaveFileDialog saveDialog = new SaveFileDialog { Filter = "PDF File (*.pdf)|*.pdf|All Files (*.*)|*.*" };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelHelper.CreateReport_Short(gridExSettlementsDetails, saveDialog.FileName);
                MessageBox.Show("Eksport danych do pliku został zakończony.", "Eksport do pliku", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PrepareDraftMail(bool reportHasSumRow)
        {
            Licensor licensor = LicensorsRepo.GetById((int)gridExSettlementsDetails.GetDataRows()[1].Cells["tLicencjodawcaCafreOfId"].Value);

            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string detailsReportPath = string.Format("{0}{1}_RaportZbiorczy.xls", ConfigurationSettings.AppSettings["mail_attachmentDirectory"], timeStamp);
            string shortReportPath = string.Format("{0}{1}_RaportSkrocony.pdf", ConfigurationSettings.AppSettings["mail_attachmentDirectory"], timeStamp);

            List<string> attachments = new List<string>();
            attachments.Add(detailsReportPath);
            attachments.Add(shortReportPath);

            ExcelHelper.CreateReport_SettlementsDetails(gridExSettlementsDetails, detailsReportPath, reportHasSumRow);
            ExcelHelper.CreateReport_Short(gridExSettlementsDetails, shortReportPath);

            OutlookHelper.SaveDraft(attachments, licensor.Email);

            MessageBox.Show("Szkic maila zostal przygotowany wraz załącznikami.", "Eksport do email", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateDispatchInfo()
        {
            Settlement settlement = SettlementsRepo.GetById((int)gridExSettlementsList.GetCheckedRows()[0].Cells["id"].Value);
            Licensor licensor = LicensorsRepo.GetById((int)gridExSettlementsDetails.GetDataRows()[0].Cells["tLicencjodawcaCafreOfId"].Value);

            settlement.Email = licensor.Email;
            settlement.DispatchDate = DateTime.Now;
            SettlementsRepo.Update(settlement);
        }

        private void gridExSettlementsList_RowCheckStateChanged(object sender, Janus.Windows.GridEX.RowCheckStateChangeEventArgs e)
        {
            this.LoadSettlementsDetails();
        }

        private void gridExSettlementsList_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            this.ShowSettlementEditForm();
        }

        private void gridExSettlementsList_RowCountChanged(object sender, EventArgs e)
        {
            if (gridExSettlementsList.GetDataRows().Length <= 20)
            {
                gridExSettlementsList.RootTable.Columns["Selector"].UseHeaderSelector = true;
            }
            else
            {
                gridExSettlementsList.RootTable.Columns["Selector"].UseHeaderSelector = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.ShowSettlementEditForm();
        }

        private void btnRecalculate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy chcesz rozpocząć przeliczanie rozliczeń?\r\nMoże to zająć kilka minut.", "Rozliczenia", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                FrmSettlementsRecalculate frmSettlementsRecalculate = new FrmSettlementsRecalculate();
                frmSettlementsRecalculate.ShowDialog();

                this.LoadData();
            }
        }

        private void btnCollectiveShort_Click(object sender, EventArgs e)
        {
            if (gridExSettlementsDetails.GetDataRows().Length > 0)
            {
                this.GenerateReport_Short();
            }
            else
            {
                MessageBox.Show("Brak danych do raportowania.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCollectiveMail_Click(object sender, EventArgs e)
        {
            if (gridExSettlementsDetails.GetDataRows().Length > 0)
            {
                this.PrepareDraftMail(chkSum.Checked);
            }
            else
            {
                MessageBox.Show("Brak danych do raportowania.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCollectiveReport_Click(object sender, EventArgs e)
        {
            if (gridExSettlementsDetails.GetDataRows().Length > 0)
            {
                this.GenerateReport_Settlement(chkSum.Checked);
            }
            else
            {
                MessageBox.Show("Brak danych do raportowania.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (gridExSettlementsList.CurrentRow != null && gridExSettlementsList.CurrentRow.RowIndex > -1)
            {
                gridExSettlementsList.UnCheckAllRecords();
                gridExSettlementsList.CurrentRow.CheckState = RowCheckState.Checked;
                this.LoadSettlementsDetails();

                this.GenerateReport_Settlement(false);

                this.UpdateDispatchInfo();
                this.ShowSettlementEditForm();
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnego wiersza.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            if (gridExSettlementsList.CurrentRow != null && gridExSettlementsList.CurrentRow.RowIndex > -1)
            {
                gridExSettlementsList.UnCheckAllRecords();
                gridExSettlementsList.CurrentRow.CheckState = RowCheckState.Checked;
                this.LoadSettlementsDetails();

                this.GenerateReport_Short();

                this.UpdateDispatchInfo();
                this.ShowSettlementEditForm();
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnego wiersza.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            if (gridExSettlementsList.CurrentRow != null && gridExSettlementsList.CurrentRow.RowIndex > -1)
            {
                gridExSettlementsList.UnCheckAllRecords();
                gridExSettlementsList.CurrentRow.CheckState = RowCheckState.Checked;
                this.LoadSettlementsDetails();

                this.PrepareDraftMail(false);

                this.UpdateDispatchInfo();
                this.ShowSettlementEditForm();
            }
            else
            {
                MessageBox.Show("Nie zaznaczono żadnego wiersza.", "Brak danych", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.datePeriodFrom = dtFrom.Checked ? dtFrom.Value : (DateTime?)null;
            this.datePeriodTo = dtTo.Checked ? dtTo.Value : (DateTime?)null;
            this.LoadData();
        }

        private void gridExSettlementsDetails_LoadingRow(object sender, RowLoadEventArgs e)
        {
            this.ApplyRowFormatting();
        }
    }
}
