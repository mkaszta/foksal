using BLL;
using DAL.Grids;
using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        }

        private void LoadSettlementsList()
        {
            this.gridSettlementsListRepo = new GridSettlementsListRepo();
            gridSettlementsListRepo.BindDataSet(gridExSettlementsList);
        }

        private void LoadSettlementsDetails()
        {
            List<int> lstRozliczenieUmowyID = new List<int>();

            if (gridExSettlementsList.HasCheckedRows)
            {
                foreach (var checkedRow in gridExSettlementsList.GetCheckedRows())
                {
                    lstRozliczenieUmowyID.Add((int)checkedRow.Cells["id"].Value);
                }
            }
            else
            {
                lstRozliczenieUmowyID.Add(-1);
            }

            this.gridSettlementsDetailsRepo = new GridSettlementsDetailsRepo();
            gridSettlementsDetailsRepo.BindDataSet(gridExSettlementsDetails, lstRozliczenieUmowyID);

            this.ApplyRowFormatting();
        }        

        private void ApplyRowFormatting()
        {
            foreach (var row in gridExSettlementsDetails.GetDataRows())
            {
                if ((int)row.Cells["typ"].Value == 1)
                {
                    row.RowStyle = new GridEXFormatStyle() { BackColor = Color.Honeydew };
                }
            }
        }

        private void gridExSettlementsList_RowCheckStateChanged(object sender, Janus.Windows.GridEX.RowCheckStateChangeEventArgs e)
        {
            this.LoadSettlementsDetails();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportGridEx(gridExSettlementsDetails);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExcelHelper.ExportWorkbookToPdf(@"C:\Users\MegaBit\Downloads\testinterop.xls", @"C:\Users\MegaBit\Downloads\testinterop.pdf");
        }
    }
}
