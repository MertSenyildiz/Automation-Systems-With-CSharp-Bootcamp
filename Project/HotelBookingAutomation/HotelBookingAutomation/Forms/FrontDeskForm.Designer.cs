namespace HotelBookingAutomation.Forms
{
    partial class FrontDeskForm
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
            frontDeskTabControl.SuspendLayout();
            bookingTab.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            panel.SuspendLayout();
            bookedTab.SuspendLayout();
            checkOutTableLayout.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // frontDeskTabControl
            // 
            frontDeskTabControl.Alignment = TabAlignment.Left;
            frontDeskTabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            frontDeskTabControl.Controls.Add(bookingTab);
            frontDeskTabControl.Controls.Add(bookedTab);
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
            // FrontDeskForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 729);
            Controls.Add(frontDeskTabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FrontDeskForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Booking Front Desk";
            WindowState = FormWindowState.Maximized;
            FormClosed += FrontDeskForm_FormClosed;
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
    }
}