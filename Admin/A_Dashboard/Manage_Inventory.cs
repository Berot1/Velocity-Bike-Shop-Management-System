﻿using Microsoft.Office.Interop.Access.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Policy;

namespace Velocity_Bike_Shop_Managemennt_System.Admin.A_Dashboard
{
    public partial class Manage_Inventory : Form
    {
        bool sidebarExpand;
        public Point mouseLocation;
        public Manage_Inventory()
        {
            InitializeComponent();
            sidebarExpand = false;
            sidebar.Width = sidebar.MinimumSize.Width;
            LoadFile();
            // Subscribe to the Click event of btnSearch
            btnSearch.Click += btnSearch_Click;
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
        private DataSet LoadFile()
        {
            DataSet dataSet = new DataSet();

            con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb");

            // Load bikes data
            da = new OleDbDataAdapter("SELECT * FROM tbl_BikesQuery", con);
            con.Open();
            da.Fill(dataSet, "tbl_BikesQuery");
            dgvBikeInfo.DataSource = dataSet.Tables["tbl_BikesQuery"];
            con.Close();

            // Load components data
            da = new OleDbDataAdapter("SELECT * FROM tbl_ComponentsQuery", con);
            con.Open();
            da.Fill(dataSet, "tbl_ComponentsQuery");
            dgvComponentInfo.DataSource = dataSet.Tables["tbl_ComponentsQuery"]; // Assign to different DataGridView
            con.Close();

            // Load accessoriess data
            da = new OleDbDataAdapter("SELECT * FROM tbl_AccessoriesQuery", con);
            con.Open();
            da.Fill(dataSet, "tbl_AccessoriesQuery");
            dgvAccessoriesInfo.DataSource = dataSet.Tables["tbl_AccessoriesQuery"]; // Assign to different DataGridView
            con.Close();

            return dataSet;
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            new startPage().Show();
            this.Hide();
        }
        //Add items in bikes
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbxBikeCategory.Text) ||
                string.IsNullOrWhiteSpace(tbxBikeName.Text) ||
                string.IsNullOrWhiteSpace(tbxBikeModel.Text) ||
                string.IsNullOrWhiteSpace(tbxBikeBrand.Text) ||
                string.IsNullOrWhiteSpace(tbxBikePrice.Text) ||
                string.IsNullOrWhiteSpace(tbxBikeColor.Text) ||
                string.IsNullOrWhiteSpace(tbxBikeStocks.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert the price from currency-formatted string to decimal
            if (!decimal.TryParse(tbxBikePrice.Text, System.Globalization.NumberStyles.Currency, null, out decimal price))
            {
                MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO tbl_BikesQuery (Category, Name, Model, Brand, Price, Color, Stocks) VALUES (@Bcategory, @Bname, @Bmodel, @Bbrand, @Bprice, @Bcolor, @Bstocks)";

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Bcategory", tbxBikeCategory.Text);
                cmd.Parameters.AddWithValue("@Bname", tbxBikeName.Text);
                cmd.Parameters.AddWithValue("@Bmodel", tbxBikeModel.Text);
                cmd.Parameters.AddWithValue("@Bbrand", tbxBikeBrand.Text);
                cmd.Parameters.AddWithValue("@Bprice", price); // Insert the decimal price.
                cmd.Parameters.AddWithValue("@Bcolor", tbxBikeColor.Text);
                cmd.Parameters.AddWithValue("@Bstocks", tbxBikeStocks.Text);

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
            }

            // Clear textbox values after insertion
            tbxBikeCategory.Text = "";
            tbxBikeName.Text = "";
            tbxBikeModel.Text = "";
            tbxBikeBrand.Text = "";
            tbxBikePrice.Text = "";
            tbxBikeColor.Text = "";
            tbxBikeStocks.Text = "";
            LoadFile();
        }
        //Remove items in bikes
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBikeInfo.SelectedCells.Count > 0)
                {
                    // Deleting data based on the selected row's "Bike_id" column value
                    int selectedRowIndex = dgvBikeInfo.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvBikeInfo.Rows[selectedRowIndex];
                    string bikeID = Convert.ToString(selectedRow.Cells["BikeID"].Value);

                    string query = "DELETE FROM tbl_BikesQuery WHERE [BikeID] = " + bikeID;
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LoadFile(); // Refresh the data after deletion
        }
        //Update items in bikes
        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbxBikeCategory.Text) ||
                string.IsNullOrWhiteSpace(tbxBikeName.Text) ||
                string.IsNullOrWhiteSpace(tbxBikeModel.Text) ||
                string.IsNullOrWhiteSpace(tbxBikeBrand.Text) ||
                string.IsNullOrWhiteSpace(tbxBikePrice.Text) ||
                string.IsNullOrWhiteSpace(tbxBikeColor.Text) ||
                string.IsNullOrWhiteSpace(tbxBikeStocks.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "UPDATE tbl_BikesQuery SET Category = @Bcategory, Name = @Bname, Model = @Bmodel, Brand = @Bbrand, Price = @Bprice, Color = @Bcolor, Stocks = @Bstocks WHERE BikeID = @OldBId";

                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Convert the price from currency-formatted string to decimal
                        if (!decimal.TryParse(tbxBikePrice.Text, System.Globalization.NumberStyles.Currency, null, out decimal price))
                        {
                            MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        command.Parameters.AddWithValue("@Bcategory", tbxBikeCategory.Text);
                        command.Parameters.AddWithValue("@Bname", tbxBikeName.Text);
                        command.Parameters.AddWithValue("@Bmodel", tbxBikeModel.Text);
                        command.Parameters.AddWithValue("@Bbrand", tbxBikeBrand.Text);
                        command.Parameters.AddWithValue("@Bprice", price); // Insert the decimal price
                        command.Parameters.AddWithValue("@Bcolor", tbxBikeColor.Text);
                        command.Parameters.AddWithValue("@Bstocks", tbxBikeStocks.Text);
                        command.Parameters.AddWithValue("@OldBId", dgvBikeInfo.CurrentRow.Cells["BikeID"].Value.ToString()); // Assuming you have a DataGridView called dgvBikeInfo

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful.");
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. The bike ID may not exist in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LoadFile(); // Load data after update
            // Clear textbox values after insertion
            tbxBikeId.Text = "";
            tbxBikeCategory.Text = "";
            tbxBikeName.Text = "";
            tbxBikeModel.Text = "";
            tbxBikeBrand.Text = "";
            tbxBikePrice.Text = "";
            tbxBikeColor.Text = "";
            tbxBikeStocks.Text = "";
        }
        //Bike Datagridview
        private void dgvBikeInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBikeInfo.Rows[e.RowIndex];
                tbxBikeId.Text = row.Cells["BikeID"].Value.ToString();
                tbxBikeCategory.Text = row.Cells["Category"].Value.ToString();
                tbxBikeName.Text = row.Cells["Name"].Value.ToString();
                tbxBikeModel.Text = row.Cells["Model"].Value.ToString();
                tbxBikeBrand.Text = row.Cells["Brand"].Value.ToString();

                // Convert the currency value to a string for display
                if (decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price))
                {
                    tbxBikePrice.Text = price.ToString("C");
                }
                else
                {
                    tbxBikePrice.Text = "Invalid Price";
                }
                tbxBikeColor.Text = row.Cells["Color"].Value.ToString();
                tbxBikeStocks.Text = row.Cells["Stocks"].Value.ToString();

                BikeDisplayImageFromDatabase(Convert.ToInt32(row.Cells["BikeID"].Value));
            }
        }
        private void BikeDisplayImageFromDatabase(int bikeID)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
                {
                    connection.Open();
                    string sql = "SELECT BikeImage FROM tbl_BikesQuery WHERE BikeID = @BikeID";

                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@BikeID", bikeID);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageBytes = (byte[])reader[0];

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    BikePicture.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                BikePicture.Image = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying image: " + ex.Message);
            }
        }

        private void BInsertImageToDatabase(string imageFilePath, int bikeID)
        {
            byte[] imageData;
            using (FileStream fs = new FileStream(imageFilePath, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
            }
            using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
            {
                connection.Open();
                string sql = "UPDATE tbl_BikesQuery SET BikeImage = ? WHERE BikeID = @BikeID";

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("?", imageData);
                    command.Parameters.AddWithValue("@BikeID", bikeID);
                    command.ExecuteNonQuery();
                }
            }
        }
        //Bike uploadImage
        private void btnUpdloadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imageFilePath = openFileDialog.FileName;
                int selectedBikeID = Convert.ToInt32(dgvBikeInfo.SelectedRows[0].Cells["BikeID"].Value);
                BInsertImageToDatabase(imageFilePath, selectedBikeID);
            }
            LoadFile();
        }
        //Clear tbx in Bikes
        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxBikeId.Text = "";
            tbxBikeCategory.Text = "";
            tbxBikeName.Text = "";
            tbxBikeModel.Text = "";
            tbxBikeBrand.Text = "";
            tbxBikePrice.Text = "";
            tbxBikeColor.Text = "";
            tbxBikeStocks.Text = "";
            tbxSearch.Text = "";
            BikePicture.Image = null;
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            new ManageUsersAccount().Show();
            this.Hide();
        }
        //Bike Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Get the search keyword entered by the user
            string searchKeyword = tbxSearch.Text.Trim();

            // If the search keyword is empty, reload the original data
            if (string.IsNullOrEmpty(searchKeyword))
            {
                ds = LoadFile();
                return;
            }

            // Filter the data based on the search keyword
            if (ds == null)
            {
                ds = LoadFile();
            }

            DataView dv = ds.Tables["tbl_BikesQuery"].DefaultView;
            dv.RowFilter = $"Name LIKE '%{searchKeyword}%'";

            // Update the DataGridView with the filtered data
            dgvBikeInfo.DataSource = dv.ToTable();
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search keyword entered by the user
            string searchKeyword = tbxSearch.Text.Trim();

            // If the search keyword is empty, reload the original data
            if (string.IsNullOrEmpty(searchKeyword))
            {
                ds = LoadFile();
                return;
            }

            // Filter the data based on the search keyword
            if (ds == null)
            {
                ds = LoadFile();
            }

            DataView dv = ds.Tables["tbl_BikesQuery"].DefaultView;
            dv.RowFilter = $"Name LIKE '%{searchKeyword}%'";

            // Update the DataGridView with the filtered data
            dgvBikeInfo.DataSource = dv.ToTable();
        }

        //Component Datagridview
        private void dgvComponentInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvComponentInfo.Rows[e.RowIndex];
                tbxComponentID.Text = row.Cells["ComponentID"].Value.ToString();
                tbxComponentCategory.Text = row.Cells["Category"].Value.ToString();
                tbxComponentName.Text = row.Cells["ComponentName"].Value.ToString();
                tbxComponentModel.Text = row.Cells["Model"].Value.ToString();
                tbxComponentBrand.Text = row.Cells["Brand"].Value.ToString();
                tbxComponentColor.Text = row.Cells["Color"].Value.ToString();
                tbxComponentStocks.Text = row.Cells["Stocks"].Value.ToString();

                // Convert the currency value to a string for display
                if (decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price))
                {
                    tbxComponentPrice.Text = price.ToString("C");
                }
                else
                {
                    // Handle conversion failure, perhaps set an appropriate default value or show an error message
                    tbxComponentPrice.Text = "Invalid Price";
                }

                ComponentDisplayImageFromDatabase(Convert.ToInt32(row.Cells["ComponentID"].Value));
            }
        }
        private void ComponentDisplayImageFromDatabase(int componentID)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
                {
                    connection.Open();
                    string sql = "SELECT ComponentImage FROM tbl_ComponentsQuery WHERE ComponentID = @ComponentID";

                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@ComponentID", componentID);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageBytes = (byte[])reader[0];

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    ComponentPicture.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                ComponentPicture.Image = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying image: " + ex.Message);
            }
        }

        private void CInsertImageToDatabase(string imageFilePath, int componentID)
        {
            byte[] imageData;
            using (FileStream fs = new FileStream(imageFilePath, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
            }
            using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
            {
                connection.Open();
                string sql = "UPDATE tbl_ComponentsQuery SET ComponentImage = ? WHERE ComponentID = @ComponentID";

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("?", imageData);
                    command.Parameters.AddWithValue("@ComponentID", componentID);
                    command.ExecuteNonQuery();
                }
            }
        }
        //Component uploadImage
        private void btnCUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imageFilePath = openFileDialog.FileName;
                int selectedComponentID = Convert.ToInt32(dgvComponentInfo.SelectedRows[0].Cells["ComponentID"].Value);
                CInsertImageToDatabase(imageFilePath, selectedComponentID);
            }
            LoadFile();
        }
        private void btnCaddItems_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbxComponentCategory.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentName.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentModel.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentBrand.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentPrice.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentStocks.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert the price from currency-formatted string to decimal
            if (!decimal.TryParse(tbxComponentPrice.Text, System.Globalization.NumberStyles.Currency, null, out decimal price))
            {
                MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO tbl_ComponentsQuery (Category, ComponentName, Model, Brand, Color, Price, Stocks) VALUES (@Ccategory, @Cname, @Cmodel, @Cbrand, @Ccolor, @Cprice, @Cstocks)";

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Ccategory", tbxComponentCategory.Text);
                cmd.Parameters.AddWithValue("@Cname", tbxComponentName.Text);
                cmd.Parameters.AddWithValue("@Cmodel", tbxComponentModel.Text);
                cmd.Parameters.AddWithValue("@Cbrand", tbxComponentBrand.Text);
                cmd.Parameters.AddWithValue("@Ccolor", tbxComponentColor.Text);
                cmd.Parameters.AddWithValue("@Cprice", price);
                cmd.Parameters.AddWithValue("@stoocks", tbxComponentStocks.Text);

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
            }

            // Clear textbox values after insertion
            tbxComponentID.Text = "";
            tbxComponentCategory.Text = "";
            tbxComponentName.Text = "";
            tbxComponentModel.Text = "";
            tbxComponentBrand.Text = "";
            tbxComponentColor.Text = "";
            tbxComponentPrice.Text = "";
            tbxComponentStocks.Text = "";

            LoadFile();
        }

        private void btnCremoveItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvComponentInfo.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvComponentInfo.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvComponentInfo.Rows[selectedRowIndex];
                    string componentID = Convert.ToString(selectedRow.Cells["ComponentID"].Value);

                    string query = "DELETE FROM tbl_ComponentsQuery WHERE [ComponentID] = @ComponentID";
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ComponentID", componentID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LoadFile();
        }

        private void btnCupdateItems_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxComponentCategory.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentName.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentModel.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentBrand.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentColor.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentPrice.Text) ||
                string.IsNullOrWhiteSpace(tbxComponentStocks.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "UPDATE tbl_ComponentsQuery SET Category = @Ccategory, ComponentName = @Cname, Model = @Cmodel, Brand = @Cbrand, Color = @Ccolor, Price = @Cprice, Stocks = @Cstocks WHERE ComponentID = @ComponentID";

                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    if (!decimal.TryParse(tbxComponentPrice.Text, System.Globalization.NumberStyles.Currency, null, out decimal price))
                    {
                        MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    command.Parameters.AddWithValue("@Ccategory", tbxComponentCategory.Text);
                    command.Parameters.AddWithValue("@Cname", tbxComponentName.Text);
                    command.Parameters.AddWithValue("@Cmodel", tbxComponentModel.Text);
                    command.Parameters.AddWithValue("@Cbrand", tbxComponentBrand.Text);
                    command.Parameters.AddWithValue("@Ccolor", tbxComponentColor.Text);
                    command.Parameters.AddWithValue("@Cprice", price);
                    command.Parameters.AddWithValue("@Cstocks", tbxComponentStocks.Text);
                    command.Parameters.AddWithValue("@ComponentID", tbxComponentID.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Update successful.");
                    }
                    else
                    {
                        MessageBox.Show("No rows updated. The component ID may not exist in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LoadFile();
            // Clear textbox values after insertion
            tbxComponentID.Text = "";
            tbxComponentCategory.Text = "";
            tbxComponentName.Text = "";
            tbxComponentModel.Text = "";
            tbxComponentBrand.Text = "";
            tbxComponentColor.Text = "";
            tbxComponentPrice.Text = "";
            tbxComponentStocks.Text = "";
        }
        private void btnCsearch_Click(object sender, EventArgs e)
        {
            // Get the search keyword entered by the user
            string searchKeyword = tbxCsearch.Text.Trim();

            // If the search keyword is empty, reload the original data
            if (string.IsNullOrEmpty(searchKeyword))
            {
                ds = LoadFile();
                return;
            }

            // Filter the data based on the search keyword
            if (ds == null)
            {
                ds = LoadFile();
            }

            DataView dv = ds.Tables["tbl_ComponentsQuery"].DefaultView;
            dv.RowFilter = $"ComponentName LIKE '%{searchKeyword}%'";

            // Update the DataGridView with the filtered data
            dgvComponentInfo.DataSource = dv.ToTable();
        }

        private void tbxCsearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search keyword entered by the user
            string searchKeyword = tbxCsearch.Text.Trim();

            // If the search keyword is empty, reload the original data
            if (string.IsNullOrEmpty(searchKeyword))
            {
                ds = LoadFile();
                return;
            }

            // Filter the data based on the search keyword
            if (ds == null)
            {
                ds = LoadFile();
            }

            DataView dv = ds.Tables["tbl_ComponentsQuery"].DefaultView;
            dv.RowFilter = $"ComponentName LIKE '%{searchKeyword}%'";

            // Update the DataGridView with the filtered data
            dgvComponentInfo.DataSource = dv.ToTable();
        }
        private void btnCclear_Click(object sender, EventArgs e)
        {
            tbxCsearch.Text = "";
            tbxComponentID.Text = "";
            tbxComponentCategory.Text = "";
            tbxComponentName.Text = "";
            tbxComponentModel.Text = "";
            tbxComponentBrand.Text = "";
            tbxComponentColor.Text = "";
            tbxComponentPrice.Text = "";
            tbxComponentStocks.Text = "";
            ComponentPicture.Image = null;
        }

        private void btnAadd_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbxAccessoriesCategory.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesName.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesModel.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesBrand.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesPrice.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesColor.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesStocks.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convert the price from currency-formatted string to decimal
            if (!decimal.TryParse(tbxAccessoriesPrice.Text, System.Globalization.NumberStyles.Currency, null, out decimal price))
            {
                MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO tbl_AccessoriesQuery (Category, AccessoriesName, Model, Brand, Price, Color, Stocks) VALUES (@Acategory, @Aname, @Amodel, @Abrand, @Aprice, @Acolor, @Astocks)";

            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Acategory", tbxAccessoriesCategory.Text);
                cmd.Parameters.AddWithValue("@Aname", tbxAccessoriesName.Text);
                cmd.Parameters.AddWithValue("@Amodel", tbxAccessoriesModel.Text);
                cmd.Parameters.AddWithValue("@Abrand", tbxAccessoriesBrand.Text);
                cmd.Parameters.AddWithValue("@Aprice", price); // Insert the decimal price
                cmd.Parameters.AddWithValue("@Acolor", tbxAccessoriesColor.Text);
                cmd.Parameters.AddWithValue("@Astocks", tbxAccessoriesStocks.Text);

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
            }

            // Clear textbox values after insertion
            tbxAccessoriesID.Text = "";
            tbxAccessoriesCategory.Text = "";
            tbxAccessoriesName.Text = "";
            tbxAccessoriesModel.Text = "";
            tbxAccessoriesBrand.Text = "";
            tbxAccessoriesPrice.Text = "";
            tbxAccessoriesColor.Text = "";
            tbxAccessoriesStocks.Text = "";
            LoadFile();
        }

        private void btnAremove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccessoriesInfo.SelectedCells.Count > 0)
                {
                    int selectedRowIndex = dgvAccessoriesInfo.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgvAccessoriesInfo.Rows[selectedRowIndex];
                    string componentID = Convert.ToString(selectedRow.Cells["AccessoriesID"].Value);

                    string query = "DELETE FROM tbl_AccessoriesQuery WHERE [AccessoriesID] = @AccessoriesID";
                    using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
                    using (OleDbCommand cmd = new OleDbCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@AccessoriesID", componentID);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LoadFile();
        }

        private void btnAupdate_Click(object sender, EventArgs e)
        {
            // Check if all required fields are filled
            if (string.IsNullOrWhiteSpace(tbxAccessoriesID.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesCategory.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesName.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesModel.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesBrand.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesPrice.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesColor.Text) ||
                string.IsNullOrWhiteSpace(tbxAccessoriesStocks.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string query = "UPDATE tbl_AccessoriesQuery SET Category = @Acategory, AccessoriesName = @Aname, Model = @Amodel, Brand = @Abrand, Price = @Aprice, Color = @Acolor, Stocks = @Astocks WHERE AccessoriesID = @OldBId";

                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
                {
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        // Convert the price from currency-formatted string to decimal
                        if (!decimal.TryParse(tbxAccessoriesPrice.Text, System.Globalization.NumberStyles.Currency, null, out decimal price))
                        {
                            MessageBox.Show("Invalid price format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        command.Parameters.AddWithValue("@Acategory", tbxAccessoriesCategory.Text);
                        command.Parameters.AddWithValue("@Aname", tbxAccessoriesName.Text);
                        command.Parameters.AddWithValue("@Amodel", tbxAccessoriesModel.Text);
                        command.Parameters.AddWithValue("@Abrand", tbxAccessoriesBrand.Text);
                        command.Parameters.AddWithValue("@Aprice", price); // Insert the decimal price
                        command.Parameters.AddWithValue("@Acolor", tbxAccessoriesColor.Text);
                        command.Parameters.AddWithValue("@Astocks", tbxAccessoriesStocks.Text);
                        command.Parameters.AddWithValue("@OldBId", dgvAccessoriesInfo.CurrentRow.Cells["AccessoriesID"].Value.ToString());

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Update successful.");
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. The accessory ID may not exist in the database.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            LoadFile(); // Load data after update
            // Clear textbox values after insertion
            tbxAccessoriesID.Text = "";
            tbxAccessoriesCategory.Text = "";
            tbxAccessoriesName.Text = "";
            tbxAccessoriesModel.Text = "";
            tbxAccessoriesBrand.Text = "";
            tbxAccessoriesPrice.Text = "";
            tbxAccessoriesColor.Text = "";
            tbxAccessoriesStocks.Text = "";
        }
        //Accessories Datagridview
        private void dgvAccessoriesInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAccessoriesInfo.Rows[e.RowIndex];
                tbxAccessoriesID.Text = row.Cells["AccessoriesID"].Value.ToString();
                tbxAccessoriesCategory.Text = row.Cells["Category"].Value.ToString();
                tbxAccessoriesName.Text = row.Cells["AccessoriesName"].Value.ToString();
                tbxAccessoriesModel.Text = row.Cells["Model"].Value.ToString();
                tbxAccessoriesBrand.Text = row.Cells["Brand"].Value.ToString();

                // Convert the currency value to a string for display
                if (decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price))
                {
                    tbxAccessoriesPrice.Text = price.ToString("C");
                }
                else
                {
                    // Handle conversion failure, perhaps set an appropriate default value or show an error message
                    tbxAccessoriesPrice.Text = "Invalid Price";
                }
                tbxAccessoriesColor.Text = row.Cells["Color"].Value.ToString();
                tbxAccessoriesStocks.Text = row.Cells["Stocks"].Value.ToString();

                AccessoriesDisplayImageFromDatabase(Convert.ToInt32(row.Cells["AccessoriesID"].Value));
            }
        }
        private void AccessoriesDisplayImageFromDatabase(int accessoriesID)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
                {
                    connection.Open();
                    string sql = "SELECT AccessoriesImage FROM tbl_AccessoriesQuery WHERE AccessoriesID = @AccessoriesID";

                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@AccessoriesID", accessoriesID);

                        using (OleDbDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageBytes = (byte[])reader[0];

                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    AccessoriesPicture.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                AccessoriesPicture.Image = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying image: " + ex.Message);
            }
        }

        private void AInsertImageToDatabase(string imageFilePath, int accessoriesID)
        {
            byte[] imageData;
            using (FileStream fs = new FileStream(imageFilePath, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, (int)fs.Length);
            }
            using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb"))
            {
                connection.Open();
                string sql = "UPDATE tbl_AccessoriesQuery SET AccessoriesImage = ? WHERE AccessoriesID = @AccessoriesID";

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("?", imageData);
                    command.Parameters.AddWithValue("@AccessoriesID", accessoriesID);
                    command.ExecuteNonQuery();
                }
            }
        }
        //Accessories uploadImage
        private void btnAUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imageFilePath = openFileDialog.FileName;
                int selectedAccessoriesID = Convert.ToInt32(dgvAccessoriesInfo.SelectedRows[0].Cells["AccessoriesID"].Value);
                AInsertImageToDatabase(imageFilePath, selectedAccessoriesID);
            }
            LoadFile();
        }
        private void btnAsearch_Click(object sender, EventArgs e)
        {
            // Get the search keyword entered by the user
            string searchKeyword = tbxAsearch.Text.Trim();

            // If the search keyword is empty, reload the original data
            if (string.IsNullOrEmpty(searchKeyword))
            {
                ds = LoadFile();
                return;
            }

            // Filter the data based on the search keyword
            if (ds == null)
            {
                ds = LoadFile();
            }

            DataView dv = ds.Tables["tbl_AccessoriesQuery"].DefaultView;
            dv.RowFilter = $"AccessoriesName LIKE '%{searchKeyword}%'";

            // Update the DataGridView with the filtered data
            dgvAccessoriesInfo.DataSource = dv.ToTable();
        }

        private void tbxAsearch_TextChanged(object sender, EventArgs e)
        {
            // Get the search keyword entered by the user
            string searchKeyword = tbxAsearch.Text.Trim();

            // If the search keyword is empty, reload the original data
            if (string.IsNullOrEmpty(searchKeyword))
            {
                ds = LoadFile();
                return;
            }

            // Filter the data based on the search keyword
            if (ds == null)
            {
                ds = LoadFile();
            }

            DataView dv = ds.Tables["tbl_AccessoriesQuery"].DefaultView;
            dv.RowFilter = $"AccessoriesName LIKE '%{searchKeyword}%'";

            // Update the DataGridView with the filtered data
            dgvAccessoriesInfo.DataSource = dv.ToTable();
        }
        private void btnAclear_Click(object sender, EventArgs e)
        {
            tbxAsearch.Text = "";
            tbxAccessoriesID.Text = "";
            tbxAccessoriesCategory.Text = "";
            tbxAccessoriesName.Text = "";
            tbxAccessoriesModel.Text = "";
            tbxAccessoriesBrand.Text = "";
            tbxAccessoriesPrice.Text = "";
            tbxAccessoriesColor.Text = "";
            tbxAccessoriesStocks.Text = "";
            AccessoriesPicture.Image = null;
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