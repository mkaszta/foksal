using BLL.Entities;
using DAL.Repositories;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmAgreement : Form
    {
        private Agreement agreement;
        public FrmAgreement(int agreementID)
        {
            InitializeComponent();

            this.agreement = AgreementsRepo.GetByID(agreementID);

            label1.Text = this.agreement.ReportTitle;
        }
    }
}
