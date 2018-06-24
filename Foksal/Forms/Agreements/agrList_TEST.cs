using DAL.Grids;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class agrList_TEST : Form
    {
        public agrList_TEST()
        {
            InitializeComponent();

            GridAgreementsListTESTRepo gridAgreementsListTESTRepo = new GridAgreementsListTESTRepo();
            gridAgreementsListTESTRepo.BindDataSet(gridExAgreementsList_TEST);
        }
    }
}
