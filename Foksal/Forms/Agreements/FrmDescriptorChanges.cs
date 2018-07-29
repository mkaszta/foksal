using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
using Janus.Windows.GridEX;
using System;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmDescriptorChanges : Form
    {
        GridDescriptorChangesRepo gridDescriptorChangesRepo;
        GridAgreementsListGroupedRepo GridAgreementsListGroupedRepo;

        public FrmDescriptorChanges()
        {
            InitializeComponent();

            this.gridDescriptorChangesRepo = new GridDescriptorChangesRepo();
            this.GridAgreementsListGroupedRepo = new GridAgreementsListGroupedRepo();

            this.LoadData();
        }

        private void LoadData()
        {
            this.gridDescriptorChangesRepo.BindDataSet(gridExDescriptorChanges);
            this.GridAgreementsListGroupedRepo.BindDataSet(gridExAgreementsListGrouped);

            gridExDescriptorChanges.Focus();
        }

        private void ApplyFilters()
        {
            GridEXFilterCondition condition = new GridEXFilterCondition();
            GridEXColumn column = new GridEXColumn();
            gridExAgreementsListGrouped.RemoveFilters();

            string ktm = gridExDescriptorChanges.CurrentRow.Cells["KTM"].Value.ToString();
            string descriptorOld = gridExDescriptorChanges.CurrentRow.Cells["DESKRYPOTR_OLD"].Value.ToString();
            string findString = string.Format("{0}|{1};", ktm, descriptorOld);

            column = gridExAgreementsListGrouped.RootTable.Columns["Find"];
            condition.AddCondition(new GridEXFilterCondition(column, ConditionOperator.Contains, findString));            

            gridExAgreementsListGrouped.RootTable.ApplyFilter(condition);
        }

        private void ApplyChanges()
        {
            if (gridExAgreementsListGrouped.HasCheckedRows)
            {
                if (gridExDescriptorChanges.CurrentRow.RowIndex > -1)
                {
                    string newDescriptor = gridExDescriptorChanges.CurrentRow.Cells["DESKRYPOTR_NEW"].Value.ToString();
                    string oldDescriptor = gridExDescriptorChanges.CurrentRow.Cells["DESKRYPOTR_OLD"].Value.ToString();

                    if (MessageBox.Show(string.Format("Dla zaznaczonych pozycji zostanie zastosowana poniższa zmiana deskryptora:\r\n\r\nStary:\t\t{0}\r\nNowy:\t\t{1}", oldDescriptor, newDescriptor),
                        "Zmiana", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        DescriptorsRepo descriptorsRepo = new DescriptorsRepo();

                        foreach (GridEXRow row in gridExAgreementsListGrouped.GetCheckedRows())
                        {
                            int positionID = (int)row.Cells["PozycjaId"].Value;
                            int descriptorChangeID = (int)gridExDescriptorChanges.CurrentRow.Cells["id"].Value;

                            descriptorsRepo.ChangeDescriptor(positionID, descriptorChangeID);
                        }

                        MessageBox.Show("Deskryptor został zmieniony dla zaznaczonych pozycji.", "Zmiana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Nie wybrano żadnej zmiany deskryptora.", "Zmiana", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnej docelowej pozycji.", "Zmiana", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ShowAgreementForm(int agreementId, int positionId = -1)
        {
            FrmAgreement frmAgreement = new FrmAgreement(agreementId, positionId);

            frmAgreement.MdiParent = this.MdiParent;
            frmAgreement.Show();
        }

        private void gridExDescriptorChanges_SelectionChanged(object sender, EventArgs e)
        {
            if (gridExDescriptorChanges.CurrentRow != null && gridExDescriptorChanges.CurrentRow.RowIndex > -1)
                this.ApplyFilters();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            this.ApplyChanges();
        }

        private void gridExAgreementsListGrouped_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            this.ShowAgreementForm(Convert.ToInt32(e.Row.Cells["IdUmowy"].Value), Convert.ToInt32(e.Row.Cells["PozycjaId"].Value));
        }
    }
}
