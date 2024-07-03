namespace CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            foreach (var v in checkedListBox1.CheckedItems)
            {
                comboBox1.Items.Add(v);
            }
            foreach (var v in checkedListBox1.CheckedIndices)
            {
                listBox1.Items.Add(v);
            }
            listBox1.Visible = true;
            comboBox1.Visible = true;
            label2.Visible = true;
            label1.Visible = true;

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = checkedListBox1.SelectedItem.ToString();
            }
            catch
            {
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;
            checkedListBox1.Items.RemoveAt(index);

            checkedListBox1.Items.Insert(index, textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}