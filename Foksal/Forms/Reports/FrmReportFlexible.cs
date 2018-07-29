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

        public FrmReportFlexible(Report reportType, DateTime? dateFrom, DateTime? dateTo)
        {
            InitializeComponent();

            this.dateFrom = dateFrom;
            this.dateTo = dateTo;

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

        private void btnExportToExcel_Click(object sender, System.EventArgs e)
        {
            ExcelGenerator.ExportGridEx(gridExReport);
        }
    }
}
