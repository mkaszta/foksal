using BLL;
using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
using System;
using System.Windows.Forms;

namespace Foksal.Forms.Settings
{
    public partial class FrmUsers : Form
    {
        GridUsersRepo gridUsersRepo;

        public FrmUsers()
        {
            InitializeComponent();

            this.gridUsersRepo = new GridUsersRepo();
            this.LoadData();
        }

        private void LoadData()
        {
            this.gridUsersRepo.BindDataSet(gridExUsers);
            gridExUsers.Refetch();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User user = new User();
            FrmUserDetails frmUserDetails = new FrmUserDetails(user);

            if (frmUserDetails.ShowDialog() == DialogResult.OK)
            {
                user.Login = frmUserDetails.Login;
                user.Password = frmUserDetails.Password;

                UsersRepo.Insert(user);
                this.LoadData();

                MessageBox.Show("Użytkownik został poprawnie dodany.", "Nowy użytkownik", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (AppUser.Instance.UserId == (int)gridExUsers.CurrentRow.Cells["id"].Value)
            {
                MessageBox.Show("Nie możesz usunąć swojego użytkownika.", "Usunięcie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show("Czy na pewno chcesz usunąć użytkownika?", "Usunięcie użytkownika", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    UsersRepo.Delete((int)gridExUsers.CurrentRow.Cells["id"].Value);
                    this.LoadData();

                    MessageBox.Show("Użytkownik zostal usunięty.", "Usunięcie użytkownika", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            User user = UsersRepo.GetById((int)gridExUsers.CurrentRow.Cells["id"].Value);
            FrmUserDetails frmUserDetails = new FrmUserDetails(user);

            if (frmUserDetails.ShowDialog() == DialogResult.OK)
            {
                user.Login = frmUserDetails.Login;
                if (frmUserDetails.Password != "")
                    user.Password = frmUserDetails.Password;

                UsersRepo.Update(user);

                this.gridUsersRepo.BindDataSet(gridExUsers);
                gridExUsers.Refetch();

                MessageBox.Show("Użytkownik został zapisany.", "Nowy użytkownik", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
