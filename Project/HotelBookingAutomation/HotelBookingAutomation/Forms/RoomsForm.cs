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
    public partial class RoomsForm : Form
    {
        IRoomService _roomService;
        ICategoryService _categoryService;
        Room? _selectedRoom = null;
        public RoomsForm(IRoomService roomService, ICategoryService categoryService)
        {
            InitializeComponent();
            _roomService = roomService;
            _categoryService = categoryService;
        }

        private void RoomsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private async Task FillTheGrid()
        {
            var rooms = await _roomService.GetAllRoomsWithDetailsAsync() as List<RoomWithDetailsDto>;
            roomsDataGridView.DataSource = new BindingList<RoomWithDetailsDto>(rooms);
        }

        private async Task FillComboBox()
        {
            var categories = await _categoryService.GetAllCategoriesAsync();
            categoryComboBox.DisplayMember = "CategoryName";
            categoryComboBox.ValueMember = "ID";
            categoryComboBox.DataSource = categories;
            categoryComboBox.SelectedIndex = 0;
        }

        private async void RoomsForm_Load(object sender, EventArgs e)
        {
            changeTheButtonsVisibility();
            await FillComboBox();
            await FillTheGrid();
        }

        private void changeTheButtonsVisibility()
        {
            if (_selectedRoom != null)
            {
                deleteButton.Enabled = true;
                deleteButton.Visible = true;
                updateButton.Enabled = true;
                updateButton.Visible = true;
            }
            else
            {
                deleteButton.Enabled = false;
                deleteButton.Visible = false;
                updateButton.Enabled = false;
                updateButton.Visible = false;
            }
        }

        private async void createButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would You Like To Create a Room", "Create Room", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Category category = categoryComboBox.SelectedItem as Category;
                Room room = new Room
                {
                    RoomNo = (int)roomNoNumericUpDown.Value,
                    Floor = (int)floorNumericUpDown.Value,
                    CategoryID = category.ID
                };
                await _roomService.InsertRoomAsync(room);
            }
            await FillTheGrid();
            FillTheFields();
        }

        private async void RoomsForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                await FillComboBox();
                await FillTheGrid();
            }
        }

        private async void roomsDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var index = roomsDataGridView.Columns["ID"].Index;
            var selectedId = (Guid)roomsDataGridView.SelectedRows[0].Cells[index].Value;
            _selectedRoom = await _roomService.GetRoomByIdAsync(selectedId);
            changeTheButtonsVisibility();
            FillTheFields();
        }

        private void FillTheFields()
        {
            if (_selectedRoom != null)
            {
                roomNoNumericUpDown.Value = _selectedRoom.RoomNo;
                floorNumericUpDown.Value = _selectedRoom.Floor;
                var index = categoryComboBox.Items.Cast<Category>().ToList().FindIndex(c => c.ID == _selectedRoom.CategoryID);
                categoryComboBox.SelectedIndex = index;
            }
            else
            {
                roomNoNumericUpDown.Value = roomNoNumericUpDown.Minimum;
                floorNumericUpDown.Value = floorNumericUpDown.Minimum;
                categoryComboBox.SelectedIndex = 0;
            }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would You Like To Update This:\n" +
                $"{_selectedRoom.ID}\n" +
                $"{_selectedRoom.Floor}" +
                $"{_selectedRoom.RoomNo}", "Update Room", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Category category = (Category)categoryComboBox.SelectedItem;
                _selectedRoom.Floor = (int)floorNumericUpDown.Value;
                _selectedRoom.RoomNo = (int)roomNoNumericUpDown.Value;
                _selectedRoom.CategoryID = category.ID;
                await _roomService.UpdateRoomAsync(_selectedRoom);
                _selectedRoom = null;
            }
            await FillTheGrid();
            FillTheFields();
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Would You Like To Delete This:\n" +
                $"{_selectedRoom.ID}\n" +
                $"{_selectedRoom.Floor}" +
                $"{_selectedRoom.RoomNo}", "Delete Room", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await _roomService.DeleteRoomAsync(_selectedRoom);
                _selectedRoom = null;
            }
            await FillTheGrid();
            FillTheFields();
        }
    }
}
