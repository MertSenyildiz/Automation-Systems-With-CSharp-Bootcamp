using Microsoft.Extensions.DependencyInjection;
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
    public partial class ManagerForm : Form
    {
        RolesForm _rolesForm;
        UsersForm _usersForm;
        CategoriesForm _categoriesForm;
        CustomersForm _customersForm;
        RoomPricesForm _roomPricesForm;
        RoomsForm _roomsForm;
        public ManagerForm(RolesForm rolesForm, UsersForm usersForm, CategoriesForm categoriesForm, CustomersForm customersForm, RoomPricesForm roomPricesForm, RoomsForm roomsForm)
        {
            InitializeComponent();
            _rolesForm = rolesForm;
            _usersForm = usersForm;
            _categoriesForm = categoriesForm;
            _customersForm = customersForm;
            _roomPricesForm = roomPricesForm;
            _roomsForm = roomsForm;
        }

        private void rolesButton_Click(object sender, EventArgs e)
        {
            _rolesForm.Show();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            _usersForm.Show();
        }

        private void categoriesButton_Click(object sender, EventArgs e)
        {
            _categoriesForm.Show();
        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            _customersForm.Show();
        }

        private void roomPricesButton_Click(object sender, EventArgs e)
        {
            _roomPricesForm.Show();
        }

        private void roomsButton_Click(object sender, EventArgs e)
        {
            _roomsForm.Show();
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }
    }
}
