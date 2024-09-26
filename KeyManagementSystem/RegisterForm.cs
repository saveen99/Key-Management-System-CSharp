using System.Data;
using System.Data.SqlClient;

namespace KeyManagementSystem
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\key_manage.mdf;Integrated Security=True;Connect Timeout=30");


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_loginBtn_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void signup_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_ShowPass.Checked ? '\0' : '*';
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if (signup_username.Text == "" || signup_password.Text == "")
            {
                MessageBox.Show("Please fill blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        //To Check if the User is Exsisting Already
                        string selectusername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using(SqlCommand checkUser = new SqlCommand(selectusername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user",signup_username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(signup_username.Text.Trim() + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO users" +
                                    "(username, password, date_register) " +
                                    "VALUES(@username, @password, @dateReg)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", signup_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", signup_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered Succsessfully",
                                        "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }


                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}
