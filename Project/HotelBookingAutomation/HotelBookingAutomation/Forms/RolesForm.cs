using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingAutomation.Forms
{
    public partial class RolesForm : Form
    {
        IRoleService _roleService;
        Role? _selectedRole;
        public RolesForm(IRoleService roleService)
        {

            InitializeComponent();
            _roleService = roleService;
            _selectedRole = null;
        }

        private async Task FillTheGridAsync()
        {
            var source= await _roleService.GetAllRoles();
            rolesDataGridView.DataSource = new BindingList<Role>(source);
        }

        private async void RolesForm_LoadAsync(object sender, EventArgs e)
        {
            await FillTheGridAsync();
        }

        private async void addRoleButton_Click(object sender, EventArgs e)
        {
            if (roleNameTextBox.Text.Length != 0)
            {
                var role = new Role { RoleName = roleNameTextBox.Text };
                await _roleService.InsertRoleAsync(role);
                await FillTheGridAsync();
                roleNameTextBox.Text = "";
                _selectedRole = null;
            }
            else
            {
                MessageBox.Show("Please fill the Role Name");
            }
        }

        private void rolesDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            enableButtons();
            roleNameTextBox.Text = rolesDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            _selectedRole = new() { ID = Guid.Parse(rolesDataGridView.SelectedRows[0].Cells[0].Value.ToString()) };
        }

        private void RolesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private async void updateRoleButton_Click(object sender, EventArgs e)
        {
            if (_selectedRole != null)
            {
                if (roleNameTextBox.Text.Length != 0)
                {
                    _selectedRole.RoleName = roleNameTextBox.Text;
                    DialogResult dialogResult = MessageBox.Show($"Do you want to update this: \n {_selectedRole.ID}\n {_selectedRole.RoleName}", "Update Role", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        await _roleService.UpdateRoleAsync(_selectedRole);
                        await FillTheGridAsync();

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        _selectedRole = null;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the Role Name");
                }

            }
            roleNameTextBox.Text = "";
            disableButtons();
        }

        private async void deleteRoleButton_Click(object sender, EventArgs e)
        {
            if (_selectedRole != null)
            {
                if (roleNameTextBox.Text.Length != 0)
                {
                    _selectedRole.RoleName = roleNameTextBox.Text;
                    DialogResult dialogResult = MessageBox.Show($"Do you want to delete this: \n {_selectedRole.ID}\n {_selectedRole.RoleName}", "Delete Role", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        await _roleService.DeleteRoleAsync(_selectedRole);
                        await FillTheGridAsync();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        _selectedRole = null;
                    }
                }
                else
                {
                    MessageBox.Show("Please fill the Role Name");
                }
            }
            roleNameTextBox.Text = "";
            disableButtons();
        }

        private void disableButtons()
        {
            deleteRoleButton.Enabled = false;
            deleteRoleButton.Visible = false;
            updateRoleButton.Enabled = false;
            updateRoleButton.Visible = false;
        }

        private void enableButtons()
        {
            deleteRoleButton.Enabled = true;
            deleteRoleButton.Visible = true;
            updateRoleButton.Enabled = true;
            updateRoleButton.Visible = true;
        }

        private async void RolesForm_VisibleChanged(object sender, EventArgs e)
        {
           if(this.Visible)
            {
                await FillTheGridAsync();
            }
            else
            {
                rolesDataGridView.Rows.Clear();
                rolesDataGridView.DataSource = null;
            }
        }
    }
}
