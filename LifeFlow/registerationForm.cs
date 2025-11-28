using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LifeFlow
{
    public partial class registerationForm : Form
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
        private bool IsStrongPassword(string password)
        {
            if (password.Length < 8) // minimum length
                return false;

            if (!password.Any(char.IsUpper)) // at least one uppercase
                return false;

            if (!password.Any(ch => !char.IsLetterOrDigit(ch))) // at least one special character
                return false;

            return true;
        }


        public registerationForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerationForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized; // Opens the form full screen
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Optional: prevents resizing
            this.MaximizeBox = false; // Optional: disables maximize button

        }

        private void register_btn_click(object sender, EventArgs e)
        {
            string name = textBoxName.Text.Trim();
            string email = textBoxEmail.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string confirm_password = textBoxConfirmPassword.Text.Trim();
            Boolean is_Male = radioButtonMale.Checked;
            Boolean is_Female = radioButtonFemale.Checked;
           
            
           

            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirm_password))

            {
                MessageBox.Show("please fill the cradential" + MessageBoxIcon.Error);
            }
            if (confirm_password != password)
            {
                MessageBox.Show("confirm_password must match password!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!IsStrongPassword(password))
            {
                MessageBox.Show(
                    "Password must be at least 8 characters long, contain at least one uppercase letter and one special character.",
                    "Weak Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // stop registration
            }
            string hashedPassword = HashPassword(password);

            string gender = "";
            if (is_Male)
            {
                gender = "Male";
            }
           
            else
            {
                gender = "Female";
            }
           

            using (MySqlConnection conn = new MySqlConnection(conString))
            {

                try
                {
                    conn.Open();
                    string checkEmailQuery = "select count(*) from `user` where email=@Email";
                    using (MySqlCommand checkCmd = new MySqlCommand(checkEmailQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                        if (count > 0)
                        {
                            MessageBox.Show("email already exists. login instead!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string qr = "INSERT INTO `user` (user_name, email, password, gender)\r\nVALUES (@Name, @Email, @Password, @Gender)\r\n";
                    using (MySqlCommand cmd = new MySqlCommand(qr, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@Gender", gender);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("registered successfully! ");
                        
                        loginForm login = new loginForm();
                        login.Show();
                        this.Hide();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RegisterationForm_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabelGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginForm login = new loginForm();
            login.Show();
            this.Hide();
        }
    }
}
