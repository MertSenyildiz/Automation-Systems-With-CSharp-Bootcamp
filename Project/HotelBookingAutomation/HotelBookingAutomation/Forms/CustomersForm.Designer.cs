namespace HotelBookingAutomation.Forms
{
    partial class CustomersForm
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
            customerCreateButton = new Button();
            customerSearchButton = new Button();
            customerSearchLabel = new Label();
            customerSearchTextBox = new TextBox();
            customersDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // customerCreateButton
            // 
            customerCreateButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerCreateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerCreateButton.Location = new Point(1088, 245);
            customerCreateButton.Name = "customerCreateButton";
            customerCreateButton.Size = new Size(257, 34);
            customerCreateButton.TabIndex = 9;
            customerCreateButton.Text = "New Customer";
            customerCreateButton.UseVisualStyleBackColor = true;
            customerCreateButton.Click += customerCreateButton_Click;
            // 
            // customerSearchButton
            // 
            customerSearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerSearchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerSearchButton.Location = new Point(613, 196);
            customerSearchButton.Name = "customerSearchButton";
            customerSearchButton.Size = new Size(143, 34);
            customerSearchButton.TabIndex = 8;
            customerSearchButton.Text = "Search";
            customerSearchButton.UseVisualStyleBackColor = true;
            customerSearchButton.Click += customerSearchButton_Click;
            // 
            // customerSearchLabel
            // 
            customerSearchLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerSearchLabel.AutoSize = true;
            customerSearchLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            customerSearchLabel.Location = new Point(12, 141);
            customerSearchLabel.Name = "customerSearchLabel";
            customerSearchLabel.Size = new Size(227, 38);
            customerSearchLabel.TabIndex = 7;
            customerSearchLabel.Text = "Search Customer";
            // 
            // customerSearchTextBox
            // 
            customerSearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerSearchTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            customerSearchTextBox.Location = new Point(12, 196);
            customerSearchTextBox.Name = "customerSearchTextBox";
            customerSearchTextBox.Size = new Size(579, 34);
            customerSearchTextBox.TabIndex = 6;
            // 
            // customersDataGridView
            // 
            customersDataGridView.AllowUserToAddRows = false;
            customersDataGridView.AllowUserToDeleteRows = false;
            customersDataGridView.AllowUserToOrderColumns = true;
            customersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDataGridView.Location = new Point(2, 285);
            customersDataGridView.MultiSelect = false;
            customersDataGridView.Name = "customersDataGridView";
            customersDataGridView.ReadOnly = true;
            customersDataGridView.RowHeadersWidth = 51;
            customersDataGridView.RowTemplate.Height = 29;
            customersDataGridView.Size = new Size(1355, 458);
            customersDataGridView.TabIndex = 5;
            customersDataGridView.RowHeaderMouseDoubleClick += customersDataGridView_RowHeaderMouseDoubleClick;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 744);
            Controls.Add(customerCreateButton);
            Controls.Add(customerSearchButton);
            Controls.Add(customerSearchLabel);
            Controls.Add(customerSearchTextBox);
            Controls.Add(customersDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "CustomersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Hotel Booking Customers";
            FormClosing += CustomersForm_FormClosing;
            Load += CustomersForm_Load;
            ((System.ComponentModel.ISupportInitialize)customersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button customerCreateButton;
        private Button customerSearchButton;
        private Label customerSearchLabel;
        private TextBox customerSearchTextBox;
        private DataGridView customersDataGridView;
    }
}