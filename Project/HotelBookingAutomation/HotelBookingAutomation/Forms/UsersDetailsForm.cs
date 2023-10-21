using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.Core.Events;
using HotelBookingAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingAutomation.Forms
{
    public partial class UsersDetailsForm : Form
    {
        public event ObjectEventHandler Action;
        User? _user;
        Guid? _roleId = null;
        readonly Dictionary<string, Guid> roles = new() {
            { "Supervisor",Guid.Parse("5432fe60-2dd4-49f5-9e0d-e137d5238ceb")},
            {"Front Desk",Guid.Parse("e994bbd2-7f09-4114-a397-aadb26018daf") }
        };
        public UsersDetailsForm(User? user = null)
        {
            InitializeComponent();
            _user = user;
            designToAction();
        }

        private void designToAction()
        {
            if (_user != null)
            {
                passwordGroupBox.Enabled = false;
                passwordGroupBox.Visible = false;
                createButton.Enabled = false;
                createButton.Visible = false;
                fillTheAreas();
            }
            else
            {
                updatePasswordGroupBox.Enabled = false;
                updatePasswordGroupBox.Visible = false;
                updateButton.Enabled = false;
                updateButton.Visible = false;
                deleteButton.Enabled = false;
                deleteButton.Visible = false;
            }
        }
        private void fillTheAreas()
        {
            createUserLabel.Text = _user.Username + " Details";
            nameTextBox.Text = _user.FirstName;
            lastNameTextBox.Text = _user.LastName;
            emailTextBox.Text = _user.Email;
            addressTextBox.Text = _user.Address;
            phoneTextBox.Text = _user.Phone;
            usernameTextBox.Text = _user.Username;
        }

        private void updatePasswordButton_Click(object sender, EventArgs e)
        {
            if (newPasswordTextBox.Text.Replace(" ", "") != String.Empty)
            {
                DialogResult dialogResult = MessageBox.Show($"Do you want to change this: \n {_user.ID}'password", "Change Employee Password", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UserPasswordToUpdateDto user = new() { ID = _user.ID, Password = newPasswordTextBox.Text };
                    Action.Invoke(this, user, Core.Events.Action.PARTIAL_UPDATE);
                }
                else
                {
                    newPasswordTextBox.Text = String.Empty;
                }
                    
            }
            else
            {
                MessageBox.Show("New password Cannot be empty");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Do you want to delete this: \n {_user.ID}", "Delete Employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Action.Invoke(this, _user, Core.Events.Action.DELETE);
            }    
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                _roleId = roles[radioButton.Text];
            }
        }

        private bool isFieldsValid()
        {
            var regex = @"\([0-9]{3}\)\s[0-9]{3}-[0-9]{4}";
            if (!string.IsNullOrWhiteSpace(emailTextBox.Text)
                && !string.IsNullOrWhiteSpace(nameTextBox.Text)
                && !string.IsNullOrWhiteSpace(lastNameTextBox.Text)
                && !string.IsNullOrWhiteSpace(addressTextBox.Text)
                && !string.IsNullOrWhiteSpace(usernameTextBox.Text)
                && Regex.IsMatch(phoneTextBox.Text, regex))
            {
                if (_user == null)
                {
                    if (_roleId == null)
                        return false;
                    if (string.IsNullOrWhiteSpace(passwordTextBox.Text) || string.IsNullOrWhiteSpace(confirmPasswordTextBox.Text))
                        return false;
                    else if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                        return false;
                    else
                        return true;
                }
                else
                   return true;
            }
            return false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (isFieldsValid())
            {
                DialogResult dialogResult = MessageBox.Show($"Do you want to create an employee?", "Create Employee", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    UserToRegisterDto user = new()
                    {
                        Email = emailTextBox.Text,
                        LastName = lastNameTextBox.Text,
                        FirstName = nameTextBox.Text,
                        Username = usernameTextBox.Text,
                        Address = addressTextBox.Text,
                        Phone = phoneTextBox.Text,
                        Password = passwordTextBox.Text,
                        RoleID = (Guid)_roleId!,
                    };
                    Action.Invoke(this, user, Core.Events.Action.CREATE);
                }
                    
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(isFieldsValid())
            {
                DialogResult dialogResult = MessageBox.Show($"Do you want to update this: \n {_user.ID}", "Update Employee", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    _user.Email = emailTextBox.Text;
                    _user.LastName = lastNameTextBox.Text;
                    _user.FirstName = nameTextBox.Text;
                    _user.Username = usernameTextBox.Text;
                    _user.Address = addressTextBox.Text;
                    _user.Phone = phoneTextBox.Text;
                    _user.RoleID = _roleId ?? _user.RoleID;

                    Action.Invoke(this, _user, Core.Events.Action.UPDATE);
                }
                else if (dialogResult == DialogResult.No)
                {
                    fillTheAreas();
                    supervisorValue.Checked=false;
                    frontDeskValue.Checked=false;
                    _roleId = null;
                }
                
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }
    }
}
