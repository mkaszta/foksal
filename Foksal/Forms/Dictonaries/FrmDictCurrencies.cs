using BLL;
using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
using Janus.Data;
using Janus.Windows.GridEX;
using System;
using System.Windows.Forms;

namespace Foksal.Forms.Dictonaries
{
    public partial class FrmDictCurrencies : Form
    {
        private GridCurrenciesRepo gridCurrenciesRepo;
        private GridCurrencyRatesRepo gridCurrencyRatesRepo;
        private bool isCurrencyUpdatePending;
        private bool isRateUpdatePending;

        public FrmDictCurrencies()
        {
            InitializeComponent();

            this.gridCurrenciesRepo = new GridCurrenciesRepo();
            this.gridCurrencyRatesRepo = new GridCurrencyRatesRepo();

            this.LoadData();
        }

        private void LoadData()
        {
            this.isCurrencyUpdatePending = true;
            this.gridCurrenciesRepo.BindDataSet(gridExCurrencies);
            this.isCurrencyUpdatePending = false;
        }

        private void LoadRates(int currencyId)
        {
            this.gridCurrencyRatesRepo.BindDataSet(gridExCurrencyRates, currencyId);
        }

        private void GetNBPRates()
        {
            DateTime currencyDate = new DateTime();

            foreach (GridEXRow row in gridExCurrencies.GetRows())
            {
                string currencyName = row.Cells["Waluta"].Value.ToString();

                if (NBPHelper.CurrencyExists(currencyName))
                {
                    CurrencyRate currencyRate = NBPHelper.GetRate(currencyName);
                    currencyDate = currencyRate.Date;
                    CurrenciesRepo.Insert(currencyRate, (int)row.Cells["Id"].Value);
                }
                else
                {
                    MessageBox.Show(string.Format("Waluta {0} nie została odnaleziona w NBP!", currencyName), "Kurs NBP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.LoadRates((int)gridExCurrencies.CurrentRow.Cells["id"].Value);
            MessageBox.Show(string.Format("Pobrano kursy na dzień {0}", currencyDate.ToShortDateString()), "Kurs NBP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridExCurrencies_SelectionChanged(object sender, System.EventArgs e)
        {
            if (!this.isCurrencyUpdatePending && gridExCurrencies.CurrentRow != null & gridExCurrencies.CurrentRow.RowIndex > -1)
            {
                this.LoadRates((int)gridExCurrencies.CurrentRow.Cells["id"].Value);
            }
        }

        private void btnGetNBPRate_Click(object sender, System.EventArgs e)
        {
            this.GetNBPRates();
        }

        private void gridExCurrencies_AddingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.isCurrencyUpdatePending = true;
            gridExCurrencies.RootTable.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
        }

        private void gridExCurrencies_UpdatingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zmienić nazwę waluty?", "Edycja waluty", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.isCurrencyUpdatePending = true;
            }
            else
            {
                this.LoadData();
                e.Cancel = true;
            }
        }

        private void gridExCurrencies_DeletingRecord(object sender, Janus.Windows.GridEX.RowActionCancelEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć walutę?", "Usuwanie waluty", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.isRateUpdatePending = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void gridExCurrencies_RecordAdded(object sender, System.EventArgs e)
        {
            this.gridCurrenciesRepo.Update();
            this.LoadData();
            gridExCurrencies.MoveLast();
        }

        private void gridExCurrencies_RecordUpdated(object sender, System.EventArgs e)
        {
            int updatingRowId = gridExCurrencies.CurrentRow.RowIndex;
            this.gridCurrenciesRepo.Update();
            this.LoadData();
            gridExCurrencies.MoveTo(updatingRowId);
        }

        private void gridExCurrencies_RecordsDeleted(object sender, System.EventArgs e)
        {
            this.gridCurrenciesRepo.Update();
            this.LoadData();
        }

        private void gridExCurrencyRates_AddingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.isRateUpdatePending = true;
            gridExCurrencyRates.RootTable.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.False;
            gridExCurrencyRates.CurrentRow.Cells["walutaId"].Value = (int)gridExCurrencies.CurrentRow.Cells["id"].Value;
        }

        private void gridExCurrencyRates_UpdatingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zaktualizować kurs?", "Aktualizacja kursu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.isRateUpdatePending = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void gridExCurrencyRates_DeletingRecord(object sender, Janus.Windows.GridEX.RowActionCancelEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć kurs?", "Usuwanie kursu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.isRateUpdatePending = true;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void gridExCurrencyRates_RecordAdded(object sender, System.EventArgs e)
        {
            this.gridCurrencyRatesRepo.Update();
            this.LoadRates((int)gridExCurrencies.CurrentRow.Cells["id"].Value);
        }

        private void gridExCurrencyRates_RecordUpdated(object sender, System.EventArgs e)
        {
            int updatingRowId = gridExCurrencyRates.CurrentRow.RowIndex;
            this.gridCurrencyRatesRepo.Update();
            this.LoadRates((int)gridExCurrencies.CurrentRow.Cells["id"].Value);
            gridExCurrencyRates.MoveTo(updatingRowId);
        }

        private void gridExCurrencyRates_RecordsDeleted(object sender, System.EventArgs e)
        {
            this.gridCurrencyRatesRepo.Update();
            this.LoadRates((int)gridExCurrencies.CurrentRow.Cells["id"].Value);
        }

        private void btnAddCurrency_Click(object sender, System.EventArgs e)
        {
            gridExCurrencies.RootTable.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
        }

        private void btnAddRate_Click(object sender, System.EventArgs e)
        {
            gridExCurrencyRates.RootTable.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
        }

        private void btnRemoveCurrency_Click(object sender, System.EventArgs e)
        {
            if (gridExCurrencies.CurrentRow.RowIndex > -1)
            {
                if (gridExCurrencyRates.RowCount > 0)
                {
                    MessageBox.Show("Nie można usunąć waluty - najpierw usuń wszystkie jej kursy.", "Usuwanie waluty", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    gridExCurrencies.Delete();
                }
            }
        }

        private void btnRemoveRate_Click(object sender, System.EventArgs e)
        {
            if (gridExCurrencyRates.CurrentRow.RowIndex > -1)
                gridExCurrencyRates.Delete();
        }
    }
}
