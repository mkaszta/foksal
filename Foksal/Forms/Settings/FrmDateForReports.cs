using BLL;
using System.Windows.Forms;

namespace Foksal.Forms.Settings
{
    public partial class FrmDateForReports : Form
    {
        public FrmDateForReports()
        {
            InitializeComponent();            
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            AppUser.Instance.DateForReports = dtDateForReports.Value;

            MessageBox.Show("Data została zmieniona.", "Zmiana daty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
