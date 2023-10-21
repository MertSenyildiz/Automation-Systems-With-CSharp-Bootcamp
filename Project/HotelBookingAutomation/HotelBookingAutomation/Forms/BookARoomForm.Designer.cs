namespace HotelBookingAutomation.Forms
{
    partial class BookARoomForm
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
            customerPanel = new Panel();
            searchButton = new Button();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            zipCodeTextBox = new TextBox();
            label1 = new Label();
            phoneTextBox = new MaskedTextBox();
            phoneLabel = new Label();
            idNoTextBox = new TextBox();
            idNoLabel = new Label();
            createButton = new Button();
            addressTextBox = new TextBox();
            addressLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            countryTextBox = new TextBox();
            countryLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            customerLabel = new Label();
            bookingPanel = new Panel();
            daysLabel = new Label();
            totalDaysLabel = new Label();
            roomLabel = new Label();
            roomNoLabel = new Label();
            approveButton = new Button();
            costLabel = new Label();
            totalCostLabel = new Label();
            checkOutDateTimePicker = new DateTimePicker();
            checkOutDateLabel = new Label();
            checkInDateTimePicker = new DateTimePicker();
            checkInDateLabel = new Label();
            roomPricesDataGridView = new DataGridView();
            bookingLabel = new Label();
            customerPanel.SuspendLayout();
            bookingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomPricesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customerPanel
            // 
            customerPanel.Controls.Add(searchButton);
            customerPanel.Controls.Add(searchLabel);
            customerPanel.Controls.Add(searchTextBox);
            customerPanel.Controls.Add(zipCodeTextBox);
            customerPanel.Controls.Add(label1);
            customerPanel.Controls.Add(phoneTextBox);
            customerPanel.Controls.Add(phoneLabel);
            customerPanel.Controls.Add(idNoTextBox);
            customerPanel.Controls.Add(idNoLabel);
            customerPanel.Controls.Add(createButton);
            customerPanel.Controls.Add(addressTextBox);
            customerPanel.Controls.Add(addressLabel);
            customerPanel.Controls.Add(emailTextBox);
            customerPanel.Controls.Add(emailLabel);
            customerPanel.Controls.Add(countryTextBox);
            customerPanel.Controls.Add(countryLabel);
            customerPanel.Controls.Add(lastNameTextBox);
            customerPanel.Controls.Add(lastNameLabel);
            customerPanel.Controls.Add(nameTextBox);
            customerPanel.Controls.Add(nameLabel);
            customerPanel.Controls.Add(customerLabel);
            customerPanel.Dock = DockStyle.Left;
            customerPanel.Location = new Point(0, 0);
            customerPanel.Name = "customerPanel";
            customerPanel.Size = new Size(501, 756);
            customerPanel.TabIndex = 0;
            customerPanel.VisibleChanged += customerPanel_VisibleChanged;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(262, 138);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(199, 34);
            searchButton.TabIndex = 69;
            searchButton.Text = "Search Customer";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchLabel.Location = new Point(12, 98);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(121, 28);
            searchLabel.TabIndex = 68;
            searchLabel.Text = "Search by ID";
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(12, 138);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(233, 34);
            searchTextBox.TabIndex = 67;
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zipCodeTextBox.Location = new Point(12, 678);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(171, 34);
            zipCodeTextBox.TabIndex = 66;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 638);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 65;
            label1.Text = "Zip Code";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(12, 487);
            phoneTextBox.Mask = " (000) 000-0000";
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(171, 34);
            phoneTextBox.TabIndex = 64;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(12, 447);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(233, 28);
            phoneLabel.TabIndex = 63;
            phoneLabel.Text = "Customer Phone Number";
            // 
            // idNoTextBox
            // 
            idNoTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idNoTextBox.Location = new Point(262, 264);
            idNoTextBox.Name = "idNoTextBox";
            idNoTextBox.Size = new Size(199, 34);
            idNoTextBox.TabIndex = 62;
            // 
            // idNoLabel
            // 
            idNoLabel.AutoSize = true;
            idNoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idNoLabel.Location = new Point(262, 224);
            idNoLabel.Name = "idNoLabel";
            idNoLabel.Size = new Size(120, 28);
            idNoLabel.TabIndex = 61;
            idNoLabel.Text = "Customer ID";
            // 
            // createButton
            // 
            createButton.Enabled = false;
            createButton.Location = new Point(262, 678);
            createButton.Name = "createButton";
            createButton.Size = new Size(199, 34);
            createButton.TabIndex = 58;
            createButton.Text = "Create Customer";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressTextBox.Location = new Point(262, 487);
            addressTextBox.MaxLength = 400;
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(199, 128);
            addressTextBox.TabIndex = 57;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressLabel.Location = new Point(262, 447);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(171, 28);
            addressLabel.TabIndex = 56;
            addressLabel.Text = "Customer Address";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(262, 371);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(199, 34);
            emailTextBox.TabIndex = 55;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(262, 331);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(148, 28);
            emailLabel.TabIndex = 54;
            emailLabel.Text = "Customer Email";
            // 
            // countryTextBox
            // 
            countryTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            countryTextBox.Location = new Point(12, 578);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(171, 34);
            countryTextBox.TabIndex = 53;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            countryLabel.Location = new Point(12, 538);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(171, 28);
            countryLabel.TabIndex = 52;
            countryLabel.Text = "Customer Country";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(12, 371);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(171, 34);
            lastNameTextBox.TabIndex = 51;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(12, 331);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(192, 28);
            lastNameLabel.TabIndex = 50;
            lastNameLabel.Text = "Customer Last Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(12, 264);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(171, 34);
            nameTextBox.TabIndex = 49;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(12, 224);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(153, 28);
            nameLabel.TabIndex = 48;
            nameLabel.Text = "Customer Name";
            // 
            // customerLabel
            // 
            customerLabel.AutoSize = true;
            customerLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            customerLabel.Location = new Point(52, 9);
            customerLabel.Name = "customerLabel";
            customerLabel.Size = new Size(381, 62);
            customerLabel.TabIndex = 0;
            customerLabel.Text = "Customer Details";
            // 
            // bookingPanel
            // 
            bookingPanel.Controls.Add(daysLabel);
            bookingPanel.Controls.Add(totalDaysLabel);
            bookingPanel.Controls.Add(roomLabel);
            bookingPanel.Controls.Add(roomNoLabel);
            bookingPanel.Controls.Add(approveButton);
            bookingPanel.Controls.Add(costLabel);
            bookingPanel.Controls.Add(totalCostLabel);
            bookingPanel.Controls.Add(checkOutDateTimePicker);
            bookingPanel.Controls.Add(checkOutDateLabel);
            bookingPanel.Controls.Add(checkInDateTimePicker);
            bookingPanel.Controls.Add(checkInDateLabel);
            bookingPanel.Controls.Add(roomPricesDataGridView);
            bookingPanel.Controls.Add(bookingLabel);
            bookingPanel.Dock = DockStyle.Left;
            bookingPanel.Location = new Point(501, 0);
            bookingPanel.Name = "bookingPanel";
            bookingPanel.Size = new Size(522, 756);
            bookingPanel.TabIndex = 1;
            // 
            // daysLabel
            // 
            daysLabel.AutoSize = true;
            daysLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            daysLabel.Location = new Point(174, 416);
            daysLabel.Name = "daysLabel";
            daysLabel.Size = new Size(23, 28);
            daysLabel.TabIndex = 63;
            daysLabel.Text = "0";
            // 
            // totalDaysLabel
            // 
            totalDaysLabel.AutoSize = true;
            totalDaysLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalDaysLabel.Location = new Point(174, 377);
            totalDaysLabel.Name = "totalDaysLabel";
            totalDaysLabel.Size = new Size(101, 28);
            totalDaysLabel.TabIndex = 62;
            totalDaysLabel.Text = "Total Days";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabel.Location = new Point(311, 416);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(23, 28);
            roomLabel.TabIndex = 61;
            roomLabel.Text = "0";
            // 
            // roomNoLabel
            // 
            roomNoLabel.AutoSize = true;
            roomNoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            roomNoLabel.Location = new Point(311, 377);
            roomNoLabel.Name = "roomNoLabel";
            roomNoLabel.Size = new Size(96, 28);
            roomNoLabel.TabIndex = 60;
            roomNoLabel.Text = "Room No";
            // 
            // approveButton
            // 
            approveButton.Location = new Point(311, 468);
            approveButton.Name = "approveButton";
            approveButton.Size = new Size(199, 29);
            approveButton.TabIndex = 59;
            approveButton.Text = "Book The Room";
            approveButton.UseVisualStyleBackColor = true;
            approveButton.Click += approveButton_Click;
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            costLabel.Location = new Point(28, 416);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(60, 28);
            costLabel.TabIndex = 22;
            costLabel.Text = "0.00$";
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalCostLabel.Location = new Point(28, 377);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(98, 28);
            totalCostLabel.TabIndex = 21;
            totalCostLabel.Text = "Total Cost";
            // 
            // checkOutDateTimePicker
            // 
            checkOutDateTimePicker.Enabled = false;
            checkOutDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkOutDateTimePicker.Location = new Point(28, 288);
            checkOutDateTimePicker.Name = "checkOutDateTimePicker";
            checkOutDateTimePicker.Size = new Size(278, 34);
            checkOutDateTimePicker.TabIndex = 20;
            // 
            // checkOutDateLabel
            // 
            checkOutDateLabel.AutoSize = true;
            checkOutDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkOutDateLabel.Location = new Point(28, 245);
            checkOutDateLabel.Name = "checkOutDateLabel";
            checkOutDateLabel.Size = new Size(148, 28);
            checkOutDateLabel.TabIndex = 19;
            checkOutDateLabel.Text = "Check Out Date";
            // 
            // checkInDateTimePicker
            // 
            checkInDateTimePicker.Enabled = false;
            checkInDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkInDateTimePicker.Location = new Point(28, 165);
            checkInDateTimePicker.Name = "checkInDateTimePicker";
            checkInDateTimePicker.Size = new Size(278, 34);
            checkInDateTimePicker.TabIndex = 18;
            // 
            // checkInDateLabel
            // 
            checkInDateLabel.AutoSize = true;
            checkInDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkInDateLabel.Location = new Point(28, 122);
            checkInDateLabel.Name = "checkInDateLabel";
            checkInDateLabel.Size = new Size(131, 28);
            checkInDateLabel.TabIndex = 17;
            checkInDateLabel.Text = "Check In Date";
            // 
            // roomPricesDataGridView
            // 
            roomPricesDataGridView.AllowUserToAddRows = false;
            roomPricesDataGridView.AllowUserToDeleteRows = false;
            roomPricesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomPricesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomPricesDataGridView.Enabled = false;
            roomPricesDataGridView.Location = new Point(0, 509);
            roomPricesDataGridView.MultiSelect = false;
            roomPricesDataGridView.Name = "roomPricesDataGridView";
            roomPricesDataGridView.ReadOnly = true;
            roomPricesDataGridView.RowHeadersWidth = 51;
            roomPricesDataGridView.RowTemplate.Height = 29;
            roomPricesDataGridView.Size = new Size(522, 247);
            roomPricesDataGridView.TabIndex = 2;
            // 
            // bookingLabel
            // 
            bookingLabel.AutoSize = true;
            bookingLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            bookingLabel.Location = new Point(82, 9);
            bookingLabel.Name = "bookingLabel";
            bookingLabel.Size = new Size(352, 62);
            bookingLabel.TabIndex = 1;
            bookingLabel.Text = "Booking Details";
            // 
            // BookARoomForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 756);
            Controls.Add(bookingPanel);
            Controls.Add(customerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "BookARoomForm";
            Text = "Hotel Booking Room Booking";
            FormClosing += BookARoomForm_FormClosing;
            customerPanel.ResumeLayout(false);
            customerPanel.PerformLayout();
            bookingPanel.ResumeLayout(false);
            bookingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomPricesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel customerPanel;
        private Label customerLabel;
        private Panel bookingPanel;
        private Label bookingLabel;
        private TextBox zipCodeTextBox;
        private Label label1;
        private MaskedTextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox idNoTextBox;
        private Label idNoLabel;
        private Button createButton;
        private TextBox addressTextBox;
        private Label addressLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox countryTextBox;
        private Label countryLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
        private DataGridView roomPricesDataGridView;
        private Label costLabel;
        private Label totalCostLabel;
        private Label checkOutDateLabel;
        private Label checkInDateLabel;
        private Button searchButton;
        private Label searchLabel;
        private TextBox searchTextBox;
        private Button approveButton;
        public Label roomLabel;
        private Label roomNoLabel;
        public DateTimePicker checkOutDateTimePicker;
        public DateTimePicker checkInDateTimePicker;
        public Label daysLabel;
        private Label totalDaysLabel;
    }
}