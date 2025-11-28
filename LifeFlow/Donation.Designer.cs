namespace LifeFlow
{
    partial class Donation
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
            DonationText_lbl = new Label();
            comboBoxBloodType = new ComboBox();
            Gender_lbl = new Label();
            radioButtonMale = new RadioButton();
            radioButtonFemale = new RadioButton();
            Donate_btn = new Button();
            dateTimePickerlastDonation = new DateTimePicker();
            comboBoxQuantity = new ComboBox();
            Request_btn = new Button();
            quantity_lbl = new Label();
            bloodtype_lbl = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // DonationText_lbl
            // 
            DonationText_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DonationText_lbl.BackColor = Color.Transparent;
            DonationText_lbl.Location = new Point(5, 380);
            DonationText_lbl.Name = "DonationText_lbl";
            DonationText_lbl.Size = new Size(998, 61);
            DonationText_lbl.TabIndex = 0;
            DonationText_lbl.Text = "“Blood donation is not just an act of kindness\r\n—it’s an act of humanity. Someone, somewhere, is alive today because of donors like you.❤️”";
            // 
            // comboBoxBloodType
            // 
            comboBoxBloodType.BackColor = Color.FromArgb(255, 128, 128);
            comboBoxBloodType.FormattingEnabled = true;
            comboBoxBloodType.Location = new Point(150, 264);
            comboBoxBloodType.Name = "comboBoxBloodType";
            comboBoxBloodType.Size = new Size(182, 33);
            comboBoxBloodType.TabIndex = 1;
            comboBoxBloodType.Text = "select blood type...";
            comboBoxBloodType.SelectedIndexChanged += comboBoxBloodType_SelectedIndexChanged;
            // 
            // Gender_lbl
            // 
            Gender_lbl.AutoSize = true;
            Gender_lbl.BackColor = Color.Transparent;
            Gender_lbl.Location = new Point(12, 74);
            Gender_lbl.Name = "Gender_lbl";
            Gender_lbl.Size = new Size(73, 25);
            Gender_lbl.TabIndex = 2;
            Gender_lbl.Text = "Gender:";
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.BackColor = Color.Transparent;
            radioButtonMale.Location = new Point(106, 74);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(75, 29);
            radioButtonMale.TabIndex = 3;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = false;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.BackColor = Color.Transparent;
            radioButtonFemale.Location = new Point(196, 74);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(93, 29);
            radioButtonFemale.TabIndex = 3;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = false;
            // 
            // Donate_btn
            // 
            Donate_btn.BackColor = Color.FromArgb(255, 128, 128);
            Donate_btn.Location = new Point(138, 341);
            Donate_btn.Name = "Donate_btn";
            Donate_btn.Size = new Size(112, 34);
            Donate_btn.TabIndex = 4;
            Donate_btn.Text = "Donate";
            Donate_btn.UseVisualStyleBackColor = false;
            Donate_btn.Click += Donate_btn_click;
            // 
            // dateTimePickerlastDonation
            // 
            dateTimePickerlastDonation.Location = new Point(719, -1);
            dateTimePickerlastDonation.Name = "dateTimePickerlastDonation";
            dateTimePickerlastDonation.Size = new Size(300, 31);
            dateTimePickerlastDonation.TabIndex = 5;
            dateTimePickerlastDonation.Visible = false;
            // 
            // comboBoxQuantity
            // 
            comboBoxQuantity.BackColor = Color.FromArgb(255, 128, 128);
            comboBoxQuantity.FormattingEnabled = true;
            comboBoxQuantity.Location = new Point(150, 170);
            comboBoxQuantity.Name = "comboBoxQuantity";
            comboBoxQuantity.Size = new Size(182, 33);
            comboBoxQuantity.TabIndex = 6;
            comboBoxQuantity.Text = "select Quantity...";
            comboBoxQuantity.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Request_btn
            // 
            Request_btn.BackColor = Color.FromArgb(255, 128, 128);
            Request_btn.Location = new Point(312, 341);
            Request_btn.Name = "Request_btn";
            Request_btn.Size = new Size(112, 34);
            Request_btn.TabIndex = 7;
            Request_btn.Text = "Request";
            Request_btn.UseVisualStyleBackColor = false;
            Request_btn.Click += Request_btn_click;
            // 
            // quantity_lbl
            // 
            quantity_lbl.AutoSize = true;
            quantity_lbl.BackColor = Color.Transparent;
            quantity_lbl.Location = new Point(12, 178);
            quantity_lbl.Name = "quantity_lbl";
            quantity_lbl.Size = new Size(132, 25);
            quantity_lbl.TabIndex = 8;
            quantity_lbl.Text = "bloodQuantity:";
            quantity_lbl.Click += quantity_lbl_Click;
            // 
            // bloodtype_lbl
            // 
            bloodtype_lbl.AutoSize = true;
            bloodtype_lbl.BackColor = Color.Transparent;
            bloodtype_lbl.Location = new Point(12, 272);
            bloodtype_lbl.Name = "bloodtype_lbl";
            bloodtype_lbl.Size = new Size(101, 25);
            bloodtype_lbl.TabIndex = 8;
            bloodtype_lbl.Text = "bloodType:";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Red;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(192, 64, 0);
            linkLabel1.Location = new Point(1, -1);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(84, 25);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "<--home";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Donation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.download__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1015, 450);
            Controls.Add(linkLabel1);
            Controls.Add(bloodtype_lbl);
            Controls.Add(quantity_lbl);
            Controls.Add(Request_btn);
            Controls.Add(comboBoxQuantity);
            Controls.Add(dateTimePickerlastDonation);
            Controls.Add(Donate_btn);
            Controls.Add(radioButtonFemale);
            Controls.Add(radioButtonMale);
            Controls.Add(Gender_lbl);
            Controls.Add(comboBoxBloodType);
            Controls.Add(DonationText_lbl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Donation";
            Text = "Donation";
            Load += Donation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DonationText_lbl;
        private ComboBox comboBoxBloodType;
        private Label Gender_lbl;
        private RadioButton radioButtonMale;
        private RadioButton radioButtonFemale;
        private Button Donate_btn;
        private DateTimePicker dateTimePickerlastDonation;
        private ComboBox comboBoxQuantity;
        private Button Request_btn;
        private Label quantity_lbl;
        private Label bloodtype_lbl;
        private LinkLabel linkLabel1;
    }
}