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

namespace LifeFlow
{

    public partial class logout : Form

    {
        string conString = "Server=localhost;Database=bm_System;Uid=root;Pwd=Root@2003;";
        public logout()
        {
            InitializeComponent();
        }

        private void logout_Load(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized; // Opens the form full screen
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Optional: prevents resizing
            this.MaximizeBox = false; // Optional: disables maximize button
        }

       

        private void logOut_lbl_Click(object sender, EventArgs e)
        {

        }

        private void home_btn_click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
