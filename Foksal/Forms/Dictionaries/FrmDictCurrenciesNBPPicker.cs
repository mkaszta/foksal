using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foksal.Forms.Dictionaries
{    
    public partial class FrmDictCurrenciesNBPPicker : Form
    {
        public DateTime dateFrom;
        public DateTime dateTo;

        public FrmDictCurrenciesNBPPicker()
        {
            InitializeComponent();

            dateFrom = DateTime.Today;
            dateTo = DateTime.Today;            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dateFrom = dtFrom.Value;
            dateTo = dtTo.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
