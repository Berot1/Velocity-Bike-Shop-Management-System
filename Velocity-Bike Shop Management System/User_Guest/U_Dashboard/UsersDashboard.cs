using System.Data.OleDb;
using Velocity_Bike_Shop_Managemennt_System.User_Guest.U_Dashboard;
using Velocity_Bike_Shop_Managemennt_System.User_Guest.U_Dashboard.Products;

namespace Velocity_Bike_Shop_Managemennt_System
{
    public partial class UsersDashboard : Form
    {
        bool sidebarExpand;
        public Point mouseLocation;
        private string username;
        private UserControlBikes ucBikes;
        private UserControlComponents ucComponents;
        private UserControlAccessories ucAccessories;
        private UserProducts userProductsForm;
        private DataGridView dgvUBills;

        public UsersDashboard()
        {
            InitializeComponent();
            sidebarExpand = false;
            sidebar.Width = sidebar.MinimumSize.Width;

            // Initialize the username label
            Username = username;

            ucBikes = new UserControlBikes();
            ucComponents = new UserControlComponents();
            ucAccessories = new UserControlAccessories();

            this.Controls.Add(ucBikes);
            this.Controls.Add(ucComponents);
            this.Controls.Add(ucAccessories);

            ucBikes.Hide();
            ucComponents.Hide();
            ucAccessories.Hide();

            // Initialize the UserProducts form
            userProductsForm = new UserProducts();

        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                lblUsername.Text = value;
            }
        }

        public DataGridView DgvUBills
        {
            set { dgvUBills = value; }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new startPage().Show();
            this.Hide();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void btnUProducts_Click(object sender, EventArgs e)
        {
            UserProducts userProductsForm = new UserProducts();
            userProductsForm.Username = this.Username; // Pass the username to the new form
            userProductsForm.Show();
            this.Hide();
        }

        private void btnUHome_Click(object sender, EventArgs e)
        {
            UsersDashboard usersDashboardForm = new UsersDashboard();
            usersDashboardForm.Username = this.Username; // Pass the username to the new form
            usersDashboardForm.Show();
            this.Hide();
        }

        //Bikes
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            userProductsForm.ucBikes.Show();
            userProductsForm.ucComponents.Hide();
            userProductsForm.ucAccessories.Hide();
            userProductsForm.Show();
            this.Hide();
            userProductsForm.Username = this.Username;
        }
        //Components
        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            userProductsForm.ucBikes.Hide();
            userProductsForm.ucComponents.Show();
            userProductsForm.ucComponents.BringToFront();
            userProductsForm.ucAccessories.Hide();
            userProductsForm.Show();
            this.Hide();
            userProductsForm.Username = this.Username;
        }
        //Accessories
        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            userProductsForm.ucBikes.Hide();
            userProductsForm.ucComponents.Hide();
            userProductsForm.ucAccessories.Show();
            userProductsForm.ucAccessories.BringToFront();
            userProductsForm.Show();
            this.Hide();
            userProductsForm.Username = this.Username;
        }

        private void pbx795_Blade_Ultegra_Di2_WS_Evo_Click(object sender, EventArgs e)
        {
            userProductsForm.ucBikes.Show();
            userProductsForm.ucComponents.Hide();
            userProductsForm.ucAccessories.Hide();
            userProductsForm.Show();
            this.Hide();
            userProductsForm.Username = this.Username;
        }

        private void pbx795_Blade_Frameset_Click(object sender, EventArgs e)
        {
            userProductsForm.ucBikes.Hide();
            userProductsForm.ucComponents.Show();
            userProductsForm.ucComponents.BringToFront();
            userProductsForm.ucAccessories.Hide();
            userProductsForm.Show();
            this.Hide();
            userProductsForm.Username = this.Username;
        }

        private void pbxSmith_Network_MIPS_Click(object sender, EventArgs e)
        {
            userProductsForm.ucBikes.Hide();
            userProductsForm.ucComponents.Hide();
            userProductsForm.ucAccessories.Show();
            userProductsForm.ucAccessories.BringToFront();
            userProductsForm.Show();
            this.Hide();
            userProductsForm.Username = this.Username;
        }

        private void pbxSmith_Wildcat_Cycling_Click(object sender, EventArgs e)
        {
            userProductsForm.ucBikes.Hide();
            userProductsForm.ucComponents.Hide();
            userProductsForm.ucAccessories.Show();
            userProductsForm.ucAccessories.BringToFront();
            userProductsForm.Show();
            this.Hide();
            userProductsForm.Username = this.Username;
        }

        private void pbxRoval_Rapide_Click(object sender, EventArgs e)
        {
            userProductsForm.ucBikes.Hide();
            userProductsForm.ucComponents.Show();
            userProductsForm.ucComponents.BringToFront();
            userProductsForm.ucAccessories.Hide();
            userProductsForm.Show();
            this.Hide();
            userProductsForm.Username = this.Username;
        }

        private void pbxUSWE_Hydro_Click(object sender, EventArgs e)
        {
            userProductsForm.ucBikes.Hide();
            userProductsForm.ucComponents.Hide();
            userProductsForm.ucAccessories.Show();
            userProductsForm.ucAccessories.BringToFront();
            userProductsForm.Show();
            this.Hide();
            userProductsForm.Username = this.Username;
        }
    }
}
