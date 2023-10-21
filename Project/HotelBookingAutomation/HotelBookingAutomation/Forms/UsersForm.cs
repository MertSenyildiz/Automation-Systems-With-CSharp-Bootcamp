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
    public partial class UsersForm : Form
    {
        private bool _isFormCreated = false;
        IUserService _userService;
        IAuthService _authService;
        public UsersForm(IUserService userService, IAuthService authService)
        {
            InitializeComponent();
            _userService = userService;
            _authService = authService;
        }

        private async Task FillTheGridAsync()
        {
            List<UserWithAllDetailsDto> source;
            if (userSearchTextBox.Text.Replace(" ", "") == String.Empty)
            {
                source = await _userService.GetAllUsersWithDetailsAsync() as List<UserWithAllDetailsDto>;
            }
            else
            {
                source = await _userService.GetAllUsersWithDetailsBySearchTermAsync(userSearchTextBox.Text) as List<UserWithAllDetailsDto>;
            }
            usersDataGridView.DataSource = new BindingList<UserWithAllDetailsDto>(source);
        }

        private void UsersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private async void UsersForm_Load(object sender, EventArgs e)
        {
            await FillTheGridAsync();
        }

        private async void userSearchButton_Click(object sender, EventArgs e)
        {
            await FillTheGridAsync();
        }

        private void userCreateButton_Click(object sender, EventArgs e)
        {
            opeUserDetailsForm(null);
        }

        private async void usersDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = usersDataGridView.Columns["Username"].Index;
            var selectedUsername = usersDataGridView.SelectedRows[0].Cells[index].Value.ToString();
            var user = await _userService.GetUserByUsernameAsync(selectedUsername);
            opeUserDetailsForm(user);
        }

        private void opeUserDetailsForm(User? user)
        {
            if (!_isFormCreated)
            {
                _isFormCreated = true;
                var form = new UsersDetailsForm(user);
                form.Action += Form_Action;
                form.FormClosing += (e, s) => { _isFormCreated = false; };
                form.Show();
            }
            else
            {
                MessageBox.Show("One instance already present!");
            }
        }

        private async void Form_Action(object sender, object obj, Core.Events.Action action)
        {
            switch (action)
            {
                case Core.Events.Action.CREATE:
                    await insertUser((Form)sender, (UserToRegisterDto)obj);
                    break;
                case Core.Events.Action.UPDATE:
                    await updateUser((Form)sender, (User)obj);
                    break;
                case Core.Events.Action.PARTIAL_UPDATE:
                    await updateUserPassword((Form)sender,(UserPasswordToUpdateDto)obj);
                    break;
                case Core.Events.Action.DELETE:
                    await deleteUser((Form)sender, (User)obj);
                    break;
                default: 
                    break;
            }
            await FillTheGridAsync();
        }
        private async Task updateUserPassword(Form sender, UserPasswordToUpdateDto newPasswordUser)
        {
            await _authService.UpdatePasswordAsync(newPasswordUser);
            sender.Close();
        }
        private async Task deleteUser(Form sender,User user)
        {
            await _userService.DeleteUserAsync(user);
            sender.Close();
        }

        private async Task insertUser(Form sender,UserToRegisterDto user)
        {
            await _authService.Register(user);
            sender.Close();
        }

        private async Task updateUser(Form sender,User user)
        {
            await _userService.UpdateUserAsync(user);
            sender.Close();
        }
    }
}
