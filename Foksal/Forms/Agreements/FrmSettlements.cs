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

            this.LoadData();
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
            gridExSettlementsList.MoveTo(currentRowId);
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

        private void GenerateReport_Settlement()
        {
            SaveFileDialog saveDialog = new SaveFileDialog { Filter = "Xls File (*.xls)|*.xls|All Files (*.*)|*.*" };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelHelper.CreateReport_SettlementsDetails(gridExSettlementsDetails, saveDialog.FileName);
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

        private void PrepareDraftMail()
        {            
            Licensor licensor = LicensorsRepo.GetById((int)gridExSettlementsDetails.GetDataRows()[1].Cells["tLicencjodawcaId"].Value);

            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string detailsReportPath = string.Format("{0}{1}_RaportZbiorczy.xls", ConfigurationSettings.AppSettings["mail_attachmentDirectory"], timeStamp);
            string shortReportPath = string.Format("{0}{1}_RaportSkrocony.pdf", ConfigurationSettings.AppSettings["mail_attachmentDirectory"], timeStamp);

            List<string> attachments = new List<string>();
            attachments.Add(detailsReportPath);
            attachments.Add(shortReportPath);

            ExcelHelper.CreateReport_SettlementsDetails(gridExSettlementsDetails, detailsReportPath);
            ExcelHelper.CreateReport_Short(gridExSettlementsDetails, shortReportPath);

            OutlookHelper.SaveDraft(attachments, licensor.Email);

            MessageBox.Show("Szkic maila zostal przygotowany wraz załącznikami.", "Eksport do email", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridExSettlementsList_RowCheckStateChanged(object sender, Janus.Windows.GridEX.RowCheckStateChangeEventArgs e)
        {
            btnReportSettlement.Enabled = gridExSettlementsList.GetCheckedRows().Length == 1;

            btnReportShort.Enabled = gridExSettlementsList.GetCheckedRows().Length > 0;
            btnReportSettlementDetails.Enabled = gridExSettlementsList.GetCheckedRows().Length > 0;
            btnMail.Enabled = gridExSettlementsList.GetCheckedRows().Length > 0;

            this.LoadSettlementsDetails();
        }

        private void gridExSettlementsList_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            this.ShowSettlementEditForm();
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            this.datePeriodFrom = dtFrom.Checked ? dtFrom.Value : (DateTime?)null;
            this.LoadData();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            this.datePeriodTo = dtTo.Checked ? dtTo.Value : (DateTime?)null;
            this.LoadData();
        }

        private void btnReportSettlementDetails_Click(object sender, EventArgs e)
        {
            this.GenerateReport_Settlement();
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

        private void btnReportShort_Click(object sender, EventArgs e)
        {
            this.GenerateReport_Short();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            this.PrepareDraftMail();
        }
    }
}
