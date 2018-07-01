using DAL.Grids;
using Janus.Windows.GridEX;
using System;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmAgreementsList : Form
    {
        private GridAgreementsListRepo gridListRepo;
        private GridAgreementsListGroupedRepo gridListGroupedRepo;
        private GridEX gridExCurrentList;
        private bool isGridGrouped;
        public FrmAgreementsList()
        {
            InitializeComponent();
            this.SetGridMode(false);

            this.LoadAgreementsList();
        }

        private void SetGridMode(bool groupList)
        {
            this.isGridGrouped = groupList;

            if (this.isGridGrouped)
            {
                this.gridExCurrentList = gridExAgreementsListGrouped;
                this.gridListGroupedRepo = new GridAgreementsListGroupedRepo();
                this.gridListGroupedRepo.BindDataSet(gridExCurrentList);
                this.gridExCurrentList.RootTable.Groups.Clear();
                this.gridExCurrentList.RootTable.Groups.Add(new GridEXGroup(this.gridExCurrentList.RootTable.Columns["IdUmowy"]));
            }
            else
            {
                this.gridExCurrentList = gridExAgreementsList;
                this.gridListRepo = new GridAgreementsListRepo();
                this.gridListRepo.BindDataSet(gridExCurrentList);
                this.gridExCurrentList.RootTable.Groups.Clear();
            }

            gridExAgreementsList.Visible = !this.isGridGrouped;
            gridExAgreementsListGrouped.Visible = this.isGridGrouped;
            btnRemoveAgreement.Enabled = !this.isGridGrouped;

            btnSwitchGridMode.ImageIndex = this.isGridGrouped ? 4 : 3;
        }

        private void LoadAgreementsList()
        {
            if (this.isGridGrouped)
            {
                this.gridListGroupedRepo = new GridAgreementsListGroupedRepo();
                this.gridListGroupedRepo.BindDataSet(gridExCurrentList);
            }
            else
            {
                this.gridListRepo = new GridAgreementsListRepo();
                this.gridListRepo.BindDataSet(gridExCurrentList);
            }
        }

        private void ShowAgreementForm(int agreementId)
        {
            FrmAgreement frmAgreement = new FrmAgreement(agreementId);

            frmAgreement.MdiParent = this.MdiParent;
            frmAgreement.Show();
        }

        private void gridExCurrentList_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            this.ShowAgreementForm(Convert.ToInt32(e.Row.Cells[0].Value));
        }

        private void btnAddAgreement_Click(object sender, EventArgs e)
        {
            this.ShowAgreementForm(0);
        }

        private void btnRemoveAgreement_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć zaznaczoną umowę?\r\nTa operacja jest nieodwracalna!", "Uwaga", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.gridListRepo.DeleteRow(gridExAgreementsList.CurrentRow.RowIndex);
                gridExAgreementsList.Refetch();
            }
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            this.LoadAgreementsList();
        }

        private void btnSwitchGridMode_Click(object sender, EventArgs e)
        {
            this.SetGridMode(!this.isGridGrouped);
            this.LoadAgreementsList();
        }
    }
}
