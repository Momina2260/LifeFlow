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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            UserCount = new Label();
            label4 = new Label();
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
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(dataGridView1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 146);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(10);
            panel4.Size = new Size(800, 304);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // panel5
            // 
            panel5.Controls.Add(UserCount);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(10, 247);
            panel5.Name = "panel5";
            panel5.Size = new Size(780, 47);
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
            label4.Location = new Point(3, 19);
            label4.Name = "label4";
            label4.Size = new Size(109, 28);
            label4.TabIndex = 0;
            label4.Text = "total Users:";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { userId, userName, Email, Role, last_login, last_logout, edit, delete });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(10, 10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.Size = new Size(780, 284);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // userId
            // 
            userId.HeaderText = "userId";
            userId.MinimumWidth = 8;
            userId.Name = "userId";
            userId.Width = 150;
            // 
            // userName
            // 
            userName.HeaderText = "userName";
            userName.MinimumWidth = 8;
            userName.Name = "userName";
            userName.Width = 150;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 8;
            Email.Name = "Email";
            Email.Width = 150;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.MinimumWidth = 8;
            Role.Name = "Role";
            Role.Width = 150;
            // 
            // last_login
            // 
            last_login.HeaderText = "last_login";
            last_login.MinimumWidth = 8;
            last_login.Name = "last_login";
            last_login.Width = 150;
            // 
            // last_logout
            // 
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
            panel3.Location = new Point(0, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 59);
            panel3.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(comboBoxRole);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(comboBoxGender);
            flowLayoutPanel1.Controls.Add(buttonfilter);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 59);
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
            buttonfilter.Anchor = AnchorStyles.Right;
            buttonfilter.BackColor = Color.DarkGray;
            buttonfilter.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonfilter.Location = new Point(523, 3);
            buttonfilter.Name = "buttonfilter";
            buttonfilter.Size = new Size(112, 34);
            buttonfilter.TabIndex = 1;
            buttonfilter.Text = "applyFilter";
            buttonfilter.UseVisualStyleBackColor = false;
            buttonfilter.Click += buttonfilter_click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(128, 64, 64);
            panel2.Controls.Add(textBoxsearchUser);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 87);
            panel2.TabIndex = 0;
            // 
            // textBoxsearchUser
            // 
            textBoxsearchUser.Location = new Point(267, 37);
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
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(227, 48);
            label1.TabIndex = 0;
            label1.Text = "All Users List";
            label1.Click += label1_Click;
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adminDashboard";
            Text = "adminDashboard";
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
    }
}