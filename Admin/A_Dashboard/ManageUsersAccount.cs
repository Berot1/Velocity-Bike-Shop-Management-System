using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Access.Dao;

namespace Velocity_Bike_Shop_Managemennt_System.Admin.A_Dashboard
{
    public partial class ManageUsersAccount : Form
    {
        bool sidebarExpand;
        public Point mouseLocation;
        public ManageUsersAccount()
        {
            InitializeComponent();
            sidebarExpand = false;
            sidebar.Width = sidebar.MinimumSize.Width;
            LoadFile();
        }

        OleDbConnection? con;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new startPage().Show();
            this.Hide();
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

        private void LoadFile()
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb");
                con.Open();

                // Load tbl_users data
                using (da = new OleDbDataAdapter("SELECT * FROM tbl_users", con))
                {
                    ds = new DataSet();
                    da.Fill(ds, "tbl_users");
                    dgvUsersAccount.DataSource = ds.Tables["tbl_users"];
                }

                // Load tbl_Admin data
                using (da = new OleDbDataAdapter("SELECT * FROM tbl_Admin", con))
                {
                    ds = new DataSet();
                    da.Fill(ds, "tbl_Admin");
                    dgvAdminAccount.DataSource = ds.Tables["tbl_Admin"];
                }

                con.Close(); // Close connection when done
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately (e.g., logging, displaying error message)
                MessageBox.Show("An error occurred: " + ex.Message);
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

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            new ManageUsersAccount().Show();
            this.Hide();
        }

        private void btnAAdd_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbxAUsername.Text) || string.IsNullOrWhiteSpace(tbxAPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the username already exists
            if (IsUsernameExists(tbxAUsername.Text, "tbl_Admin"))
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxAdminID.Text = "";
                tbxAUsername.Text = "";
                tbxAPassword.Text = "";
                return;
            }

            string query = "INSERT INTO tbl_Admin (Username, [Password]) VALUES (@Ausername, @Apassword)";

            // Update the column name 'Password' to '[Password]' because it is a reserved keyword in MS Access and needs to be enclosed in square brackets

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Ausername", tbxAUsername.Text);
                cmd.Parameters.AddWithValue("@Apassword", tbxAPassword.Text);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            // Clear textbox values after insertion
            tbxAUsername.Text = "";
            tbxAPassword.Text = "";
            LoadFile();
        }

        private void dgvAdminAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAdminAccount.Rows[e.RowIndex];
                tbxAdminID.Text = row.Cells["AdminID"].Value.ToString();
                tbxAUsername.Text = row.Cells["Username"].Value.ToString();
                tbxAPassword.Text = row.Cells["Password"].Value.ToString();
            }

        }

        private void btnARemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAdminAccount.SelectedCells.Count > 0)
                {
                    // Deleting data based on the selected row's "Student ID" column value
                    int selectedRowIndex = dgvAdminAccount.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvAdminAccount.Rows[selectedRowIndex];
                    string studentID = Convert.ToString(selectedRow.Cells["AdminID"].Value);

                    string query = "DELETE FROM tbl_Admin WHERE [AdminID] = @AdminID";
                    cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@AdminID", studentID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            // Clear textbox values after insertion
            tbxAUsername.Text = "";
            tbxAPassword.Text = "";
            LoadFile();
        }

        private void btnAEdit_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbxAUsername.Text) ||
                string.IsNullOrWhiteSpace(tbxAPassword.Text) ||
                string.IsNullOrWhiteSpace(tbxAdminID.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OleDbConnection connection = null;

            try
            {
                string query = "UPDATE tbl_Admin SET Username = @Ausername, [Password] = @Apassword WHERE [AdminID] = @AdminID";

                connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb");

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Ausername", tbxAUsername.Text);
                    command.Parameters.AddWithValue("@Apassword", tbxAPassword.Text);
                    command.Parameters.AddWithValue("@AdminID", Convert.ToInt32(tbxAdminID.Text)); // Corrected parameter name

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful.");
                    }
                    else
                    {
                        MessageBox.Show("No rows updated. The Admin ID may not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Always ensure connection is closed
                connection?.Close();
            }
            // Clear textbox values after update
            tbxAUsername.Text = "";
            tbxAPassword.Text = "";
            LoadFile();
        }

        private void btnUAdd_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbxUUsername.Text) || string.IsNullOrWhiteSpace(tbxUPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check if the username already exists
            if (IsUsernameExists(tbxUUsername.Text, "tbl_users"))
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxUserID.Text = "";
                tbxUUsername.Text = "";
                tbxUPassword.Text = "";
                return;
            }

            string query = "INSERT INTO tbl_users (Username, [password]) VALUES (@Uusername, @Upassword)";

            // Update the column name 'Password' to '[Password]' because it is a reserved keyword in MS Access and needs to be enclosed in square brackets

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Uusername", tbxUUsername.Text);
                cmd.Parameters.AddWithValue("@Upassword", tbxUPassword.Text); // Corrected parameter names

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            // Clear textbox values after insertion
            tbxUserID.Text = "";
            tbxUUsername.Text = "";
            tbxUPassword.Text = "";
            LoadFile();
        }

        private void btnURemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsersAccount.SelectedCells.Count > 0)
                {
                    // Deleting data based on the selected row's "Student ID" column value
                    int selectedRowIndex = dgvUsersAccount.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvUsersAccount.Rows[selectedRowIndex];
                    string userID = Convert.ToString(selectedRow.Cells["UserID"].Value);

                    string query = "DELETE FROM tbl_users WHERE [UserID] = @UserID";
                    cmd = new OleDbCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            // Clear textbox values after insertion
            tbxUserID.Text = "";
            tbxUUsername.Text = "";
            tbxUPassword.Text = "";
            LoadFile();
        }

        private void btnUEdit_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbxUUsername.Text) ||
                string.IsNullOrWhiteSpace(tbxUPassword.Text) ||
                string.IsNullOrWhiteSpace(tbxUserID.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OleDbConnection connection = null;

            try
            {
                string query = "UPDATE tbl_users SET Username = @Uusername, [password] = @Upassword WHERE [UserID] = @UserID";

                connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb");

                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Uusername", tbxUUsername.Text);
                    command.Parameters.AddWithValue("@Upassword", tbxUPassword.Text);
                    command.Parameters.AddWithValue("@UserID", Convert.ToInt32(tbxUserID.Text)); // Corrected parameter name

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful.");
                    }
                    else
                    {
                        MessageBox.Show("No rows updated. The User ID may not exist.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Always ensure connection is closed
                connection?.Close();
            }
            // Clear textbox values after update
            tbxUserID.Text = "";
            tbxUUsername.Text = "";
            tbxUPassword.Text = "";
            LoadFile();
        }

        private void dgvUsersAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsersAccount.Rows[e.RowIndex];
                tbxUserID.Text = row.Cells["UserID"].Value.ToString();
                tbxUUsername.Text = row.Cells["Username"].Value.ToString();
                tbxUPassword.Text = row.Cells["password"].Value.ToString();
            }
        }
        private bool IsUsernameExists(string username, string tableName)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
            using (OleDbCommand cmd = new OleDbCommand($"SELECT COUNT(*) FROM {tableName} WHERE Username = @Username", con))
            {
                cmd.Parameters.AddWithValue("@Username", username);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            new Admin_POS().Show();
            this.Hide();
        }

        private void btnAProducts_Click(object sender, EventArgs e)
        {
            new Manage_Inventory().Show();
            this.Hide();
        }

        private void btnViewInventoryList_Click(object sender, EventArgs e)
        {
            new View_Inventory_List().Show();
            this.Hide();
        }
    }
}
