using DAL.Grids;
using Janus.Windows.GridEX;
using System;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmProductsAndArticles : Form
    {
        GridProductsAndArticlesRepo gridProductsAndArticlesRepo;
        GridAgreementsListGroupedRepo gridAgreementsListGroupedRepo;

        public FrmProductsAndArticles()
        {
            InitializeComponent();

            this.gridProductsAndArticlesRepo = new GridProductsAndArticlesRepo();
            this.gridAgreementsListGroupedRepo = new GridAgreementsListGroupedRepo();

            this.LoadData();
        }

        private void LoadData()
        {
            this.gridProductsAndArticlesRepo.BindDataSet(gridExProductsAndArticles);

            this.gridAgreementsListGroupedRepo.BindDataSet(gridExAgreementsListGrouped);
            gridExAgreementsListGrouped.RootTable.Groups.Clear();
            gridExAgreementsListGrouped.RootTable.Groups.Add(new GridEXGroup(this.gridExAgreementsListGrouped.RootTable.Columns["IdUmowy"]));
        }

        private void ApplyFilters()
        {
            GridEXFilterCondition condition = new GridEXFilterCondition();
            GridEXColumn column = new GridEXColumn();
            gridExAgreementsListGrouped.RemoveFilters();

            if (rdbKTM.Checked)
            {
                column = gridExAgreementsListGrouped.RootTable.Columns["KTM"];
                condition = new GridEXFilterCondition(column, ConditionOperator.Equal, gridExProductsAndArticles.CurrentRow.Cells["KTM"].Text);                
            }
            else if (rdbDescriptor.Checked)
            {
                column = gridExAgreementsListGrouped.RootTable.Columns["Deskryptor"];
                condition = new GridEXFilterCondition(column, ConditionOperator.Equal, gridExProductsAndArticles.CurrentRow.Cells["Deskryptor"].Text);
            }

            gridExAgreementsListGrouped.RootTable.ApplyFilter(condition);
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            this.ApplyFilters();
        }        
    }
}
