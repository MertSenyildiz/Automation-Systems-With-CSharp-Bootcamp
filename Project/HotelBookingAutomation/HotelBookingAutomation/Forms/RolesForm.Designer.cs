namespace HotelBookingAutomation.Forms
{
    partial class RolesForm
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
            rolesDataGridView = new DataGridView();
            roleNameTextBox = new TextBox();
            addRoleButton = new Button();
            roleNameLabel = new Label();
            rolesHeaderLabel = new Label();
            updateRoleButton = new Button();
            deleteRoleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)rolesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // rolesDataGridView
            // 
            rolesDataGridView.AllowUserToAddRows = false;
            rolesDataGridView.AllowUserToDeleteRows = false;
            rolesDataGridView.AllowUserToResizeColumns = false;
            rolesDataGridView.AllowUserToResizeRows = false;
            rolesDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rolesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rolesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rolesDataGridView.Location = new Point(-1, 310);
            rolesDataGridView.MultiSelect = false;
            rolesDataGridView.Name = "rolesDataGridView";
            rolesDataGridView.ReadOnly = true;
            rolesDataGridView.RowHeadersWidth = 51;
            rolesDataGridView.RowTemplate.Height = 29;
            rolesDataGridView.Size = new Size(666, 417);
            rolesDataGridView.TabIndex = 1;
            rolesDataGridView.RowHeaderMouseDoubleClick += rolesDataGridView_RowHeaderMouseDoubleClick;
            // 
            // roleNameTextBox
            // 
            roleNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roleNameTextBox.Location = new Point(12, 160);
            roleNameTextBox.Name = "roleNameTextBox";
            roleNameTextBox.Size = new Size(309, 27);
            roleNameTextBox.TabIndex = 2;
            // 
            // addRoleButton
            // 
            addRoleButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addRoleButton.BackColor = Color.FromArgb(0, 192, 0);
            addRoleButton.Location = new Point(385, 160);
            addRoleButton.Name = "addRoleButton";
            addRoleButton.Size = new Size(200, 27);
            addRoleButton.TabIndex = 3;
            addRoleButton.Text = "Add Role";
            addRoleButton.UseVisualStyleBackColor = false;
            addRoleButton.Click += addRoleButton_Click;
            // 
            // roleNameLabel
            // 
            roleNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            roleNameLabel.AutoSize = true;
            roleNameLabel.Location = new Point(12, 124);
            roleNameLabel.Name = "roleNameLabel";
            roleNameLabel.Size = new Size(83, 20);
            roleNameLabel.TabIndex = 4;
            roleNameLabel.Text = "Role Name";
            // 
            // rolesHeaderLabel
            // 
            rolesHeaderLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rolesHeaderLabel.AutoSize = true;
            rolesHeaderLabel.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            rolesHeaderLabel.Location = new Point(213, 9);
            rolesHeaderLabel.Name = "rolesHeaderLabel";
            rolesHeaderLabel.Size = new Size(233, 106);
            rolesHeaderLabel.TabIndex = 5;
            rolesHeaderLabel.Text = "Roles";
            // 
            // updateRoleButton
            // 
            updateRoleButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            updateRoleButton.BackColor = Color.FromArgb(255, 128, 0);
            updateRoleButton.Enabled = false;
            updateRoleButton.Location = new Point(385, 210);
            updateRoleButton.Name = "updateRoleButton";
            updateRoleButton.Size = new Size(200, 27);
            updateRoleButton.TabIndex = 6;
            updateRoleButton.Text = "Update Role";
            updateRoleButton.UseVisualStyleBackColor = false;
            updateRoleButton.Visible = false;
            updateRoleButton.Click += updateRoleButton_Click;
            // 
            // deleteRoleButton
            // 
            deleteRoleButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            deleteRoleButton.BackColor = Color.FromArgb(192, 0, 0);
            deleteRoleButton.Enabled = false;
            deleteRoleButton.ForeColor = SystemColors.Control;
            deleteRoleButton.Location = new Point(385, 259);
            deleteRoleButton.Name = "deleteRoleButton";
            deleteRoleButton.Size = new Size(200, 27);
            deleteRoleButton.TabIndex = 7;
            deleteRoleButton.Text = "Delete Role";
            deleteRoleButton.UseVisualStyleBackColor = false;
            deleteRoleButton.Visible = false;
            deleteRoleButton.Click += deleteRoleButton_Click;
            // 
            // RolesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 727);
            Controls.Add(deleteRoleButton);
            Controls.Add(updateRoleButton);
            Controls.Add(rolesHeaderLabel);
            Controls.Add(roleNameLabel);
            Controls.Add(addRoleButton);
            Controls.Add(roleNameTextBox);
            Controls.Add(rolesDataGridView);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RolesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Roles";
            FormClosing += RolesForm_FormClosing;
            Load += RolesForm_LoadAsync;
            VisibleChanged += RolesForm_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)rolesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private DataGridView rolesDataGridView;
        private TextBox roleNameTextBox;
        private Button addRoleButton;
        private Label roleNameLabel;
        private Label rolesHeaderLabel;
        private Button updateRoleButton;
        private Button deleteRoleButton;
    }
}