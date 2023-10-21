namespace HotelBookingAutomation.Forms
{
    partial class SupervisorForm
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
            frontDeskTabControl = new TabControl();
            bookingTab = new TabPage();
            tableLayoutPanel = new TableLayoutPanel();
            panel = new Panel();
            roomsButton = new Button();
            availableRoomsLabel = new Label();
            checkOutDateTimePicker = new DateTimePicker();
            checkOutDateLabel = new Label();
            checkInDateTimePicker = new DateTimePicker();
            checkInDateLabel = new Label();
            roomsFlowLayoutPanel = new FlowLayoutPanel();
            bookedTab = new TabPage();
            checkOutTableLayout = new TableLayoutPanel();
            panel1 = new Panel();
            bookedRoomsLabel = new Label();
            monthCalendar = new MonthCalendar();
            bookedRoomsFlowLayoutPanel = new FlowLayoutPanel();
            deleteBooking = new TabPage();
            panel2 = new Panel();
            searchReservationButton = new Button();
            endDateTimePicker = new DateTimePicker();
            label1 = new Label();
            startDateTimePicker = new DateTimePicker();
            label2 = new Label();
            searchButton = new Button();
            searchLabel = new Label();
            searchTextBox = new TextBox();
            idNoTextBox = new TextBox();
            idNoLabel = new Label();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            nameTextBox = new TextBox();
            nameLabel = new Label();
            customerBookingsDataGridView = new DataGridView();
            frontDeskTabControl.SuspendLayout();
            bookingTab.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            panel.SuspendLayout();
            bookedTab.SuspendLayout();
            checkOutTableLayout.SuspendLayout();
            panel1.SuspendLayout();
            deleteBooking.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customerBookingsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // frontDeskTabControl
            // 
            frontDeskTabControl.Alignment = TabAlignment.Left;
            frontDeskTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frontDeskTabControl.Controls.Add(bookingTab);
            frontDeskTabControl.Controls.Add(bookedTab);
            frontDeskTabControl.Controls.Add(deleteBooking);
            frontDeskTabControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            frontDeskTabControl.Location = new Point(-2, 1);
            frontDeskTabControl.Multiline = true;
            frontDeskTabControl.Name = "frontDeskTabControl";
            frontDeskTabControl.SelectedIndex = 0;
            frontDeskTabControl.Size = new Size(1309, 728);
            frontDeskTabControl.SizeMode = TabSizeMode.FillToRight;
            frontDeskTabControl.TabIndex = 0;
            frontDeskTabControl.SelectedIndexChanged += frontDeskTabControl_SelectedIndexChanged;
            // 
            // bookingTab
            // 
            bookingTab.Controls.Add(tableLayoutPanel);
            bookingTab.Location = new Point(37, 4);
            bookingTab.Name = "bookingTab";
            bookingTab.Padding = new Padding(3);
            bookingTab.Size = new Size(1268, 720);
            bookingTab.TabIndex = 0;
            bookingTab.Text = "Booking";
            bookingTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(panel, 0, 0);
            tableLayoutPanel.Controls.Add(roomsFlowLayoutPanel, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(3, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1262, 714);
            tableLayoutPanel.TabIndex = 0;
            // 
            // panel
            // 
            panel.Controls.Add(roomsButton);
            panel.Controls.Add(availableRoomsLabel);
            panel.Controls.Add(checkOutDateTimePicker);
            panel.Controls.Add(checkOutDateLabel);
            panel.Controls.Add(checkInDateTimePicker);
            panel.Controls.Add(checkInDateLabel);
            panel.Dock = DockStyle.Left;
            panel.Location = new Point(3, 3);
            panel.Name = "panel";
            panel.Size = new Size(372, 708);
            panel.TabIndex = 8;
            // 
            // roomsButton
            // 
            roomsButton.Location = new Point(50, 516);
            roomsButton.Name = "roomsButton";
            roomsButton.Size = new Size(278, 41);
            roomsButton.TabIndex = 17;
            roomsButton.Text = "Get Available Rooms";
            roomsButton.UseVisualStyleBackColor = true;
            roomsButton.Click += roomsButton_Click;
            // 
            // availableRoomsLabel
            // 
            availableRoomsLabel.AutoSize = true;
            availableRoomsLabel.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            availableRoomsLabel.Location = new Point(50, 156);
            availableRoomsLabel.Name = "availableRoomsLabel";
            availableRoomsLabel.Size = new Size(313, 54);
            availableRoomsLabel.TabIndex = 12;
            availableRoomsLabel.Text = "Available Rooms";
            // 
            // checkOutDateTimePicker
            // 
            checkOutDateTimePicker.Location = new Point(50, 418);
            checkOutDateTimePicker.Name = "checkOutDateTimePicker";
            checkOutDateTimePicker.Size = new Size(278, 34);
            checkOutDateTimePicker.TabIndex = 16;
            checkOutDateTimePicker.KeyPress += checkOutDateTimePicker_KeyPress;
            // 
            // checkOutDateLabel
            // 
            checkOutDateLabel.AutoSize = true;
            checkOutDateLabel.Location = new Point(50, 375);
            checkOutDateLabel.Name = "checkOutDateLabel";
            checkOutDateLabel.Size = new Size(148, 28);
            checkOutDateLabel.TabIndex = 15;
            checkOutDateLabel.Text = "Check Out Date";
            // 
            // checkInDateTimePicker
            // 
            checkInDateTimePicker.Location = new Point(50, 295);
            checkInDateTimePicker.Name = "checkInDateTimePicker";
            checkInDateTimePicker.Size = new Size(278, 34);
            checkInDateTimePicker.TabIndex = 14;
            checkInDateTimePicker.ValueChanged += checkInDateTimePicker_ValueChanged;
            checkInDateTimePicker.KeyPress += checkInDateTimePicker_KeyPress;
            // 
            // checkInDateLabel
            // 
            checkInDateLabel.AutoSize = true;
            checkInDateLabel.Location = new Point(50, 252);
            checkInDateLabel.Name = "checkInDateLabel";
            checkInDateLabel.Size = new Size(131, 28);
            checkInDateLabel.TabIndex = 13;
            checkInDateLabel.Text = "Check In Date";
            // 
            // roomsFlowLayoutPanel
            // 
            roomsFlowLayoutPanel.AutoScroll = true;
            roomsFlowLayoutPanel.Dock = DockStyle.Fill;
            roomsFlowLayoutPanel.Location = new Point(381, 3);
            roomsFlowLayoutPanel.Name = "roomsFlowLayoutPanel";
            roomsFlowLayoutPanel.Size = new Size(878, 708);
            roomsFlowLayoutPanel.TabIndex = 9;
            // 
            // bookedTab
            // 
            bookedTab.Controls.Add(checkOutTableLayout);
            bookedTab.Location = new Point(37, 4);
            bookedTab.Name = "bookedTab";
            bookedTab.Size = new Size(1268, 720);
            bookedTab.TabIndex = 1;
            bookedTab.Text = "Check Out";
            bookedTab.UseVisualStyleBackColor = true;
            // 
            // checkOutTableLayout
            // 
            checkOutTableLayout.ColumnCount = 2;
            checkOutTableLayout.ColumnStyles.Add(new ColumnStyle());
            checkOutTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            checkOutTableLayout.Controls.Add(panel1, 0, 0);
            checkOutTableLayout.Controls.Add(bookedRoomsFlowLayoutPanel, 1, 0);
            checkOutTableLayout.Dock = DockStyle.Fill;
            checkOutTableLayout.Location = new Point(0, 0);
            checkOutTableLayout.Name = "checkOutTableLayout";
            checkOutTableLayout.RowCount = 1;
            checkOutTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            checkOutTableLayout.Size = new Size(1268, 720);
            checkOutTableLayout.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(bookedRoomsLabel);
            panel1.Controls.Add(monthCalendar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 714);
            panel1.TabIndex = 0;
            // 
            // bookedRoomsLabel
            // 
            bookedRoomsLabel.AutoSize = true;
            bookedRoomsLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            bookedRoomsLabel.Location = new Point(29, 51);
            bookedRoomsLabel.Name = "bookedRoomsLabel";
            bookedRoomsLabel.Size = new Size(342, 62);
            bookedRoomsLabel.TabIndex = 1;
            bookedRoomsLabel.Text = "Booked Rooms";
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(59, 195);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // bookedRoomsFlowLayoutPanel
            // 
            bookedRoomsFlowLayoutPanel.AutoScroll = true;
            bookedRoomsFlowLayoutPanel.Dock = DockStyle.Fill;
            bookedRoomsFlowLayoutPanel.Location = new Point(411, 3);
            bookedRoomsFlowLayoutPanel.Name = "bookedRoomsFlowLayoutPanel";
            bookedRoomsFlowLayoutPanel.Size = new Size(854, 714);
            bookedRoomsFlowLayoutPanel.TabIndex = 1;
            // 
            // deleteBooking
            // 
            deleteBooking.Controls.Add(panel2);
            deleteBooking.Controls.Add(customerBookingsDataGridView);
            deleteBooking.Location = new Point(37, 4);
            deleteBooking.Name = "deleteBooking";
            deleteBooking.Size = new Size(1268, 720);
            deleteBooking.TabIndex = 2;
            deleteBooking.Text = "Delete Booking";
            deleteBooking.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(searchReservationButton);
            panel2.Controls.Add(endDateTimePicker);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(startDateTimePicker);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(searchButton);
            panel2.Controls.Add(searchLabel);
            panel2.Controls.Add(searchTextBox);
            panel2.Controls.Add(idNoTextBox);
            panel2.Controls.Add(idNoLabel);
            panel2.Controls.Add(emailTextBox);
            panel2.Controls.Add(emailLabel);
            panel2.Controls.Add(lastNameTextBox);
            panel2.Controls.Add(lastNameLabel);
            panel2.Controls.Add(nameTextBox);
            panel2.Controls.Add(nameLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1268, 373);
            panel2.TabIndex = 1;
            // 
            // searchReservationButton
            // 
            searchReservationButton.Location = new Point(1033, 285);
            searchReservationButton.Name = "searchReservationButton";
            searchReservationButton.Size = new Size(199, 58);
            searchReservationButton.TabIndex = 101;
            searchReservationButton.Text = "Search Reservation";
            searchReservationButton.UseVisualStyleBackColor = true;
            searchReservationButton.Click += searchReservationButton_Click;
            // 
            // endDateTimePicker
            // 
            endDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            endDateTimePicker.Location = new Point(954, 104);
            endDateTimePicker.Name = "endDateTimePicker";
            endDateTimePicker.Size = new Size(278, 34);
            endDateTimePicker.TabIndex = 100;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(954, 61);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 99;
            label1.Text = "Check Out Date";
            // 
            // startDateTimePicker
            // 
            startDateTimePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startDateTimePicker.Location = new Point(593, 104);
            startDateTimePicker.Name = "startDateTimePicker";
            startDateTimePicker.Size = new Size(278, 34);
            startDateTimePicker.TabIndex = 98;
            startDateTimePicker.ValueChanged += startDateTimePicker_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(593, 61);
            label2.Name = "label2";
            label2.Size = new Size(131, 28);
            label2.TabIndex = 97;
            label2.Text = "Check In Date";
            // 
            // searchButton
            // 
            searchButton.Location = new Point(287, 61);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(199, 34);
            searchButton.TabIndex = 96;
            searchButton.Text = "Search Customer";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchLabel
            // 
            searchLabel.AutoSize = true;
            searchLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchLabel.Location = new Point(37, 21);
            searchLabel.Name = "searchLabel";
            searchLabel.Size = new Size(121, 28);
            searchLabel.TabIndex = 95;
            searchLabel.Text = "Search by ID";
            // 
            // searchTextBox
            // 
            searchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchTextBox.Location = new Point(37, 61);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(233, 34);
            searchTextBox.TabIndex = 94;
            // 
            // idNoTextBox
            // 
            idNoTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idNoTextBox.Location = new Point(287, 187);
            idNoTextBox.Name = "idNoTextBox";
            idNoTextBox.ReadOnly = true;
            idNoTextBox.Size = new Size(199, 34);
            idNoTextBox.TabIndex = 93;
            // 
            // idNoLabel
            // 
            idNoLabel.AutoSize = true;
            idNoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idNoLabel.Location = new Point(287, 147);
            idNoLabel.Name = "idNoLabel";
            idNoLabel.Size = new Size(120, 28);
            idNoLabel.TabIndex = 92;
            idNoLabel.Text = "Customer ID";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(287, 294);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.ReadOnly = true;
            emailTextBox.Size = new Size(199, 34);
            emailTextBox.TabIndex = 91;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(287, 254);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(148, 28);
            emailLabel.TabIndex = 90;
            emailLabel.Text = "Customer Email";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(37, 294);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.ReadOnly = true;
            lastNameTextBox.Size = new Size(171, 34);
            lastNameTextBox.TabIndex = 89;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(37, 254);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(192, 28);
            lastNameLabel.TabIndex = 88;
            lastNameLabel.Text = "Customer Last Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(37, 187);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(171, 34);
            nameTextBox.TabIndex = 87;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(37, 147);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(153, 28);
            nameLabel.TabIndex = 86;
            nameLabel.Text = "Customer Name";
            // 
            // customerBookingsDataGridView
            // 
            customerBookingsDataGridView.AllowUserToAddRows = false;
            customerBookingsDataGridView.AllowUserToDeleteRows = false;
            customerBookingsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customerBookingsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerBookingsDataGridView.Dock = DockStyle.Bottom;
            customerBookingsDataGridView.Location = new Point(0, 373);
            customerBookingsDataGridView.MultiSelect = false;
            customerBookingsDataGridView.Name = "customerBookingsDataGridView";
            customerBookingsDataGridView.ReadOnly = true;
            customerBookingsDataGridView.RowHeadersWidth = 51;
            customerBookingsDataGridView.RowTemplate.Height = 29;
            customerBookingsDataGridView.Size = new Size(1268, 347);
            customerBookingsDataGridView.TabIndex = 0;
            customerBookingsDataGridView.RowHeaderMouseDoubleClick += customerBookingsDataGridView_RowHeaderMouseDoubleClick;
            // 
            // SupervisorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 729);
            Controls.Add(frontDeskTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "SupervisorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Booking Front Desk";
            WindowState = FormWindowState.Maximized;
            FormClosed += SupervisorForm_FormClosed;
            Load += FrontDeskForm_Load;
            frontDeskTabControl.ResumeLayout(false);
            bookingTab.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            bookedTab.ResumeLayout(false);
            checkOutTableLayout.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            deleteBooking.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)customerBookingsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl frontDeskTabControl;
        private TabPage bookingTab;
        private TableLayoutPanel tableLayoutPanel;
        private Panel panel;
        private Button roomsButton;
        private Label availableRoomsLabel;
        private DateTimePicker checkOutDateTimePicker;
        private Label checkOutDateLabel;
        private DateTimePicker checkInDateTimePicker;
        private Label checkInDateLabel;
        private FlowLayoutPanel roomsFlowLayoutPanel;
        private TabPage bookedTab;
        private TableLayoutPanel checkOutTableLayout;
        private Panel panel1;
        private MonthCalendar monthCalendar;
        private FlowLayoutPanel bookedRoomsFlowLayoutPanel;
        private Label bookedRoomsLabel;
        private TabPage deleteBooking;
        private DataGridView customerBookingsDataGridView;
        private Panel panel2;
        private Button searchReservationButton;
        public DateTimePicker endDateTimePicker;
        private Label label1;
        public DateTimePicker startDateTimePicker;
        private Label label2;
        private Button searchButton;
        private Label searchLabel;
        private TextBox searchTextBox;
        private TextBox idNoTextBox;
        private Label idNoLabel;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox nameTextBox;
        private Label nameLabel;
    }
}