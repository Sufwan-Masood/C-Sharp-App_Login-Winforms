namespace CheckListBox
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
            checkedListBox1 = new CheckedListBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = SystemColors.GradientActiveCaption;
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Sitka Banner", 14F, FontStyle.Italic, GraphicsUnit.Point);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Rolex Daytona", "Seiko 21 Jewels", "Casio G-Shock", "Jacob and Co. Timeless Treasure", "A-P", "Richard Millie" });
            checkedListBox1.Location = new Point(12, 67);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(398, 244);
            checkedListBox1.TabIndex = 0;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(12, 317);
            button1.Name = "button1";
            button1.Size = new Size(181, 59);
            button1.TabIndex = 1;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.BackColor = Color.LightSkyBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(494, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(282, 33);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 2;
            comboBox1.Visible = false;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightSkyBlue;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(494, 352);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(343, 129);
            listBox1.TabIndex = 3;
            listBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(494, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 52);
            label1.TabIndex = 4;
            label1.Text = "Selected Watches";
            label1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Banner", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(27, 0);
            label3.Name = "label3";
            label3.Size = new Size(285, 52);
            label3.TabIndex = 4;
            label3.Text = "Available Watches";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(475, 296);
            label2.Name = "label2";
            label2.Size = new Size(382, 52);
            label2.TabIndex = 4;
            label2.Text = "Selected Watches Indices";
            label2.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 448);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(398, 33);
            textBox1.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 510);
            button2.Name = "button2";
            button2.Size = new Size(181, 59);
            button2.TabIndex = 1;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 717);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(245, 33);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(890, 591);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(checkedListBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Check List Box";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Button button1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private TextBox textBox2;
    }
}