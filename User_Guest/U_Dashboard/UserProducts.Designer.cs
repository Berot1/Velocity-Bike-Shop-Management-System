namespace Velocity_Bike_Shop_Managemennt_System.User_Guest.U_Dashboard
{
    partial class UserProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProducts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            sidebar = new FlowLayoutPanel();
            panelMenu = new Panel();
            lblUsername = new Label();
            pbxUsername = new PictureBox();
            btnMenu = new PictureBox();
            btnUHome = new Button();
            btnUProducts = new Button();
            panelLogout = new Panel();
            btnLogout = new Button();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            guna2Elipse_UserProducts = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse_sidebar = new Guna.UI2.WinForms.Guna2Elipse(components);
            panel_main = new Panel();
            userControlAccessories1 = new Products.UserControlAccessories();
            userControlComponents = new Products.UserControlComponents();
            userControlBikes = new Products.UserControlBikes();
            pbxCart = new PictureBox();
            tbxCart = new TextBox();
            dgvUBills = new DataGridView();
            Product = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            btnBuy = new Button();
            lblTotalBill = new Label();
            tbxTotalBill = new TextBox();
            btnRemove = new Button();
            panel_OrderBill = new Panel();
            btnReset = new Button();
            tbxAmount = new TextBox();
            lblAmountPaid = new Label();
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            guna2Elipse_panel_OrderBill = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnComponents = new Button();
            btnAccessories = new Button();
            btnBikes = new Button();
            panel1 = new Panel();
            sidebar.SuspendLayout();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUsername).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).BeginInit();
            panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbxCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUBills).BeginInit();
            panel_OrderBill.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(35, 40, 45);
            sidebar.Controls.Add(panelMenu);
            sidebar.Controls.Add(btnUHome);
            sidebar.Controls.Add(btnUProducts);
            sidebar.Controls.Add(panelLogout);
            sidebar.Controls.Add(btnLogout);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(272, 739);
            sidebar.MinimumSize = new Size(80, 739);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(80, 739);
            sidebar.TabIndex = 3;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(35, 40, 45);
            panelMenu.Controls.Add(lblUsername);
            panelMenu.Controls.Add(pbxUsername);
            panelMenu.Controls.Add(btnMenu);
            panelMenu.Location = new Point(3, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(269, 148);
            panelMenu.TabIndex = 1;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(134, 65);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 20);
            lblUsername.TabIndex = 3;
            // 
            // pbxUsername
            // 
            pbxUsername.Image = (Image)resources.GetObject("pbxUsername.Image");
            pbxUsername.Location = new Point(74, 47);
            pbxUsername.Name = "pbxUsername";
            pbxUsername.Size = new Size(51, 51);
            pbxUsername.SizeMode = PictureBoxSizeMode.Zoom;
            pbxUsername.TabIndex = 2;
            pbxUsername.TabStop = false;
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
            btnMenu.TabIndex = 2;
            btnMenu.TabStop = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnUHome
            // 
            btnUHome.BackColor = Color.FromArgb(35, 40, 45);
            btnUHome.Cursor = Cursors.Hand;
            btnUHome.FlatAppearance.BorderSize = 0;
            btnUHome.FlatStyle = FlatStyle.Flat;
            btnUHome.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUHome.ForeColor = Color.White;
            btnUHome.Image = (Image)resources.GetObject("btnUHome.Image");
            btnUHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnUHome.Location = new Point(3, 157);
            btnUHome.Name = "btnUHome";
            btnUHome.Padding = new Padding(20, 0, 0, 0);
            btnUHome.Size = new Size(269, 44);
            btnUHome.TabIndex = 14;
            btnUHome.Text = "             Home";
            btnUHome.TextAlign = ContentAlignment.MiddleLeft;
            btnUHome.UseVisualStyleBackColor = false;
            btnUHome.Click += btnUHome_Click;
            // 
            // btnUProducts
            // 
            btnUProducts.BackColor = Color.FromArgb(35, 40, 45);
            btnUProducts.Cursor = Cursors.Hand;
            btnUProducts.FlatAppearance.BorderSize = 0;
            btnUProducts.FlatStyle = FlatStyle.Flat;
            btnUProducts.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnUProducts.ForeColor = Color.White;
            btnUProducts.Image = (Image)resources.GetObject("btnUProducts.Image");
            btnUProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnUProducts.Location = new Point(3, 207);
            btnUProducts.Name = "btnUProducts";
            btnUProducts.Padding = new Padding(18, 0, 0, 0);
            btnUProducts.Size = new Size(269, 44);
            btnUProducts.TabIndex = 13;
            btnUProducts.Text = "             Products";
            btnUProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnUProducts.UseVisualStyleBackColor = false;
            btnUProducts.Click += btnUProducts_Click;
            // 
            // panelLogout
            // 
            panelLogout.BackColor = Color.FromArgb(35, 40, 45);
            panelLogout.Location = new Point(3, 257);
            panelLogout.Name = "panelLogout";
            panelLogout.Size = new Size(269, 95);
            panelLogout.TabIndex = 3;
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
            btnLogout.Location = new Point(3, 358);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(14, 0, 0, 0);
            btnLogout.Size = new Size(266, 46);
            btnLogout.TabIndex = 2;
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
            // guna2Elipse_UserProducts
            // 
            guna2Elipse_UserProducts.BorderRadius = 30;
            guna2Elipse_UserProducts.TargetControl = this;
            // 
            // guna2Elipse_sidebar
            // 
            guna2Elipse_sidebar.BorderRadius = 25;
            guna2Elipse_sidebar.TargetControl = sidebar;
            // 
            // panel_main
            // 
            panel_main.Controls.Add(userControlAccessories1);
            panel_main.Controls.Add(userControlComponents);
            panel_main.Controls.Add(userControlBikes);
            panel_main.Location = new Point(89, 60);
            panel_main.Name = "panel_main";
            panel_main.Size = new Size(811, 679);
            panel_main.TabIndex = 4;
            // 
            // userControlAccessories1
            // 
            userControlAccessories1.AutoScroll = true;
            userControlAccessories1.BackColor = Color.White;
            userControlAccessories1.Dock = DockStyle.Fill;
            userControlAccessories1.Location = new Point(0, 0);
            userControlAccessories1.Name = "userControlAccessories1";
            userControlAccessories1.Size = new Size(811, 679);
            userControlAccessories1.TabIndex = 9;
            // 
            // userControlComponents
            // 
            userControlComponents.AutoScroll = true;
            userControlComponents.AutoScrollMargin = new Size(0, 100);
            userControlComponents.BackColor = Color.White;
            userControlComponents.Dock = DockStyle.Fill;
            userControlComponents.Location = new Point(0, 0);
            userControlComponents.Name = "userControlComponents";
            userControlComponents.Size = new Size(811, 679);
            userControlComponents.TabIndex = 7;
            // 
            // userControlBikes
            // 
            userControlBikes.BackColor = Color.White;
            userControlBikes.Dock = DockStyle.Fill;
            userControlBikes.Location = new Point(0, 0);
            userControlBikes.Name = "userControlBikes";
            userControlBikes.Size = new Size(811, 679);
            userControlBikes.TabIndex = 0;
            // 
            // pbxCart
            // 
            pbxCart.Image = (Image)resources.GetObject("pbxCart.Image");
            pbxCart.Location = new Point(2, 15);
            pbxCart.Name = "pbxCart";
            pbxCart.Size = new Size(59, 66);
            pbxCart.SizeMode = PictureBoxSizeMode.Zoom;
            pbxCart.TabIndex = 9;
            pbxCart.TabStop = false;
            // 
            // tbxCart
            // 
            tbxCart.BackColor = Color.FromArgb(238, 238, 238);
            tbxCart.BorderStyle = BorderStyle.None;
            tbxCart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            tbxCart.Location = new Point(920, 32);
            tbxCart.Multiline = true;
            tbxCart.Name = "tbxCart";
            tbxCart.ReadOnly = true;
            tbxCart.Size = new Size(31, 23);
            tbxCart.TabIndex = 10;
            tbxCart.Text = "0";
            tbxCart.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvUBills
            // 
            dgvUBills.BackgroundColor = Color.FromArgb(118, 171, 174);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUBills.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUBills.Columns.AddRange(new DataGridViewColumn[] { Product, Price, Quantity });
            dgvUBills.Location = new Point(906, 88);
            dgvUBills.Name = "dgvUBills";
            dgvUBills.ReadOnly = true;
            dgvUBills.RowHeadersWidth = 51;
            dgvUBills.RowTemplate.Height = 29;
            dgvUBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUBills.Size = new Size(412, 451);
            dgvUBills.TabIndex = 11;
            dgvUBills.CellFormatting += dgvUBills_CellFormatting;
            dgvUBills.RowsAdded += dgvUBills_RowsAdded;
            dgvUBills.RowsRemoved += dgvUBills_RowsRemoved;
            // 
            // Product
            // 
            Product.HeaderText = "Product";
            Product.MinimumWidth = 6;
            Product.Name = "Product";
            Product.ReadOnly = true;
            Product.Width = 150;
            // 
            // Price
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Price.DefaultCellStyle = dataGridViewCellStyle2;
            Price.HeaderText = "Price";
            Price.MinimumWidth = 6;
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Width = 118;
            // 
            // Quantity
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Quantity.DefaultCellStyle = dataGridViewCellStyle3;
            Quantity.HeaderText = "Quantity";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            Quantity.ReadOnly = true;
            Quantity.Width = 90;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(118, 171, 174);
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuy.ForeColor = Color.White;
            btnBuy.Location = new Point(68, 660);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(301, 59);
            btnBuy.TabIndex = 12;
            btnBuy.Text = "Buy";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // lblTotalBill
            // 
            lblTotalBill.AutoSize = true;
            lblTotalBill.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalBill.Location = new Point(92, 553);
            lblTotalBill.Name = "lblTotalBill";
            lblTotalBill.Size = new Size(91, 25);
            lblTotalBill.TabIndex = 13;
            lblTotalBill.Text = "Total Bill:";
            // 
            // tbxTotalBill
            // 
            tbxTotalBill.BackColor = Color.FromArgb(238, 238, 238);
            tbxTotalBill.BorderStyle = BorderStyle.FixedSingle;
            tbxTotalBill.Location = new Point(197, 553);
            tbxTotalBill.Name = "tbxTotalBill";
            tbxTotalBill.Size = new Size(156, 27);
            tbxTotalBill.TabIndex = 14;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(118, 171, 174);
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(222, 26);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(83, 36);
            btnRemove.TabIndex = 15;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // panel_OrderBill
            // 
            panel_OrderBill.BackColor = Color.FromArgb(238, 238, 238);
            panel_OrderBill.Controls.Add(btnReset);
            panel_OrderBill.Controls.Add(tbxAmount);
            panel_OrderBill.Controls.Add(lblAmountPaid);
            panel_OrderBill.Controls.Add(lblPaymentMethod);
            panel_OrderBill.Controls.Add(btnRemove);
            panel_OrderBill.Controls.Add(cmbPaymentMethod);
            panel_OrderBill.Controls.Add(tbxTotalBill);
            panel_OrderBill.Controls.Add(lblTotalBill);
            panel_OrderBill.Controls.Add(btnBuy);
            panel_OrderBill.Controls.Add(pbxCart);
            panel_OrderBill.Dock = DockStyle.Right;
            panel_OrderBill.Location = new Point(906, 0);
            panel_OrderBill.Name = "panel_OrderBill";
            panel_OrderBill.Size = new Size(412, 739);
            panel_OrderBill.TabIndex = 16;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(118, 171, 174);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(317, 26);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(83, 36);
            btnReset.TabIndex = 16;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // tbxAmount
            // 
            tbxAmount.Location = new Point(197, 588);
            tbxAmount.Name = "tbxAmount";
            tbxAmount.Size = new Size(156, 27);
            tbxAmount.TabIndex = 20;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAmountPaid.Location = new Point(94, 592);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(80, 23);
            lblAmountPaid.TabIndex = 19;
            lblAmountPaid.Text = "Amount:";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblPaymentMethod.Location = new Point(80, 627);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(153, 23);
            lblPaymentMethod.TabIndex = 27;
            lblPaymentMethod.Text = "Payment method:";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Debit Card" });
            cmbPaymentMethod.Location = new Point(243, 622);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(110, 28);
            cmbPaymentMethod.TabIndex = 26;
            // 
            // guna2Elipse_panel_OrderBill
            // 
            guna2Elipse_panel_OrderBill.BorderRadius = 30;
            guna2Elipse_panel_OrderBill.TargetControl = panel_OrderBill;
            // 
            // btnComponents
            // 
            btnComponents.BackColor = Color.FromArgb(118, 171, 174);
            btnComponents.FlatAppearance.BorderSize = 0;
            btnComponents.FlatStyle = FlatStyle.Flat;
            btnComponents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnComponents.ForeColor = Color.White;
            btnComponents.Location = new Point(534, 9);
            btnComponents.Name = "btnComponents";
            btnComponents.Size = new Size(137, 40);
            btnComponents.TabIndex = 6;
            btnComponents.Text = "Components";
            btnComponents.UseVisualStyleBackColor = false;
            btnComponents.Click += btnComponents_Click;
            // 
            // btnAccessories
            // 
            btnAccessories.BackColor = Color.FromArgb(118, 171, 174);
            btnAccessories.FlatAppearance.BorderSize = 0;
            btnAccessories.FlatStyle = FlatStyle.Flat;
            btnAccessories.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAccessories.ForeColor = Color.White;
            btnAccessories.Location = new Point(677, 9);
            btnAccessories.Name = "btnAccessories";
            btnAccessories.Size = new Size(137, 40);
            btnAccessories.TabIndex = 7;
            btnAccessories.Text = "Accessories";
            btnAccessories.UseVisualStyleBackColor = false;
            btnAccessories.Click += btnAccessories_Click;
            // 
            // btnBikes
            // 
            btnBikes.BackColor = Color.FromArgb(118, 171, 174);
            btnBikes.FlatAppearance.BorderSize = 0;
            btnBikes.FlatStyle = FlatStyle.Flat;
            btnBikes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBikes.ForeColor = Color.White;
            btnBikes.Location = new Point(391, 9);
            btnBikes.Name = "btnBikes";
            btnBikes.Size = new Size(137, 40);
            btnBikes.TabIndex = 5;
            btnBikes.Text = "Bikes";
            btnBikes.UseVisualStyleBackColor = false;
            btnBikes.Click += btnBikes_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBikes);
            panel1.Controls.Add(btnAccessories);
            panel1.Controls.Add(btnComponents);
            panel1.Location = new Point(86, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(816, 54);
            panel1.TabIndex = 8;
            // 
            // UserProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1318, 739);
            Controls.Add(dgvUBills);
            Controls.Add(tbxCart);
            Controls.Add(sidebar);
            Controls.Add(panel_main);
            Controls.Add(panel1);
            Controls.Add(panel_OrderBill);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserProducts";
            MouseDown += mouse_Down;
            MouseMove += mouse_Move;
            sidebar.ResumeLayout(false);
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbxUsername).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMenu).EndInit();
            panel_main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbxCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUBills).EndInit();
            panel_OrderBill.ResumeLayout(false);
            panel_OrderBill.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel sidebar;
        private Panel panelMenu;
        private PictureBox pbxUsername;
        private PictureBox btnMenu;
        private Button btnUHome;
        private Button btnUProducts;
        private Panel panelLogout;
        private Button btnLogout;
        private System.Windows.Forms.Timer sidebarTimer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_UserProducts;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_sidebar;
        private Panel panel_main;
        private Products.UserControlBikes userControlBikes;
        private Products.UserControlComponents userControlComponents;
        private Products.UserControlAccessories userControlAccessories1;
        private DataGridView dgvUBills;
        private TextBox tbxCart;
        private PictureBox pbxCart;
        private Button btnBuy;
        private TextBox tbxTotalBill;
        private Label lblTotalBill;
        private Button btnRemove;
        private Panel panel_OrderBill;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse_panel_OrderBill;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Quantity;
        private Label lblUsername;
        private Panel panel1;
        private Button btnBikes;
        private Button btnAccessories;
        private Button btnComponents;
        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;
        private TextBox tbxAmount;
        private Label lblAmountPaid;
        private Button btnReset;
    }
}