namespace LifeFlow
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            RequestsPanel = new Panel();
            requestCountlbl = new Label();
            lblRequests = new Label();
            topHeaderPanel = new Panel();
            bloodServicesbtn = new Button();
            logOut_btn = new Button();
            login_btn = new Button();
            label1 = new Label();
            LifeFlowlbl = new Label();
            panel1 = new Panel();
            donarscount_lbl = new Label();
            lblTotalDonors = new Label();
            lblBloodStock = new Label();
            bloodStockcount_lbl = new Label();
            BloodStockPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            panel2 = new Panel();
            RequestsPanel.SuspendLayout();
            topHeaderPanel.SuspendLayout();
            panel1.SuspendLayout();
            BloodStockPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // RequestsPanel
            // 
            RequestsPanel.AutoSize = true;
            RequestsPanel.BackColor = Color.WhiteSmoke;
            RequestsPanel.BorderStyle = BorderStyle.Fixed3D;
            RequestsPanel.Controls.Add(requestCountlbl);
            RequestsPanel.Controls.Add(lblRequests);
            RequestsPanel.Dock = DockStyle.Fill;
            RequestsPanel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RequestsPanel.Location = new Point(3, 3);
            RequestsPanel.Name = "RequestsPanel";
            RequestsPanel.Size = new Size(197, 111);
            RequestsPanel.TabIndex = 1;
            RequestsPanel.Paint += RequetsPanel_Paint;
            // 
            // requestCountlbl
            // 
            requestCountlbl.AutoSize = true;
            requestCountlbl.BackColor = Color.Transparent;
            requestCountlbl.FlatStyle = FlatStyle.Flat;
            requestCountlbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            requestCountlbl.ForeColor = Color.Firebrick;
            requestCountlbl.Location = new Point(14, 9);
            requestCountlbl.Name = "requestCountlbl";
            requestCountlbl.Size = new Size(162, 48);
            requestCountlbl.TabIndex = 1;
            requestCountlbl.Text = "Requests";
            // 
            // lblRequests
            // 
            lblRequests.AutoSize = true;
            lblRequests.BackColor = Color.Transparent;
            lblRequests.FlatStyle = FlatStyle.Flat;
            lblRequests.ForeColor = Color.Firebrick;
            lblRequests.Location = new Point(62, 79);
            lblRequests.Name = "lblRequests";
            lblRequests.Size = new Size(20, 24);
            lblRequests.TabIndex = 0;
            lblRequests.Text = "0";
            lblRequests.Click += Donar_lbl_Click;
            // 
            // topHeaderPanel
            // 
            topHeaderPanel.BackColor = Color.FromArgb(255, 192, 192);
            topHeaderPanel.BorderStyle = BorderStyle.FixedSingle;
            topHeaderPanel.Controls.Add(bloodServicesbtn);
            topHeaderPanel.Controls.Add(logOut_btn);
            topHeaderPanel.Controls.Add(login_btn);
            topHeaderPanel.Controls.Add(label1);
            topHeaderPanel.Controls.Add(LifeFlowlbl);
            topHeaderPanel.Dock = DockStyle.Top;
            topHeaderPanel.ForeColor = SystemColors.ActiveBorder;
            topHeaderPanel.Location = new Point(0, 0);
            topHeaderPanel.Name = "topHeaderPanel";
            topHeaderPanel.Size = new Size(1364, 73);
            topHeaderPanel.TabIndex = 3;
            topHeaderPanel.Paint += topHeaderPanel_Paint;
            // 
            // bloodServicesbtn
            // 
            bloodServicesbtn.BackColor = Color.FromArgb(192, 64, 0);
            bloodServicesbtn.ForeColor = SystemColors.ActiveCaptionText;
            bloodServicesbtn.Location = new Point(101, 17);
            bloodServicesbtn.Name = "bloodServicesbtn";
            bloodServicesbtn.Size = new Size(151, 35);
            bloodServicesbtn.TabIndex = 8;
            bloodServicesbtn.Text = "bloodServices";
            bloodServicesbtn.UseVisualStyleBackColor = false;
            bloodServicesbtn.Click += bloodServicesbtn_click;
            // 
            // logOut_btn
            // 
            logOut_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            logOut_btn.BackColor = Color.FromArgb(192, 64, 0);
            logOut_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOut_btn.ForeColor = SystemColors.ActiveCaptionText;
            logOut_btn.Location = new Point(1245, 17);
            logOut_btn.Name = "logOut_btn";
            logOut_btn.Size = new Size(114, 46);
            logOut_btn.TabIndex = 7;
            logOut_btn.Text = "logOut";
            logOut_btn.UseVisualStyleBackColor = false;
            logOut_btn.Click += logOut_btn_click;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(192, 64, 0);
            login_btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ActiveCaptionText;
            login_btn.Location = new Point(3, 11);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(69, 46);
            login_btn.TabIndex = 7;
            login_btn.Text = "login";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 64, 0);
            label1.Location = new Point(640, 22);
            label1.Name = "label1";
            label1.Size = new Size(514, 25);
            label1.TabIndex = 1;
            label1.Text = "\"whoever saves one life, it is as if he had saved all of humanity,\"";
            // 
            // LifeFlowlbl
            // 
            LifeFlowlbl.AllowDrop = true;
            LifeFlowlbl.AutoSize = true;
            LifeFlowlbl.FlatStyle = FlatStyle.Popup;
            LifeFlowlbl.Font = new Font("Palatino Linotype", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LifeFlowlbl.ForeColor = Color.FromArgb(192, 0, 0);
            LifeFlowlbl.Location = new Point(486, 8);
            LifeFlowlbl.Name = "LifeFlowlbl";
            LifeFlowlbl.Size = new Size(148, 43);
            LifeFlowlbl.TabIndex = 0;
            LifeFlowlbl.Text = "LIfeFlow";
            LifeFlowlbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(donarscount_lbl);
            panel1.Controls.Add(lblTotalDonors);
            panel1.Dock = DockStyle.Fill;
            panel1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(409, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 111);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // donarscount_lbl
            // 
            donarscount_lbl.AutoSize = true;
            donarscount_lbl.BackColor = Color.Transparent;
            donarscount_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            donarscount_lbl.ForeColor = Color.Firebrick;
            donarscount_lbl.Location = new Point(3, 9);
            donarscount_lbl.Name = "donarscount_lbl";
            donarscount_lbl.Size = new Size(132, 48);
            donarscount_lbl.TabIndex = 1;
            donarscount_lbl.Text = "Donars";
            // 
            // lblTotalDonors
            // 
            lblTotalDonors.AutoSize = true;
            lblTotalDonors.BackColor = Color.Transparent;
            lblTotalDonors.FlatStyle = FlatStyle.Flat;
            lblTotalDonors.ForeColor = Color.Firebrick;
            lblTotalDonors.Location = new Point(61, 79);
            lblTotalDonors.Name = "lblTotalDonors";
            lblTotalDonors.Size = new Size(20, 24);
            lblTotalDonors.TabIndex = 0;
            lblTotalDonors.Text = "0";
            lblTotalDonors.Click += Donar_lbl_Click;
            // 
            // lblBloodStock
            // 
            lblBloodStock.AutoSize = true;
            lblBloodStock.BackColor = Color.Transparent;
            lblBloodStock.FlatStyle = FlatStyle.Flat;
            lblBloodStock.ForeColor = Color.Firebrick;
            lblBloodStock.Location = new Point(69, 79);
            lblBloodStock.Name = "lblBloodStock";
            lblBloodStock.Size = new Size(20, 24);
            lblBloodStock.TabIndex = 0;
            lblBloodStock.Text = "0";
            lblBloodStock.Click += Donar_lbl_Click;
            // 
            // bloodStockcount_lbl
            // 
            bloodStockcount_lbl.AutoSize = true;
            bloodStockcount_lbl.BackColor = Color.Transparent;
            bloodStockcount_lbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bloodStockcount_lbl.ForeColor = Color.Firebrick;
            bloodStockcount_lbl.Location = new Point(27, 9);
            bloodStockcount_lbl.Name = "bloodStockcount_lbl";
            bloodStockcount_lbl.Size = new Size(106, 48);
            bloodStockcount_lbl.TabIndex = 1;
            bloodStockcount_lbl.Text = "Stock";
            bloodStockcount_lbl.Click += bloodStockcount_lbl_Click;
            // 
            // BloodStockPanel
            // 
            BloodStockPanel.AutoSize = true;
            BloodStockPanel.BackColor = Color.WhiteSmoke;
            BloodStockPanel.BorderStyle = BorderStyle.Fixed3D;
            BloodStockPanel.Controls.Add(bloodStockcount_lbl);
            BloodStockPanel.Controls.Add(lblBloodStock);
            BloodStockPanel.Dock = DockStyle.Fill;
            BloodStockPanel.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BloodStockPanel.Location = new Point(206, 3);
            BloodStockPanel.Name = "BloodStockPanel";
            BloodStockPanel.Size = new Size(197, 111);
            BloodStockPanel.TabIndex = 2;
            BloodStockPanel.Paint += BloodStockPanel_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(RequestsPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 2, 0);
            tableLayoutPanel1.Controls.Add(BloodStockPanel, 1, 0);
            tableLayoutPanel1.Location = new Point(356, 97);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(610, 117);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(0, 2);
            label2.Name = "label2";
            label2.Size = new Size(386, 50);
            label2.TabIndex = 5;
            label2.Text = "\"Donate blood, save a life.\r\nBe a hero — give hope through your veins.\"";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 515);
            panel2.Name = "panel2";
            panel2.Size = new Size(1364, 62);
            panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._360_F_478987727_BLVoXe6RzMgHbzxNIlU3Bz2XodQENCvC;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1364, 579);
            Controls.Add(panel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(topHeaderPanel);
            Name = "Form1";
            Text = "Home";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            RequestsPanel.ResumeLayout(false);
            RequestsPanel.PerformLayout();
            topHeaderPanel.ResumeLayout(false);
            topHeaderPanel.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            BloodStockPanel.ResumeLayout(false);
            BloodStockPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Panel RequestsPanel;
        private Label requestCountlbl;
        private Label lblRequests;
        private Panel topHeaderPanel;
        private Label LifeFlowlbl;
        private Label label1;
        private Panel panel1;
        private Label donarscount_lbl;
        private Label lblTotalDonors;
        private Label lblBloodStock;
        private Label bloodStockcount_lbl;
        private Panel BloodStockPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Panel panel2;
        private Button login_btn;
        private Button bloodServicesbtn;
        private Button logOut_btn;
    }
}
