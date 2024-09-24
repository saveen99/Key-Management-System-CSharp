namespace KeyManagementSystem
{
    partial class RegisterForm
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
            signup_btn = new Button();
            signup_ShowPass = new CheckBox();
            signup_password = new TextBox();
            label4 = new Label();
            signup_username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            exit = new Label();
            panel1 = new Panel();
            signup_loginBtn = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // signup_btn
            // 
            signup_btn.BackColor = SystemColors.GradientActiveCaption;
            signup_btn.Cursor = Cursors.Hand;
            signup_btn.FlatAppearance.BorderSize = 0;
            signup_btn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.Black;
            signup_btn.Location = new Point(474, 404);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(106, 25);
            signup_btn.TabIndex = 17;
            signup_btn.Text = "SIGNUP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // signup_ShowPass
            // 
            signup_ShowPass.AutoSize = true;
            signup_ShowPass.BackColor = Color.Transparent;
            signup_ShowPass.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_ShowPass.ForeColor = Color.White;
            signup_ShowPass.Location = new Point(603, 375);
            signup_ShowPass.Name = "signup_ShowPass";
            signup_ShowPass.Size = new Size(112, 18);
            signup_ShowPass.TabIndex = 16;
            signup_ShowPass.Text = "Show Password";
            signup_ShowPass.UseVisualStyleBackColor = false;
            signup_ShowPass.CheckedChanged += signup_ShowPass_CheckedChanged;
            // 
            // signup_password
            // 
            signup_password.Font = new Font("Segoe UI", 11.25F);
            signup_password.Location = new Point(474, 339);
            signup_password.Multiline = true;
            signup_password.Name = "signup_password";
            signup_password.PasswordChar = '*';
            signup_password.Size = new Size(241, 30);
            signup_password.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(474, 311);
            label4.Name = "label4";
            label4.Size = new Size(71, 16);
            label4.TabIndex = 14;
            label4.Text = "Password :";
            // 
            // signup_username
            // 
            signup_username.Font = new Font("Segoe UI", 11.25F);
            signup_username.Location = new Point(474, 260);
            signup_username.Multiline = true;
            signup_username.Name = "signup_username";
            signup_username.Size = new Size(241, 30);
            signup_username.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(474, 232);
            label3.Name = "label3";
            label3.Size = new Size(74, 16);
            label3.TabIndex = 12;
            label3.Text = "Username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(474, 187);
            label2.Name = "label2";
            label2.Size = new Size(169, 22);
            label2.TabIndex = 11;
            label2.Text = "Register Account";
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
            exit.TabIndex = 10;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(signup_loginBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 564);
            panel1.TabIndex = 9;
            // 
            // signup_loginBtn
            // 
            signup_loginBtn.BackColor = Color.FromArgb(30, 62, 134);
            signup_loginBtn.Cursor = Cursors.Hand;
            signup_loginBtn.FlatAppearance.BorderSize = 0;
            signup_loginBtn.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            signup_loginBtn.FlatStyle = FlatStyle.Flat;
            signup_loginBtn.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signup_loginBtn.ForeColor = Color.White;
            signup_loginBtn.Location = new Point(42, 501);
            signup_loginBtn.Name = "signup_loginBtn";
            signup_loginBtn.Size = new Size(272, 30);
            signup_loginBtn.TabIndex = 2;
            signup_loginBtn.Text = "SIGN IN";
            signup_loginBtn.UseVisualStyleBackColor = false;
            signup_loginBtn.Click += signup_loginBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(122, 475);
            label5.Name = "label5";
            label5.Size = new Size(114, 14);
            label5.TabIndex = 1;
            label5.Text = "Login your Account";
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
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackImage;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(830, 564);
            Controls.Add(signup_btn);
            Controls.Add(signup_ShowPass);
            Controls.Add(signup_password);
            Controls.Add(label4);
            Controls.Add(signup_username);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(exit);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signup_btn;
        private CheckBox signup_ShowPass;
        private TextBox signup_password;
        private Label label4;
        private TextBox signup_username;
        private Label label3;
        private Label label2;
        private Label exit;
        private Panel panel1;
        private Button signup_loginBtn;
        private Label label5;
        private PictureBox pictureBox1;
    }
}