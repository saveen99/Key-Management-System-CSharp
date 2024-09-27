namespace KeyManagementSystem
{
    partial class MainForm
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
            panel1 = new Panel();
            exit = new Label();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 62, 134);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(exit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1100, 35);
            panel1.TabIndex = 0;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.Red;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(1071, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 11;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 8);
            label1.Name = "label1";
            label1.Size = new Size(151, 16);
            label1.TabIndex = 1;
            label1.Text = "Key Management System";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 565);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AASL_LOGO_pvt;
            pictureBox1.Location = new Point(28, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 135);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.FlatAppearance.BorderColor = Color.FromArgb(30, 62, 134);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 62, 134);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 62, 134);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 229);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 2;
            button1.Text = "DASHBOARD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.FlatAppearance.BorderColor = Color.FromArgb(30, 62, 134);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 62, 134);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 62, 134);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(12, 275);
            button2.Name = "button2";
            button2.Size = new Size(200, 40);
            button2.TabIndex = 3;
            button2.Text = "ADD EMPLOYEE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.FlatAppearance.BorderColor = Color.FromArgb(30, 62, 134);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 62, 134);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 62, 134);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(12, 321);
            button3.Name = "button3";
            button3.Size = new Size(200, 40);
            button3.TabIndex = 4;
            button3.Text = "HISTORY";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 518);
            button4.Name = "button4";
            button4.Size = new Size(35, 35);
            button4.TabIndex = 2;
            button4.Text = "X";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 528);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Sign Out";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private Button button2;
        private Button button4;
        private Label label2;
    }
}