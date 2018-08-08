using DAL.Repositories;
using System.Threading;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmSettlementsRecalculate : Form
    {
        public FrmSettlementsRecalculate()
        {
            InitializeComponent();              
        }

        public void RecalculateSettlements()
        {
            SettlementsRepo.RecalculateSettlements();
            this.Close();
        }

        private void FrmSettlementsRecalculate_Load(object sender, System.EventArgs e)
        {
            ThreadStart threadStart = new ThreadStart(this.RecalculateSettlements);
            Thread thread = new Thread(threadStart);
            thread.Start();
        }
    }
}
