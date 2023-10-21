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
    public partial class CustomersForm : Form
    {
        private bool _isFormCreated = false;
        ICustomerService _customerService;
        public CustomersForm(ICustomerService customerService)
        {
            InitializeComponent();
            _customerService = customerService;
        }

        private async Task FillTheGridAsync()
        {
            List<Customer> source;
            if (string.IsNullOrWhiteSpace(customerSearchTextBox.Text))
            {
                source = await _customerService.GetAllCustomersAsync() as List<Customer>;
            }
            else
            {
                source = await _customerService.GetAllCustomersBySearchTermAsync(customerSearchTextBox.Text) as List<Customer>;
            }
            customersDataGridView.DataSource = new BindingList<Customer>(source);
        }

        private void CustomersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private async void CustomersForm_Load(object sender, EventArgs e)
        {
            await FillTheGridAsync();
        }

        private async void customerSearchButton_Click(object sender, EventArgs e)
        {
            await FillTheGridAsync();
        }

        private void openCustomerDetailsForm(Customer? customer)
        {
            if (!_isFormCreated)
            {
                _isFormCreated = true;
                var form = new CustomerDetailsForm(customer);
                form.Action += Form_ActionAsync;
                form.FormClosing += (e, s) => { _isFormCreated = false; };
                form.Show();
            }
            else
            {
                MessageBox.Show("One instance already present!");
            }
        }

        private async void Form_ActionAsync(object sender, object obj, Core.Events.Action action)
        {
            switch (action)
            {
                case Core.Events.Action.CREATE:
                    await insertCustomer((Form)sender, (Customer)obj);
                    break;
                case Core.Events.Action.UPDATE:
                    await updateCustomer((Form)sender, (Customer)obj);
                    break;
                case Core.Events.Action.DELETE:
                    await deleteCustomer((Form)sender, (Customer)obj);
                    break;
                default:
                    break;
            }
            await FillTheGridAsync();
        }

        private async Task deleteCustomer(Form sender, Customer obj)
        {
            await _customerService.DeleteCustomerAsync(obj);
            sender.Close();
        }

        private async Task updateCustomer(Form sender, Customer obj)
        {
            await _customerService.UpdateCustomerAsync(obj);
            sender.Close();
        }

        private async Task insertCustomer(Form sender, Customer obj)
        {
            await _customerService.InsertCustomerAsync(obj);
            sender.Close();
        }

        private void customerCreateButton_Click(object sender, EventArgs e)
        {
            openCustomerDetailsForm(null);
        }

        private async void customersDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = customersDataGridView.Columns["ID"].Index;
            var selectedCustomerID = customersDataGridView.SelectedRows[0].Cells[index].Value.ToString();
            var customer =await  _customerService.GetCustomerByIdAsync(Guid.Parse(selectedCustomerID));
            openCustomerDetailsForm(customer);
        }


    }
}
