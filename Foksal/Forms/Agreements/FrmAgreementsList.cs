using DAL.Grids;
using System;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmAgreementsList : Form
    {        
        public FrmAgreementsList()
        {
            InitializeComponent();

            GridAgreementsListRepo gridRepo = new GridAgreementsListRepo();
            gridRepo.BindDataSet(gridExAgreementsList);            
        }

        private void gridExAgreementsList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            FrmAgreement frmAgreement = new FrmAgreement(Convert.ToInt32(e.Row.Cells[0].Value));

            frmAgreement.MdiParent = this.MdiParent;
            frmAgreement.Show();
        }
    }
}
