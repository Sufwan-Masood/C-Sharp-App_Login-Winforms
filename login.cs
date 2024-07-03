using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CheckListBox
{
    public partial class login : Form
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        public login()
        {
            InitializeComponent();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                this.textBox1.Focus();
                errorProvider1.SetError(this.textBox1, "Please Fill The ID Field");
                errorProvider1.Icon = Properties.Resources.cross;
            }
            else
            {
                errorProvider1.Icon = Properties.Resources.tick;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                this.textBox2.Focus();
                errorProvider2.SetError(this.textBox2, "Please Fill The Password Field");
                errorProvider2.Icon = Properties.Resources.cross;
            }
            else
            {
                errorProvider2.Icon = Properties.Resources.tick;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            //if (textBox1.Text != "admin" || textBox2.Text != "admin")
            //{
            //    MessageBox.Show("Please Enter Correct Credentials");
            //}
            //else
            //{
            //    Form1 form = new Form1();
            //    form.Show();
            //}
            if (Regex.IsMatch(textBox1.Text, pattern))
            {
                if (textBox2.Text == "admin")
                {
                    Form1 form = new Form1();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter Correct Password\nDefault Password: admin", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }

            else
            {
                MessageBox.Show("Please Enter a regular expression Email in ID field\nDefault ID: admin@form.com", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }

        }
    }
}
