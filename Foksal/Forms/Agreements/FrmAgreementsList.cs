using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foksal.Forms.Agreements
{
    public partial class FrmAgreementsList : Form
    {
        DBConnection dbConnection = new DBConnection();
        DataSet dataSetAgreements = new DataSet("dataSetAgreements");
        DataTable dataTableAgreements = new DataTable("dataTableAgreements");
        SqlDataAdapter dataAdapterAgreements = new SqlDataAdapter();

        public FrmAgreementsList()
        {
            InitializeComponent();

            BindDataSetAgreements();
        }

        private void BindDataSetAgreements()
        {
            dataTableAgreements.Clear();

            SqlCommand cmdSelect = new SqlCommand();
            cmdSelect.Connection = dbConnection.Connection;
            cmdSelect.CommandType = CommandType.Text;
            cmdSelect.CommandText = "SELECT id, Tytul, Autor, TytulOryginal, Zaliczka, ZaliczkaData, Uwagi FROM [dbo].[Umowa]";
            dataAdapterAgreements.SelectCommand = cmdSelect;

            dataAdapterAgreements.Fill(dataTableAgreements);
            gridExAgreementsList.DataSource = dataTableAgreements;
        }

        private void gridExAgreementsList_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            FrmAgreement frmAgreement = new FrmAgreement(Convert.ToInt32(e.Row.Cells[0].Value));

            frmAgreement.MdiParent = this.MdiParent;
            frmAgreement.Show();
        }
    }
}
