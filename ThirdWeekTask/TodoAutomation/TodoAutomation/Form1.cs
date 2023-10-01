namespace TodoAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                todos.Items.Add(textBox1.Text);
                MessageBox.Show($"{textBox1.Text} added to the to do list");
                textBox1.Text = "";
            }
            else
            {
                MessageBox.Show($"Todo cannot be empty!");
            }
        }

        private void todos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (todos.SelectedItem != null)
                button2.Enabled = true;
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string todo = todos.GetItemText(todos.SelectedItem);
            MessageBox.Show($"{todo} is completed");
            ctodos.Items.Add(todo);
            todos.Items.Remove(todos.SelectedItem);
        }

        private void ctodos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctodos.SelectedItem != null)
                Reverse.Enabled = true;
            else
            {
                Reverse.Enabled = false;
            }
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            string todo = ctodos.GetItemText(ctodos.SelectedItem);
            MessageBox.Show($"{todo} is undone");
            todos.Items.Add(todo);
            ctodos.Items.Remove(ctodos.SelectedItem);
        }
    }
}