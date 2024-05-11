namespace Velocity_Bike_Shop_Managemennt_System.Admin.A_Dashboard
{
    partial class ManageUsersAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsersAccount));
            sidebar = new FlowLayoutPanel();
            PanelMenu = new Panel();
            btnMenu = new PictureBox();
            pbxVelocityLogo = new PictureBox();
            btnHome = new Button();
            btnAProducts = new Button();
            btnViewInventoryList = new Button();
            btnUserManage = new Button();
            btnPOS = new Button();
            PanelLogout = new Panel();
            btnLogout = new Button();
            guna2Elipse_ManageUsersAccount = new Guna.UI2.WinForms.Guna2Elipse(components);
            sidebarTimer = new System.Windows.Forms.Timer(components);
            dgvUsersAccount = new DataGridView();
            guna2Elipse_sidebar = new Guna.UI2.WinForms.Guna2Elipse(components);
            tbcManageUserAccount = new TabControl();
            AdminAccount = new TabPage();
            panelAdmin = new Panel();
            btnARemove = new Button();
            btnAEdit = new Button();
            btnAAdd = new Button();
            tbxAPassword = new TextBox();
            APassword = new Label();
            tbxAUsername = new TextBox();
            AUsername = new Label();
            tbxAdminID = new TextBox();
            AdminID = new Label();
            dgvAdminAccount = new DataGridView();
            UserAccounts = new TabPage();
            panelUser = new Panel();
            btnURemove = new Button();
            btnUEdit = new Button();
            btnUAdd = new Button();
            tbxUPassword = new TextBox();
            UPassword = new Label();
            tbxUUsername = new TextBox();
            UUsername = new Label();
            tbxUserID = new TextBox();
            UserID = new Label();
            guna2Elipse_tbcManageUserAccount = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_dgvAdminAccount = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_dgvUsersAccount = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panelAdmin = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panelUser = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse__btnAadd = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnAedit = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnAremove = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnUadd = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnUremove = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnUedit = new Guna.UI2.WinForms.Guna2Elipse(components);
            sidebar.SuspendLayout();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxVelocityLogo).BeginInit();
            PanelLogout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsersAccount).BeginInit();
            tbcManageUserAccount.SuspendLayout();
            AdminAccount.SuspendLayout();
            panelAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminAccount).BeginInit();
            UserAccounts.SuspendLayout();
            panelUser.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(PanelMenu);
            sidebar.Controls.Add(btnHome);
            sidebar.Controls.Add(btnAProducts);
            sidebar.Controls.Add(btnViewInventoryList);
            sidebar.Controls.Add(btnUserManage);
            sidebar.Controls.Add(btnPOS);
            sidebar.Controls.Add(PanelLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(272, 739);
            sidebar.MinimumSize = new Size(80, 739);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(80, 739);
            sidebar.TabIndex = 5;
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(35, 40, 45);
            PanelMenu.Controls.Add(btnMenu);
            PanelMenu.Controls.Add(pbxVelocityLogo);
            PanelMenu.Location = new Point(3, 3);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(269, 119);
            PanelMenu.TabIndex = 4;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.FromArgb(35, 40, 45);
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.Image = (Image)resources.GetObject("btnMenu.Image");
            btnMenu.Location = new Point(17, 41);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(42, 34);
            btnMenu.SizeMode = PictureBoxSizeMode.Zoom;
            btnMenu.TabIndex = 1;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pbxVelocityLogo
            // 
            pbxVelocityLogo.Image = (Image)resources.GetObject("pbxVelocityLogo.Image");
            pbxVelocityLogo.Location = new Point(86, 24);
            pbxVelocityLogo.Name = "pbxVelocityLogo";
            pbxVelocityLogo.Size = new Size(132, 55);
            pbxVelocityLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbxVelocityLogo.TabIndex = 1;
            pbxVelocityLogo.TabStop = false;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.FromArgb(35, 40, 45);
            btnHome.Cursor = Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Image = (Image)resources.GetObject("btnHome.Image");
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(3, 128);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(19, 0, 0, 0);
            btnHome.Size = new Size(269, 44);
            btnHome.TabIndex = 13;
            btnHome.Text = "              Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnAProducts
            // 
            btnAProducts.BackColor = Color.FromArgb(35, 40, 45);
            btnAProducts.Cursor = Cursors.Hand;
            btnAProducts.FlatAppearance.BorderSize = 0;
            btnAProducts.FlatStyle = FlatStyle.Flat;
            btnAProducts.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAProducts.ForeColor = Color.White;
            btnAProducts.Image = (Image)resources.GetObject("btnAProducts.Image");
            btnAProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnAProducts.Location = new Point(3, 178);
            btnAProducts.Name = "btnAProducts";
            btnAProducts.Padding = new Padding(20, 0, 0, 0);
            btnAProducts.Size = new Size(269, 44);
            btnAProducts.TabIndex = 14;
            btnAProducts.Text = "              Manage Inventory";
            btnAProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnAProducts.UseVisualStyleBackColor = false;
            btnAProducts.Click += btnAProducts_Click;
            // 
            // btnViewInventoryList
            // 
            btnViewInventoryList.BackColor = Color.FromArgb(35, 40, 45);
            btnViewInventoryList.Cursor = Cursors.Hand;
            btnViewInventoryList.FlatAppearance.BorderSize = 0;
            btnViewInventoryList.FlatStyle = FlatStyle.Flat;
            btnViewInventoryList.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnViewInventoryList.ForeColor = Color.White;
            btnViewInventoryList.Image = (Image)resources.GetObject("btnViewInventoryList.Image");
            btnViewInventoryList.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewInventoryList.Location = new Point(3, 228);
            btnViewInventoryList.Name = "btnViewInventoryList";
            btnViewInventoryList.Padding = new Padding(17, 0, 0, 0);
            btnViewInventoryList.Size = new Size(269, 44);
            btnViewInventoryList.TabIndex = 12;
            btnViewInventoryList.Text = "              View Inventory List";
            btnViewInventoryList.TextAlign = ContentAlignment.MiddleLeft;
            btnViewInventoryList.UseVisualStyleBackColor = false;
            btnViewInventoryList.Click += btnViewInventoryList_Click;
            // 
            // btnUserManage
            // 
            btnUserManage.BackColor = Color.FromArgb(35, 40, 45);
            btnUserManage.Cursor = Cursors.Hand;
            btnUserManage.FlatAppearance.BorderSize = 0;
            btnUserManage.FlatStyle = FlatStyle.Flat;
            btnUserManage.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserManage.ForeColor = Color.White;
            btnUserManage.Image = (Image)resources.GetObject("btnUserManage.Image");
            btnUserManage.ImageAlign = ContentAlignment.MiddleLeft;
            btnUserManage.Location = new Point(3, 278);
            btnUserManage.Name = "btnUserManage";
            btnUserManage.Padding = new Padding(12, 0, 0, 0);
            btnUserManage.Size = new Size(269, 44);
            btnUserManage.TabIndex = 11;
            btnUserManage.Text = "               Manage Accounts";
            btnUserManage.TextAlign = ContentAlignment.MiddleLeft;
            btnUserManage.UseVisualStyleBackColor = false;
            btnUserManage.Click += btnUserManage_Click;
            // 
            // btnPOS
            // 
            btnPOS.BackColor = Color.FromArgb(35, 40, 45);
            btnPOS.Cursor = Cursors.Hand;
            btnPOS.FlatAppearance.BorderSize = 0;
            btnPOS.FlatStyle = FlatStyle.Flat;
            btnPOS.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPOS.ForeColor = Color.White;
            btnPOS.Image = (Image)resources.GetObject("btnPOS.Image");
            btnPOS.ImageAlign = ContentAlignment.MiddleLeft;
            btnPOS.Location = new Point(3, 328);
            btnPOS.Name = "btnPOS";
            btnPOS.Padding = new Padding(12, 0, 0, 0);
            btnPOS.Size = new Size(269, 44);
            btnPOS.TabIndex = 10;
            btnPOS.Text = "               Sales and Point of Sale (POS)";
            btnPOS.TextAlign = ContentAlignment.MiddleLeft;
            btnPOS.UseVisualStyleBackColor = false;
            btnPOS.Click += btnPOS_Click;
            // 
            // PanelLogout
            // 
            PanelLogout.BackColor = Color.FromArgb(35, 40, 45);
            PanelLogout.Controls.Add(btnLogout);
            PanelLogout.Location = new Point(3, 378);
            PanelLogout.Name = "PanelLogout";
            PanelLogout.Size = new Size(269, 138);
            PanelLogout.TabIndex = 9;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(35, 40, 45);
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = (Image)resources.GetObject("btnLogout.Image");
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(1, 46);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(14, 0, 0, 0);
            btnLogout.Size = new Size(266, 46);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "              Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // guna2Elipse_ManageUsersAccount
            // 
            guna2Elipse_ManageUsersAccount.BorderRadius = 30;
            guna2Elipse_ManageUsersAccount.TargetControl = this;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 2;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // dgvUsersAccount
            // 
            dgvUsersAccount.BackgroundColor = Color.FromArgb(49, 54, 63);
            dgvUsersAccount.BorderStyle = BorderStyle.Fixed3D;
            dgvUsersAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsersAccount.Location = new Point(610, 61);
            dgvUsersAccount.Name = "dgvUsersAccount";
            dgvUsersAccount.ReadOnly = true;
            dgvUsersAccount.RowHeadersWidth = 51;
            dgvUsersAccount.RowTemplate.Height = 29;
            dgvUsersAccount.ScrollBars = ScrollBars.None;
            dgvUsersAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsersAccount.Size = new Size(419, 469);
            dgvUsersAccount.TabIndex = 6;
            dgvUsersAccount.CellContentClick += dgvUsersAccount_CellContentClick;
            // 
            // guna2Elipse_sidebar
            // 
            guna2Elipse_sidebar.BorderRadius = 25;
            guna2Elipse_sidebar.TargetControl = sidebar;
            // 
            // tbcManageUserAccount
            // 
            tbcManageUserAccount.Controls.Add(AdminAccount);
            tbcManageUserAccount.Controls.Add(UserAccounts);
            tbcManageUserAccount.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbcManageUserAccount.ItemSize = new Size(547, 55);
            tbcManageUserAccount.Location = new Point(158, 58);
            tbcManageUserAccount.Name = "tbcManageUserAccount";
            tbcManageUserAccount.SelectedIndex = 0;
            tbcManageUserAccount.Size = new Size(1098, 650);
            tbcManageUserAccount.SizeMode = TabSizeMode.Fixed;
            tbcManageUserAccount.TabIndex = 8;
            // 
            // AdminAccount
            // 
            AdminAccount.BackColor = Color.FromArgb(226, 223, 208);
            AdminAccount.Controls.Add(panelAdmin);
            AdminAccount.Controls.Add(dgvAdminAccount);
            AdminAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AdminAccount.Location = new Point(4, 59);
            AdminAccount.Name = "AdminAccount";
            AdminAccount.Padding = new Padding(3);
            AdminAccount.Size = new Size(1090, 587);
            AdminAccount.TabIndex = 0;
            AdminAccount.Text = "Admin Account";
            // 
            // panelAdmin
            // 
            panelAdmin.BackColor = Color.FromArgb(49, 54, 63);
            panelAdmin.Controls.Add(btnARemove);
            panelAdmin.Controls.Add(btnAEdit);
            panelAdmin.Controls.Add(btnAAdd);
            panelAdmin.Controls.Add(tbxAPassword);
            panelAdmin.Controls.Add(APassword);
            panelAdmin.Controls.Add(tbxAUsername);
            panelAdmin.Controls.Add(AUsername);
            panelAdmin.Controls.Add(tbxAdminID);
            panelAdmin.Controls.Add(AdminID);
            panelAdmin.Location = new Point(66, 61);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(438, 353);
            panelAdmin.TabIndex = 1;
            // 
            // btnARemove
            // 
            btnARemove.BackColor = Color.FromArgb(238, 238, 238);
            btnARemove.FlatAppearance.BorderSize = 0;
            btnARemove.FlatStyle = FlatStyle.Flat;
            btnARemove.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnARemove.Image = (Image)resources.GetObject("btnARemove.Image");
            btnARemove.ImageAlign = ContentAlignment.TopCenter;
            btnARemove.Location = new Point(176, 237);
            btnARemove.Name = "btnARemove";
            btnARemove.Padding = new Padding(0, 10, 0, 0);
            btnARemove.Size = new Size(90, 79);
            btnARemove.TabIndex = 8;
            btnARemove.Text = "\r\nRemove";
            btnARemove.UseVisualStyleBackColor = false;
            btnARemove.Click += btnARemove_Click;
            // 
            // btnAEdit
            // 
            btnAEdit.BackColor = Color.FromArgb(238, 238, 238);
            btnAEdit.FlatAppearance.BorderSize = 0;
            btnAEdit.FlatStyle = FlatStyle.Flat;
            btnAEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAEdit.Image = (Image)resources.GetObject("btnAEdit.Image");
            btnAEdit.ImageAlign = ContentAlignment.TopCenter;
            btnAEdit.Location = new Point(288, 237);
            btnAEdit.Name = "btnAEdit";
            btnAEdit.Padding = new Padding(0, 10, 0, 0);
            btnAEdit.Size = new Size(90, 79);
            btnAEdit.TabIndex = 7;
            btnAEdit.Text = "\r\nEdit";
            btnAEdit.UseVisualStyleBackColor = false;
            btnAEdit.Click += btnAEdit_Click;
            // 
            // btnAAdd
            // 
            btnAAdd.BackColor = Color.FromArgb(238, 238, 238);
            btnAAdd.FlatAppearance.BorderSize = 0;
            btnAAdd.FlatStyle = FlatStyle.Flat;
            btnAAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAAdd.Image = (Image)resources.GetObject("btnAAdd.Image");
            btnAAdd.ImageAlign = ContentAlignment.TopCenter;
            btnAAdd.Location = new Point(63, 237);
            btnAAdd.Name = "btnAAdd";
            btnAAdd.Padding = new Padding(0, 10, 0, 0);
            btnAAdd.Size = new Size(90, 79);
            btnAAdd.TabIndex = 6;
            btnAAdd.Text = "\r\nAdd";
            btnAAdd.UseVisualStyleBackColor = false;
            btnAAdd.Click += btnAAdd_Click;
            // 
            // tbxAPassword
            // 
            tbxAPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbxAPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxAPassword.Location = new Point(156, 173);
            tbxAPassword.Name = "tbxAPassword";
            tbxAPassword.Size = new Size(236, 30);
            tbxAPassword.TabIndex = 5;
            // 
            // APassword
            // 
            APassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            APassword.AutoSize = true;
            APassword.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            APassword.ForeColor = Color.WhiteSmoke;
            APassword.Location = new Point(39, 180);
            APassword.Name = "APassword";
            APassword.Size = new Size(89, 22);
            APassword.TabIndex = 4;
            APassword.Text = "Password:";
            // 
            // tbxAUsername
            // 
            tbxAUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbxAUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxAUsername.Location = new Point(156, 104);
            tbxAUsername.Name = "tbxAUsername";
            tbxAUsername.Size = new Size(236, 30);
            tbxAUsername.TabIndex = 3;
            // 
            // AUsername
            // 
            AUsername.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AUsername.AutoSize = true;
            AUsername.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AUsername.ForeColor = Color.WhiteSmoke;
            AUsername.Location = new Point(39, 111);
            AUsername.Name = "AUsername";
            AUsername.Size = new Size(93, 22);
            AUsername.TabIndex = 2;
            AUsername.Text = "Username:";
            // 
            // tbxAdminID
            // 
            tbxAdminID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            tbxAdminID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxAdminID.Location = new Point(156, 48);
            tbxAdminID.Name = "tbxAdminID";
            tbxAdminID.Size = new Size(236, 30);
            tbxAdminID.TabIndex = 1;
            // 
            // AdminID
            // 
            AdminID.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AdminID.AutoSize = true;
            AdminID.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AdminID.ForeColor = Color.WhiteSmoke;
            AdminID.Location = new Point(39, 55);
            AdminID.Name = "AdminID";
            AdminID.Size = new Size(87, 22);
            AdminID.TabIndex = 0;
            AdminID.Text = "Admin ID:";
            // 
            // dgvAdminAccount
            // 
            dgvAdminAccount.BackgroundColor = Color.FromArgb(49, 54, 63);
            dgvAdminAccount.BorderStyle = BorderStyle.Fixed3D;
            dgvAdminAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdminAccount.Location = new Point(612, 61);
            dgvAdminAccount.Name = "dgvAdminAccount";
            dgvAdminAccount.ReadOnly = true;
            dgvAdminAccount.RowHeadersWidth = 51;
            dgvAdminAccount.RowTemplate.Height = 29;
            dgvAdminAccount.ScrollBars = ScrollBars.None;
            dgvAdminAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAdminAccount.Size = new Size(419, 469);
            dgvAdminAccount.TabIndex = 0;
            dgvAdminAccount.CellContentClick += dgvAdminAccount_CellContentClick;
            // 
            // UserAccounts
            // 
            UserAccounts.BackColor = Color.FromArgb(226, 223, 208);
            UserAccounts.Controls.Add(panelUser);
            UserAccounts.Controls.Add(dgvUsersAccount);
            UserAccounts.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            UserAccounts.Location = new Point(4, 59);
            UserAccounts.Name = "UserAccounts";
            UserAccounts.Padding = new Padding(3);
            UserAccounts.Size = new Size(1090, 587);
            UserAccounts.TabIndex = 1;
            UserAccounts.Text = "User Accounts";
            // 
            // panelUser
            // 
            panelUser.BackColor = Color.FromArgb(49, 54, 63);
            panelUser.Controls.Add(btnURemove);
            panelUser.Controls.Add(btnUEdit);
            panelUser.Controls.Add(btnUAdd);
            panelUser.Controls.Add(tbxUPassword);
            panelUser.Controls.Add(UPassword);
            panelUser.Controls.Add(tbxUUsername);
            panelUser.Controls.Add(UUsername);
            panelUser.Controls.Add(tbxUserID);
            panelUser.Controls.Add(UserID);
            panelUser.Location = new Point(64, 61);
            panelUser.Name = "panelUser";
            panelUser.Size = new Size(453, 368);
            panelUser.TabIndex = 7;
            // 
            // btnURemove
            // 
            btnURemove.BackColor = Color.FromArgb(238, 238, 238);
            btnURemove.FlatAppearance.BorderSize = 0;
            btnURemove.FlatStyle = FlatStyle.Flat;
            btnURemove.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnURemove.Image = (Image)resources.GetObject("btnURemove.Image");
            btnURemove.ImageAlign = ContentAlignment.TopCenter;
            btnURemove.Location = new Point(186, 247);
            btnURemove.Name = "btnURemove";
            btnURemove.Padding = new Padding(0, 10, 0, 0);
            btnURemove.Size = new Size(90, 79);
            btnURemove.TabIndex = 14;
            btnURemove.Text = "\r\nRemove";
            btnURemove.UseVisualStyleBackColor = false;
            btnURemove.Click += btnURemove_Click;
            // 
            // btnUEdit
            // 
            btnUEdit.BackColor = Color.FromArgb(238, 238, 238);
            btnUEdit.FlatAppearance.BorderSize = 0;
            btnUEdit.FlatStyle = FlatStyle.Flat;
            btnUEdit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUEdit.Image = (Image)resources.GetObject("btnUEdit.Image");
            btnUEdit.ImageAlign = ContentAlignment.TopCenter;
            btnUEdit.Location = new Point(297, 247);
            btnUEdit.Name = "btnUEdit";
            btnUEdit.Padding = new Padding(0, 10, 0, 0);
            btnUEdit.Size = new Size(90, 79);
            btnUEdit.TabIndex = 13;
            btnUEdit.Text = "\r\nEdit";
            btnUEdit.UseVisualStyleBackColor = false;
            btnUEdit.Click += btnUEdit_Click;
            // 
            // btnUAdd
            // 
            btnUAdd.BackColor = Color.FromArgb(238, 238, 238);
            btnUAdd.FlatAppearance.BorderSize = 0;
            btnUAdd.FlatStyle = FlatStyle.Flat;
            btnUAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnUAdd.Image = (Image)resources.GetObject("btnUAdd.Image");
            btnUAdd.ImageAlign = ContentAlignment.TopCenter;
            btnUAdd.Location = new Point(73, 247);
            btnUAdd.Name = "btnUAdd";
            btnUAdd.Padding = new Padding(0, 10, 0, 0);
            btnUAdd.Size = new Size(90, 79);
            btnUAdd.TabIndex = 12;
            btnUAdd.Text = "\r\nAdd";
            btnUAdd.UseVisualStyleBackColor = false;
            btnUAdd.Click += btnUAdd_Click;
            // 
            // tbxUPassword
            // 
            tbxUPassword.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxUPassword.Location = new Point(152, 174);
            tbxUPassword.Name = "tbxUPassword";
            tbxUPassword.Size = new Size(255, 30);
            tbxUPassword.TabIndex = 11;
            // 
            // UPassword
            // 
            UPassword.AutoSize = true;
            UPassword.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UPassword.ForeColor = Color.WhiteSmoke;
            UPassword.Location = new Point(46, 181);
            UPassword.Name = "UPassword";
            UPassword.Size = new Size(89, 22);
            UPassword.TabIndex = 10;
            UPassword.Text = "Password:";
            // 
            // tbxUUsername
            // 
            tbxUUsername.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxUUsername.Location = new Point(152, 105);
            tbxUUsername.Name = "tbxUUsername";
            tbxUUsername.Size = new Size(255, 30);
            tbxUUsername.TabIndex = 9;
            // 
            // UUsername
            // 
            UUsername.AutoSize = true;
            UUsername.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UUsername.ForeColor = Color.WhiteSmoke;
            UUsername.Location = new Point(46, 112);
            UUsername.Name = "UUsername";
            UUsername.Size = new Size(93, 22);
            UUsername.TabIndex = 8;
            UUsername.Text = "Username:";
            // 
            // tbxUserID
            // 
            tbxUserID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxUserID.Location = new Point(152, 49);
            tbxUserID.Name = "tbxUserID";
            tbxUserID.Size = new Size(255, 30);
            tbxUserID.TabIndex = 7;
            // 
            // UserID
            // 
            UserID.AutoSize = true;
            UserID.Font = new Font("Segoe UI Variable Display", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            UserID.ForeColor = Color.WhiteSmoke;
            UserID.Location = new Point(46, 56);
            UserID.Name = "UserID";
            UserID.Size = new Size(71, 22);
            UserID.TabIndex = 6;
            UserID.Text = "User ID:";
            // 
            // guna2Elipse_tbcManageUserAccount
            // 
            guna2Elipse_tbcManageUserAccount.BorderRadius = 50;
            guna2Elipse_tbcManageUserAccount.TargetControl = tbcManageUserAccount;
            // 
            // guna2Elipse_dgvAdminAccount
            // 
            guna2Elipse_dgvAdminAccount.BorderRadius = 20;
            guna2Elipse_dgvAdminAccount.TargetControl = dgvAdminAccount;
            // 
            // guna2Elipse_dgvUsersAccount
            // 
            guna2Elipse_dgvUsersAccount.BorderRadius = 20;
            guna2Elipse_dgvUsersAccount.TargetControl = dgvUsersAccount;
            // 
            // guna2Elipse_panelAdmin
            // 
            guna2Elipse_panelAdmin.BorderRadius = 25;
            guna2Elipse_panelAdmin.TargetControl = panelAdmin;
            // 
            // guna2Elipse_panelUser
            // 
            guna2Elipse_panelUser.BorderRadius = 25;
            guna2Elipse_panelUser.TargetControl = panelUser;
            // 
            // guna2Elipse__btnAadd
            // 
            guna2Elipse__btnAadd.BorderRadius = 20;
            guna2Elipse__btnAadd.TargetControl = btnAAdd;
            // 
            // guna2Elipse_btnAedit
            // 
            guna2Elipse_btnAedit.BorderRadius = 20;
            guna2Elipse_btnAedit.TargetControl = btnAEdit;
            // 
            // guna2Elipse_btnAremove
            // 
            guna2Elipse_btnAremove.BorderRadius = 20;
            guna2Elipse_btnAremove.TargetControl = btnARemove;
            // 
            // guna2Elipse_btnUadd
            // 
            guna2Elipse_btnUadd.BorderRadius = 20;
            guna2Elipse_btnUadd.TargetControl = btnUAdd;
            // 
            // guna2Elipse_btnUremove
            // 
            guna2Elipse_btnUremove.BorderRadius = 20;
            guna2Elipse_btnUremove.TargetControl = btnURemove;
            // 
            // guna2Elipse_btnUedit
            // 
            guna2Elipse_btnUedit.BorderRadius = 20;
            guna2Elipse_btnUedit.TargetControl = btnUEdit;
            // 
            // ManageUsersAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(1318, 739);
            Controls.Add(sidebar);
            Controls.Add(tbcManageUserAccount);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsersAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsersAccount";
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            sidebar.ResumeLayout(false);
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxVelocityLogo).EndInit();
            PanelLogout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsersAccount).EndInit();
            tbcManageUserAccount.ResumeLayout(false);
            AdminAccount.ResumeLayout(false);
            panelAdmin.ResumeLayout(false);
            panelAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAdminAccount).EndInit();
            UserAccounts.ResumeLayout(false);
            panelUser.ResumeLayout(false);
            panelUser.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel PanelMenu;
        private PictureBox btnMenu;
        private PictureBox pbxVelocityLogo;
        private Button btnHome;
        private Button btnViewInventoryList;
        private Button btnUserManage;
        private Button btnPOS;
        private Panel PanelLogout;
        private Button btnLogout;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_ManageUsersAccount;
        private System.Windows.Forms.Timer sidebarTimer;
        private DataGridView dgvUsersAccount;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_sidebar;
        private TabControl tbcManageUserAccount;
        private TabPage AdminAccount;
        private TabPage UserAccounts;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_tbcManageUserAccount;
        private DataGridView dgvAdminAccount;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_dgvAdminAccount;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_dgvUsersAccount;
        private Panel panelAdmin;
        private Panel panelUser;
        private TextBox tbxAPassword;
        private Label APassword;
        private TextBox tbxAUsername;
        private Label AUsername;
        private TextBox tbxAdminID;
        private Label AdminID;
        private TextBox tbxUPassword;
        private Label UPassword;
        private TextBox tbxUUsername;
        private Label UUsername;
        private TextBox tbxUserID;
        private Label UserID;
        private Button btnARemove;
        private Button btnAEdit;
        private Button btnAAdd;
        private Button btnURemove;
        private Button btnUEdit;
        private Button btnUAdd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panelAdmin;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panelUser;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse__btnAadd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnAedit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnAremove;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnUadd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnUremove;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnUedit;
        private Button btnAProducts;
    }
}