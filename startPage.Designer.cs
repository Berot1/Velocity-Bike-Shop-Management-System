namespace Velocity_Bike_Shop_Managemennt_System
{
    partial class startPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startPage));
            panelControl = new Panel();
            lblMinize = new Label();
            lblClosed = new Label();
            panelLoginForm = new Panel();
            lblForgetPassword = new Label();
            lblSignup = new Label();
            lblAdmin = new Label();
            lblDontHaveAnAcc = new Label();
            cbxShowpassword = new CheckBox();
            lblContinue_as = new Label();
            lblGetStarted = new Label();
            lblPassword = new Label();
            tbxPassword = new TextBox();
            tbxUsername = new TextBox();
            lblUsername = new Label();
            pbxPassword = new PictureBox();
            pbxUsername = new PictureBox();
            btnLogin = new Button();
            pbxVelocityLogo = new PictureBox();
            pictureBox4 = new PictureBox();
            guna2Elipse1_StartPage = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1_LoginForm = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse1_btnLogin = new Guna.UI2.WinForms.Guna2Elipse(components);
            panelControl.SuspendLayout();
            panelLoginForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxVelocityLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panelControl
            // 
            panelControl.BackColor = Color.Black;
            panelControl.Controls.Add(lblMinize);
            panelControl.Controls.Add(lblClosed);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(0, 0);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(466, 34);
            panelControl.TabIndex = 0;
            panelControl.MouseDown += mouse_Down;
            panelControl.MouseMove += mouse_Move;
            // 
            // lblMinize
            // 
            lblMinize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMinize.AutoSize = true;
            lblMinize.BackColor = Color.Black;
            lblMinize.Cursor = Cursors.Hand;
            lblMinize.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMinize.ForeColor = Color.Yellow;
            lblMinize.Location = new Point(395, 2);
            lblMinize.Name = "lblMinize";
            lblMinize.Size = new Size(33, 28);
            lblMinize.TabIndex = 2;
            lblMinize.Text = "🗕";
            lblMinize.Click += lblMinize_Click;
            // 
            // lblClosed
            // 
            lblClosed.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblClosed.AutoSize = true;
            lblClosed.BackColor = Color.Black;
            lblClosed.Cursor = Cursors.Hand;
            lblClosed.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblClosed.ForeColor = Color.Red;
            lblClosed.Location = new Point(429, 2);
            lblClosed.Name = "lblClosed";
            lblClosed.Size = new Size(33, 28);
            lblClosed.TabIndex = 1;
            lblClosed.Text = "🗙";
            lblClosed.Click += lblClosed_Click;
            // 
            // panelLoginForm
            // 
            panelLoginForm.BackColor = Color.FromArgb(49, 54, 63);
            panelLoginForm.Controls.Add(lblForgetPassword);
            panelLoginForm.Controls.Add(lblSignup);
            panelLoginForm.Controls.Add(lblAdmin);
            panelLoginForm.Controls.Add(lblDontHaveAnAcc);
            panelLoginForm.Controls.Add(cbxShowpassword);
            panelLoginForm.Controls.Add(lblContinue_as);
            panelLoginForm.Controls.Add(lblGetStarted);
            panelLoginForm.Controls.Add(lblPassword);
            panelLoginForm.Controls.Add(tbxPassword);
            panelLoginForm.Controls.Add(tbxUsername);
            panelLoginForm.Controls.Add(lblUsername);
            panelLoginForm.Controls.Add(pbxPassword);
            panelLoginForm.Controls.Add(pbxUsername);
            panelLoginForm.Controls.Add(btnLogin);
            panelLoginForm.Location = new Point(68, 210);
            panelLoginForm.Name = "panelLoginForm";
            panelLoginForm.Size = new Size(337, 388);
            panelLoginForm.TabIndex = 2;
            // 
            // lblForgetPassword
            // 
            lblForgetPassword.AutoSize = true;
            lblForgetPassword.Cursor = Cursors.Hand;
            lblForgetPassword.Font = new Font("Franklin Gothic Demi Cond", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblForgetPassword.ForeColor = Color.Cyan;
            lblForgetPassword.Location = new Point(71, 216);
            lblForgetPassword.Name = "lblForgetPassword";
            lblForgetPassword.Size = new Size(95, 17);
            lblForgetPassword.TabIndex = 15;
            lblForgetPassword.Text = "Forget Password?";
            lblForgetPassword.Click += lblForgetPassword_Click;
            // 
            // lblSignup
            // 
            lblSignup.AutoSize = true;
            lblSignup.Cursor = Cursors.Hand;
            lblSignup.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignup.ForeColor = Color.Cyan;
            lblSignup.Location = new Point(215, 309);
            lblSignup.Name = "lblSignup";
            lblSignup.Size = new Size(61, 21);
            lblSignup.TabIndex = 14;
            lblSignup.Text = "Signup";
            lblSignup.Click += lblSignup_Click;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Cursor = Cursors.Hand;
            lblAdmin.Font = new Font("Franklin Gothic Medium Cond", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdmin.ForeColor = Color.Cyan;
            lblAdmin.Location = new Point(188, 338);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(55, 21);
            lblAdmin.TabIndex = 13;
            lblAdmin.Text = "Admin";
            lblAdmin.Click += lblAdmin_Click;
            // 
            // lblDontHaveAnAcc
            // 
            lblDontHaveAnAcc.AutoSize = true;
            lblDontHaveAnAcc.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblDontHaveAnAcc.ForeColor = Color.White;
            lblDontHaveAnAcc.Location = new Point(81, 310);
            lblDontHaveAnAcc.Name = "lblDontHaveAnAcc";
            lblDontHaveAnAcc.Size = new Size(140, 20);
            lblDontHaveAnAcc.TabIndex = 12;
            lblDontHaveAnAcc.Text = "Don't have an account?";
            // 
            // cbxShowpassword
            // 
            cbxShowpassword.AutoSize = true;
            cbxShowpassword.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point);
            cbxShowpassword.ForeColor = Color.Gainsboro;
            cbxShowpassword.Location = new Point(170, 214);
            cbxShowpassword.Name = "cbxShowpassword";
            cbxShowpassword.Size = new Size(125, 21);
            cbxShowpassword.TabIndex = 11;
            cbxShowpassword.Text = "Show password";
            cbxShowpassword.UseVisualStyleBackColor = true;
            cbxShowpassword.CheckedChanged += cbxShowpassword_CheckedChanged;
            // 
            // lblContinue_as
            // 
            lblContinue_as.AutoSize = true;
            lblContinue_as.Font = new Font("Franklin Gothic Medium Cond", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblContinue_as.ForeColor = Color.White;
            lblContinue_as.Location = new Point(116, 339);
            lblContinue_as.Name = "lblContinue_as";
            lblContinue_as.Size = new Size(75, 20);
            lblContinue_as.TabIndex = 10;
            lblContinue_as.Text = "Continue as";
            // 
            // lblGetStarted
            // 
            lblGetStarted.AutoSize = true;
            lblGetStarted.Font = new Font("Franklin Gothic Medium Cond", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblGetStarted.ForeColor = Color.White;
            lblGetStarted.Location = new Point(101, 17);
            lblGetStarted.Name = "lblGetStarted";
            lblGetStarted.Size = new Size(143, 36);
            lblGetStarted.TabIndex = 9;
            lblGetStarted.Text = "Get Started";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblPassword.ForeColor = Color.Gainsboro;
            lblPassword.Location = new Point(73, 157);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(66, 17);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbxPassword.Location = new Point(72, 177);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '•';
            tbxPassword.Size = new Size(215, 27);
            tbxPassword.TabIndex = 7;
            // 
            // tbxUsername
            // 
            tbxUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            tbxUsername.Location = new Point(72, 106);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(215, 27);
            tbxUsername.TabIndex = 6;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.Gainsboro;
            lblUsername.Location = new Point(73, 86);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(69, 17);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // pbxPassword
            // 
            pbxPassword.Image = (Image)resources.GetObject("pbxPassword.Image");
            pbxPassword.Location = new Point(30, 169);
            pbxPassword.Name = "pbxPassword";
            pbxPassword.Size = new Size(36, 35);
            pbxPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPassword.TabIndex = 4;
            pbxPassword.TabStop = false;
            // 
            // pbxUsername
            // 
            pbxUsername.BackColor = Color.Transparent;
            pbxUsername.Image = (Image)resources.GetObject("pbxUsername.Image");
            pbxUsername.Location = new Point(31, 95);
            pbxUsername.Name = "pbxUsername";
            pbxUsername.Size = new Size(36, 39);
            pbxUsername.SizeMode = PictureBoxSizeMode.Zoom;
            pbxUsername.TabIndex = 3;
            pbxUsername.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.OrangeRed;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(72, 253);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(215, 42);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pbxVelocityLogo
            // 
            pbxVelocityLogo.BackColor = Color.Transparent;
            pbxVelocityLogo.Image = (Image)resources.GetObject("pbxVelocityLogo.Image");
            pbxVelocityLogo.Location = new Point(68, 51);
            pbxVelocityLogo.Name = "pbxVelocityLogo";
            pbxVelocityLogo.Size = new Size(337, 147);
            pbxVelocityLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVelocityLogo.TabIndex = 3;
            pbxVelocityLogo.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 564);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(466, 178);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // guna2Elipse1_StartPage
            // 
            guna2Elipse1_StartPage.BorderRadius = 20;
            guna2Elipse1_StartPage.TargetControl = this;
            // 
            // guna2Elipse1_LoginForm
            // 
            guna2Elipse1_LoginForm.BorderRadius = 36;
            guna2Elipse1_LoginForm.TargetControl = panelLoginForm;
            // 
            // guna2Elipse1_btnLogin
            // 
            guna2Elipse1_btnLogin.BorderRadius = 25;
            guna2Elipse1_btnLogin.TargetControl = btnLogin;
            // 
            // startPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(466, 741);
            Controls.Add(panelLoginForm);
            Controls.Add(pbxVelocityLogo);
            Controls.Add(panelControl);
            Controls.Add(pictureBox4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "startPage";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            panelLoginForm.ResumeLayout(false);
            panelLoginForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxVelocityLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelControl;
        private Label lblMinize;
        private Label lblClosed;
        private Panel panelLoginForm;
        private Button btnLogin;
        private PictureBox pbxPassword;
        private PictureBox pbxUsername;
        private Label lblUsername;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Label lblGetStarted;
        private Label lblPassword;
        private Label lblDontHaveAnAcc;
        private CheckBox cbxShowpassword;
        private Label lblContinue_as;
        private Label lblSignup;
        private Label lblAdmin;
        private PictureBox pbxVelocityLogo;
        private PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1_StartPage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1_LoginForm;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1_btnLogin;
        private Label lblForgetPassword;
    }
}