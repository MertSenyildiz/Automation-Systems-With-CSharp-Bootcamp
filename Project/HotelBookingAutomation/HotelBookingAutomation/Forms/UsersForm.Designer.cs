namespace HotelBookingAutomation.Forms
{
    partial class UsersForm
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
            usersDataGridView = new DataGridView();
            userSearchTextBox = new TextBox();
            userSearchLabel = new Label();
            userSearchButton = new Button();
            userCreateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // usersDataGridView
            // 
            usersDataGridView.AllowUserToAddRows = false;
            usersDataGridView.AllowUserToDeleteRows = false;
            usersDataGridView.AllowUserToOrderColumns = true;
            usersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            usersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            usersDataGridView.Location = new Point(2, 287);
            usersDataGridView.MultiSelect = false;
            usersDataGridView.Name = "usersDataGridView";
            usersDataGridView.ReadOnly = true;
            usersDataGridView.RowHeadersWidth = 51;
            usersDataGridView.RowTemplate.Height = 29;
            usersDataGridView.Size = new Size(1355, 458);
            usersDataGridView.TabIndex = 0;
            usersDataGridView.RowHeaderMouseDoubleClick += usersDataGridView_RowHeaderMouseDoubleClick;
            // 
            // userSearchTextBox
            // 
            userSearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userSearchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSearchTextBox.Location = new Point(12, 198);
            userSearchTextBox.Name = "userSearchTextBox";
            userSearchTextBox.Size = new Size(579, 34);
            userSearchTextBox.TabIndex = 1;
            // 
            // userSearchLabel
            // 
            userSearchLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userSearchLabel.AutoSize = true;
            userSearchLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            userSearchLabel.Location = new Point(12, 143);
            userSearchLabel.Name = "userSearchLabel";
            userSearchLabel.Size = new Size(164, 38);
            userSearchLabel.TabIndex = 2;
            userSearchLabel.Text = "Search User";
            // 
            // userSearchButton
            // 
            userSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userSearchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSearchButton.Location = new Point(613, 198);
            userSearchButton.Name = "userSearchButton";
            userSearchButton.Size = new Size(143, 34);
            userSearchButton.TabIndex = 3;
            userSearchButton.Text = "Search";
            userSearchButton.UseVisualStyleBackColor = true;
            userSearchButton.Click += userSearchButton_Click;
            // 
            // userCreateButton
            // 
            userCreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userCreateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userCreateButton.Location = new Point(1088, 247);
            userCreateButton.Name = "userCreateButton";
            userCreateButton.Size = new Size(257, 34);
            userCreateButton.TabIndex = 4;
            userCreateButton.Text = "New Employee";
            userCreateButton.UseVisualStyleBackColor = true;
            userCreateButton.Click += userCreateButton_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 744);
            Controls.Add(userCreateButton);
            Controls.Add(userSearchButton);
            Controls.Add(userSearchLabel);
            Controls.Add(userSearchTextBox);
            Controls.Add(usersDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hotel Booking Employees";
            FormClosing += UsersForm_FormClosing;
            Load += UsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)usersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView usersDataGridView;
        private TextBox userSearchTextBox;
        private Label userSearchLabel;
        private Button userSearchButton;
        private Button userCreateButton;
    }
}