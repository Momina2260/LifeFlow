using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing.Drawing2D;
using System.Security.Cryptography;

namespace LifeFlow
{
    public partial class loginForm : Form
    {
        string conString = "Server=localhost;Database=bm_System;Uid=root;Pwd=Root@2003;";
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())

            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
        public loginForm()
        {
            InitializeComponent();
        }

        private void Password_lbl_Click(object sender, EventArgs e)
        {

        }



        private void loginForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Opens the form full screen
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Optional: prevents resizing
            this.MaximizeBox = false; // Optional: disables maximize button

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter credentials!", "Error");
                return;
            }

            string enteredHashedPassword = HashPassword(password);

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();

                string qr = "SELECT user_id, user_name, password, role FROM user WHERE email=@Email";

                int userId = 0;
                string userName = "";
                string role = "";
                string storedHashedPassword = "";

                using (MySqlCommand cmd = new MySqlCommand(qr, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            storedHashedPassword = reader["password"].ToString();

                            if (enteredHashedPassword == storedHashedPassword)
                            {
                                userId = Convert.ToInt32(reader["user_id"]);
                                userName = reader["user_name"].ToString();
                                role = reader["role"].ToString();

                                // Store session information
                                UserSession.UserId = userId;
                                UserSession.UserName = userName;
                                UserSession.Role = role;
                                UserSession.Email = email;
                            }
                            else
                            {
                                MessageBox.Show("Invalid password!", "Error");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email not found!", "Error");
                            return;
                        }
                    }
                }
                string updateQr = "UPDATE user SET last_login = NOW() WHERE user_id = @user_id";
                using (MySqlCommand updatecmd = new MySqlCommand(updateQr, conn))
                {
                    updatecmd.Parameters.AddWithValue("@user_id", userId);
                    updatecmd.ExecuteNonQuery();
                }

                MessageBox.Show("Login Successful!");

                // Open main form
                Form1 mainForm = new Form1(userId, userName, role);
                mainForm.Show();
                this.Hide();
            }
        }





        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registerationForm register = new registerationForm();
            register.Show();
            this.Hide();
        }

        private void loginFormPanel_Paint(object sender, PaintEventArgs e)
        {


        }

        private void loginForm_Resize(object sender, EventArgs e)
        {

        }
    }
}
