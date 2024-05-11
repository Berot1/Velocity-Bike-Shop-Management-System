using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velocity_Bike_Shop_Managemennt_System.Admin.A_Dashboard
{
    public partial class View_Inventory_List : Form
    {
        bool sidebarExpand;
        public Point mouseLocation;
        public View_Inventory_List()
        {
            InitializeComponent();
            sidebarExpand = false;
            sidebar.Width = sidebar.MinimumSize.Width;

            LoadData();
        }

        OleDbConnection? con;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            new AdminDashboard().Show();
            this.Hide();
        }

        private void btnAProducts_Click(object sender, EventArgs e)
        {
            new Manage_Inventory().Show();
            this.Hide();
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            new View_Inventory_List().Show();
            this.Hide();
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            new ManageUsersAccount().Show();
            this.Hide();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            new Admin_POS().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new startPage().Show();
            this.Hide();
        }
        private void LoadData()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = "SELECT * FROM tbl_ProductsQuery";
                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvAllProductInfo.DataSource = dt;
                    }
                }
                dgvAllProductInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchKeyword = tbxSearch.Text.Trim();
            SearchData(searchKeyword);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchKeyword = tbxSearch.Text.Trim();
            SearchData(searchKeyword);
        }
        private void SearchData(string searchKeyword)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    string query = $"SELECT * FROM tbl_ProductsQuery WHERE Name LIKE '%{searchKeyword}%'";
                    using (OleDbDataAdapter da = new OleDbDataAdapter(query, connection))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvAllProductInfo.DataSource = dt;
                    }
                }
                dgvAllProductInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
