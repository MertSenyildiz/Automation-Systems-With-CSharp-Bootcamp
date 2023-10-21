using HotelBookingAutomation.Business.Abstract;
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
    public partial class BookARoomForm : Form
    {
        ICustomerService _customerService;
        ICategoryService _categoryService;
        IRoomPriceService _roomPriceService;
        IBookingService _bookingService;
        IRoomService _roomService;
        Room _selectedRoom;
        Customer? _selectedCustomer = null;
        List<RoomPrice> _roomPrices = new List<RoomPrice>();
        decimal _cost = 0;
        int _days = 0;
        public BookARoomForm(ICustomerService customerService, IBookingService bookingService, IRoomPriceService roomPriceService, IRoomService roomService, ICategoryService categoryService)
        {
            InitializeComponent();
            _bookingService = bookingService;
            _roomPriceService = roomPriceService;
            _roomService = roomService;
            _customerService = customerService;
            _categoryService = categoryService;
        }

        private void BookARoomForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _days = 0;
            _cost = 0;
            _selectedRoom = null;
            _roomPrices.Clear();
            e.Cancel = true;
            this.Hide();
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
                    MessageBox.Show("Customer is not registered. Please create register the customer before booking a room.");
                }
            }
            else
            {
                MessageBox.Show("Empty Search String");
            }
            fillTheCustomer();
        }
        private void fillTheCustomer()
        {
            if (_selectedCustomer != null)
            {
                createButton.Enabled = false;
                nameTextBox.ReadOnly = true;
                lastNameTextBox.ReadOnly = true;
                idNoTextBox.ReadOnly = true;
                addressTextBox.ReadOnly = true;
                zipCodeTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                countryTextBox.ReadOnly = true;
                phoneTextBox.ReadOnly = true;
                nameTextBox.Text = _selectedCustomer.FirstName;
                lastNameTextBox.Text = _selectedCustomer.LastName;
                idNoTextBox.Text = _selectedCustomer.IDNo;
                addressTextBox.Text = _selectedCustomer.Address;
                zipCodeTextBox.Text = _selectedCustomer.ZipCode;
                emailTextBox.Text = _selectedCustomer.Email;
                countryTextBox.Text = _selectedCustomer.Country;
                phoneTextBox.Text = _selectedCustomer.Phone;
            }
            else
            {
                createButton.Enabled = true;
                nameTextBox.ReadOnly = false;
                lastNameTextBox.ReadOnly = false;
                idNoTextBox.ReadOnly = false;
                addressTextBox.ReadOnly = false;
                zipCodeTextBox.ReadOnly = false;
                emailTextBox.ReadOnly = false;
                countryTextBox.ReadOnly = false;
                phoneTextBox.ReadOnly = false;
                nameTextBox.Text = "";
                lastNameTextBox.Text = "";
                idNoTextBox.Text = "";
                addressTextBox.Text = "";
                zipCodeTextBox.Text = "";
                emailTextBox.Text = "";
                countryTextBox.Text = "";
                phoneTextBox.Text = "";
                costLabel.Text = 0.0.ToString("C2");
            }
        }

        private async void customerPanel_VisibleChanged(object sender, EventArgs e)
        {

            if (Visible)
            {
                _selectedRoom = await _roomService.GetRoomByUniqueRoomNo(roomLabel.Text);
                _roomPrices = await _roomPriceService.GetRoomPricesByCategoryAndOverlappingDatesAsync(_selectedRoom.CategoryID,
                    checkInDateTimePicker.Value,
                    checkOutDateTimePicker.Value) as List<RoomPrice>;
                var category = await _categoryService.GetCategoryByIdAsync(_selectedRoom.CategoryID);
                _cost = await _bookingService.CalculateBookingPrice(new Booking { CheckInDate = checkInDateTimePicker.Value, CheckOutDate = checkOutDateTimePicker.Value }, category);
                var indate = checkInDateTimePicker.Value;
                var outdate = checkOutDateTimePicker.Value;
                _days = (int)Math.Ceiling((outdate - indate).TotalDays);
                //int otherdays = 0;
                //if (_roomPrices.Any())
                //{
                //    foreach (var price in _roomPrices)
                //    {
                //        if (indate >= price.StartDate && outdate <= price.EndDate)
                //        {
                //            otherdays = _days;
                //            _cost =_days*price.Price;
                //        }
                //        else if (indate >= price.StartDate && indate <= price.EndDate)
                //        {
                //            var otherday = (int)Math.Ceiling((indate - price.StartDate).TotalDays);
                //            _cost += otherday * price.Price;
                //            otherdays += otherday;
                //        }
                //        else if (outdate >= price.StartDate && outdate<=price.EndDate)
                //        {
                //            var otherday = (int)Math.Ceiling((outdate-price.StartDate).TotalDays);
                //            _cost += otherday*price.Price;
                //            otherdays += otherday;
                //        }
                //        else if(indate<=price.StartDate && outdate>=price.EndDate)
                //        {
                //            var otherday = (int)Math.Floor((price.EndDate - price.StartDate).TotalDays);
                //            _cost += otherday * price.Price;
                //            otherdays += otherday;
                //        }

                //    }
                //    if (_days > otherdays)
                //        _cost += (_days-otherdays)*category.BasePrice;
                //}
                //else
                //{
                //    _cost = category.BasePrice*_days;
                //}

            }
            fillTheCustomer();
            costLabel.Text = _cost.ToString("C2");
            daysLabel.Text = _days.ToString();
            roomPricesDataGridView.DataSource = _roomPrices;
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

        private async void createButton_Click(object sender, EventArgs e)
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
                    await _customerService.InsertCustomerAsync(customer);
                    _selectedCustomer = await _customerService.GetCustomerByIdentificationAsync(customer.IDNo);
                    if (_selectedCustomer != null)
                    {

                        MessageBox.Show("Customer successfully created");
                    }
                    else
                    {
                        MessageBox.Show("Customer is already registered");
                    }
                    fillTheCustomer();
                }

            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private async void approveButton_Click(object sender, EventArgs e)
        {
            if (_selectedCustomer != null)
            {
                DialogResult result = MessageBox.Show("Would you like the book this room:\n" +
                    $"{_selectedRoom.UniqueRoomNo}\n" +
                    $"{_cost.ToString("C2")}\n" +
                    $"{_selectedCustomer.FirstName}\n" +
                    $"{_selectedCustomer.IDNo}", "Approve Booking", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Booking booking = new Booking
                    {
                        CheckInDate = checkInDateTimePicker.Value,
                        CheckOutDate = checkOutDateTimePicker.Value,
                        CustomerID = _selectedCustomer.ID,
                        TotalPrice = _cost,
                        RoomID = _selectedRoom.ID
                    };
                    var success = await _bookingService.InsertBookingAsync(booking);
                    if (success)
                    {
                        MessageBox.Show($"{_selectedRoom.UniqueRoomNo}\n" +
                            $"Check In Date : {booking.CheckInDate}\n" +
                            $"Check Out Date : {booking.CheckOutDate}", "Room has been Successfully Booked");
                        this.Close();
                    }
                    else
                    {
                        DialogResult resultRetry = MessageBox.Show("Problem has been occured while booking this room:\n" +
                        $"{_selectedRoom.UniqueRoomNo}\n" +
                        $"{_cost.ToString("C2")}\n" +
                        $"{_selectedCustomer.FirstName}\n" +
                        $"{_selectedCustomer.IDNo}", "Would You Try Again", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            approveButton.PerformClick();
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill the customer informations");
            }
        }
    }
}
