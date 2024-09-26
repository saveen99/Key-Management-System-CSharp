namespace KeyManagementSystem
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
            panel1 = new Panel();
            login_signupBtn = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            exit = new Label();
            label2 = new Label();
            label3 = new Label();
            login_username = new TextBox();
            login_password = new TextBox();
            label4 = new Label();
            login_ShowPass = new CheckBox();
            login_btn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(login_signupBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 564);
            panel1.TabIndex = 0;
            // 
            // login_signupBtn
            // 
            login_signupBtn.BackColor = Color.FromArgb(30, 62, 134);
            login_signupBtn.Cursor = Cursors.Hand;
            login_signupBtn.FlatAppearance.BorderSize = 0;
            login_signupBtn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            login_signupBtn.FlatStyle = FlatStyle.Flat;
            login_signupBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_signupBtn.ForeColor = Color.White;
            login_signupBtn.Location = new Point(42, 501);
            login_signupBtn.Name = "login_signupBtn";
            login_signupBtn.Size = new Size(272, 30);
            login_signupBtn.TabIndex = 2;
            login_signupBtn.Text = "SIGNUP";
            login_signupBtn.UseVisualStyleBackColor = false;
            login_signupBtn.Click += login_signupBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(108, 475);
            label5.Name = "label5";
            label5.Size = new Size(129, 14);
            label5.TabIndex = 1;
            label5.Text = "Register your Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.AASL_LOGO_pvt;
            pictureBox1.Location = new Point(72, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.Red;
            exit.Cursor = Cursors.Hand;
            exit.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.White;
            exit.Location = new Point(801, 9);
            exit.Name = "exit";
            exit.Size = new Size(17, 18);
            exit.TabIndex = 1;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(468, 187);
            label2.Name = "label2";
            label2.Size = new Size(141, 22);
            label2.TabIndex = 2;
            label2.Text = "Login Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(468, 232);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 3;
            label3.Text = "Username :";
            // 
            // login_username
            // 
            login_username.Font = new Font("Segoe UI", 11.25F);
            login_username.Location = new Point(468, 260);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(241, 30);
            login_username.TabIndex = 4;
            login_username.TextChanged += textBox1_TextChanged;
            // 
            // login_password
            // 
            login_password.Font = new Font("Segoe UI", 11.25F);
            login_password.Location = new Point(468, 339);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(241, 30);
            login_password.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(468, 311);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 5;
            label4.Text = "Password :";
            // 
            // login_ShowPass
            // 
            login_ShowPass.AutoSize = true;
            login_ShowPass.BackColor = Color.Transparent;
            login_ShowPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_ShowPass.ForeColor = Color.White;
            login_ShowPass.Location = new Point(597, 375);
            login_ShowPass.Name = "login_ShowPass";
            login_ShowPass.Size = new Size(112, 18);
            login_ShowPass.TabIndex = 7;
            login_ShowPass.Text = "Show Password";
            login_ShowPass.UseVisualStyleBackColor = false;
            login_ShowPass.CheckedChanged += login_ShowPass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.GradientActiveCaption;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatAppearance.BorderSize = 0;
            login_btn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.Black;
            login_btn.Location = new Point(468, 404);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(106, 25);
            login_btn.TabIndex = 8;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.BackImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 564);
            Controls.Add(login_btn);
            Controls.Add(login_ShowPass);
            Controls.Add(login_password);
            Controls.Add(label4);
            Controls.Add(login_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label exit;
        private Label label2;
        private Label label3;
        private TextBox login_username;
        private PictureBox pictureBox1;
        private TextBox login_password;
        private Label label4;
        private CheckBox login_ShowPass;
        private Button login_btn;
        private Button login_signupBtn;
        private Label label5;
    }
}
