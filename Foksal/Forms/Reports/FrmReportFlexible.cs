using BLL;
using BLL.Entities;
using DAL.Grids;
using Janus.Windows.GridEX;
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

            dtFrom.Value = DateTime.Now.AddMonths(-1);
            dtTo.Value = DateTime.Now;

            this.Name = string.Format("Raport: {0}", reportType.Name);

            this.gridReportFlexibleRepo = new GridReportFlexibleRepo();
            this.reportType = reportType;

            this.LoadData();
        }

        private void LoadData()
        {
            this.gridReportFlexibleRepo.BindDataSet(gridExReport, this.reportType, this.dateFrom, this.dateTo);

            gridExReport.RetrieveStructure();
            this.FormatGrid();
        }

        private void FormatGrid()
        {
            gridExReport.RootTable.Columns["DataFiltr"].Visible = false;

            foreach (GridEXColumn column in gridExReport.RootTable.Columns)
            {
                if (column.FormatString == "c")
                    column.FormatString = "";
            }
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportGridEx(gridExReport);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (dtTo.Checked)
            {
                this.dateTo = dtTo.Value;
            }
            else
            {
                this.dateTo = null;
            }

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
    }
}
