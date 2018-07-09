using DAL.Grids;
using System;
using System.Windows.Forms;

namespace Foksal.Forms.Dictonaries
{
    public partial class FrmDictLicensors : Form
    {
        private GridLicensorsRepo gridLicensorsRepo;
        private bool isChangesPending;

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
    }
}
