using DAL.Grids;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmWFMagPicker : Form
    {
        private GridWFMagPickerRepo gridWFMagPickerRepo;

        public string ChosenKTM { get; set; }
        public string ChosenDescriptor { get; set; }
        public string ChosenTitle { get; set; }

        public FrmWFMagPicker()
        {
            InitializeComponent();

            this.gridWFMagPickerRepo = new GridWFMagPickerRepo();
            this.LoadData();
        }

        private void LoadData()
        {
            if (rdbRelated.Checked)
            {
                this.gridWFMagPickerRepo.BindDataSet_Related(gridExWFMagPicker);
            }
            else
            {
                this.gridWFMagPickerRepo.BindDataSet_Unrelated(gridExWFMagPicker);
            }            
        }

        private void ReturnData()
        {
            this.ChosenDescriptor = (gridExWFMagPicker.CurrentRow.Cells["Deskryptor"].Value ?? string.Empty).ToString();
            this.ChosenKTM = (gridExWFMagPicker.CurrentRow.Cells["KTM"].Value ?? string.Empty).ToString();
            this.ChosenTitle = (gridExWFMagPicker.CurrentRow.Cells["Tytuł"].Value ?? string.Empty).ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPick_Click(object sender, System.EventArgs e)
        {
            this.ReturnData();
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void rdb_CheckedChanged(object sender, System.EventArgs e)
        {            
            this.LoadData();
        }

        private void gridExWFMagPicker_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            this.ReturnData();
        }
    }
}
