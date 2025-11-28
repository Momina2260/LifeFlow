namespace LifeFlow
{
    partial class logout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logout));
            home_btn = new Button();
            logOut_lbl = new Label();
            SuspendLayout();
            // 
            // home_btn
            // 
            home_btn.BackColor = SystemColors.ActiveCaption;
            home_btn.Location = new Point(12, 3);
            home_btn.Name = "home_btn";
            home_btn.Size = new Size(112, 34);
            home_btn.TabIndex = 0;
            home_btn.Text = "home";
            home_btn.UseVisualStyleBackColor = false;
            home_btn.Click += home_btn_click;
            // 
            // logOut_lbl
            // 
            logOut_lbl.AutoSize = true;
            logOut_lbl.BackColor = Color.Transparent;
            logOut_lbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOut_lbl.ForeColor = Color.Navy;
            logOut_lbl.Location = new Point(214, 50);
            logOut_lbl.Name = "logOut_lbl";
            logOut_lbl.Size = new Size(462, 38);
            logOut_lbl.TabIndex = 1;
            logOut_lbl.Text = "you have logged Out successfully!";
            logOut_lbl.Click += logOut_lbl_Click;
            // 
            // logout
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(logOut_lbl);
            Controls.Add(home_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "logout";
            Text = "logout";
            Load += logout_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button home_btn;
        private Label logOut_lbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
    }
}