using HotelBookingAutomation.Business.Abstract;
using HotelBookingAutomation.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class RoomPricesForm : Form
    {
        IRoomPriceService _roomPriceService;
        ICategoryService _categoryService;
        RoomPrice? _selectedRoomPrice = null;
        public RoomPricesForm(IRoomPriceService roomPriceService, ICategoryService categoryService)
        {
            InitializeComponent();
            _roomPriceService = roomPriceService;
            _categoryService = categoryService;
        }

        private async Task FillTheGridAsync()
        {
            var roomPrices = await _roomPriceService.GetAllRoomPricesWithDetailsAsync() as List<RoomPricesWithDetailsDto>;
            roomPricesDataGridView.DataSource = new BindingList<RoomPricesWithDetailsDto>(roomPrices);
        }

        private async Task FillComboBox()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "ID";
            categoryComboBox.DataSource = categories;
            categoryComboBox.SelectedIndex = 0;
        }

        private async void RoomPricesForm_Load(object sender, EventArgs e)
        {
            startDateTimePicker.MinDate = DateTime.Now.AddDays(1);
            startDateTimePicker.MaxDate = DateTime.Now.AddMonths(3);
            endDateTimePicker.MaxDate = startDateTimePicker.Value.AddDays(15);
            await FillComboBox();
            await FillTheGridAsync();
        }

        private void RoomPricesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void startDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void endDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void startDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (startDateTimePicker.Value < endDateTimePicker.MinDate)
            {
                endDateTimePicker.MinDate = startDateTimePicker.Value.AddDays(1);
                endDateTimePicker.MaxDate = startDateTimePicker.Value.AddDays(15);
            }
            else
            {
                endDateTimePicker.MaxDate = startDateTimePicker.Value.AddDays(15);
                endDateTimePicker.MinDate = startDateTimePicker.Value.AddDays(1);
            }
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            var Category = (Category)categoryComboBox.SelectedItem;
            var roomPrice = new RoomPrice
            {
                StartDate = startDateTimePicker.Value,
                EndDate = endDateTimePicker.Value,
                CategoryID = Category.ID,
                Price = priceNumericUpDown.Value
            };
            var overlapping = await _roomPriceService.GetOverlappingRoomPriceAsync(roomPrice);
            if (overlapping == null)
            {
                await _roomPriceService.InsertRoomPriceAsync(roomPrice);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Overlapping Dated Would You Like To Delete Overlapping One:\n" +
                    $"{overlapping.ID}\n" +
                    $"{overlapping.StartDate}\n" +
                    $"{overlapping.EndDate}\n" +
                    $"{overlapping.Price}", "Overlapping Dates",
                    MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    await _roomPriceService.DeleteOldInsertNewAsync(overlapping, roomPrice);
                }

            }
            await FillTheGridAsync();
            _selectedRoomPrice = null;
            changeDeleteButtonVisibility();

        }

        private async void RoomPricesForm_VisibleChanged(object sender, EventArgs e)
        {
            await FillComboBox();
            await FillTheGridAsync();
        }

        private void changeDeleteButtonVisibility()
        {
            if (_selectedRoomPrice != null)
            {
                deleteButton.Enabled = true;
                deleteButton.Visible = true;
            }
            else
            {
                deleteButton.Enabled = false;
                deleteButton.Visible = false;
            }
        }

        private async void roomPricesDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var selectedIndex = roomPricesDataGridView.Columns["ID"].Index;
            var selectedId = (Guid)roomPricesDataGridView.SelectedRows[0].Cells[selectedIndex].Value;
            _selectedRoomPrice = await _roomPriceService.GetRoomPriceByIdAsync(selectedId);
            changeDeleteButtonVisibility();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Do you want to delete this:\n" +
                $"{_selectedRoomPrice.ID}\n" +
                $"{_selectedRoomPrice.StartDate}\n" +
                $"{_selectedRoomPrice.EndDate}\n" +
                $"{_selectedRoomPrice.Price}",
                "Delete Room Price", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await _roomPriceService.DeleteRoomPriceAsync(_selectedRoomPrice);
            }
            _selectedRoomPrice = null;
            await FillTheGridAsync();
            changeDeleteButtonVisibility();
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = categoryComboBox.SelectedItem as Category;
            priceNumericUpDown.Value = category.BasePrice;
        }
    }
}
