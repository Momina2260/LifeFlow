using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace LifeFlow
{
    public partial class adminDashboard : Form
    {
        string conString = "Server=localhost;Database=bm_System;Uid=root;Pwd=Root@2003;";
        private void loadUser(string searchText = "")

        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                string qr = "SELECT user_id,user_name,email,role , last_login FROM `user` WHERE user_name LIKE @search OR email LIKE @search OR role like  @search OR last_login LIKE @search  ";
                using (MySqlCommand cmd = new MySqlCommand(qr, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);
                   
                    dataGridView1.DataSource = table;
                }
            }
        }
        private int getUsersCount()
        {
            int total = 0;
            string query = "SELECT COUNT(*) FROM user";
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
        public adminDashboard()
        {
            InitializeComponent();
            this.Load += adminDashboard_Load;
            comboBoxRole.DataSource = new string[]
           {
               "select Role...", "Admin", "reciever", "Donar"
           };
            comboBoxGender.DataSource = new string[]
           {
               "select Gender...", "Male", "Female"
           };
        }
        private void adminDashboard_Load(object sender, EventArgs e)
        {
            loadUser(); // Load all users initially
        }


        private void buttonfilter_click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(conString))
            {
                con.Open();

                string query = "SELECT user_id, user_name, email, role, Gender FROM user WHERE 1=1";
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.Connection = con;

                    // Add Gender filter
                    if (comboBoxGender.SelectedIndex >= 0)
                    {
                        query += " AND Gender = @gender";
                        cmd.Parameters.AddWithValue("@gender", comboBoxGender.Text);
                    }

                    // Add Role filter
                    if (comboBoxRole.SelectedIndex >= 0)
                    {
                        query += " AND role = @role";
                        cmd.Parameters.AddWithValue("@role", comboBoxRole.Text);
                    }
                    cmd.CommandText = query;
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    da.Fill(table);

                    dataGridView1.DataSource = table;
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadUser(textBoxsearchUser.Text);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

            int total = getUsersCount();
            UserCount.Text = total.ToString();
        }
    }
}
