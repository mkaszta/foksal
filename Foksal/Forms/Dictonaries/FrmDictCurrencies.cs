using BLL;
using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
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

        private void gridExCurrencies_SelectionChanged(object sender, System.EventArgs e)
        {
            if (!this.isCurrencyUpdatePending && gridExCurrencies.CurrentRow != null & gridExCurrencies.CurrentRow.RowIndex > -1)
            {
                this.LoadRates((int)gridExCurrencies.CurrentRow.Cells["id"].Value);
            }
        }

        private void btnGetNBPRate_Click(object sender, System.EventArgs e)
        {
            if (NBPHelper.CurrencyExists(gridExCurrencies.CurrentRow.Cells["Waluta"].Value.ToString()))
            {
                CurrencyRate currencyRate = NBPHelper.GetRate(gridExCurrencies.CurrentRow.Cells["Waluta"].Value.ToString());
                CurrenciesRepo.InsertUpdateRate(currencyRate, (int)gridExCurrencies.CurrentRow.Cells["id"].Value);

                this.LoadRates((int)gridExCurrencies.CurrentRow.Cells["id"].Value);

                MessageBox.Show(string.Format("Pobrano kurs na dzień {0}", currencyRate.Date.ToShortDateString()), "Kurs NBP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Waluta nie została odnaleziona w NBP!", "Kurs NBP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridExCurrencies_AddingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.isCurrencyUpdatePending = true;
        }

        private void gridExCurrencies_UpdatingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz Zmienić nazwę waluty?", "Edycja waluty", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                this.isCurrencyUpdatePending = true;
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
        }

        private void gridExCurrencies_RecordUpdated(object sender, System.EventArgs e)
        {
            this.gridCurrenciesRepo.Update();
            this.LoadData();
        }

        private void gridExCurrencies_RecordsDeleted(object sender, System.EventArgs e)
        {
            this.gridCurrenciesRepo.Update();
            this.LoadData();
        }

        private void gridExCurrencyRates_AddingRecord(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.isRateUpdatePending = true;
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
            this.gridCurrencyRatesRepo.Update();
            this.LoadRates((int)gridExCurrencies.CurrentRow.Cells["id"].Value);
        }

        private void gridExCurrencyRates_RecordsDeleted(object sender, System.EventArgs e)
        {
            this.gridCurrencyRatesRepo.Update();
            this.LoadRates((int)gridExCurrencies.CurrentRow.Cells["id"].Value);
        }
    }
}
