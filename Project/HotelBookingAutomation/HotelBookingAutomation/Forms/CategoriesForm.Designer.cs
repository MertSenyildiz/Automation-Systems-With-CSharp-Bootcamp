namespace HotelBookingAutomation.Forms
{
    partial class CategoriesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            deleteCategoryButton = new Button();
            updateCategoryButton = new Button();
            categoriesHeaderLabel = new Label();
            categoryNameLabel = new Label();
            addCategoryButton = new Button();
            categoryNameTextBox = new TextBox();
            categoriesDataGridView = new DataGridView();
            categoryPriceLabel = new Label();
            categoryPriceNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryPriceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // deleteCategoryButton
            // 
            deleteCategoryButton.BackColor = Color.FromArgb(192, 0, 0);
            deleteCategoryButton.Enabled = false;
            deleteCategoryButton.ForeColor = SystemColors.Control;
            deleteCategoryButton.Location = new Point(405, 326);
            deleteCategoryButton.Name = "deleteCategoryButton";
            deleteCategoryButton.Size = new Size(200, 34);
            deleteCategoryButton.TabIndex = 14;
            deleteCategoryButton.Text = "Delete Category";
            deleteCategoryButton.UseVisualStyleBackColor = false;
            deleteCategoryButton.Visible = false;
            deleteCategoryButton.Click += deleteCategoryButton_Click;
            // 
            // updateCategoryButton
            // 
            updateCategoryButton.BackColor = Color.FromArgb(255, 128, 0);
            updateCategoryButton.Enabled = false;
            updateCategoryButton.Location = new Point(405, 277);
            updateCategoryButton.Name = "updateCategoryButton";
            updateCategoryButton.Size = new Size(200, 34);
            updateCategoryButton.TabIndex = 13;
            updateCategoryButton.Text = "Update Category";
            updateCategoryButton.UseVisualStyleBackColor = false;
            updateCategoryButton.Visible = false;
            updateCategoryButton.Click += updateCategoryButton_Click;
            // 
            // categoriesHeaderLabel
            // 
            categoriesHeaderLabel.AutoSize = true;
            categoriesHeaderLabel.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            categoriesHeaderLabel.Location = new Point(143, 32);
            categoriesHeaderLabel.Name = "categoriesHeaderLabel";
            categoriesHeaderLabel.Size = new Size(422, 106);
            categoriesHeaderLabel.TabIndex = 12;
            categoriesHeaderLabel.Text = "Categories";
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.AutoSize = true;
            categoryNameLabel.Location = new Point(32, 191);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new Size(113, 20);
            categoryNameLabel.TabIndex = 11;
            categoryNameLabel.Text = "Category Name";
            // 
            // addCategoryButton
            // 
            addCategoryButton.BackColor = Color.FromArgb(0, 192, 0);
            addCategoryButton.Location = new Point(405, 227);
            addCategoryButton.Name = "addCategoryButton";
            addCategoryButton.Size = new Size(200, 34);
            addCategoryButton.TabIndex = 10;
            addCategoryButton.Text = "Create Category";
            addCategoryButton.UseVisualStyleBackColor = false;
            addCategoryButton.Click += addCategoryButton_Click;
            // 
            // categoryNameTextBox
            // 
            categoryNameTextBox.Location = new Point(32, 227);
            categoryNameTextBox.Name = "categoryNameTextBox";
            categoryNameTextBox.Size = new Size(309, 27);
            categoryNameTextBox.TabIndex = 9;
            // 
            // categoriesDataGridView
            // 
            categoriesDataGridView.AllowUserToAddRows = false;
            categoriesDataGridView.AllowUserToDeleteRows = false;
            categoriesDataGridView.AllowUserToResizeColumns = false;
            categoriesDataGridView.AllowUserToResizeRows = false;
            categoriesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            categoriesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            categoriesDataGridView.Location = new Point(19, 377);
            categoriesDataGridView.MultiSelect = false;
            categoriesDataGridView.Name = "categoriesDataGridView";
            categoriesDataGridView.ReadOnly = true;
            categoriesDataGridView.RowHeadersWidth = 51;
            categoriesDataGridView.RowTemplate.Height = 29;
            categoriesDataGridView.Size = new Size(666, 424);
            categoriesDataGridView.TabIndex = 8;
            categoriesDataGridView.RowHeaderMouseDoubleClick += rolesDataGridView_RowHeaderMouseDoubleClick;
            // 
            // categoryPriceLabel
            // 
            categoryPriceLabel.AutoSize = true;
            categoryPriceLabel.Location = new Point(32, 277);
            categoryPriceLabel.Name = "categoryPriceLabel";
            categoryPriceLabel.Size = new Size(105, 20);
            categoryPriceLabel.TabIndex = 15;
            categoryPriceLabel.Text = "Category Price";
            // 
            // categoryPriceNumericUpDown
            // 
            categoryPriceNumericUpDown.DecimalPlaces = 2;
            categoryPriceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            categoryPriceNumericUpDown.Location = new Point(34, 312);
            categoryPriceNumericUpDown.Maximum = new decimal(new int[] { 7500, 0, 0, 0 });
            categoryPriceNumericUpDown.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            categoryPriceNumericUpDown.Name = "categoryPriceNumericUpDown";
            categoryPriceNumericUpDown.Size = new Size(150, 27);
            categoryPriceNumericUpDown.TabIndex = 16;
            categoryPriceNumericUpDown.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // CategoriesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 809);
            Controls.Add(categoryPriceNumericUpDown);
            Controls.Add(categoryPriceLabel);
            Controls.Add(deleteCategoryButton);
            Controls.Add(updateCategoryButton);
            Controls.Add(categoriesHeaderLabel);
            Controls.Add(categoryNameLabel);
            Controls.Add(addCategoryButton);
            Controls.Add(categoryNameTextBox);
            Controls.Add(categoriesDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CategoriesForm";
            Text = "Hotel Bookign Categories";
            FormClosing += CategoriesForm_FormClosing;
            Load += CategoriesForm_Load;
            VisibleChanged += CategoriesForm_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)categoriesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryPriceNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteCategoryButton;
        private Button updateCategoryButton;
        private Label categoriesHeaderLabel;
        private Label categoryNameLabel;
        private Button addCategoryButton;
        private TextBox categoryNameTextBox;
        private DataGridView categoriesDataGridView;
        private Label categoryPriceLabel;
        private NumericUpDown categoryPriceNumericUpDown;
    }
}