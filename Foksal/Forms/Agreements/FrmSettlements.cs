using BLL;
using DAL.Grids;
using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmSettlements : Form
    {
        private GridSettlementsListRepo gridSettlementsListRepo;
        private GridSettlementsDetailsRepo gridSettlementsDetailsRepo;

        public FrmSettlements()
        {
            InitializeComponent();

            this.LoadSettlementsList();
            this.LoadSettlementsDetails();
            this.ApplyFilters();
        }

        private void LoadSettlementsList()
        {
            this.gridSettlementsListRepo = new GridSettlementsListRepo();
            gridSettlementsListRepo.BindDataSet(gridExSettlementsList);
        }

        private void LoadSettlementsDetails()
        {
            this.gridSettlementsDetailsRepo = new GridSettlementsDetailsRepo();
            gridSettlementsDetailsRepo.BindDataSet(gridExSettlementsDetails);
            //gridExSettlementsDetails.RootTable.Groups.Clear();
            //gridExSettlementsDetails.RootTable.Groups.Add(new GridEXGroup(this.gridExSettlementsDetails.RootTable.Columns["tRozliczenieUmowyId"]));
        }

        private void ApplyFilters()
        {
            GridEXFilterCondition condition = new GridEXFilterCondition();
            GridEXColumn column = new GridEXColumn();
            List<int> lstId = new List<int>();

            if (gridExSettlementsList.HasCheckedRows)
            {
                foreach (var checkedRow in gridExSettlementsList.GetCheckedRows())
                {
                    lstId.Add((int)checkedRow.Cells["id"].Value);
                }
            }
            else
            {
                lstId.Add(-1);
            }

            gridExSettlementsDetails.RemoveFilters();

            column = gridExSettlementsDetails.RootTable.Columns["tRozliczenieUmowyId"];
            condition = new GridEXFilterCondition(column, ConditionOperator.In, lstId);

            gridExSettlementsDetails.RootTable.ApplyFilter(condition);
        }

        private void gridExSettlementsList_RowCheckStateChanged(object sender, Janus.Windows.GridEX.RowCheckStateChangeEventArgs e)
        {
            this.ApplyFilters();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExcelGenerator.ExportGridEx(gridExSettlementsDetails);
        }
    }
}
