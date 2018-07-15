using BLL;
using BLL.Entities;
using DAL.Grids;
using System.Windows.Forms;

namespace Foksal.Forms.Reports
{
    public partial class FrmReportFlexible : Form
    {
        private GridReportFlexibleRepo gridReportFlexibleRepo;
        private Report reportType;

        public FrmReportFlexible(Report reportType)
        {
            InitializeComponent();

            this.Name = string.Format("Raport: {0}", reportType.Name);

            this.gridReportFlexibleRepo = new GridReportFlexibleRepo();
            this.reportType = reportType;

            this.LoadData();
        }

        private void LoadData()
        {
            this.gridReportFlexibleRepo.BindDataSet(gridExReport, this.reportType);
            gridExReport.RetrieveStructure();
        }

        private void btnExportToExcel_Click(object sender, System.EventArgs e)
        {
            ExcelGenerator.ExportGridEx(gridExReport);
        }
    }
}
