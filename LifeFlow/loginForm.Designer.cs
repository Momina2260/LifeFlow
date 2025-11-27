namespace LifeFlow
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            loginFormPanel = new Panel();
            btnlogin = new Button();
            linkLabel1 = new LinkLabel();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            textBoxName = new TextBox();
            Password_lbl = new Label();
            Email_lbl = new Label();
            Name_lbl = new Label();
            loginFormPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginFormPanel
            // 
            loginFormPanel.Anchor = AnchorStyles.None;
            loginFormPanel.BackColor = Color.WhiteSmoke;
            loginFormPanel.BorderStyle = BorderStyle.Fixed3D;
            loginFormPanel.Controls.Add(btnlogin);
            loginFormPanel.Controls.Add(linkLabel1);
            loginFormPanel.Controls.Add(textBoxPassword);
            loginFormPanel.Controls.Add(textBoxEmail);
            loginFormPanel.Controls.Add(textBoxName);
            loginFormPanel.Controls.Add(Password_lbl);
            loginFormPanel.Controls.Add(Email_lbl);
            loginFormPanel.Controls.Add(Name_lbl);
            loginFormPanel.Location = new Point(351, -2);
            loginFormPanel.Name = "loginFormPanel";
            loginFormPanel.Size = new Size(522, 597);
            loginFormPanel.TabIndex = 0;
            loginFormPanel.Paint += loginFormPanel_Paint;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.IndianRed;
            btnlogin.Location = new Point(181, 303);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(217, 34);
            btnlogin.TabIndex = 4;
            btnlogin.Text = "login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(128, 64, 64);
            linkLabel1.Location = new Point(209, 378);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 25);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "register account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(148, 223);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(276, 31);
            textBoxPassword.TabIndex = 1;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(148, 133);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(276, 31);
            textBoxEmail.TabIndex = 1;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(148, 41);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(276, 31);
            textBoxName.TabIndex = 1;
            // 
            // Password_lbl
            // 
            Password_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Password_lbl.AutoSize = true;
            Password_lbl.Location = new Point(13, 229);
            Password_lbl.Name = "Password_lbl";
            Password_lbl.Size = new Size(91, 25);
            Password_lbl.TabIndex = 0;
            Password_lbl.Text = "Password:";
            Password_lbl.Click += Password_lbl_Click;
            // 
            // Email_lbl
            // 
            Email_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Email_lbl.AutoSize = true;
            Email_lbl.Location = new Point(31, 133);
            Email_lbl.Name = "Email_lbl";
            Email_lbl.Size = new Size(58, 25);
            Email_lbl.TabIndex = 0;
            Email_lbl.Text = "Email:";
            // 
            // Name_lbl
            // 
            Name_lbl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Name_lbl.AutoSize = true;
            Name_lbl.Location = new Point(31, 41);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(63, 25);
            Name_lbl.TabIndex = 0;
            Name_lbl.Text = "Name:";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(950, 718);
            Controls.Add(loginFormPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginForm";
            StartPosition = FormStartPosition.Manual;
            Text = "loginForm";
            Load += loginForm_Load;
            Resize += loginForm_Resize;
            loginFormPanel.ResumeLayout(false);
            loginFormPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginFormPanel;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxName;
        private Label Password_lbl;
        private Label Email_lbl;
        private Label Name_lbl;
        private LinkLabel linkLabel1;
        private Button buttonLogin;
        private Button btnlogin;
    }
}