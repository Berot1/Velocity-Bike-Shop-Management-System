namespace Velocity_Bike_Shop_Managemennt_System.Admin.A_Dashboard
{
    partial class Admin_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_POS));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            sidebarTimer = new System.Windows.Forms.Timer(components);
            guna2Elipse_AdminPOS = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_sidebar = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel_OrderBill = new Panel();
            label1 = new Label();
            cmbPaymentMethod = new ComboBox();
            btnReset = new Button();
            dgvBills = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            btnReceipt = new Button();
            tbxChange = new TextBox();
            label4 = new Label();
            tbxAmount = new TextBox();
            label3 = new Label();
            tbxTotalBill = new TextBox();
            label2 = new Label();
            btnPay = new Button();
            btnRemove = new Button();
            panel_main = new Panel();
            userControlaBikes1 = new UserControlABikes();
            userControlaComponents1 = new UserControlAComponents();
            userControlaAccessories1 = new UserControlAAccessories();
            guna2Elipse_panelOrderBill = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnABikes = new Button();
            btnAAccessories = new Button();
            btnAComponents = new Button();
            pdReceipt = new System.Drawing.Printing.PrintDocument();
            sidebar.SuspendLayout();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxVelocityLogo).BeginInit();
            panel_OrderBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).BeginInit();
            panel_main.SuspendLayout();
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
            btnAProducts.Padding = new Padding(20, 0, 0, 0);
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
            // guna2Elipse_AdminPOS
            // 
            guna2Elipse_AdminPOS.BorderRadius = 30;
            guna2Elipse_AdminPOS.TargetControl = this;
            // 
            // guna2Elipse_sidebar
            // 
            guna2Elipse_sidebar.BorderRadius = 25;
            guna2Elipse_sidebar.TargetControl = sidebar;
            // 
            // panel_OrderBill
            // 
            panel_OrderBill.BackColor = Color.FromArgb(238, 238, 238);
            panel_OrderBill.Controls.Add(label1);
            panel_OrderBill.Controls.Add(cmbPaymentMethod);
            panel_OrderBill.Controls.Add(btnReset);
            panel_OrderBill.Controls.Add(dgvBills);
            panel_OrderBill.Controls.Add(btnReceipt);
            panel_OrderBill.Controls.Add(tbxChange);
            panel_OrderBill.Controls.Add(label4);
            panel_OrderBill.Controls.Add(tbxAmount);
            panel_OrderBill.Controls.Add(label3);
            panel_OrderBill.Controls.Add(tbxTotalBill);
            panel_OrderBill.Controls.Add(label2);
            panel_OrderBill.Controls.Add(btnPay);
            panel_OrderBill.Controls.Add(btnRemove);
            panel_OrderBill.Dock = DockStyle.Right;
            panel_OrderBill.Location = new Point(882, 0);
            panel_OrderBill.Name = "panel_OrderBill";
            panel_OrderBill.Size = new Size(436, 739);
            panel_OrderBill.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(81, 582);
            label1.Name = "label1";
            label1.Size = new Size(153, 23);
            label1.TabIndex = 25;
            label1.Text = "Payment method:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Debit Card" });
            cmbPaymentMethod.Location = new Point(250, 577);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(110, 28);
            cmbPaymentMethod.TabIndex = 24;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(118, 171, 174);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(290, 673);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 45);
            btnReset.TabIndex = 23;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // dgvBills
            // 
            dgvBills.BackgroundColor = Color.FromArgb(118, 171, 174);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBills.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Quantity });
            dgvBills.Location = new Point(6, 57);
            dgvBills.Name = "dgvBills";
            dgvBills.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(118, 171, 174);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvBills.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvBills.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dgvBills.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvBills.RowTemplate.Height = 29;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.Size = new Size(430, 386);
            dgvBills.TabIndex = 22;
            dgvBills.CellFormatting += dgvBills_CellFormatting;
            dgvBills.RowsAdded += dgvBills_RowsAdded;
            // 
            // Product
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Product.DefaultCellStyle = dataGridViewCellStyle2;
            Product.HeaderText = "Product";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 155;
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 125;
            // 
            // Quantity
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 96;
            // 
            // btnReceipt
            // 
            btnReceipt.BackColor = Color.FromArgb(118, 171, 174);
            btnReceipt.FlatAppearance.BorderSize = 0;
            btnReceipt.FlatStyle = FlatStyle.Flat;
            btnReceipt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReceipt.ForeColor = Color.White;
            btnReceipt.Location = new Point(165, 673);
            btnReceipt.Name = "btnReceipt";
            btnReceipt.Size = new Size(119, 45);
            btnReceipt.TabIndex = 21;
            btnReceipt.Text = "Receipt";
            btnReceipt.UseVisualStyleBackColor = false;
            btnReceipt.Click += btnReceipt_Click;
            // 
            // tbxChange
            // 
            tbxChange.BackColor = Color.FromArgb(238, 238, 238);
            tbxChange.BorderStyle = BorderStyle.FixedSingle;
            tbxChange.Location = new Point(185, 535);
            tbxChange.Name = "tbxChange";
            tbxChange.Size = new Size(175, 27);
            tbxChange.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 539);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 19;
            label4.Text = "Change:";
            // 
            // tbxAmount
            // 
            tbxAmount.Location = new Point(185, 502);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(175, 27);
            tbxAmount.TabIndex = 18;
            tbxAmount.TextChanged += tbxAmount_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 506);
            label3.Name = "label3";
            label3.Size = new Size(80, 23);
            label3.TabIndex = 17;
            label3.Text = "Amount:";
            // 
            // tbxTotalBill
            // 
            tbxTotalBill.BackColor = Color.FromArgb(238, 238, 238);
            tbxTotalBill.BorderStyle = BorderStyle.FixedSingle;
            tbxTotalBill.Location = new Point(185, 469);
            tbxTotalBill.Name = "tbxTotalBill";
            tbxTotalBill.Size = new Size(175, 27);
            tbxTotalBill.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 473);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 15;
            label2.Text = "Total Bill:";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(118, 171, 174);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(49, 625);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(351, 42);
            btnPay.TabIndex = 8;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(118, 171, 174);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(49, 673);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(110, 45);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // panel_main
            // 
            panel_main.BackColor = Color.White;
            panel_main.Controls.Add(userControlaBikes1);
            panel_main.Controls.Add(userControlaComponents1);
            panel_main.Controls.Add(userControlaAccessories1);
            panel_main.Location = new Point(96, 75);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(770, 664);
            panel_main.TabIndex = 7;
            // 
            // userControlaBikes1
            // 
            userControlaBikes1.BackColor = Color.White;
            userControlaBikes1.Dock = DockStyle.Fill;
            userControlaBikes1.Location = new Point(0, 0);
            userControlaBikes1.Name = "userControlaBikes1";
            userControlaBikes1.Size = new Size(770, 664);
            userControlaBikes1.TabIndex = 11;
            // 
            // userControlaComponents1
            // 
            userControlaComponents1.BackColor = Color.White;
            userControlaComponents1.Dock = DockStyle.Fill;
            userControlaComponents1.Location = new Point(0, 0);
            userControlaComponents1.Name = "userControlaComponents1";
            userControlaComponents1.Size = new Size(770, 664);
            userControlaComponents1.TabIndex = 11;
            // 
            // userControlaAccessories1
            // 
            userControlaAccessories1.BackColor = Color.White;
            userControlaAccessories1.Dock = DockStyle.Fill;
            userControlaAccessories1.Location = new Point(0, 0);
            userControlaAccessories1.Name = "userControlaAccessories1";
            userControlaAccessories1.Size = new Size(770, 664);
            userControlaAccessories1.TabIndex = 0;
            // 
            // guna2Elipse_panelOrderBill
            // 
            guna2Elipse_panelOrderBill.BorderRadius = 30;
            guna2Elipse_panelOrderBill.TargetControl = panel_OrderBill;
            // 
            // btnABikes
            // 
            btnABikes.BackColor = Color.FromArgb(118, 171, 174);
            btnABikes.FlatAppearance.BorderSize = 0;
            btnABikes.FlatStyle = FlatStyle.Flat;
            btnABikes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnABikes.ForeColor = Color.White;
            btnABikes.ImageAlign = ContentAlignment.MiddleLeft;
            btnABikes.Location = new Point(262, 38);
            btnABikes.Name = "btnABikes";
            btnABikes.Size = new Size(137, 40);
            btnABikes.TabIndex = 8;
            btnABikes.Text = "Bikes";
            btnABikes.UseVisualStyleBackColor = false;
            btnABikes.Click += btnABikes_Click;
            // 
            // btnAAccessories
            // 
            btnAAccessories.BackColor = Color.FromArgb(118, 171, 174);
            btnAAccessories.FlatAppearance.BorderSize = 0;
            btnAAccessories.FlatStyle = FlatStyle.Flat;
            btnAAccessories.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAAccessories.ForeColor = Color.White;
            btnAAccessories.Location = new Point(548, 38);
            btnAAccessories.Name = "btnAAccessories";
            btnAAccessories.Size = new Size(137, 40);
            btnAAccessories.TabIndex = 10;
            btnAAccessories.Text = "Accessories";
            btnAAccessories.UseVisualStyleBackColor = false;
            btnAAccessories.Click += btnAAccessories_Click;
            // 
            // btnAComponents
            // 
            btnAComponents.BackColor = Color.FromArgb(118, 171, 174);
            btnAComponents.FlatAppearance.BorderSize = 0;
            btnAComponents.FlatStyle = FlatStyle.Flat;
            btnAComponents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAComponents.ForeColor = Color.White;
            btnAComponents.ImageAlign = ContentAlignment.MiddleLeft;
            btnAComponents.Location = new Point(405, 38);
            btnAComponents.Name = "btnAComponents";
            btnAComponents.Size = new Size(137, 40);
            btnAComponents.TabIndex = 9;
            btnAComponents.Text = "Components";
            btnAComponents.UseVisualStyleBackColor = false;
            btnAComponents.Click += btnAComponents_Click;
            // 
            // Admin_POS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1318, 739);
            Controls.Add(sidebar);
            Controls.Add(panel_OrderBill);
            Controls.Add(panel_main);
            Controls.Add(btnABikes);
            Controls.Add(btnAComponents);
            Controls.Add(btnAAccessories);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_POS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_POS";
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            sidebar.ResumeLayout(false);
            PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxVelocityLogo).EndInit();
            panel_OrderBill.ResumeLayout(false);
            panel_OrderBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBills).EndInit();
            panel_main.ResumeLayout(false);
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
        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_AdminPOS;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_sidebar;
        private Panel panel_OrderBill;
        private Button btnPay;
        private Button btnRemove;
        private Panel panel_main;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panelOrderBill;
        private TextBox tbxChange;
        private Label label4;
        private TextBox tbxAmount;
        private Label label3;
        private TextBox tbxTotalBill;
        private Label label2;
        private Button btnABikes;
        private Button btnAAccessories;
        private Button btnAComponents;
        private UserControlABikes userControlaBikes1;
        private UserControlAComponents userControlaComponents1;
        private UserControlAAccessories userControlaAccessories1;
        private Button btnReceipt;
        private DataGridView dgvBills;
        private Button btnReset;
        private Button btnAProducts;
        private Label label1;
        private ComboBox cmbPaymentMethod;
        private System.Drawing.Printing.PrintDocument pdReceipt;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
    }
}