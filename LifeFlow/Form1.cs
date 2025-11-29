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
    public partial class Form1 : Form
    {
        string conString = "Server=localhost;Database=bm_System;Uid=root;Pwd=Root@2003;";
        private int currentUserId;
        private string currentUserName;
        private string role;

        public Form1(int userId, string userName, string role)
        {
            InitializeComponent();
            currentUserId = userId;
            currentUserName = userName;
            this.role = role;
        }
        private int GetTotalDonors()
        {
            int total = 0;
            string query = "SELECT COUNT(*) FROM user WHERE role='donar'";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    total = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return total;
        }


        private int GetBloodStock()
        {
            int total = 0;
            string query = "SELECT SUM(quantity) FROM blood";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    total = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return total;
        }

        private int GetRequestsCount()
        {
            int total = 0;
            string query = "SELECT COUNT(*) FROM reception";
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    total = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
            return total;
        }










        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void Donar_lbl_Click(object sender, EventArgs e)
        {

        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTotalDonors.Text = GetTotalDonors().ToString();
            lblBloodStock.Text = GetBloodStock().ToString() + " units";
            lblRequests.Text = GetRequestsCount().ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RequetsPanel_Paint(object sender, PaintEventArgs e)
        {



        }

        private void BloodStockPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bloodStockcount_lbl_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void topHeaderPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_btn_click(object sender, EventArgs e)
        {
            // Open the login form
            loginForm login = new loginForm();
            login.Show();

            // Optional: hide current form
            this.Hide();
        }

        private void bloodServicesbtn_click(object sender, EventArgs e)
        {
            if (UserSession.UserId == 0)
            {
                MessageBox.Show("please login first!");
                loginForm login = new loginForm();
                login.Show();
                this.Hide();
            }
            else
            {
                Donation donate = new Donation();
                donate.Show();
                this.Hide();
            }
        }

        private void logOut_btn_click(object sender, EventArgs e)
        {
            if (UserSession.UserId == 0)
            {
                MessageBox.Show("you cannot logOut when you are not logged in!");
                return;
            }
            else
            {
                using (MySqlConnection conn = new MySqlConnection(conString))
                {
                    conn.Open();
                    string updateQr = "update  user set last_logout=Now() where user_id=@user_id";
                    using (MySqlCommand updatecmd = new MySqlCommand(updateQr, conn))
                    {
                        updatecmd.Parameters.AddWithValue("user_id", UserSession.UserId);
                        updatecmd.ExecuteNonQuery();
                    }

                    UserSession.ClearSession();
                    logout logout = new logout();
                    logout.Show();
                    this.Hide();

                }
            }


        }

        private void adminDash_btn_click(object sender, EventArgs e)
        {
            // Admin button logic using UserSession
            if (UserSession.UserId == 0)
            {
                MessageBox.Show("Please login first!");
                return;
            }

            if (UserSession.Role.ToLower() == "admin")
            {
                adminDashboard dash = new adminDashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Access denied. Only admin can access!");
            }

        }
    }
}

