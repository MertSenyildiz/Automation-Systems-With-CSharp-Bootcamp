namespace HotelBookingAutomation.Forms
{
    partial class CustomerDetailsForm
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
            deleteButton = new Button();
            updateButton = new Button();
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
            createCustomerLabel = new Label();
            idNoTextBox = new TextBox();
            idNoLabel = new Label();
            phoneTextBox = new MaskedTextBox();
            phoneLabel = new Label();
            zipCodeTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(340, 590);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(250, 29);
            deleteButton.TabIndex = 39;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // updateButton
            // 
            updateButton.Location = new Point(340, 555);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(250, 29);
            updateButton.TabIndex = 38;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // createButton
            // 
            createButton.Location = new Point(340, 520);
            createButton.Name = "createButton";
            createButton.Size = new Size(250, 29);
            createButton.TabIndex = 37;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressTextBox.Location = new Point(340, 345);
            addressTextBox.MaxLength = 400;
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(250, 128);
            addressTextBox.TabIndex = 33;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addressLabel.Location = new Point(340, 305);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(171, 28);
            addressLabel.TabIndex = 32;
            addressLabel.Text = "Customer Address";
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(340, 229);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(258, 34);
            emailTextBox.TabIndex = 31;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            emailLabel.Location = new Point(340, 189);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(148, 28);
            emailLabel.TabIndex = 30;
            emailLabel.Text = "Customer Email";
            // 
            // countryTextBox
            // 
            countryTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            countryTextBox.Location = new Point(24, 436);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(250, 34);
            countryTextBox.TabIndex = 27;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            countryLabel.Location = new Point(24, 396);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(171, 28);
            countryLabel.TabIndex = 26;
            countryLabel.Text = "Customer Country";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(24, 229);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(250, 34);
            lastNameTextBox.TabIndex = 25;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(24, 189);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(192, 28);
            lastNameLabel.TabIndex = 24;
            lastNameLabel.Text = "Customer Last Name";
            // 
            // nameTextBox
            // 
            nameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameTextBox.Location = new Point(24, 122);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(250, 34);
            nameTextBox.TabIndex = 23;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(24, 82);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(153, 28);
            nameLabel.TabIndex = 22;
            nameLabel.Text = "Customer Name";
            // 
            // createCustomerLabel
            // 
            createCustomerLabel.AutoSize = true;
            createCustomerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            createCustomerLabel.Location = new Point(24, 29);
            createCustomerLabel.Name = "createCustomerLabel";
            createCustomerLabel.Size = new Size(157, 28);
            createCustomerLabel.TabIndex = 21;
            createCustomerLabel.Text = "Create Customer";
            // 
            // idNoTextBox
            // 
            idNoTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idNoTextBox.Location = new Point(340, 122);
            idNoTextBox.Name = "idNoTextBox";
            idNoTextBox.Size = new Size(250, 34);
            idNoTextBox.TabIndex = 43;
            // 
            // idNoLabel
            // 
            idNoLabel.AutoSize = true;
            idNoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idNoLabel.Location = new Point(340, 82);
            idNoLabel.Name = "idNoLabel";
            idNoLabel.Size = new Size(120, 28);
            idNoLabel.TabIndex = 42;
            idNoLabel.Text = "Customer ID";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneTextBox.Location = new Point(24, 345);
            phoneTextBox.Mask = " (000) 000-0000";
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(258, 34);
            phoneTextBox.TabIndex = 45;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            phoneLabel.Location = new Point(24, 305);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(233, 28);
            phoneLabel.TabIndex = 44;
            phoneLabel.Text = "Customer Phone Number";
            // 
            // zipCodeTextBox
            // 
            zipCodeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            zipCodeTextBox.Location = new Point(24, 557);
            zipCodeTextBox.Name = "zipCodeTextBox";
            zipCodeTextBox.Size = new Size(250, 34);
            zipCodeTextBox.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 517);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 46;
            label1.Text = "Zip Code";
            // 
            // CustomerDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 645);
            Controls.Add(zipCodeTextBox);
            Controls.Add(label1);
            Controls.Add(phoneTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(idNoTextBox);
            Controls.Add(idNoLabel);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(createButton);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(emailTextBox);
            Controls.Add(emailLabel);
            Controls.Add(countryTextBox);
            Controls.Add(countryLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(nameTextBox);
            Controls.Add(nameLabel);
            Controls.Add(createCustomerLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CustomerDetailsForm";
            Text = "Hotel Booking Customer Details ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteButton;
        private Button updateButton;
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
        private Label createCustomerLabel;
        private TextBox idNoTextBox;
        private Label idNoLabel;
        private MaskedTextBox phoneTextBox;
        private Label phoneLabel;
        private TextBox zipCodeTextBox;
        private Label label1;
    }
}