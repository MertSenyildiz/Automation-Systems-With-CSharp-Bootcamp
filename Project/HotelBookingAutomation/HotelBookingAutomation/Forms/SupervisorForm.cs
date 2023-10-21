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
    public partial class SupervisorForm : Form
    {
        BookARoomForm _bookARoomForm;
        ICategoryService _categoryService;
        IRoomService _roomService;
        IBookingService _bookingService;
        ICustomerService _customerService;
        Room? _selectedRoom = null;
        Customer? _selectedCustomer = null;
        public SupervisorForm(IRoomService roomService, BookARoomForm bookARoomForm, IBookingService bookingService, ICategoryService categoryService, ICustomerService customerService)
        {
            InitializeComponent();
            MaximizeBox = false;
            _bookingService = bookingService;
            _categoryService = categoryService;
            _roomService = roomService;
            _bookARoomForm = bookARoomForm;
            _bookARoomForm.FormClosing += async (s, e) => { await fillTheRoomsAsync(); _selectedRoom = null; adjustTheDateTimes(); };
            _customerService = customerService;
        }

        private async void SupervisorForm_Load(object sender, EventArgs e)
        {
            adjustTheDateTimes();
            await fillTheRoomsAsync();
        }

        private void SupervisorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
        }

        private void checkInDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (checkInDateTimePicker.Value < checkOutDateTimePicker.MinDate)
            {
                checkOutDateTimePicker.MinDate = checkInDateTimePicker.Value.AddDays(1);
                checkOutDateTimePicker.MaxDate = checkInDateTimePicker.Value.AddDays(15);
            }
            else
            {
                checkOutDateTimePicker.MaxDate = checkInDateTimePicker.Value.AddDays(15);
                checkOutDateTimePicker.MinDate = checkInDateTimePicker.Value.AddDays(1);
            }
        }

        private async void frontDeskTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (frontDeskTabControl.SelectedTab == bookingTab)
            {
                if (_selectedRoom == null)
                {
                    await fillTheRoomsAsync();
                    adjustTheDateTimes();
                }
            }
            else if (frontDeskTabControl.SelectedTab == bookedTab)
            {
                await fillTheBookedRooms();
            }
            else if (frontDeskTabControl.SelectedTab == deleteBooking)
            {
                startDateTimePicker.MinDate = DateTime.Now.AddDays(15);
                endDateTimePicker.MinDate = startDateTimePicker.MinDate.AddDays(1);
                customerBookingsDataGridView.DataSource = new List<BookingWithRoomNoDto>();
                _selectedCustomer = null;
                fillTheCustomer();
            }
        }

        private void adjustTheDateTimes()
        {
            checkInDateTimePicker.MinDate = DateTime.Now;
            checkInDateTimePicker.MaxDate = DateTime.Now.AddMonths(6);
            checkOutDateTimePicker.MaxDate = checkInDateTimePicker.Value.AddDays(15);
            checkOutDateTimePicker.MinDate = checkInDateTimePicker.Value.AddDays(1);
        }
        private async Task fillTheRoomsAsync()
        {
            roomsFlowLayoutPanel.Controls.Clear();
            var rooms = await _roomService.GetAllAvailableRoomsAsync(checkInDateTimePicker.Value, checkOutDateTimePicker.Value);
            Dictionary<string, CategoryGroupBox> roomButtonsDic = new Dictionary<string, CategoryGroupBox>();

            foreach (var room in rooms)
            {
                var button = new RoomButton();
                button.Text = room.UniqueRoomNo;
                button.BackColor = Color.DarkGreen;
                button.DoubleClick += OpenBookingForm;
                if (roomButtonsDic.TryGetValue(room.CategoryName, out CategoryGroupBox groupBox))
                {
                    groupBox.flowPanel.Controls.Add(button);
                }
                else
                {
                    var group = new CategoryGroupBox();
                    group.Text = room.CategoryName;
                    group.flowPanel.Controls.Add(button);
                    roomButtonsDic[room.CategoryName] = group;
                }
            }
            foreach (var room in roomButtonsDic.Values)
            {
                room.Width = roomsFlowLayoutPanel.Width - 40;
                double count = room.flowPanel.Controls.Count;
                double width = roomsFlowLayoutPanel.Width / 200;
                var calcHeight = Math.Ceiling(count / width);
                room.Height = (int)calcHeight > 1 ? (int)calcHeight * 225 : 250;
                roomsFlowLayoutPanel.Controls.Add(room);
            }
        }

        private async Task fillTheBookedRooms()
        {
            bookedRoomsFlowLayoutPanel.Controls.Clear();
            var rooms = await _roomService.GetAllBookedRoomsAsync(DateTime.Now, DateTime.Now.AddDays(1));
            Dictionary<string, CategoryGroupBox> roomButtonsDic = new Dictionary<string, CategoryGroupBox>();

            foreach (var room in rooms)
            {
                var button = new RoomButton();
                button.Text = room.UniqueRoomNo;
                button.BackColor = Color.OrangeRed;
                button.DoubleClick += CheckOutRooms;
                button.Click += FillTheCalender;
                if (roomButtonsDic.TryGetValue(room.CategoryName, out CategoryGroupBox groupBox))
                {
                    groupBox.flowPanel.Controls.Add(button);
                }
                else
                {
                    var group = new CategoryGroupBox();
                    group.Text = room.CategoryName;
                    group.flowPanel.Controls.Add(button);
                    roomButtonsDic[room.CategoryName] = group;
                }
            }
            foreach (var room in roomButtonsDic.Values)
            {
                room.Width = roomsFlowLayoutPanel.Width - 40;
                double count = room.flowPanel.Controls.Count;
                double width = roomsFlowLayoutPanel.Width / 200;
                var calcHeight = Math.Ceiling(count / width);
                room.Height = (int)calcHeight > 1 ? (int)calcHeight * 225 : 250;
                bookedRoomsFlowLayoutPanel.Controls.Add(room);
            }
        }

        private async void FillTheCalender(object? sender, EventArgs e)
        {
            RoomButton button = (RoomButton)sender;
            var room = await _roomService.GetRoomByUniqueRoomNo(button.Text);
            var booking = await _bookingService.GetBookingByRoomId(room.ID, DateTime.Now, DateTime.Now.AddDays(1));
            monthCalendar.SelectionRange = new SelectionRange(booking.CheckInDate, booking.CheckOutDate);
        }

        private async void CheckOutRooms(object? sender, EventArgs e)
        {
            RoomButton button = (RoomButton)sender;
            var roomToUpdate = await _roomService.GetRoomByUniqueRoomNo(button.Text);
            var booking = await _bookingService.GetBookingByRoomId(roomToUpdate.ID, DateTime.Now, DateTime.Now.AddDays(1));
            booking.CheckOutDate = DateTime.Now;
            Category category = await _categoryService.GetCategoryByIdAsync(roomToUpdate.CategoryID);
            var cost = await _bookingService.CalculateBookingPrice(booking, category);
            if (booking != null && booking.CheckInDate<=DateTime.Now)
            {
                DialogResult result = MessageBox.Show("Would you like the check out this room:\n" +
                   $"{roomToUpdate.UniqueRoomNo}\n" +
                   $"{cost.ToString("C2")}", "Approve Check Out", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    booking.TotalPrice = cost;
                    var success = await _bookingService.UpdateBookingAsync(booking);
                    if (!success)
                    {
                        MessageBox.Show("Unable To Check Out Please Try Again");
                    }
                }
            }
            await fillTheBookedRooms();
        }

        public void OpenBookingForm(object? sender, EventArgs e)
        {
            RoomButton roomButton = (RoomButton)sender;
            _bookARoomForm.checkInDateTimePicker.Value = checkInDateTimePicker.Value;
            _bookARoomForm.checkOutDateTimePicker.Value = checkOutDateTimePicker.Value;
            _bookARoomForm.roomLabel.Text = roomButton.Text;
            _bookARoomForm.Show();
        }

        private async void FrontDeskForm_Load(object sender, EventArgs e)
        {
            adjustTheDateTimes();
            await fillTheRoomsAsync();
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;
            const int WM_NCLBUTTONDBLCLK = 0x00A3; //double click on a title bar a.k.a. non-client area of the form

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:             //preventing the form from being moved by the mouse.
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            if (m.Msg == WM_NCLBUTTONDBLCLK)       //preventing the form being resized by the mouse double click on the title bar.
            {
                m.Result = IntPtr.Zero;
                return;
            }

            base.WndProc(ref m);
        }

        private async void roomsButton_Click(object sender, EventArgs e)
        {
            await fillTheRoomsAsync();
        }

        private void checkInDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void checkOutDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }



        private void fillTheCustomer()
        {
            searchReservationButton.Enabled = true;
            nameTextBox.ReadOnly = true;
            lastNameTextBox.ReadOnly = true;
            idNoTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            if (_selectedCustomer != null)
            {
                nameTextBox.Text = _selectedCustomer.FirstName;
                lastNameTextBox.Text = _selectedCustomer.LastName;
                idNoTextBox.Text = _selectedCustomer.IDNo;
                emailTextBox.Text = _selectedCustomer.Email;
            }
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                _selectedCustomer = await _customerService.GetCustomerByIdentificationAsync(searchTextBox.Text);
                if (_selectedCustomer != null)
                {
                    MessageBox.Show("Customer Found!");
                    searchTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Customer not found!");
                }
            }
            else
            {
                MessageBox.Show("Empty Search String");
            }
            fillTheCustomer();
        }

        private async void searchReservationButton_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer != null)
            {
                var bookings = await _bookingService.GetBookingsByCustomerIdAndDatesAsync(_selectedCustomer.ID, startDateTimePicker.Value, endDateTimePicker.Value) as List<BookingWithRoomNoDto>;
                customerBookingsDataGridView.DataSource = bookings;
            }
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDateTimePicker.Value < checkOutDateTimePicker.MinDate)
            {
                endDateTimePicker.MinDate = startDateTimePicker.Value.AddDays(1);
                endDateTimePicker.MaxDate = startDateTimePicker.Value.AddMonths(6);
            }
            else
            {
                endDateTimePicker.MaxDate = startDateTimePicker.Value.AddMonths(6);
                endDateTimePicker.MinDate = startDateTimePicker.Value.AddDays(1);
            }
        }

        private async void customerBookingsDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = customerBookingsDataGridView.Columns["ID"].Index;
            int noIndex = customerBookingsDataGridView.Columns["UniqueRoomNo"].Index;
            var selectedRoomNo = customerBookingsDataGridView.SelectedRows[0].Cells[noIndex].Value.ToString();
            var selectedBookingID =Guid.Parse( customerBookingsDataGridView.SelectedRows[0].Cells[index].Value.ToString());
            var booking = await _bookingService.GetBookingById(selectedBookingID);
            if(booking != null)
            {
                DialogResult result = MessageBox.Show("Would You Like To Delete This Reservation:\n" +
                    $"{booking.ID}\n" +
                    $"{booking.CheckInDate}\n" +
                    $"{booking.CheckOutDate}\n" +
                    $"{selectedRoomNo}","Delete Reservation",MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    var success = await _bookingService.DeleteBookingAsync(booking);
                    if(success) {
                        _selectedCustomer = null;
                        customerBookingsDataGridView.DataSource = new List<BookingWithRoomNoDto>();
                        MessageBox.Show("Reservation has been successfully deleted");
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!");
                    }
                }
            }
            
            
        }
    }
}
