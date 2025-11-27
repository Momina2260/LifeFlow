using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace LifeFlow
{
    public partial class Donation : Form
    {
        string conString = "Server=localhost;Database=bm_System;Uid=root;Pwd=Root@2003;";
        public Donation()
        {
            InitializeComponent();

            // Option 1: Set blood types here
            comboBoxBloodType.DataSource = new string[]
            {
               "select bloodType...", "A+", "A-", "B+", "B-", "O+", "O-", "AB+", "AB-"
            };
            comboBoxQuantity.DataSource = new int[] { 1, 2, 3, 4 };

        }

        private void Donation_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxBloodType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Donate_btn_click(object sender, EventArgs e)
        {
            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("Please select your gender!");
                return;
            }

            if (comboBoxBloodType.SelectedIndex == 0) // assuming first item is placeholder
            {
                MessageBox.Show("Please select your blood type!");
                return;
            }

            if (comboBoxQuantity.SelectedIndex == -1) // assuming first item is placeholder
            {
                MessageBox.Show("Please select quantity in units!");
                return;
            }
           

            // 1. Get user session
            if (UserSession.UserId == 0)
            {
                MessageBox.Show("Please login first!");
                return;
            }

            int waitingMonths = radioButtonMale.Checked ? 3 : 6;

            // 2. Get last donation date for this user
            DateTime lastDonation = DateTime.MinValue;
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                string lastDonationQuery = "SELECT MAX(d_date) FROM donation WHERE user_id=@userId";
                MySqlCommand cmd = new MySqlCommand(lastDonationQuery, conn);
                cmd.Parameters.AddWithValue("@userId", UserSession.UserId);

                object result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    lastDonation = Convert.ToDateTime(result);
                }

                DateTime today = DateTime.Today;
                DateTime eligibleDate = lastDonation.AddMonths(waitingMonths);

                if (today < eligibleDate)
                {
                    MessageBox.Show($"You are not eligible to donate yet. Next eligible date: {eligibleDate.ToShortDateString()}");
                    return;
                }

                // 3. Insert donation entry
                string bloodType = comboBoxBloodType.SelectedItem.ToString();
                int quantity = int.Parse(comboBoxQuantity.SelectedItem.ToString().Split(' ')[0]); // get numeric part

                // Get blood id
                string getBloodIdQuery = "SELECT b_id, quantity FROM blood WHERE b_type=@b_type";
                MySqlCommand cmdBlood = new MySqlCommand(getBloodIdQuery, conn);
                cmdBlood.Parameters.AddWithValue("@b_type", bloodType);
                using (var reader = cmdBlood.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int bloodId = Convert.ToInt32(reader["b_id"]);
                        int currentQuantity = Convert.ToInt32(reader["quantity"]);
                        reader.Close();

                        // Insert donation
                        string insertDonation = "INSERT INTO donation(d_date, user_id, b_id) VALUES(@d_date, @user_id, @b_id)";
                        MySqlCommand cmdInsert = new MySqlCommand(insertDonation, conn);
                        cmdInsert.Parameters.AddWithValue("@d_date", DateTime.Now);
                        cmdInsert.Parameters.AddWithValue("@user_id", UserSession.UserId);
                        cmdInsert.Parameters.AddWithValue("@b_id", bloodId);
                        cmdInsert.ExecuteNonQuery();

                        // Update blood stock
                        string updateBlood = "UPDATE blood SET quantity = quantity + @quantity WHERE b_id=@b_id";
                        MySqlCommand cmdUpdate = new MySqlCommand(updateBlood, conn);
                        cmdUpdate.Parameters.AddWithValue("@quantity", quantity);
                        cmdUpdate.Parameters.AddWithValue("@b_id", bloodId);
                        cmdUpdate.ExecuteNonQuery();

                        MessageBox.Show("Donation recorded successfully! Thank you for donating.");
                    }
                    else
                    {
                        MessageBox.Show("Selected blood type not found in stock!");
                    }
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Request_btn_click(object sender, EventArgs e)
        {
            if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                MessageBox.Show("please select your gender !");
                return;
            }
            if (comboBoxBloodType.SelectedIndex == -1)
            {
                MessageBox.Show("please select your blood type!");

            }
            if (comboBoxQuantity.SelectedIndex == -1)
            {
                MessageBox.Show("please enter quantity in units ");
                return;

            }
            // 2. Get values
            string gender = radioButtonMale.Checked ? "Male" : "Female";
            string bloodType = comboBoxBloodType.SelectedItem.ToString();
            int requestedUnits = int.Parse(comboBoxQuantity.SelectedItem.ToString());
            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                conn.Open();
                string checkQuery = "select quantity,b_id from blood where b_type= @b_type";
                MySqlCommand cmdCheck = new MySqlCommand(checkQuery, conn);
                cmdCheck.Parameters.AddWithValue("@b_type", bloodType);
                MySqlDataReader reader = cmdCheck.ExecuteReader();
                if (reader.Read())
                {
                    int availableUnits = int.Parse(reader["quantity"].ToString());
                    int bloodId = int.Parse(reader["b_id"].ToString());
                    reader.Close();
                    if (availableUnits < requestedUnits)
                    {
                        MessageBox.Show("not enough bloood is available.sorry!");
                    }
                    string updateQuery = "update blood set quantity =quantity - @units where b_id=@b_id";
                    MySqlCommand cmdUpdate = new MySqlCommand(updateQuery, conn);
                    cmdUpdate.Parameters.AddWithValue("@units", requestedUnits);
                    cmdUpdate.Parameters.AddWithValue("@b_id", bloodId);
                    cmdUpdate.ExecuteNonQuery();
                    string insertQuery = "insert into reception(r_date,user_id, b_id) VALUES(@r_date, @user_id, @b_id) ";

                    MySqlCommand cmdInsert = new MySqlCommand(insertQuery, conn);
                    cmdInsert.Parameters.AddWithValue("@r_date", DateTime.Now);
                    cmdInsert.Parameters.AddWithValue("@user_id", UserSession.UserId);
                    cmdInsert.Parameters.AddWithValue("@b_id", bloodId);
             
                    cmdInsert.ExecuteNonQuery();
                    MessageBox.Show("Request fulfilled successfully!");
                }
                else
                {
                    MessageBox.Show("Blood type not found!");
                }
            }
            }

        }
    }

