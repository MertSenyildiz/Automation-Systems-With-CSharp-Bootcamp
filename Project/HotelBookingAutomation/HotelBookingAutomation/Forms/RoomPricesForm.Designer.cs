namespace HotelBookingAutomation.Forms
{
    partial class RoomPricesForm
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
            roomPricesHeaderLabel = new Label();
            startDateLabel = new Label();
            startDateTimePicker = new DateTimePicker();
            endDateTimePicker = new DateTimePicker();
            endDateLabel = new Label();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            priceNumericUpDown = new NumericUpDown();
            priceLabel = new Label();
            roomPricesDataGridView = new DataGridView();
            createButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomPricesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // roomPricesHeaderLabel
            // 
            roomPricesHeaderLabel.AutoSize = true;
            roomPricesHeaderLabel.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            roomPricesHeaderLabel.Location = new Point(49, 9);
            roomPricesHeaderLabel.Name = "roomPricesHeaderLabel";
            roomPricesHeaderLabel.Size = new Size(481, 106);
            roomPricesHeaderLabel.TabIndex = 0;
            roomPricesHeaderLabel.Text = "Room Prices";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startDateLabel.Location = new Point(27, 150);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(99, 28);
            startDateLabel.TabIndex = 1;
            startDateLabel.Text = "Start Date";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Location = new Point(27, 201);
            startDateTimePicker.MinDate = new DateTime(2023, 10, 18, 0, 0, 0, 0);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(241, 27);
            startDateTimePicker.TabIndex = 2;
            startDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
            startDateTimePicker.KeyPress += startDateTimePicker_KeyPress;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Location = new Point(327, 201);
            endDateTimePicker.MinDate = new DateTime(2023, 10, 18, 0, 0, 0, 0);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(241, 27);
            endDateTimePicker.TabIndex = 4;
            endDateTimePicker.KeyPress += endDateTimePicker_KeyPress;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            endDateLabel.Location = new Point(327, 150);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(91, 28);
            endDateLabel.TabIndex = 3;
            endDateLabel.Text = "End Date";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.Location = new Point(27, 290);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(92, 28);
            categoryLabel.TabIndex = 5;
            categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(27, 335);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(241, 28);
            categoryComboBox.TabIndex = 6;
            categoryComboBox.SelectedIndexChanged += categoryComboBox_SelectedIndexChanged;
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.DecimalPlaces = 2;
            priceNumericUpDown.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            priceNumericUpDown.Location = new Point(327, 335);
            priceNumericUpDown.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            priceNumericUpDown.Minimum = new decimal(new int[] { 25, 0, 0, 0 });
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(241, 27);
            priceNumericUpDown.TabIndex = 7;
            priceNumericUpDown.Value = new decimal(new int[] { 25, 0, 0, 0 });
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(326, 290);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(54, 28);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price";
            // 
            // roomPricesDataGridView
            // 
            roomPricesDataGridView.AllowUserToAddRows = false;
            roomPricesDataGridView.AllowUserToDeleteRows = false;
            roomPricesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomPricesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomPricesDataGridView.Location = new Point(0, 428);
            roomPricesDataGridView.MultiSelect = false;
            roomPricesDataGridView.Name = "roomPricesDataGridView";
            roomPricesDataGridView.ReadOnly = true;
            roomPricesDataGridView.RowHeadersWidth = 51;
            roomPricesDataGridView.RowTemplate.Height = 29;
            roomPricesDataGridView.Size = new Size(584, 316);
            roomPricesDataGridView.TabIndex = 9;
            roomPricesDataGridView.RowHeaderMouseDoubleClick += roomPricesDataGridView_RowHeaderMouseDoubleClick;
            // 
            // createButton
            // 
            createButton.Location = new Point(27, 388);
            createButton.Name = "createButton";
            createButton.Size = new Size(241, 29);
            createButton.TabIndex = 10;
            createButton.Text = "Create Room Price";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Enabled = false;
            deleteButton.Location = new Point(327, 388);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(241, 29);
            deleteButton.TabIndex = 11;
            deleteButton.Text = "Delete Room Price";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Visible = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // RoomPricesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 744);
            Controls.Add(deleteButton);
            Controls.Add(createButton);
            Controls.Add(roomPricesDataGridView);
            Controls.Add(priceLabel);
            Controls.Add(priceNumericUpDown);
            Controls.Add(categoryComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(endDateTimePicker);
            Controls.Add(endDateLabel);
            Controls.Add(startDateTimePicker);
            Controls.Add(startDateLabel);
            Controls.Add(roomPricesHeaderLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "RoomPricesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hotel Booking Room Prices";
            FormClosing += RoomPricesForm_FormClosing;
            Load += RoomPricesForm_Load;
            VisibleChanged += RoomPricesForm_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomPricesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label roomPricesHeaderLabel;
        private Label startDateLabel;
        private DateTimePicker startDateTimePicker;
        private DateTimePicker endDateTimePicker;
        private Label endDateLabel;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private NumericUpDown priceNumericUpDown;
        private Label priceLabel;
        private DataGridView roomPricesDataGridView;
        private Button createButton;
        private Button deleteButton;
    }
}