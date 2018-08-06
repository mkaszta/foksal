using BLL;
using BLL.Entities;
using DAL.Grids;
using System;
using System.Windows.Forms;

namespace Foksal.Forms.Reports
{
    public partial class FrmReportFlexible : Form
    {
        private GridReportFlexibleRepo gridReportFlexibleRepo;
        private Report reportType;
        private DateTime? dateFrom;
        private DateTime? dateTo;

        public FrmReportFlexible(Report reportType)
        {
            InitializeComponent();

            this.dateFrom = DateTime.Now.AddMonths(-1);
            this.dateTo = DateTime.Now;

            this.Name = string.Format("Raport: {0}", reportType.Name);

            this.gridReportFlexibleRepo = new GridReportFlexibleRepo();
            this.reportType = reportType;

            this.LoadData();
        }

        private void LoadData()
        {
            this.gridReportFlexibleRepo.BindDataSet(gridExReport, this.reportType, this.dateFrom, this.dateTo);
            gridExReport.RetrieveStructure();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportGridEx(gridExReport);
        }

        private void dtFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtFrom.Checked)
            {
                this.dateFrom = dtFrom.Value;
            }
            else
            {
                this.dateFrom = null;
            }

            this.LoadData();
        }

        private void dtTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtTo.Checked)
            {
                this.dateTo = dtTo.Value;
            }
            else
            {
                this.dateTo = null;
            }

            this.LoadData();
        }
    }
}
