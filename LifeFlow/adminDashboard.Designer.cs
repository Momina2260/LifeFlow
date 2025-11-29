namespace LifeFlow
{
    partial class adminDashboard
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel5 = new Panel();
            UserCount = new Label();
            label4 = new Label();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            userId = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            last_login = new DataGridViewTextBoxColumn();
            last_logout = new DataGridViewTextBoxColumn();
            edit = new DataGridViewButtonColumn();
            delete = new DataGridViewButtonColumn();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            comboBoxRole = new ComboBox();
            label3 = new Label();
            comboBoxGender = new ComboBox();
            buttonfilter = new Button();
            panel2 = new Panel();
            textBoxsearchUser = new TextBox();
            label1 = new Label();
            buttonHome = new Button();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources._360_F_478987727_BLVoXe6RzMgHbzxNIlU3Bz2XodQENCvC2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(806, 474);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(UserCount);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 406);
            panel5.Name = "panel5";
            panel5.Size = new Size(802, 64);
            panel5.TabIndex = 2;
            // 
            // UserCount
            // 
            UserCount.AutoSize = true;
            UserCount.Location = new Point(118, 23);
            UserCount.Name = "UserCount";
            UserCount.Size = new Size(22, 25);
            UserCount.TabIndex = 1;
            UserCount.Text = "0";
            UserCount.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(0, 20);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 0;
            label4.Text = "total Users:";
            label4.Click += label4_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 119);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(802, 351);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle9.BackColor = Color.Silver;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userId, userName, Email, Role, last_login, last_logout, edit, delete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(782, 331);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // userId
            // 
            dataGridViewCellStyle11.BackColor = Color.FromArgb(255, 128, 128);
            dataGridViewCellStyle11.ForeColor = Color.Gray;
            userId.DefaultCellStyle = dataGridViewCellStyle11;
            userId.HeaderText = "userId";
            userId.MinimumWidth = 8;
            userId.Name = "userId";
            userId.Width = 150;
            // 
            // userName
            // 
            dataGridViewCellStyle12.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle12.ForeColor = Color.Gray;
            userName.DefaultCellStyle = dataGridViewCellStyle12;
            userName.HeaderText = "userName";
            userName.MinimumWidth = 8;
            userName.Name = "userName";
            userName.Width = 150;
            // 
            // Email
            // 
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle13.ForeColor = Color.Gray;
            Email.DefaultCellStyle = dataGridViewCellStyle13;
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Role
            // 
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle14.SelectionForeColor = Color.Gray;
            Role.DefaultCellStyle = dataGridViewCellStyle14;
            Role.HeaderText = "Role";
            Role.MinimumWidth = 8;
            Role.Name = "Role";
            Role.Width = 150;
            // 
            // last_login
            // 
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle15.SelectionBackColor = Color.Gray;
            last_login.DefaultCellStyle = dataGridViewCellStyle15;
            last_login.HeaderText = "last_login";
            last_login.MinimumWidth = 8;
            last_login.Name = "last_login";
            last_login.Width = 150;
            // 
            // last_logout
            // 
            dataGridViewCellStyle16.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle16.ForeColor = Color.Gray;
            last_logout.DefaultCellStyle = dataGridViewCellStyle16;
            last_logout.HeaderText = "last_logout";
            last_logout.MinimumWidth = 8;
            last_logout.Name = "last_logout";
            last_logout.Width = 150;
            // 
            // edit
            // 
            edit.HeaderText = "edit";
            edit.MinimumWidth = 8;
            edit.Name = "edit";
            edit.Width = 150;
            // 
            // delete
            // 
            delete.HeaderText = "delete";
            delete.MinimumWidth = 8;
            delete.Name = "delete";
            delete.Width = 150;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(flowLayoutPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(802, 59);
            panel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(comboBoxRole);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(comboBoxGender);
            flowLayoutPanel1.Controls.Add(buttonfilter);
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(802, 52);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 0;
            label2.Text = "Role:";
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.None;
            comboBoxRole.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(62, 3);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(182, 33);
            comboBoxRole.TabIndex = 0;
            comboBoxRole.Text = "All";
            comboBoxRole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(250, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 0;
            label3.Text = "Gender:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.Anchor = AnchorStyles.None;
            comboBoxGender.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(335, 3);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(182, 33);
            comboBoxGender.TabIndex = 0;
            comboBoxGender.Text = "All";
            // 
            // buttonfilter
            // 
            buttonfilter.BackColor = Color.DarkGray;
            buttonfilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonfilter.Location = new Point(523, 3);
            buttonfilter.Name = "buttonfilter";
            buttonfilter.Size = new Size(112, 33);
            buttonfilter.TabIndex = 1;
            buttonfilter.Text = "applyFilter";
            buttonfilter.UseVisualStyleBackColor = false;
            buttonfilter.Click += buttonfilter_click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 64, 64);
            panel2.Controls.Add(buttonHome);
            panel2.Controls.Add(textBoxsearchUser);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 60);
            panel2.TabIndex = 0;
            // 
            // textBoxsearchUser
            // 
            textBoxsearchUser.Location = new Point(250, 20);
            textBoxsearchUser.Name = "textBoxsearchUser";
            textBoxsearchUser.Size = new Size(250, 31);
            textBoxsearchUser.TabIndex = 1;
            textBoxsearchUser.Text = "Search users…";
            textBoxsearchUser.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 4);
            label1.Name = "label1";
            label1.Size = new Size(227, 48);
            label1.TabIndex = 0;
            label1.Text = "All Users List";
            label1.Click += label1_Click;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.Gray;
            buttonHome.Location = new Point(669, 18);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(112, 34);
            buttonHome.TabIndex = 2;
            buttonHome.Text = "Home";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_click;
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 474);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminDashboard";
            Text = "adminDashboard";
            WindowState = FormWindowState.Maximized;
            Load += adminDashboard_Load_1;
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxsearchUser;
        private Label label1;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox comboBoxRole;
        private ComboBox comboBoxGender;
        private Button buttonfilter;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn userId;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn last_login;
        private DataGridViewTextBoxColumn last_logout;
        private DataGridViewButtonColumn edit;
        private DataGridViewButtonColumn delete;
        private Panel panel5;
        private Label label4;
        private Label UserCount;
        private Button buttonHome;
    }
}