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
    public partial class CategoriesForm : Form
    {
        ICategoryService _categoryService;
        Category? _selectedCategory = null;
        public CategoriesForm(ICategoryService categoryService)
        {
            InitializeComponent();
            _categoryService = categoryService;
        }
        private async Task FillTheGridAsync()
        {
            var source = await _categoryService.GetAllCategoriesAsync() as List<Category>;
            categoriesDataGridView.DataSource = new BindingList<Category>(source);
        }
        private void disableButtons()
        {
            deleteCategoryButton.Enabled = false;
            deleteCategoryButton.Visible = false;
            updateCategoryButton.Enabled = false;
            updateCategoryButton.Visible = false;
        }

        private void enableButtons()
        {
            deleteCategoryButton.Enabled = true;
            deleteCategoryButton.Visible = true;
            updateCategoryButton.Enabled = true;
            updateCategoryButton.Visible = true;
        }

        private void CategoriesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private async void CategoriesForm_Load(object sender, EventArgs e)
        {
            await FillTheGridAsync();
        }

        private async void CategoriesForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                await FillTheGridAsync();
            }
            else
            {
                categoriesDataGridView.Rows.Clear();
                categoriesDataGridView.DataSource = null;
            }
        }

        private async void addCategoryButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(categoryNameTextBox.Text))
            {
                var category = new Category
                {
                    CategoryName = categoryNameTextBox.Text,
                    BasePrice = categoryPriceNumericUpDown.Value
                };
                await _categoryService.InsertCategoryAsync(category);
                categoryNameTextBox.Text = "";
                categoryPriceNumericUpDown.Value = categoryPriceNumericUpDown.Minimum;
                await FillTheGridAsync();
            }
            else
            {
                MessageBox.Show("Please fill the Category Name");
            }
        }

        private void rolesDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            _selectedCategory = new()
            {
                ID = Guid.Parse(categoriesDataGridView.SelectedRows[0].Cells[0].Value.ToString())
            };
            categoryNameTextBox.Text = categoriesDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            categoryPriceNumericUpDown.Value = (decimal)categoriesDataGridView.SelectedRows[0].Cells[2].Value;
            enableButtons();

        }

        private async void updateCategoryButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(categoryNameTextBox.Text))
            {
                _selectedCategory.CategoryName = categoryNameTextBox.Text;
                _selectedCategory.BasePrice = categoryPriceNumericUpDown.Value;
                DialogResult dialogResult = MessageBox.Show($"Do you want to update this: \n {_selectedCategory.ID}\n {_selectedCategory.CategoryName}", "Update Category", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    await _categoryService.UpdateCategoryAsync(_selectedCategory);
                    await FillTheGridAsync();

                }
                else if (dialogResult == DialogResult.No)
                {
                    _selectedCategory = null;
                }
            }
            else
            {
                MessageBox.Show("Please fill the Category Name");
            }
            categoryNameTextBox.Text = "";
            categoryPriceNumericUpDown.Value = categoryPriceNumericUpDown.Minimum;
            disableButtons();
        }

        private async void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Do you want to delete this: \n {_selectedCategory.ID}\n {_selectedCategory.CategoryName}", "Delete Category", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await _categoryService.DeleteCategoryAsync(_selectedCategory);
                await FillTheGridAsync();

            }
            else if (dialogResult == DialogResult.No)
            {
                _selectedCategory = null;
            }
            categoryNameTextBox.Text = "";
            categoryPriceNumericUpDown.Value = categoryPriceNumericUpDown.Minimum;
            disableButtons();
        }
    }
}
