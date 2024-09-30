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
            label1 = new Label();
            exit = new Label();
            panel2 = new Panel();
            label2 = new Label();
            logout_btn = new Button();
            keylog_btn = new Button();
            addEmployee_btn = new Button();
            dashboard_btn = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            dashboard1 = new Dashboard();
            addEmployee1 = new addEmployee1();
            keylog1 = new keylog1();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
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
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(keylog_btn);
            panel2.Controls.Add(addEmployee_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 565);
            panel2.TabIndex = 1;
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
            // logout_btn
            // 
            logout_btn.Cursor = Cursors.Hand;
            logout_btn.Location = new Point(12, 518);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(35, 35);
            logout_btn.TabIndex = 2;
            logout_btn.Text = "X";
            logout_btn.UseVisualStyleBackColor = true;
            logout_btn.Click += logout_btn_Click;
            // 
            // keylog_btn
            // 
            keylog_btn.BackColor = SystemColors.GradientActiveCaption;
            keylog_btn.Cursor = Cursors.Hand;
            keylog_btn.FlatAppearance.BorderColor = Color.FromArgb(30, 62, 134);
            keylog_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 62, 134);
            keylog_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 62, 134);
            keylog_btn.FlatStyle = FlatStyle.Flat;
            keylog_btn.Location = new Point(12, 321);
            keylog_btn.Name = "keylog_btn";
            keylog_btn.Size = new Size(200, 40);
            keylog_btn.TabIndex = 4;
            keylog_btn.Text = "KEYLOG";
            keylog_btn.UseVisualStyleBackColor = false;
            keylog_btn.Click += button3_Click;
            // 
            // addEmployee_btn
            // 
            addEmployee_btn.BackColor = SystemColors.GradientActiveCaption;
            addEmployee_btn.Cursor = Cursors.Hand;
            addEmployee_btn.FlatAppearance.BorderColor = Color.FromArgb(30, 62, 134);
            addEmployee_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 62, 134);
            addEmployee_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 62, 134);
            addEmployee_btn.FlatStyle = FlatStyle.Flat;
            addEmployee_btn.Location = new Point(12, 275);
            addEmployee_btn.Name = "addEmployee_btn";
            addEmployee_btn.Size = new Size(200, 40);
            addEmployee_btn.TabIndex = 3;
            addEmployee_btn.Text = "ADD EMPLOYEE";
            addEmployee_btn.UseVisualStyleBackColor = false;
            addEmployee_btn.Click += button2_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = SystemColors.GradientActiveCaption;
            dashboard_btn.Cursor = Cursors.Hand;
            dashboard_btn.FlatAppearance.BorderColor = Color.FromArgb(30, 62, 134);
            dashboard_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 62, 134);
            dashboard_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 62, 134);
            dashboard_btn.FlatStyle = FlatStyle.Flat;
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(12, 229);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(200, 40);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "DASHBOARD";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += button1_Click;
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
            // panel3
            // 
            panel3.Controls.Add(dashboard1);
            panel3.Controls.Add(addEmployee1);
            panel3.Controls.Add(keylog1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(225, 35);
            panel3.Name = "panel3";
            panel3.Size = new Size(875, 565);
            panel3.TabIndex = 2;
            // 
            // dashboard1
            // 
            dashboard1.Location = new Point(0, 0);
            dashboard1.Name = "dashboard1";
            dashboard1.Size = new Size(875, 565);
            dashboard1.TabIndex = 12;
            // 
            // addEmployee1
            // 
            addEmployee1.Location = new Point(0, 0);
            addEmployee1.Name = "addEmployee1";
            addEmployee1.Size = new Size(875, 565);
            addEmployee1.TabIndex = 12;
            // 
            // keylog1
            // 
            keylog1.Location = new Point(0, 0);
            keylog1.Name = "keylog1";
            keylog1.Size = new Size(875, 565);
            keylog1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1100, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button dashboard_btn;
        private Button keylog_btn;
        private Button addEmployee_btn;
        private Button logout_btn;
        private Label label2;
        private Panel panel3;
        private keylog1 keylog1;
        private addEmployee1 addEmployee1;
        private Dashboard dashboard1;
    }
}