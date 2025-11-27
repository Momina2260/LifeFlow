namespace LifeFlow
{
    partial class registerationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerationForm));
            RegisterationForm_panel = new Panel();
            register_btn = new Button();
            radioButtonFemale = new RadioButton();
            radioButtonMale = new RadioButton();
            Gender_lbl = new Label();
            textBoxPassword = new TextBox();
            textBoxConfirmPassword = new TextBox();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            linkLabelLogin = new LinkLabel();
            confirm_password_lbl = new Label();
            Email_lbl = new Label();
            Password_lbl = new Label();
            Name_lbl = new Label();
            RegisterationForm_panel.SuspendLayout();
            SuspendLayout();
            // 
            // RegisterationForm_panel
            // 
            RegisterationForm_panel.Anchor = AnchorStyles.None;
            RegisterationForm_panel.BorderStyle = BorderStyle.Fixed3D;
            RegisterationForm_panel.Controls.Add(register_btn);
            RegisterationForm_panel.Controls.Add(radioButtonFemale);
            RegisterationForm_panel.Controls.Add(radioButtonMale);
            RegisterationForm_panel.Controls.Add(Gender_lbl);
            RegisterationForm_panel.Controls.Add(textBoxPassword);
            RegisterationForm_panel.Controls.Add(textBoxConfirmPassword);
            RegisterationForm_panel.Controls.Add(textBoxName);
            RegisterationForm_panel.Controls.Add(textBoxEmail);
            RegisterationForm_panel.Controls.Add(linkLabelLogin);
            RegisterationForm_panel.Controls.Add(confirm_password_lbl);
            RegisterationForm_panel.Controls.Add(Email_lbl);
            RegisterationForm_panel.Controls.Add(Password_lbl);
            RegisterationForm_panel.Controls.Add(Name_lbl);
            RegisterationForm_panel.Location = new Point(71, 3);
            RegisterationForm_panel.Name = "RegisterationForm_panel";
            RegisterationForm_panel.Size = new Size(560, 628);
            RegisterationForm_panel.TabIndex = 0;
            RegisterationForm_panel.Paint += RegisterationForm_panel_Paint;
            // 
            // register_btn
            // 
            register_btn.Anchor = AnchorStyles.None;
            register_btn.Location = new Point(175, 422);
            register_btn.Name = "register_btn";
            register_btn.Size = new Size(143, 42);
            register_btn.TabIndex = 15;
            register_btn.Text = "Register";
            register_btn.UseVisualStyleBackColor = true;
            register_btn.Click += register_btn_click;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.Anchor = AnchorStyles.None;
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Location = new Point(270, 369);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(93, 29);
            radioButtonFemale.TabIndex = 1;
            radioButtonFemale.Text = "Female";
            // 
            // radioButtonMale
            // 
            radioButtonMale.Anchor = AnchorStyles.None;
            radioButtonMale.AutoSize = true;
            radioButtonMale.Location = new Point(175, 367);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(75, 29);
            radioButtonMale.TabIndex = 2;
            radioButtonMale.Text = "Male";
            radioButtonMale.CheckedChanged += radioButtonMale_CheckedChanged;
            // 
            // Gender_lbl
            // 
            Gender_lbl.Anchor = AnchorStyles.None;
            Gender_lbl.AutoSize = true;
            Gender_lbl.Location = new Point(61, 367);
            Gender_lbl.Name = "Gender_lbl";
            Gender_lbl.Size = new Size(73, 25);
            Gender_lbl.TabIndex = 3;
            Gender_lbl.Text = "Gender:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Location = new Point(151, 232);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(358, 31);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Anchor = AnchorStyles.None;
            textBoxConfirmPassword.Location = new Point(151, 303);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.PasswordChar = '*';
            textBoxConfirmPassword.Size = new Size(358, 31);
            textBoxConfirmPassword.TabIndex = 6;
            textBoxConfirmPassword.UseSystemPasswordChar = true;
            textBoxConfirmPassword.TextChanged += textBox3_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.None;
            textBoxName.Location = new Point(151, 85);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(358, 31);
            textBoxName.TabIndex = 7;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.None;
            textBoxEmail.Location = new Point(151, 159);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(358, 31);
            textBoxEmail.TabIndex = 8;
            // 
            // linkLabelLogin
            // 
            linkLabelLogin.Anchor = AnchorStyles.None;
            linkLabelLogin.AutoSize = true;
            linkLabelLogin.LinkColor = Color.FromArgb(128, 64, 64);
            linkLabelLogin.Location = new Point(195, 485);
            linkLabelLogin.Name = "linkLabelLogin";
            linkLabelLogin.Size = new Size(114, 25);
            linkLabelLogin.TabIndex = 10;
            linkLabelLogin.TabStop = true;
            linkLabelLogin.Text = "login instead";
            linkLabelLogin.LinkClicked += linkLabelLogin_LinkClicked;
            // 
            // confirm_password_lbl
            // 
            confirm_password_lbl.Anchor = AnchorStyles.None;
            confirm_password_lbl.AutoSize = true;
            confirm_password_lbl.Location = new Point(58, 303);
            confirm_password_lbl.Name = "confirm_password_lbl";
            confirm_password_lbl.Size = new Size(76, 25);
            confirm_password_lbl.TabIndex = 11;
            confirm_password_lbl.Text = "Confirm";
            // 
            // Email_lbl
            // 
            Email_lbl.Anchor = AnchorStyles.None;
            Email_lbl.AutoSize = true;
            Email_lbl.Location = new Point(58, 159);
            Email_lbl.Name = "Email_lbl";
            Email_lbl.Size = new Size(58, 25);
            Email_lbl.TabIndex = 12;
            Email_lbl.Text = "Email:";
            // 
            // Password_lbl
            // 
            Password_lbl.Anchor = AnchorStyles.None;
            Password_lbl.AutoSize = true;
            Password_lbl.Location = new Point(58, 232);
            Password_lbl.Name = "Password_lbl";
            Password_lbl.Size = new Size(87, 25);
            Password_lbl.TabIndex = 13;
            Password_lbl.Text = "Password";
            // 
            // Name_lbl
            // 
            Name_lbl.Anchor = AnchorStyles.None;
            Name_lbl.AutoSize = true;
            Name_lbl.Location = new Point(58, 85);
            Name_lbl.Name = "Name_lbl";
            Name_lbl.Size = new Size(63, 25);
            Name_lbl.TabIndex = 14;
            Name_lbl.Text = "Name:";
            // 
            // registerationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(949, 742);
            Controls.Add(RegisterationForm_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "registerationForm";
            StartPosition = FormStartPosition.Manual;
            Text = "registerationForm";
            Load += registerationForm_Load;
            RegisterationForm_panel.ResumeLayout(false);
            RegisterationForm_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel RegisterationForm_panel;
        private TextBox textBoxPassword;
        private TextBox textBox3;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private LinkLabel linkLabelLogin;
        private Label confirm_password_lbl;
        private Label Email_lbl;
        private Label Password_lbl;
        private Label Name_lbl;
        private LinkLabel linkLabelGoogle;
        private RadioButton radioButtonOther;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonMale;
 
        private Label Gender_lbl;
        private PictureBox pictureBoxGoogle;
        private Button button1;
        private Button register_btn;
        private TextBox textBoxConfirmPassword;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
