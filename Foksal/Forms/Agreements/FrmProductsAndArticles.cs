using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
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

        private bool IsPositionSelected()
        {
            return gridExAgreementsListGrouped.CurrentRow.GroupCaption == null ? true : false;
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

        private void BindKTM()
        {
            if (this.IsPositionSelected())
            {
                string ktm = gridExProductsAndArticles.CurrentRow.Cells["KTM"].Value.ToString();
                string descriptor = gridExProductsAndArticles.CurrentRow.Cells["Deskryptor"].Value.ToString();
                string positionKtm = gridExAgreementsListGrouped.CurrentRow.Cells["KTM"].Value.ToString();
                string positionDescriptor = gridExAgreementsListGrouped.CurrentRow.Cells["Deskryptor"].Value.ToString();
                int agreementId = (int)gridExAgreementsListGrouped.CurrentRow.Cells["IdUmowy"].Value;
                int agreementPositionId = (int)gridExAgreementsListGrouped.CurrentRow.Cells["PozycjaId"].Value;

                if (MessageBox.Show(string.Format("W pozycji:\r\n\r\nKTM:\t\t{0}\r\nDeskryptor:\t{1}\r\n\r\nna umowie {2} zostanie zmieniony parametr:\r\n\r\nKTM:\t\t{3}",
                    positionKtm, positionDescriptor, agreementId.ToString(), ktm), "Przypisanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    AgreementPosition agreementPosition = AgreementPositionsRepo.GetByID(agreementPositionId);
                    agreementPosition.KTM = ktm;

                    AgreementPositionsRepo.InsertUpdate(agreementPosition);

                    MessageBox.Show("KTM został poprawnie zmieniony.", "Przypisanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LoadData();
                }
            }
            else
            {
                MessageBox.Show("Ta opcja wymaga zaznaczenia jednej pozycji umowy.", "Przypisanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BindProduct()
        {
            if (this.IsPositionSelected())
            {
                string ktm = gridExProductsAndArticles.CurrentRow.Cells["KTM"].Value.ToString();
                string descriptor = gridExProductsAndArticles.CurrentRow.Cells["Deskryptor"].Value.ToString();
                string positionKtm = gridExAgreementsListGrouped.CurrentRow.Cells["KTM"].Value.ToString();
                string positionDescriptor = gridExAgreementsListGrouped.CurrentRow.Cells["Deskryptor"].Value.ToString();
                int agreementId = (int)gridExAgreementsListGrouped.CurrentRow.Cells["IdUmowy"].Value;
                int agreementPositionId = (int)gridExAgreementsListGrouped.CurrentRow.Cells["PozycjaId"].Value;

                if (MessageBox.Show(string.Format("Do pozycji:\r\n\r\nKTM:\t\t{0}\r\nDeskryptor:\t{1}\r\n\r\nna umowie {2} zostanie dopisany produkt powiązany:\r\n\r\nKTM:\t\t{3}\r\nDeskryptor:\t{4}",
                    positionKtm, positionDescriptor, agreementId.ToString(), ktm, descriptor), "Przypisanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    RelatedProduct relatedProduct = new RelatedProduct()
                    {
                        AgreementPositionId = agreementPositionId,
                        KTM = ktm,
                        Descriptor = descriptor
                    };

                    AgreementPositionsRepo.InsertRelatedProduct(relatedProduct);

                    MessageBox.Show("Produkt został poprawnie powiązany.", "Przypisanie", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.LoadData();
                }
            }
            else
            {
                MessageBox.Show("Ta opcja wymaga zaznaczenia jednej pozycji umowy.", "Przypisanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BindNewPosition()
        {
            string ktm = gridExProductsAndArticles.CurrentRow.Cells["KTM"].Value.ToString();
            string descriptor = gridExProductsAndArticles.CurrentRow.Cells["Deskryptor"].Value.ToString();
            int agreementId = gridExAgreementsListGrouped.CurrentRow.GroupCaption == null ? (int)gridExAgreementsListGrouped.CurrentRow.Cells["IdUmowy"].Value : Convert.ToInt16(gridExAgreementsListGrouped.CurrentRow.GroupCaption);
            int selectedAgreementRowId = gridExAgreementsListGrouped.CurrentRow.Position;

            if (MessageBox.Show(string.Format("Do umowy {0} zostanie dopisana nowa pozycja:\r\n\r\nKTM:\t\t{1}\r\nDeskryptor:\t{2}", agreementId.ToString(), ktm, descriptor), "Przypisanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                FrmAgreement frmAgreement = new FrmAgreement(agreementId, -1);

                frmAgreement.AddPosition(ktm, descriptor);
                frmAgreement.ShowDialog();
                this.LoadData();
            }
        }

        private void BindArticle()
        {
            string ktm = gridExProductsAndArticles.CurrentRow.Cells["KTM"].Value.ToString();
            string descriptor = gridExProductsAndArticles.CurrentRow.Cells["Deskryptor"].Value.ToString();
            int agreementId = gridExAgreementsListGrouped.CurrentRow.GroupCaption == null ? (int)gridExAgreementsListGrouped.CurrentRow.Cells["IdUmowy"].Value : Convert.ToInt16(gridExAgreementsListGrouped.CurrentRow.GroupCaption);

            if (MessageBox.Show(string.Format("Do umowy {0} zostanie dopisany towar powiązany:\r\n\r\nKTM:\t\t{1}\r\nDeskryptor:\t{2}", agreementId.ToString(), ktm, descriptor), "Przypisanie", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                RelatedArticle relatedArticle = new RelatedArticle()
                {
                    AgreementId = agreementId,
                    KTM = ktm,
                    Descriptor = descriptor,
                    Comments = ""
                };

                AgreementsRepo.InsertRelatedArticle(relatedArticle);

                MessageBox.Show("Towar został poprawnie powiązany.", "Przypisanie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadData();
            }
        }

        private void ShowAgreementForm(int agreementId, int positionId = -1)
        {
            FrmAgreement frmAgreement = new FrmAgreement(agreementId, positionId);

            frmAgreement.MdiParent = this.MdiParent;
            frmAgreement.Show();
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            this.ApplyFilters();
        }

        private void btnBindArticle_Click(object sender, EventArgs e)
        {
            this.BindArticle();
        }

        private void btnBindProduct_Click(object sender, EventArgs e)
        {
            this.BindProduct();
        }

        private void btnBindNewPosition_Click(object sender, EventArgs e)
        {
            this.BindNewPosition();
        }

        private void btnBindKTM_Click(object sender, EventArgs e)
        {
            this.BindKTM();
        }

        private void gridExAgreementsListGrouped_RowDoubleClick(object sender, RowActionEventArgs e)
        {
            if (e.Row.GroupValue != null)
            {
                this.ShowAgreementForm(Convert.ToInt32(e.Row.GroupValue));
            }
            else
            {
                if (sender == gridExAgreementsListGrouped)
                {
                    this.ShowAgreementForm(Convert.ToInt32(e.Row.Cells[0].Value), Convert.ToInt32(e.Row.Cells["PozycjaId"].Value));
                }
                else
                {
                    this.ShowAgreementForm(Convert.ToInt32(e.Row.Cells[0].Value), 0);
                }
            }
        }

        private void gridExAgreementsListGrouped_DoubleClick(object sender, EventArgs e)
        {
            gridExAgreementsListGrouped.ExpandGroups();
        }
    }
}
