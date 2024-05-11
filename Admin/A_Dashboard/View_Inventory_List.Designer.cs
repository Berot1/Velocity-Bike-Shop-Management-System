namespace Velocity_Bike_Shop_Managemennt_System.Admin.A_Dashboard
{
    partial class View_Inventory_List
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Inventory_List));
            sidebar = new FlowLayoutPanel();
            PanelMenu = new Panel();
            btnMenu = new PictureBox();
            pbxVelocityLogo = new PictureBox();
            btnHome = new Button();
            btnAProducts = new Button();
            btnManageInventory = new Button();
            btnUserManage = new Button();
            btnPOS = new Button();
            PanelLogout = new Panel();
            btnLogout = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            guna2ElipseView_Inventory_List = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_sidebar = new Guna.UI2.WinForms.Guna2Elipse(components);
            dgvAllProductInfo = new DataGridView();
            btnSearch = new Button();
            tbxSearch = new TextBox();
            guna2Elipse_tbxSearch = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_btnSearch = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_dgvAllProductInfo = new Guna.UI2.WinForms.Guna2Elipse(components);
            sidebar.SuspendLayout();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxVelocityLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllProductInfo).BeginInit();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(PanelMenu);
            sidebar.Controls.Add(btnHome);
            sidebar.Controls.Add(btnAProducts);
            sidebar.Controls.Add(btnManageInventory);
            sidebar.Controls.Add(btnUserManage);
            sidebar.Controls.Add(btnPOS);
            sidebar.Controls.Add(PanelLogout);
            sidebar.Controls.Add(btnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(272, 739);
            sidebar.MinimumSize = new Size(80, 739);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(80, 739);
            sidebar.TabIndex = 4;
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
            btnHome.TabIndex = 14;
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
            btnAProducts.Padding = new Padding(18, 0, 0, 0);
            btnAProducts.Size = new Size(269, 44);
            btnAProducts.TabIndex = 15;
            btnAProducts.Text = "              Manage Inventory";
            btnAProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnAProducts.UseVisualStyleBackColor = false;
            btnAProducts.Click += btnAProducts_Click;
            // 
            // btnManageInventory
            // 
            btnManageInventory.BackColor = Color.FromArgb(35, 40, 45);
            btnManageInventory.Cursor = Cursors.Hand;
            btnManageInventory.FlatAppearance.BorderSize = 0;
            btnManageInventory.FlatStyle = FlatStyle.Flat;
            btnManageInventory.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnManageInventory.ForeColor = Color.White;
            btnManageInventory.Image = (Image)resources.GetObject("btnManageInventory.Image");
            btnManageInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageInventory.Location = new Point(3, 228);
            btnManageInventory.Name = "btnManageInventory";
            btnManageInventory.Padding = new Padding(17, 0, 0, 0);
            btnManageInventory.Size = new Size(269, 44);
            btnManageInventory.TabIndex = 12;
            btnManageInventory.Text = "              View Inventory List";
            btnManageInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnManageInventory.UseVisualStyleBackColor = false;
            btnManageInventory.Click += btnManageInventory_Click;
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
            PanelLogout.Location = new Point(3, 378);
            PanelLogout.Name = "PanelLogout";
            PanelLogout.Size = new Size(269, 102);
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
            btnLogout.Location = new Point(3, 486);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(14, 0, 0, 0);
            btnLogout.Size = new Size(266, 46);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "              Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 2;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // guna2ElipseView_Inventory_List
            // 
            guna2ElipseView_Inventory_List.BorderRadius = 30;
            guna2ElipseView_Inventory_List.TargetControl = this;
            // 
            // guna2Elipse_sidebar
            // 
            guna2Elipse_sidebar.BorderRadius = 25;
            guna2Elipse_sidebar.TargetControl = sidebar;
            // 
            // dgvAllProductInfo
            // 
            dgvAllProductInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAllProductInfo.BackgroundColor = Color.FromArgb(49, 54, 63);
            dgvAllProductInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllProductInfo.Location = new Point(126, 107);
            dgvAllProductInfo.Name = "dgvAllProductInfo";
            dgvAllProductInfo.ReadOnly = true;
            dgvAllProductInfo.RowHeadersWidth = 51;
            dgvAllProductInfo.RowTemplate.Height = 29;
            dgvAllProductInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllProductInfo.Size = new Size(1151, 591);
            dgvAllProductInfo.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(118, 171, 174);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(1163, 56);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 45);
            btnSearch.TabIndex = 24;
            btnSearch.Text = "     Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbxSearch
            // 
            tbxSearch.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxSearch.BackColor = Color.FromArgb(118, 171, 174);
            tbxSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tbxSearch.Location = new Point(126, 53);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(1031, 49);
            tbxSearch.TabIndex = 23;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // guna2Elipse_tbxSearch
            // 
            guna2Elipse_tbxSearch.BorderRadius = 40;
            guna2Elipse_tbxSearch.TargetControl = tbxSearch;
            // 
            // guna2Elipse_btnSearch
            // 
            guna2Elipse_btnSearch.BorderRadius = 30;
            guna2Elipse_btnSearch.TargetControl = btnSearch;
            // 
            // guna2Elipse_dgvAllProductInfo
            // 
            guna2Elipse_dgvAllProductInfo.BorderRadius = 15;
            guna2Elipse_dgvAllProductInfo.TargetControl = dgvAllProductInfo;
            // 
            // View_Inventory_List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1318, 739);
            Controls.Add(btnSearch);
            Controls.Add(tbxSearch);
            Controls.Add(sidebar);
            Controls.Add(dgvAllProductInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View_Inventory_List";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View_Inventory_List";
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            sidebar.ResumeLayout(false);
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxVelocityLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAllProductInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel PanelMenu;
        private PictureBox btnMenu;
        private PictureBox pbxVelocityLogo;
        private Button btnHome;
        private Button btnAProducts;
        private Button btnManageInventory;
        private Button btnUserManage;
        private Button btnPOS;
        private Panel PanelLogout;
        private Button btnLogout;
        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2Elipse guna2ElipseView_Inventory_List;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_sidebar;
        private DataGridView dgvAllProductInfo;
        private Button btnSearch;
        private TextBox tbxSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_tbxSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_btnSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_dgvAllProductInfo;
    }
}