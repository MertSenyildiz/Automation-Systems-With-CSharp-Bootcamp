namespace HotelBookingAutomation.Forms
{
    partial class UsersDetailsForm
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
            createUserLabel = new Label();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            lastNameLabel = new Label();
            usernameTextBox = new TextBox();
            usernameLabel = new Label();
            phoneLabel = new Label();
            phoneTextBox = new MaskedTextBox();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            addressTextBox = new TextBox();
            addressLabel = new Label();
            roleGroupBox = new GroupBox();
            supervisorValue = new RadioButton();
            frontDeskValue = new RadioButton();
            updatePasswordGroupBox = new GroupBox();
            updatePasswordButton = new Button();
            newPasswordTextBox = new TextBox();
            newPasswordLabel = new Label();
            passwordGroupBox = new GroupBox();
            confirmPasswordTextBox = new TextBox();
            confimPasswordLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            createButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            roleGroupBox.SuspendLayout();
            updatePasswordGroupBox.SuspendLayout();
            passwordGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // createUserLabel
            // 
            createUserLabel.AutoSize = true;
            createUserLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createUserLabel.Location = new Point(12, 27);
            createUserLabel.Name = "createUserLabel";
            createUserLabel.Size = new Size(159, 28);
            createUserLabel.TabIndex = 0;
            createUserLabel.Text = "Create Employee";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(12, 80);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(155, 28);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Employee Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(12, 120);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 34);
            nameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(12, 227);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(250, 34);
            lastNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(12, 187);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(194, 28);
            lastNameLabel.TabIndex = 3;
            lastNameLabel.Text = "Employee Last Name";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(12, 343);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(250, 34);
            usernameTextBox.TabIndex = 6;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(12, 303);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(190, 28);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Employee Username";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(328, 80);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(235, 28);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Employee Phone Number";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(328, 120);
            phoneTextBox.Mask = " (000) 000-0000";
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(258, 34);
            phoneTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(328, 227);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(258, 34);
            emailTextBox.TabIndex = 11;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(328, 187);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(150, 28);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Employee Email";
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressTextBox.Location = new Point(328, 343);
            addressTextBox.MaxLength = 400;
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(250, 128);
            addressTextBox.TabIndex = 13;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressLabel.Location = new Point(328, 303);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(173, 28);
            addressLabel.TabIndex = 12;
            addressLabel.Text = "Employee Address";
            // 
            // roleGroupBox
            // 
            roleGroupBox.Controls.Add(supervisorValue);
            roleGroupBox.Controls.Add(frontDeskValue);
            roleGroupBox.Location = new Point(12, 410);
            roleGroupBox.Name = "roleGroupBox";
            roleGroupBox.Size = new Size(267, 113);
            roleGroupBox.TabIndex = 15;
            roleGroupBox.TabStop = false;
            roleGroupBox.Text = "Employee Role";
            // 
            // supervisorValue
            // 
            supervisorValue.AutoSize = true;
            supervisorValue.Location = new Point(11, 74);
            supervisorValue.Name = "supervisorValue";
            supervisorValue.Size = new Size(99, 24);
            supervisorValue.TabIndex = 1;
            supervisorValue.TabStop = true;
            supervisorValue.Text = "Supervisor";
            supervisorValue.UseVisualStyleBackColor = true;
            supervisorValue.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // frontDeskValue
            // 
            frontDeskValue.AutoSize = true;
            frontDeskValue.Location = new Point(11, 33);
            frontDeskValue.Name = "frontDeskValue";
            frontDeskValue.Size = new Size(100, 24);
            frontDeskValue.TabIndex = 0;
            frontDeskValue.TabStop = true;
            frontDeskValue.Text = "Front Desk";
            frontDeskValue.UseVisualStyleBackColor = true;
            frontDeskValue.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // updatePasswordGroupBox
            // 
            updatePasswordGroupBox.Controls.Add(updatePasswordButton);
            updatePasswordGroupBox.Controls.Add(newPasswordTextBox);
            updatePasswordGroupBox.Controls.Add(newPasswordLabel);
            updatePasswordGroupBox.Location = new Point(328, 496);
            updatePasswordGroupBox.Name = "updatePasswordGroupBox";
            updatePasswordGroupBox.Size = new Size(258, 189);
            updatePasswordGroupBox.TabIndex = 16;
            updatePasswordGroupBox.TabStop = false;
            updatePasswordGroupBox.Text = "Update Password";
            // 
            // updatePasswordButton
            // 
            updatePasswordButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            updatePasswordButton.Location = new Point(66, 146);
            updatePasswordButton.Name = "updatePasswordButton";
            updatePasswordButton.Size = new Size(143, 29);
            updatePasswordButton.TabIndex = 24;
            updatePasswordButton.Text = "Update Password";
            updatePasswordButton.UseVisualStyleBackColor = true;
            updatePasswordButton.Click += updatePasswordButton_Click;
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordTextBox.Location = new Point(5, 86);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PasswordChar = '*';
            newPasswordTextBox.Size = new Size(250, 34);
            newPasswordTextBox.TabIndex = 23;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordLabel.Location = new Point(5, 46);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(137, 28);
            newPasswordLabel.TabIndex = 22;
            newPasswordLabel.Text = "New Password";
            // 
            // passwordGroupBox
            // 
            passwordGroupBox.Controls.Add(confirmPasswordTextBox);
            passwordGroupBox.Controls.Add(confimPasswordLabel);
            passwordGroupBox.Controls.Add(passwordTextBox);
            passwordGroupBox.Controls.Add(passwordLabel);
            passwordGroupBox.Location = new Point(12, 542);
            passwordGroupBox.Name = "passwordGroupBox";
            passwordGroupBox.Size = new Size(267, 239);
            passwordGroupBox.TabIndex = 17;
            passwordGroupBox.TabStop = false;
            passwordGroupBox.Text = "Create Password";
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTextBox.Location = new Point(0, 179);
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(250, 34);
            confirmPasswordTextBox.TabIndex = 21;
            // 
            // confimPasswordLabel
            // 
            confimPasswordLabel.AutoSize = true;
            confimPasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confimPasswordLabel.Location = new Point(0, 139);
            confimPasswordLabel.Name = "confimPasswordLabel";
            confimPasswordLabel.Size = new Size(168, 28);
            confimPasswordLabel.TabIndex = 20;
            confimPasswordLabel.Text = "Confirm Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(0, 83);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(250, 34);
            passwordTextBox.TabIndex = 19;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(0, 43);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(93, 28);
            passwordLabel.TabIndex = 18;
            passwordLabel.Text = "Password";
            // 
            // createButton
            // 
            createButton.Location = new Point(328, 699);
            createButton.Name = "createButton";
            createButton.Size = new Size(258, 29);
            createButton.TabIndex = 18;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(328, 734);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(258, 29);
            updateButton.TabIndex = 19;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(328, 769);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(258, 29);
            deleteButton.TabIndex = 20;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // UsersDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 829);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(createButton);
            Controls.Add(passwordGroupBox);
            Controls.Add(updatePasswordGroupBox);
            Controls.Add(roleGroupBox);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(usernameTextBox);
            Controls.Add(usernameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(createUserLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "UsersDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hotel Booking Employee Details";
            roleGroupBox.ResumeLayout(false);
            roleGroupBox.PerformLayout();
            updatePasswordGroupBox.ResumeLayout(false);
            updatePasswordGroupBox.PerformLayout();
            passwordGroupBox.ResumeLayout(false);
            passwordGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label createUserLabel;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox lastNameTextBox;
        private Label lastNameLabel;
        private TextBox usernameTextBox;
        private Label usernameLabel;
        private Label phoneLabel;
        private MaskedTextBox phoneTextBox;
        private TextBox emailTextBox;
        private Label emailLabel;
        private TextBox addressTextBox;
        private Label addressLabel;
        private GroupBox roleGroupBox;
        private RadioButton frontDeskValue;
        private RadioButton supervisorValue;
        private GroupBox updatePasswordGroupBox;
        private GroupBox passwordGroupBox;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private TextBox confirmPasswordTextBox;
        private Label confimPasswordLabel;
        private TextBox newPasswordTextBox;
        private Label newPasswordLabel;
        private Button updatePasswordButton;
        private Button createButton;
        private Button updateButton;
        private Button deleteButton;
    }
}