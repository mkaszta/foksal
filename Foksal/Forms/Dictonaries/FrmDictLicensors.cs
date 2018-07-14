using DAL.Grids;
using DAL.Repositories;
using System;
using System.Windows.Forms;

namespace Foksal.Forms.Dictonaries
{
    public partial class FrmDictLicensors : Form
    {
        private GridLicensorsRepo gridLicensorsRepo;
        private bool isChangesPending;
        private int mergeSourceId;
        private int mergeTargetId;

        public FrmDictLicensors()
        {
            InitializeComponent();

            this.gridLicensorsRepo = new GridLicensorsRepo();

            this.LoadData();
        }

        private void LoadData()
        {
            this.gridLicensorsRepo.BindDataSet(gridExLicensors);
            isChangesPending = false;

            this.SetChangesPending(false);
        }

        private void SetChangesPending(bool changesPending)
        {
            this.isChangesPending = changesPending;
            btnSave.Enabled = changesPending;
            btnRefreshList.Enabled = changesPending;
        }

        private void SaveChanges()
        {
            try
            {
                this.gridLicensorsRepo.Update();
                this.SetChangesPending(false);

                MessageBox.Show("Zmiany zostały zapisane", "Zapis słownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać zmian w słowniku.\r\nSpróbuj ponownie", "Zapis słownika", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRow()
        {
            gridExLicensors.CurrentRow.Delete();
            this.SetChangesPending(true);
        }

        private void ActivateMergeButton()
        {
            if (this.mergeSourceId > 0 && this.mergeTargetId > 0)
                btnMergeStart.Enabled = true;
        }

        private void MergeLicensors()
        {
            if (MessageBox.Show(string.Format("Poniższy licencjodawca zostanie usunięty:\r\n{0},\r\na jego umowy zostaną przepisane na:\r\n{1}\r\n\r\nCzy chcesz kontynuować?", lblSource.Text, lblTarget.Text),
                "Scalanie licencjodawców", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                LicensorsRepo.Merge(this.mergeSourceId, this.mergeTargetId);

                MessageBox.Show("Licencjodawcy zostali scaleni.", "Scalanie licencjodawców", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnMergeStart.Enabled = false;
                lblSource.Text = "(nie wybrano)";
                lblTarget.Text = "(nie wybrano)";
                this.mergeSourceId = 0;
                this.mergeTargetId = 0;

                this.LoadData();
            }
        }

        private void btnSavePosition_Click(object sender, System.EventArgs e)
        {
            this.SaveChanges();
        }

        private void gridExLicensors_CellValueChanged(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            this.SetChangesPending(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
        }

        private void gridExLicensors_RecordsDeleted(object sender, EventArgs e)
        {
            this.SetChangesPending(true);
        }

        private void gridExLicensors_RecordAdded(object sender, EventArgs e)
        {
            this.SetChangesPending(true);
            gridExLicensors.MoveLast();
            gridExLicensors.VerticalScrollPosition = 10000;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            this.DeleteRow();
        }

        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Odświeżając listę, utracisz wszystkie niezapisane zmiany.\r\nCzy chcesz kontynuować?", "Odśwież listę", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.LoadData();
            }
        }

        private void btnMergeSource_Click(object sender, EventArgs e)
        {
            this.mergeSourceId = (int)gridExLicensors.CurrentRow.Cells["id"].Value;
            lblSource.Text = string.Format("{0} {1} {2}", gridExLicensors.CurrentRow.Cells["Imie"].Value, gridExLicensors.CurrentRow.Cells["Nazwisko"].Value, gridExLicensors.CurrentRow.Cells["Nazwa"].Value);

            this.ActivateMergeButton();
        }

        private void btnMergeTarget_Click(object sender, EventArgs e)
        {
            this.mergeTargetId = (int)gridExLicensors.CurrentRow.Cells["id"].Value;
            lblTarget.Text = string.Format("{0} {1} {2}", gridExLicensors.CurrentRow.Cells["Imie"].Value, gridExLicensors.CurrentRow.Cells["Nazwisko"].Value, gridExLicensors.CurrentRow.Cells["Nazwa"].Value);

            this.ActivateMergeButton();
        }

        private void btnMergeStart_Click(object sender, EventArgs e)
        {
            if (this.mergeSourceId != this.mergeTargetId)
                this.MergeLicensors();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            gridExLicensors.RootTable.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
        }

        private void gridExLicensors_AddingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.isChangesPending = true;
            gridExLicensors.RootTable.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;            
        }
    }
}
