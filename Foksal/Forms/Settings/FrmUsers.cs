﻿using BLL;
using BLL.Entities;
using DAL.Grids;
using DAL.Repositories;
using Janus.Windows.GridEX;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Foksal.Forms.Settings
{
    public partial class FrmUsers : Form
    {
        GridUsersRepo gridUsersRepo;
        GridUserPermissionsRepo gridUserPermissionsRepo;

        public FrmUsers()
        {
            InitializeComponent();

            this.gridUsersRepo = new GridUsersRepo();
            this.gridUserPermissionsRepo = new GridUserPermissionsRepo();

            this.PreparePermissionsGrid();
            this.LoadData();
        }

        private void PreparePermissionsGrid()
        {
            GridEXColumn colLevel = gridExUserPermissions.RootTable.Columns["Poziom"];
            colLevel.HasValueList = true;

            GridEXValueListItemCollection valuesCboLevel = colLevel.ValueList;
            valuesCboLevel.Add(0, "Brak");
            valuesCboLevel.Add(1, "Tylko odczyt");
            valuesCboLevel.Add(2, "Pełne");
        }

        private void LoadData()
        {
            this.gridUsersRepo.BindDataSet(gridExUsers);
            gridExUsers.Refetch();
            gridExUsers.MoveFirst();
        }

        private void LoadUserPermissions()
        {
            this.gridUserPermissionsRepo.BindDataSet(gridExUserPermissions, (int)gridExUsers.CurrentRow.Cells["id"].Value);
            gridExUserPermissions.Refetch();
        }

        private void SavePermissions()
        {
            try
            {
                this.gridUserPermissionsRepo.Update();

                MessageBox.Show("Zmiany zostały zapisane.\r\nNowe uprawnienia zostaną zastosowane przy następnym logowaniu użytkownika.", "Zapis uprawnień", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się zapisać zmian.\r\nSpróbuj ponownie", "Zapis uprawnień", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void gridExUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (gridExUsers.CurrentRow != null && gridExUsers.CurrentRow.RowIndex > -1)
                this.LoadUserPermissions();
        }

        private void btnSavePermissions_Click(object sender, EventArgs e)
        {
            this.SavePermissions();
        }
    }
}
