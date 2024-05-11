namespace Velocity_Bike_Shop_Managemennt_System
{
    partial class AdminLoginPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginPage));
            panel1 = new Panel();
            btnBack = new Button();
            pictureBox1 = new PictureBox();
            panelAdminLoginForm = new Panel();
            pbxUsername = new PictureBox();
            pbxPassword = new PictureBox();
            cbxShowpassword = new CheckBox();
            label3 = new Label();
            tbxPassword = new TextBox();
            btnLogin = new Button();
            tbxUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            pictureBox4 = new PictureBox();
            guna2Elipse1_AdminLoginPage = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1_AdminLoginForm = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1_btnLogin = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAdminLoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnBack);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 34);
            panel1.TabIndex = 0;
            panel1.MouseDown += mouse_Down;
            panel1.MouseMove += mouse_Move;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Image = (Image)resources.GetObject("btnBack.Image");
            btnBack.Location = new Point(433, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(29, 28);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 147);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panelAdminLoginForm
            // 
            panelAdminLoginForm.BackColor = Color.FromArgb(49, 54, 63);
            panelAdminLoginForm.Controls.Add(pbxUsername);
            panelAdminLoginForm.Controls.Add(pbxPassword);
            panelAdminLoginForm.Controls.Add(cbxShowpassword);
            panelAdminLoginForm.Controls.Add(label3);
            panelAdminLoginForm.Controls.Add(tbxPassword);
            panelAdminLoginForm.Controls.Add(btnLogin);
            panelAdminLoginForm.Controls.Add(tbxUsername);
            panelAdminLoginForm.Controls.Add(lblPassword);
            panelAdminLoginForm.Controls.Add(lblUsername);
            panelAdminLoginForm.Location = new Point(68, 210);
            panelAdminLoginForm.Name = "panelAdminLoginForm";
            panelAdminLoginForm.Size = new Size(337, 388);
            panelAdminLoginForm.TabIndex = 2;
            // 
            // pbxUsername
            // 
            pbxUsername.BackColor = Color.Transparent;
            pbxUsername.Image = (Image)resources.GetObject("pbxUsername.Image");
            pbxUsername.Location = new Point(32, 121);
            pbxUsername.Name = "pbxUsername";
            pbxUsername.Size = new Size(36, 39);
            pbxUsername.SizeMode = PictureBoxSizeMode.Zoom;
            pbxUsername.TabIndex = 13;
            pbxUsername.TabStop = false;
            // 
            // pbxPassword
            // 
            pbxPassword.Image = (Image)resources.GetObject("pbxPassword.Image");
            pbxPassword.Location = new Point(32, 184);
            pbxPassword.Name = "pbxPassword";
            pbxPassword.Size = new Size(36, 35);
            pbxPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPassword.TabIndex = 7;
            pbxPassword.TabStop = false;
            // 
            // cbxShowpassword
            // 
            cbxShowpassword.AutoSize = true;
            cbxShowpassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            cbxShowpassword.ForeColor = Color.Gainsboro;
            cbxShowpassword.Location = new Point(169, 236);
            cbxShowpassword.Name = "cbxShowpassword";
            cbxShowpassword.Size = new Size(125, 21);
            cbxShowpassword.TabIndex = 12;
            cbxShowpassword.Text = "Show password";
            cbxShowpassword.UseVisualStyleBackColor = true;
            cbxShowpassword.CheckedChanged += cbxShowpassword_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(82, 27);
            label3.Name = "label3";
            label3.Size = new Size(187, 36);
            label3.TabIndex = 10;
            label3.Text = "Welcome Boss!";
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbxPassword.Location = new Point(74, 196);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '•';
            tbxPassword.Size = new Size(215, 27);
            tbxPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(74, 274);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(215, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbxUsername
            // 
            tbxUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbxUsername.Location = new Point(74, 133);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(215, 27);
            tbxUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Gainsboro;
            lblPassword.Location = new Point(74, 175);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 17);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Gainsboro;
            lblUsername.Location = new Point(74, 112);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(69, 17);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 564);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(466, 178);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // guna2Elipse1_AdminLoginPage
            // 
            guna2Elipse1_AdminLoginPage.BorderRadius = 20;
            guna2Elipse1_AdminLoginPage.TargetControl = this;
            // 
            // guna2Elipse1_AdminLoginForm
            // 
            guna2Elipse1_AdminLoginForm.BorderRadius = 36;
            guna2Elipse1_AdminLoginForm.TargetControl = panelAdminLoginForm;
            // 
            // guna2Elipse1_btnLogin
            // 
            guna2Elipse1_btnLogin.BorderRadius = 25;
            guna2Elipse1_btnLogin.TargetControl = btnLogin;
            // 
            // AdminLoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(466, 741);
            Controls.Add(panelAdminLoginForm);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminLoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLoginPage";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelAdminLoginForm.ResumeLayout(false);
            panelAdminLoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panelAdminLoginForm;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox tbxUsername;
        private Button btnLogin;
        private TextBox tbxPassword;
        private Label label3;
        private CheckBox cbxShowpassword;
        private PictureBox pictureBox4;
        private Button btnBack;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1_AdminLoginPage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1_AdminLoginForm;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1_btnLogin;
        private PictureBox pbxUsername;
        private PictureBox pbxPassword;
    }
}