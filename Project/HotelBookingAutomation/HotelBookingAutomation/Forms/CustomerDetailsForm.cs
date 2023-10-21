using HotelBookingAutomation.Core.Events;
using HotelBookingAutomation.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class CustomerDetailsForm : Form
    {
        public event ObjectEventHandler Action;
        Customer? _customer;
        public CustomerDetailsForm(Customer? customer = null)
        {
            InitializeComponent();
            _customer = customer;
            designToAction();
        }

        private void designToAction()
        {
            if (_customer != null)
            {
                createButton.Enabled = false;
                createButton.Visible = false;
                fillTheAreas();
            }
            else
            {
                updateButton.Enabled = false;
                updateButton.Visible = false;
                deleteButton.Enabled = false;
                deleteButton.Visible = false;
            }
        }

        private void fillTheAreas()
        {
            createCustomerLabel.Text = _customer.FirstName + " Details";
            nameTextBox.Text = _customer.FirstName;
            lastNameTextBox.Text = _customer.LastName;
            emailTextBox.Text = _customer.Email;
            addressTextBox.Text = _customer.Address;
            phoneTextBox.Text = _customer.Phone;
            countryTextBox.Text = _customer.Country;
            zipCodeTextBox.Text = _customer.ZipCode;
            idNoTextBox.Text = _customer.IDNo;
        }

        private bool isFieldsValid()
        {
            var regex = @"\([0-9]{3}\)\s[0-9]{3}-[0-9]{4}";
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text)
                && !string.IsNullOrWhiteSpace(lastNameTextBox.Text)
                && !string.IsNullOrWhiteSpace(emailTextBox.Text)
                && !string.IsNullOrWhiteSpace(addressTextBox.Text)
                && !string.IsNullOrWhiteSpace(countryTextBox.Text)
                && !string.IsNullOrWhiteSpace(zipCodeTextBox.Text)
                && !string.IsNullOrWhiteSpace(idNoTextBox.Text)
                && Regex.IsMatch(phoneTextBox.Text, regex))
            {
                return true;
            }
            else
                return false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (isFieldsValid())
            {
                DialogResult dialogResult = MessageBox.Show($"Do you want to create an customer?", "Create Customer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Customer customer = new()
                    {
                        Email = emailTextBox.Text,
                        LastName = lastNameTextBox.Text,
                        FirstName = nameTextBox.Text,
                        Address = addressTextBox.Text,
                        Phone = phoneTextBox.Text,
                        ZipCode = zipCodeTextBox.Text,
                        Country = countryTextBox.Text,
                        IDNo = idNoTextBox.Text,
                    };
                    Action.Invoke(this, customer, Core.Events.Action.CREATE);
                }

            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (isFieldsValid())
            {
                DialogResult dialogResult = MessageBox.Show($"Do you want to update this: \n {_customer.ID}", "Update Employee", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    _customer.Email = emailTextBox.Text;
                    _customer.LastName = lastNameTextBox.Text;
                    _customer.FirstName = nameTextBox.Text;
                    _customer.IDNo = idNoTextBox.Text;
                    _customer.Address = addressTextBox.Text;
                    _customer.Phone = phoneTextBox.Text;
                    _customer.ZipCode = zipCodeTextBox.Text;
                    _customer.Country = countryTextBox.Text;

                    Action.Invoke(this, _customer, Core.Events.Action.UPDATE);
                }
                else if (dialogResult == DialogResult.No)
                {
                    fillTheAreas();
                }

            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Do you want to update this: \n {_customer.ID}", "Update Employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Action.Invoke(this, _customer, Core.Events.Action.DELETE);
            }
        }
    }
}
