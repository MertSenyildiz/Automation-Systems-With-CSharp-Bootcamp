namespace TodoAutomation
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            button2 = new Button();
            todos = new ListBox();
            label2 = new Label();
            tabPage3 = new TabPage();
            Reverse = new Button();
            ctodos = new ListBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(668, 681);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(660, 648);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add ToDo";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(258, 132);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Add ToDo";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(282, 29);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 1;
            label1.Text = "ToDo";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 68);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(390, 27);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(todos);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(660, 648);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "List ToDo";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(269, 51);
            button2.Name = "button2";
            button2.Size = new Size(224, 29);
            button2.TabIndex = 2;
            button2.Text = "Completed";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // todos
            // 
            todos.FormattingEnabled = true;
            todos.ItemHeight = 20;
            todos.Location = new Point(23, 48);
            todos.Name = "todos";
            todos.Size = new Size(194, 564);
            todos.TabIndex = 1;
            todos.SelectedIndexChanged += todos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 17);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 0;
            label2.Text = "ToDo";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(Reverse);
            tabPage3.Controls.Add(ctodos);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(660, 648);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Completed ToDo";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Reverse
            // 
            Reverse.Enabled = false;
            Reverse.Location = new Point(254, 46);
            Reverse.Name = "Reverse";
            Reverse.Size = new Size(224, 29);
            Reverse.TabIndex = 5;
            Reverse.Text = "Undo";
            Reverse.UseVisualStyleBackColor = true;
            Reverse.Click += Reverse_Click;
            // 
            // ctodos
            // 
            ctodos.FormattingEnabled = true;
            ctodos.ItemHeight = 20;
            ctodos.Location = new Point(8, 43);
            ctodos.Name = "ctodos";
            ctodos.Size = new Size(194, 564);
            ctodos.TabIndex = 4;
            ctodos.SelectedIndexChanged += ctodos_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 12);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 3;
            label3.Text = "ToDo";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 682);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private ListBox todos;
        private Label label2;
        private TabPage tabPage3;
        private Button Reverse;
        private ListBox ctodos;
        private Label label3;
    }
}