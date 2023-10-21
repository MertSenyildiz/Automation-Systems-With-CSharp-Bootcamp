using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.Core.Events;
using HotelBookingAutomation.DataAcess.Abstract;
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
    public partial class LoginForm : Form
    {
        public event ObjectEventHandler Action;
        IAuthService _authService;
        public LoginForm(IAuthService authService)
        {
            InitializeComponent();
            _authService = authService;
        }

        private async void loginButton_ClickAsync(object sender, EventArgs e)
        {
            loginButton.Enabled = false;
            UserToLoginDto userToLogin = new()
            {
                Username = usernameTextBox.Text,
                Password = passwordTextBox.Text
            };
            var user = await _authService.Login(userToLogin);
            if (user != null)
            {
                Action.Invoke(this, user, Core.Events.Action.PARTIAL_UPDATE);
            }
            else
            {
                loginButton.Enabled = true;
                MessageBox.Show("Username or Password is incorrect!");
            }
        }

    }
}
