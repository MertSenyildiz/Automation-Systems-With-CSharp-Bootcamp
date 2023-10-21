namespace HotelBookingAutomation.Forms
{
    partial class ManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerForm));
            rolesButton = new Button();
            usersButton = new Button();
            categoriesButton = new Button();
            customersButton = new Button();
            roomPricesButton = new Button();
            roomsButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // rolesButton
            // 
            rolesButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rolesButton.BackgroundImage = (Image)resources.GetObject("rolesButton.BackgroundImage");
            rolesButton.BackgroundImageLayout = ImageLayout.Stretch;
            rolesButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rolesButton.ForeColor = SystemColors.Desktop;
            rolesButton.Location = new Point(219, 134);
            rolesButton.Name = "rolesButton";
            rolesButton.Size = new Size(158, 151);
            rolesButton.TabIndex = 0;
            rolesButton.Text = "Roles";
            rolesButton.TextAlign = ContentAlignment.BottomCenter;
            rolesButton.UseVisualStyleBackColor = true;
            rolesButton.Click += rolesButton_Click;
            // 
            // usersButton
            // 
            usersButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersButton.BackgroundImage = (Image)resources.GetObject("usersButton.BackgroundImage");
            usersButton.BackgroundImageLayout = ImageLayout.Stretch;
            usersButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            usersButton.ForeColor = SystemColors.Desktop;
            usersButton.Location = new Point(434, 134);
            usersButton.Name = "usersButton";
            usersButton.Size = new Size(158, 151);
            usersButton.TabIndex = 1;
            usersButton.Text = "Employees";
            usersButton.TextAlign = ContentAlignment.BottomCenter;
            usersButton.UseVisualStyleBackColor = true;
            usersButton.Click += usersButton_Click;
            // 
            // categoriesButton
            // 
            categoriesButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categoriesButton.BackgroundImage = (Image)resources.GetObject("categoriesButton.BackgroundImage");
            categoriesButton.BackgroundImageLayout = ImageLayout.Stretch;
            categoriesButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            categoriesButton.ForeColor = SystemColors.Desktop;
            categoriesButton.Location = new Point(646, 134);
            categoriesButton.Name = "categoriesButton";
            categoriesButton.Size = new Size(158, 151);
            categoriesButton.TabIndex = 2;
            categoriesButton.Text = "Categories";
            categoriesButton.TextAlign = ContentAlignment.BottomCenter;
            categoriesButton.UseVisualStyleBackColor = true;
            categoriesButton.Click += categoriesButton_Click;
            // 
            // customersButton
            // 
            customersButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customersButton.BackgroundImage = (Image)resources.GetObject("customersButton.BackgroundImage");
            customersButton.BackgroundImageLayout = ImageLayout.Stretch;
            customersButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            customersButton.ForeColor = SystemColors.Desktop;
            customersButton.Location = new Point(219, 344);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(158, 151);
            customersButton.TabIndex = 3;
            customersButton.Text = "Customers";
            customersButton.TextAlign = ContentAlignment.BottomCenter;
            customersButton.UseVisualStyleBackColor = true;
            customersButton.Click += customersButton_Click;
            // 
            // roomPricesButton
            // 
            roomPricesButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roomPricesButton.BackgroundImage = (Image)resources.GetObject("roomPricesButton.BackgroundImage");
            roomPricesButton.BackgroundImageLayout = ImageLayout.Stretch;
            roomPricesButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            roomPricesButton.ForeColor = SystemColors.Desktop;
            roomPricesButton.Location = new Point(434, 344);
            roomPricesButton.Name = "roomPricesButton";
            roomPricesButton.Size = new Size(158, 151);
            roomPricesButton.TabIndex = 4;
            roomPricesButton.Text = "Room Prices";
            roomPricesButton.TextAlign = ContentAlignment.BottomCenter;
            roomPricesButton.UseVisualStyleBackColor = true;
            roomPricesButton.Click += roomPricesButton_Click;
            // 
            // roomsButton
            // 
            roomsButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roomsButton.BackgroundImage = (Image)resources.GetObject("roomsButton.BackgroundImage");
            roomsButton.BackgroundImageLayout = ImageLayout.Stretch;
            roomsButton.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            roomsButton.ForeColor = SystemColors.Desktop;
            roomsButton.Location = new Point(646, 344);
            roomsButton.Name = "roomsButton";
            roomsButton.Size = new Size(158, 151);
            roomsButton.TabIndex = 5;
            roomsButton.Text = "Rooms";
            roomsButton.TextAlign = ContentAlignment.BottomCenter;
            roomsButton.UseVisualStyleBackColor = true;
            roomsButton.Click += roomsButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(431, 81);
            label1.TabIndex = 6;
            label1.Text = "Manager Panel";
            // 
            // ManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 651);
            Controls.Add(label1);
            Controls.Add(roomsButton);
            Controls.Add(roomPricesButton);
            Controls.Add(customersButton);
            Controls.Add(categoriesButton);
            Controls.Add(usersButton);
            Controls.Add(rolesButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ManagerForm";
            Text = "Hotel Booking Manager";
            FormClosed += ManagerForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button rolesButton;
        private Button usersButton;
        private Button categoriesButton;
        private Button customersButton;
        private Button roomPricesButton;
        private Button roomsButton;
        private Label label1;
    }
}