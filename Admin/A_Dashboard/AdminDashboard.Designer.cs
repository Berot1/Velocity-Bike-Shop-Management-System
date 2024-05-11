namespace Velocity_Bike_Shop_Managemennt_System
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            btnLogout = new Button();
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
            sidebarTimer = new System.Windows.Forms.Timer(components);
            guna2Elipse_AdminDashboard = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_sidebar = new Guna.UI2.WinForms.Guna2Elipse(components);
            panelUsers = new Panel();
            pbxUsers = new PictureBox();
            tbxNumberUsers = new TextBox();
            lblUsers = new Label();
            panelBrands = new Panel();
            tbxTotalBrands = new TextBox();
            pbxBrands = new PictureBox();
            lblBrands = new Label();
            lblStocks = new Label();
            panelTotalStocksperProduct = new Panel();
            tbxComponents = new TextBox();
            tbxBikes = new TextBox();
            tbxAccessories = new TextBox();
            lbl3rd = new Label();
            lbl2nd = new Label();
            lblAccessories = new Label();
            panelTotalStocks = new Panel();
            tbxTotalStocks = new TextBox();
            pbxTotalStocks = new PictureBox();
            lblTotalStocks = new Label();
            guna2Elipse_panelUsers = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panelBrands = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panelOrders = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_panelTotalStocks = new Guna.UI2.WinForms.Guna2Elipse(components);
            PanelBarGraph = new Panel();
            guna2Elipse_PanelBarGraph = new Guna.UI2.WinForms.Guna2Elipse(components);
            panelPieChart = new Panel();
            guna2Elipse_PanelPieChart = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel_AvgIncomePerProductPurchase = new Panel();
            guna2Elipsepanel_AvgIncomePerProductPurchase = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel_WeeklySalesReport = new Panel();
            guna2Elipsepanel_WeeklySalesReport = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel_Clock = new Panel();
            lblClock = new Label();
            guna2Elipsepanel_Clock = new Guna.UI2.WinForms.Guna2Elipse(components);
            Clock = new System.Windows.Forms.Timer(components);
            sidebar.SuspendLayout();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxVelocityLogo).BeginInit();
            panelUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUsers).BeginInit();
            panelBrands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBrands).BeginInit();
            panelTotalStocksperProduct.SuspendLayout();
            panelTotalStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTotalStocks).BeginInit();
            panel_Clock.SuspendLayout();
            SuspendLayout();
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
            sidebar.Controls.Add(btnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(272, 739);
            sidebar.MinimumSize = new Size(80, 739);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(80, 739);
            sidebar.TabIndex = 3;
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
            PanelLogout.Location = new Point(3, 378);
            PanelLogout.Name = "PanelLogout";
            PanelLogout.Size = new Size(269, 102);
            PanelLogout.TabIndex = 9;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 5;
            sidebarTimer.Tick += sidebarTimer_Tick;
            // 
            // guna2Elipse_AdminDashboard
            // 
            guna2Elipse_AdminDashboard.BorderRadius = 30;
            guna2Elipse_AdminDashboard.TargetControl = this;
            // 
            // guna2Elipse_sidebar
            // 
            guna2Elipse_sidebar.BorderRadius = 25;
            guna2Elipse_sidebar.TargetControl = sidebar;
            // 
            // panelUsers
            // 
            panelUsers.BackColor = Color.FromArgb(38, 28, 44);
            panelUsers.Controls.Add(pbxUsers);
            panelUsers.Controls.Add(tbxNumberUsers);
            panelUsers.Controls.Add(lblUsers);
            panelUsers.Location = new Point(114, 57);
            panelUsers.Name = "panelUsers";
            panelUsers.Size = new Size(276, 150);
            panelUsers.TabIndex = 4;
            panelUsers.Paint += panelUsers_Paint;
            // 
            // pbxUsers
            // 
            pbxUsers.Image = (Image)resources.GetObject("pbxUsers.Image");
            pbxUsers.Location = new Point(30, 53);
            pbxUsers.Name = "pbxUsers";
            pbxUsers.Size = new Size(52, 49);
            pbxUsers.SizeMode = PictureBoxSizeMode.Zoom;
            pbxUsers.TabIndex = 6;
            pbxUsers.TabStop = false;
            // 
            // tbxNumberUsers
            // 
            tbxNumberUsers.BackColor = Color.FromArgb(38, 28, 44);
            tbxNumberUsers.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbxNumberUsers.ForeColor = Color.White;
            tbxNumberUsers.Location = new Point(137, 58);
            tbxNumberUsers.Multiline = true;
            tbxNumberUsers.Name = "tbxNumberUsers";
            tbxNumberUsers.ReadOnly = true;
            tbxNumberUsers.Size = new Size(100, 42);
            tbxNumberUsers.TabIndex = 6;
            tbxNumberUsers.TextAlign = HorizontalAlignment.Center;
            // 
            // lblUsers
            // 
            lblUsers.AutoSize = true;
            lblUsers.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsers.ForeColor = Color.White;
            lblUsers.Location = new Point(25, 11);
            lblUsers.Name = "lblUsers";
            lblUsers.Size = new Size(77, 27);
            lblUsers.TabIndex = 0;
            lblUsers.Text = "Users";
            // 
            // panelBrands
            // 
            panelBrands.BackColor = Color.FromArgb(110, 133, 178);
            panelBrands.Controls.Add(tbxTotalBrands);
            panelBrands.Controls.Add(pbxBrands);
            panelBrands.Controls.Add(lblBrands);
            panelBrands.Location = new Point(708, 57);
            panelBrands.Name = "panelBrands";
            panelBrands.Size = new Size(276, 150);
            panelBrands.TabIndex = 5;
            panelBrands.Paint += panelBrands_Paint;
            // 
            // tbxTotalBrands
            // 
            tbxTotalBrands.BackColor = Color.FromArgb(110, 133, 178);
            tbxTotalBrands.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTotalBrands.ForeColor = Color.White;
            tbxTotalBrands.Location = new Point(146, 58);
            tbxTotalBrands.Multiline = true;
            tbxTotalBrands.Name = "tbxTotalBrands";
            tbxTotalBrands.ReadOnly = true;
            tbxTotalBrands.Size = new Size(100, 42);
            tbxTotalBrands.TabIndex = 6;
            tbxTotalBrands.TextAlign = HorizontalAlignment.Center;
            // 
            // pbxBrands
            // 
            pbxBrands.Image = (Image)resources.GetObject("pbxBrands.Image");
            pbxBrands.Location = new Point(38, 53);
            pbxBrands.Name = "pbxBrands";
            pbxBrands.Size = new Size(52, 49);
            pbxBrands.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBrands.TabIndex = 2;
            pbxBrands.TabStop = false;
            // 
            // lblBrands
            // 
            lblBrands.AutoSize = true;
            lblBrands.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblBrands.ForeColor = Color.White;
            lblBrands.Location = new Point(27, 11);
            lblBrands.Name = "lblBrands";
            lblBrands.Size = new Size(93, 27);
            lblBrands.TabIndex = 1;
            lblBrands.Text = "Brands";
            // 
            // lblStocks
            // 
            lblStocks.AutoSize = true;
            lblStocks.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblStocks.ForeColor = Color.White;
            lblStocks.Location = new Point(36, 6);
            lblStocks.Name = "lblStocks";
            lblStocks.Size = new Size(212, 20);
            lblStocks.TabIndex = 1;
            lblStocks.Text = "Total Stocks per Product";
            // 
            // panelTotalStocksperProduct
            // 
            panelTotalStocksperProduct.BackColor = Color.FromArgb(92, 82, 127);
            panelTotalStocksperProduct.Controls.Add(tbxComponents);
            panelTotalStocksperProduct.Controls.Add(tbxBikes);
            panelTotalStocksperProduct.Controls.Add(tbxAccessories);
            panelTotalStocksperProduct.Controls.Add(lbl3rd);
            panelTotalStocksperProduct.Controls.Add(lbl2nd);
            panelTotalStocksperProduct.Controls.Add(lblAccessories);
            panelTotalStocksperProduct.Controls.Add(lblStocks);
            panelTotalStocksperProduct.Location = new Point(412, 57);
            panelTotalStocksperProduct.Name = "panelTotalStocksperProduct";
            panelTotalStocksperProduct.Size = new Size(276, 150);
            panelTotalStocksperProduct.TabIndex = 5;
            panelTotalStocksperProduct.Paint += panelTotalStocksperProduct_Paint;
            // 
            // tbxComponents
            // 
            tbxComponents.BackColor = Color.White;
            tbxComponents.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxComponents.ForeColor = Color.FromArgb(92, 82, 127);
            tbxComponents.Location = new Point(137, 103);
            tbxComponents.Name = "tbxComponents";
            tbxComponents.ReadOnly = true;
            tbxComponents.Size = new Size(98, 30);
            tbxComponents.TabIndex = 14;
            tbxComponents.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxBikes
            // 
            tbxBikes.BackColor = Color.White;
            tbxBikes.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxBikes.ForeColor = Color.FromArgb(92, 82, 127);
            tbxBikes.Location = new Point(137, 68);
            tbxBikes.Name = "tbxBikes";
            tbxBikes.ReadOnly = true;
            tbxBikes.Size = new Size(98, 30);
            tbxBikes.TabIndex = 13;
            tbxBikes.TextAlign = HorizontalAlignment.Center;
            // 
            // tbxAccessories
            // 
            tbxAccessories.BackColor = Color.White;
            tbxAccessories.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxAccessories.ForeColor = Color.FromArgb(92, 82, 127);
            tbxAccessories.Location = new Point(137, 32);
            tbxAccessories.Name = "tbxAccessories";
            tbxAccessories.ReadOnly = true;
            tbxAccessories.Size = new Size(98, 30);
            tbxAccessories.TabIndex = 12;
            tbxAccessories.TextAlign = HorizontalAlignment.Center;
            // 
            // lbl3rd
            // 
            lbl3rd.AutoSize = true;
            lbl3rd.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3rd.ForeColor = Color.White;
            lbl3rd.Location = new Point(25, 115);
            lbl3rd.Name = "lbl3rd";
            lbl3rd.Size = new Size(99, 17);
            lbl3rd.TabIndex = 11;
            lbl3rd.Text = "Components";
            // 
            // lbl2nd
            // 
            lbl2nd.AutoSize = true;
            lbl2nd.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2nd.ForeColor = Color.White;
            lbl2nd.Location = new Point(70, 74);
            lbl2nd.Name = "lbl2nd";
            lbl2nd.Size = new Size(49, 17);
            lbl2nd.TabIndex = 10;
            lbl2nd.Text = "Bikes";
            // 
            // lblAccessories
            // 
            lblAccessories.AutoSize = true;
            lblAccessories.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblAccessories.ForeColor = Color.White;
            lblAccessories.Location = new Point(25, 38);
            lblAccessories.Name = "lblAccessories";
            lblAccessories.Size = new Size(99, 17);
            lblAccessories.TabIndex = 8;
            lblAccessories.Text = "Accessories";
            // 
            // panelTotalStocks
            // 
            panelTotalStocks.BackColor = Color.FromArgb(62, 44, 65);
            panelTotalStocks.Controls.Add(tbxTotalStocks);
            panelTotalStocks.Controls.Add(pbxTotalStocks);
            panelTotalStocks.Controls.Add(lblTotalStocks);
            panelTotalStocks.Location = new Point(1004, 57);
            panelTotalStocks.Name = "panelTotalStocks";
            panelTotalStocks.Size = new Size(276, 150);
            panelTotalStocks.TabIndex = 5;
            panelTotalStocks.Paint += panelTotalStocks_Paint;
            // 
            // tbxTotalStocks
            // 
            tbxTotalStocks.BackColor = Color.FromArgb(62, 44, 65);
            tbxTotalStocks.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tbxTotalStocks.ForeColor = Color.White;
            tbxTotalStocks.Location = new Point(133, 58);
            tbxTotalStocks.Multiline = true;
            tbxTotalStocks.Name = "tbxTotalStocks";
            tbxTotalStocks.ReadOnly = true;
            tbxTotalStocks.Size = new Size(100, 42);
            tbxTotalStocks.TabIndex = 6;
            tbxTotalStocks.TextAlign = HorizontalAlignment.Center;
            // 
            // pbxTotalStocks
            // 
            pbxTotalStocks.Image = (Image)resources.GetObject("pbxTotalStocks.Image");
            pbxTotalStocks.Location = new Point(21, 53);
            pbxTotalStocks.Name = "pbxTotalStocks";
            pbxTotalStocks.Size = new Size(52, 49);
            pbxTotalStocks.SizeMode = PictureBoxSizeMode.Zoom;
            pbxTotalStocks.TabIndex = 2;
            pbxTotalStocks.TabStop = false;
            // 
            // lblTotalStocks
            // 
            lblTotalStocks.AutoSize = true;
            lblTotalStocks.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalStocks.ForeColor = Color.White;
            lblTotalStocks.Location = new Point(17, 11);
            lblTotalStocks.Name = "lblTotalStocks";
            lblTotalStocks.Size = new Size(150, 27);
            lblTotalStocks.TabIndex = 1;
            lblTotalStocks.Text = "Total Stocks";
            // 
            // guna2Elipse_panelUsers
            // 
            guna2Elipse_panelUsers.BorderRadius = 36;
            guna2Elipse_panelUsers.TargetControl = panelUsers;
            // 
            // guna2Elipse_panelBrands
            // 
            guna2Elipse_panelBrands.BorderRadius = 36;
            guna2Elipse_panelBrands.TargetControl = panelBrands;
            // 
            // guna2Elipse_panelOrders
            // 
            guna2Elipse_panelOrders.BorderRadius = 36;
            guna2Elipse_panelOrders.TargetControl = panelTotalStocksperProduct;
            // 
            // guna2Elipse_panelTotalStocks
            // 
            guna2Elipse_panelTotalStocks.BorderRadius = 36;
            guna2Elipse_panelTotalStocks.TargetControl = panelTotalStocks;
            // 
            // PanelBarGraph
            // 
            PanelBarGraph.BackColor = Color.Lavender;
            PanelBarGraph.Location = new Point(114, 233);
            PanelBarGraph.Name = "PanelBarGraph";
            PanelBarGraph.Size = new Size(574, 232);
            PanelBarGraph.TabIndex = 6;
            // 
            // guna2Elipse_PanelBarGraph
            // 
            guna2Elipse_PanelBarGraph.BorderRadius = 35;
            guna2Elipse_PanelBarGraph.TargetControl = PanelBarGraph;
            // 
            // panelPieChart
            // 
            panelPieChart.BackColor = Color.Lavender;
            panelPieChart.Location = new Point(708, 233);
            panelPieChart.Name = "panelPieChart";
            panelPieChart.Size = new Size(572, 232);
            panelPieChart.TabIndex = 7;
            // 
            // guna2Elipse_PanelPieChart
            // 
            guna2Elipse_PanelPieChart.BorderRadius = 35;
            guna2Elipse_PanelPieChart.TargetControl = panelPieChart;
            // 
            // panel_AvgIncomePerProductPurchase
            // 
            panel_AvgIncomePerProductPurchase.BackColor = Color.Lavender;
            panel_AvgIncomePerProductPurchase.Location = new Point(708, 484);
            panel_AvgIncomePerProductPurchase.Name = "panel_AvgIncomePerProductPurchase";
            panel_AvgIncomePerProductPurchase.Size = new Size(572, 220);
            panel_AvgIncomePerProductPurchase.TabIndex = 8;
            // 
            // guna2Elipsepanel_AvgIncomePerProductPurchase
            // 
            guna2Elipsepanel_AvgIncomePerProductPurchase.BorderRadius = 35;
            guna2Elipsepanel_AvgIncomePerProductPurchase.TargetControl = panel_AvgIncomePerProductPurchase;
            // 
            // panel_WeeklySalesReport
            // 
            panel_WeeklySalesReport.BackColor = Color.Lavender;
            panel_WeeklySalesReport.Location = new Point(114, 484);
            panel_WeeklySalesReport.Name = "panel_WeeklySalesReport";
            panel_WeeklySalesReport.Size = new Size(574, 220);
            panel_WeeklySalesReport.TabIndex = 9;
            // 
            // guna2Elipsepanel_WeeklySalesReport
            // 
            guna2Elipsepanel_WeeklySalesReport.BorderRadius = 35;
            guna2Elipsepanel_WeeklySalesReport.TargetControl = panel_WeeklySalesReport;
            // 
            // panel_Clock
            // 
            panel_Clock.BackColor = Color.FromArgb(35, 40, 45);
            panel_Clock.Controls.Add(lblClock);
            panel_Clock.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            panel_Clock.Location = new Point(1144, 12);
            panel_Clock.Name = "panel_Clock";
            panel_Clock.Size = new Size(136, 39);
            panel_Clock.TabIndex = 10;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.Dock = DockStyle.Fill;
            lblClock.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblClock.ForeColor = Color.White;
            lblClock.Location = new Point(0, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(0, 31);
            lblClock.TabIndex = 0;
            lblClock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2Elipsepanel_Clock
            // 
            guna2Elipsepanel_Clock.BorderRadius = 20;
            guna2Elipsepanel_Clock.TargetControl = panel_Clock;
            // 
            // Clock
            // 
            Clock.Enabled = true;
            Clock.Interval = 1000;
            Clock.Tick += Clock_Tick;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1318, 739);
            Controls.Add(panel_Clock);
            Controls.Add(panel_AvgIncomePerProductPurchase);
            Controls.Add(panelTotalStocksperProduct);
            Controls.Add(sidebar);
            Controls.Add(panelUsers);
            Controls.Add(panelBrands);
            Controls.Add(panelTotalStocks);
            Controls.Add(PanelBarGraph);
            Controls.Add(panelPieChart);
            Controls.Add(panel_WeeklySalesReport);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += AdminDashboard_Load;
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            sidebar.ResumeLayout(false);
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxVelocityLogo).EndInit();
            panelUsers.ResumeLayout(false);
            panelUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUsers).EndInit();
            panelBrands.ResumeLayout(false);
            panelBrands.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxBrands).EndInit();
            panelTotalStocksperProduct.ResumeLayout(false);
            panelTotalStocksperProduct.PerformLayout();
            panelTotalStocks.ResumeLayout(false);
            panelTotalStocks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxTotalStocks).EndInit();
            panel_Clock.ResumeLayout(false);
            panel_Clock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private FlowLayoutPanel sidebar;
        private System.Windows.Forms.Timer sidebarTimer;
        private Panel PanelLogout;
        private Panel PanelMenu;
        private PictureBox btnMenu;
        private PictureBox pbxVelocityLogo;
        private Button btnPOS;
        private Button btnUserManage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_AdminDashboard;
        private Button btnViewInventoryList;
        private Button btnHome;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_sidebar;
        private Panel panelUsers;
        private Panel panelTotalStocksperProduct;
        private Panel panelBrands;
        private Panel panelTotalStocks;
        private Label lblTotalStocks;
        private Label lblBrands;
        private Label lblStocks;
        private Label lblUsers;
        private PictureBox pbxUsers;
        private PictureBox pbxBrands;
        private PictureBox pbxTotalStocks;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panelUsers;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panelBrands;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panelOrders;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panelTotalStocks;
        private TextBox tbxNumberUsers;
        private TextBox tbxTotalStocks;
        private TextBox tbxTotalBrands;
        private Button btnAProducts;
        private Panel PanelBarGraph;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_PanelBarGraph;
        private Panel panelPieChart;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_PanelPieChart;
        private Label lbl3rd;
        private Label lbl2nd;
        private Label lblAccessories;
        private TextBox tbxComponents;
        private TextBox tbxBikes;
        private TextBox tbxAccessories;
        private Panel panel_AvgIncomePerProductPurchase;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipsepanel_AvgIncomePerProductPurchase;
        private Panel panel_WeeklySalesReport;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipsepanel_WeeklySalesReport;
        private Panel panel_Clock;
        private Label lblClock;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipsepanel_Clock;
        private System.Windows.Forms.Timer Clock;
    }
}