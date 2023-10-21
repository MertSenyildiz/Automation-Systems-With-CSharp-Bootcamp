namespace HotelBookingAutomation.Forms
{
    partial class RoomsForm
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
            roomsDataGridView = new DataGridView();
            categoryLabel = new Label();
            categoryComboBox = new ComboBox();
            floorLabel = new Label();
            floorNumericUpDown = new NumericUpDown();
            roomNoNumericUpDown = new NumericUpDown();
            roomNoLabel = new Label();
            createButton = new Button();
            roomsHeaderLabel = new Label();
            updateButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)roomsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)floorNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomNoNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // roomsDataGridView
            // 
            roomsDataGridView.AllowUserToAddRows = false;
            roomsDataGridView.AllowUserToDeleteRows = false;
            roomsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomsDataGridView.Location = new Point(-1, 322);
            roomsDataGridView.MultiSelect = false;
            roomsDataGridView.Name = "roomsDataGridView";
            roomsDataGridView.ReadOnly = true;
            roomsDataGridView.RowHeadersWidth = 51;
            roomsDataGridView.RowTemplate.Height = 29;
            roomsDataGridView.Size = new Size(994, 431);
            roomsDataGridView.TabIndex = 0;
            roomsDataGridView.RowHeaderMouseDoubleClick += roomsDataGridView_RowHeaderMouseDoubleClick;
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            categoryLabel.Location = new Point(7, 168);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(92, 28);
            categoryLabel.TabIndex = 1;
            categoryLabel.Text = "Category";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(7, 211);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(205, 28);
            categoryComboBox.TabIndex = 2;
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            floorLabel.Location = new Point(346, 168);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new Size(58, 28);
            floorLabel.TabIndex = 3;
            floorLabel.Text = "Floor";
            // 
            // floorNumericUpDown
            // 
            floorNumericUpDown.Location = new Point(349, 207);
            floorNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            floorNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            floorNumericUpDown.Name = "floorNumericUpDown";
            floorNumericUpDown.Size = new Size(205, 27);
            floorNumericUpDown.TabIndex = 4;
            floorNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // roomNoNumericUpDown
            // 
            roomNoNumericUpDown.Location = new Point(699, 207);
            roomNoNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            roomNoNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            roomNoNumericUpDown.Name = "roomNoNumericUpDown";
            roomNoNumericUpDown.Size = new Size(205, 27);
            roomNoNumericUpDown.TabIndex = 6;
            roomNoNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // roomNoLabel
            // 
            roomNoLabel.AutoSize = true;
            roomNoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roomNoLabel.Location = new Point(699, 168);
            roomNoLabel.Name = "roomNoLabel";
            roomNoLabel.Size = new Size(96, 28);
            roomNoLabel.TabIndex = 5;
            roomNoLabel.Text = "Room No";
            // 
            // createButton
            // 
            createButton.Location = new Point(7, 275);
            createButton.Name = "createButton";
            createButton.Size = new Size(205, 29);
            createButton.TabIndex = 7;
            createButton.Text = "Create Room";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // roomsHeaderLabel
            // 
            roomsHeaderLabel.AutoSize = true;
            roomsHeaderLabel.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            roomsHeaderLabel.Location = new Point(311, 9);
            roomsHeaderLabel.Name = "roomsHeaderLabel";
            roomsHeaderLabel.Size = new Size(288, 106);
            roomsHeaderLabel.TabIndex = 8;
            roomsHeaderLabel.Text = "Rooms";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(349, 275);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(205, 29);
            updateButton.TabIndex = 9;
            updateButton.Text = "Update Room";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(699, 275);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(205, 29);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "Delete Room";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // RoomsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 753);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(roomsHeaderLabel);
            Controls.Add(createButton);
            Controls.Add(roomNoNumericUpDown);
            Controls.Add(roomNoLabel);
            Controls.Add(floorNumericUpDown);
            Controls.Add(floorLabel);
            Controls.Add(categoryComboBox);
            Controls.Add(categoryLabel);
            Controls.Add(roomsDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "RoomsForm";
            Text = "Hotel Booking Rooms";
            FormClosing += RoomsForm_FormClosing;
            Load += RoomsForm_Load;
            VisibleChanged += RoomsForm_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)roomsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)floorNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomNoNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView roomsDataGridView;
        private Label categoryLabel;
        private ComboBox categoryComboBox;
        private Label floorLabel;
        private NumericUpDown floorNumericUpDown;
        private NumericUpDown roomNoNumericUpDown;
        private Label roomNoLabel;
        private Button createButton;
        private Label roomsHeaderLabel;
        private Button updateButton;
        private Button deleteButton;
    }
}