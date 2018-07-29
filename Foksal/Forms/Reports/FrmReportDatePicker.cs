using System;
using System.Windows.Forms;

namespace Foksal.Forms.Reports
{
    public partial class FrmReportDatePicker : Form
    {
        public DateTime? dateFrom;
        public DateTime? dateTo;

        public FrmReportDatePicker()
        {
            InitializeComponent();

            dateFrom = DateTime.Today;
            dateTo = DateTime.Today;            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dateFrom = dtFrom.Checked ? dtFrom.Value : (DateTime?)null;
            dateTo = dtTo.Checked ? dtTo.Value : (DateTime?)null;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
