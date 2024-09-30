namespace KeyManagementSystem
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            comboBox2 = new ComboBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(18, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(838, 329);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(813, 265);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 11);
            label1.Name = "label1";
            label1.Size = new Size(65, 23);
            label1.TabIndex = 0;
            label1.Text = "Keylog";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(comboBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(18, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(838, 183);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(30, 62, 134);
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            button4.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Tahoma", 9.75F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(617, 119);
            button4.Name = "button4";
            button4.Size = new Size(92, 36);
            button4.TabIndex = 14;
            button4.Text = "CLEAR";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(30, 62, 134);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            button3.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Tahoma", 9.75F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(471, 119);
            button3.Name = "button3";
            button3.Size = new Size(92, 36);
            button3.TabIndex = 13;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(30, 62, 134);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9.75F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(326, 119);
            button2.Name = "button2";
            button2.Size = new Size(92, 36);
            button2.TabIndex = 12;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 62, 134);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            button1.FlatAppearance.MouseOverBackColor = Color.DarkSlateBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9.75F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(164, 119);
            button1.Name = "button1";
            button1.Size = new Size(92, 36);
            button1.TabIndex = 11;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Taken", "Return" });
            comboBox2.Location = new Point(485, 64);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(221, 23);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(384, 67);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 8;
            label6.Text = "Taken/Return : ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(485, 24);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(221, 23);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 27);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 6;
            label5.Text = "Number : ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(164, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 67);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = " Key Name :  ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 27);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Name : ";
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AddEmployee";
            Size = new Size(875, 565);
            Load += AddEmployee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private ComboBox comboBox2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
