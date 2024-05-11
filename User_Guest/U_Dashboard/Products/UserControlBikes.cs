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

namespace Velocity_Bike_Shop_Managemennt_System.User_Guest.U_Dashboard.Products
{
    public partial class UserControlBikes : UserControl
    {
        private DataGridView dgvUBills;

        public UserControlBikes()
        {
            InitializeComponent();
            DisplayStock();
        }

        public DataGridView DgvUBills
        {
            set { dgvUBills = value; }
        }

        private void DisplayStock()
        {
            DisplayStockXTC_SLR_29_2_2022();
            DisplayStockTranceX_29_2_2022();
            DisplayStockTranceX_29_1_2022();
            DisplayStockTalon_29_2_2022();
            DisplayStockTalon_29_1_2024();
            DisplayStockStance_29_2_2022();
            DisplayStockStance_29_1_2022();
            DisplayStockRevolt_2_2022();
            DisplayStockRevolt_1_2024();
            DisplayStockPropelAdvanced_1_2024();
            DisplayStockFathom_29_2_2021();
            DisplayStockDefy_Advanced_2_2024();
            DisplayStockDefy_Advanced_2_2022();
            DisplayStockContend_AR_1_2022();
            DisplayStock795_Blade_Ultegra_Di2_WS_EVO47();
        }
        private int GetTotalSoldQuantity(string productName)
        {
            int totalSoldQuantity = 0;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";
            string querySelect = "SELECT SUM(Quantity) AS TotalSold FROM tbl_OrderSalesRecord WHERE ProductName = @ProductName";

            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand commandSelect = new OleDbCommand(querySelect, connection))
                    {
                        commandSelect.Parameters.AddWithValue("@ProductName", productName);
                        connection.Open();
                        var result = commandSelect.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            totalSoldQuantity = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching sold quantity: " + ex.Message);
            }

            return totalSoldQuantity;
        }

        private void btnXTC_29_2_2022_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant XTC SLR 29 2 2022";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockXTC_SLR_29_2_2022()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant XTC SLR 29 2 2022";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxXTC_SLR_29_2_2022.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityXTC_SLR_29_2_2022("Giant XTC SLR 29 2 2022");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityXTC_SLR_29_2_2022(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_XTC_29_2_2022.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnTrance_X_29_2_2022_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Trance X 29 2 2022";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockTranceX_29_2_2022()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Trance X 29 2 2022";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxTranceX_29_2_2022.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityTranceX_29_2_2022("Giant Trance X 29 2 2022");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityTranceX_29_2_2022(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Trance_X_29_2_2022.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnTrance_X_29_1_2022_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Trance X 29 1 2022";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockTranceX_29_1_2022()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Trance X 29 1 2022";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxranceX_29_1_2022.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityTranceX_29_1_2022("Giant Trance X 29 1 2022");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityTranceX_29_1_2022(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Trance_X_29_1_2022.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnTalon_29_2_2022_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Talon 29 2 2022";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockTalon_29_2_2022()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Talon 29 2 2022";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxTalon_29_2_2022.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityTalon_29_2_2022("Giant Talon 29 2 2022");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityTalon_29_2_2022(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Talon_29_2_2022.Text = $"Sold : {totalSoldQuantity}";
        }


        private void btnTalon_29_1_2024_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Talon 29 1 2024";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockTalon_29_1_2024()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Talon 29 1 2024";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxTalon_29_1_2024.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityTalon_29_1_2024("Giant Talon 29 1 2024");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityTalon_29_1_2024(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_alon_29_1_2024.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnStance_29_2_2022_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Stance 29 2 2022";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockStance_29_2_2022()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Stance 29 2 2022";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxStance_29_2_2022.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityStance_29_2_2022("Giant Stance 29 2 2022");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityStance_29_2_2022(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Stance_29_2_2022.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnStance_29_1_2022_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Stance 29 1 2022";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockStance_29_1_2022()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Stance 29 1 2022";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxStance_29_1_2022.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityStance_29_1_2022("Giant Stance 29 1 2022");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityStance_29_1_2022(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Stance_29_1_2022.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnRevolt_2_2022_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Revolt 2 2022";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockRevolt_2_2022()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Revolt 2 2022";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxRevolt_2_2022.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityRevolt_2_2022("Giant Revolt 2 2022");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityRevolt_2_2022(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Revolt_2_2022.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnRevolt_1_2024_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Revolt 1 2024";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockRevolt_1_2024()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Revolt 1 2024";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxRevolt_1_2024.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityRevolt_1_2024("Giant Revolt 1 2024");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityRevolt_1_2024(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Revolt_1_2024.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnPropel_Advanced_1_2024_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Propel Advanced 1 2024";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockPropelAdvanced_1_2024()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Propel Advanced 1 2024";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxPropelAdvanced_1_2024.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityPropelAdvanced_1_2024("Giant Propel Advanced 1 2024");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityPropelAdvanced_1_2024(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Propel_Advanced_1_2024.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnFathom_29_2_2022_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant FATHOM 29 2 2021";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockFathom_29_2_2021()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant FATHOM 29 2 2021";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxFathom_29_2_2021.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityFathom_29_2_2021("Giant FATHOM 29 2 2021");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityFathom_29_2_2021(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Fathom_29_2_2022.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnDefy_Advanced_2_2024_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Defy Advanced 2 2024";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockDefy_Advanced_2_2024()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Defy Advanced 2 2024";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxDefy_Advanced_2_2024.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityDefy_Advanced_2_2024("Giant Defy Advanced 2 2024");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityDefy_Advanced_2_2024(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Defy_Advanced_2_2024.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnDefy_Advanced_2_2022_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Defy Advanced 2 2022";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockDefy_Advanced_2_2022()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Defy Advanced 2 2022";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxDefy_Advanced_2_2022.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityDefy_Advanced_2_2022("Giant Defy Advanced 2 2022");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityDefy_Advanced_2_2022(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Defy_Advanced_2_2022.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnContend_AR_1_2022_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Contend AR 1 2022";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStockContend_AR_1_2022()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant Contend AR 1 2022";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxContend_AR_1_2022.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityContend_AR_1_2022("Giant Contend AR 1 2022");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantityContend_AR_1_2022(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_Contend_AR_1_2022.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btn795_Blade_Ultegra_Di2_WS_EVO47_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Look 795 Blade Ultegra Di2  WS EVO 47";
            int initialQuantity = 1;

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string bikeName = reader["Name"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(bikeName, cost * quantity, quantity);
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplayStock795_Blade_Ultegra_Di2_WS_EVO47()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Look 795 Blade Ultegra Di2  WS EVO 47";

            string querySelect = "SELECT Name, Price, Stocks FROM tbl_Bikes WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbx795_Blade_Ultegra_Di2_WS_EVO47.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantity795_Blade_Ultegra_Di2_WS_EVO47("Look 795 Blade Ultegra Di2  WS EVO 47");
                        }
                        else
                        {
                            MessageBox.Show("Out of Stocks!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Product not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void DisplaySoldQuantity795_Blade_Ultegra_Di2_WS_EVO47(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQTY_795_Blade_Ultegra_Di2_WS_EVO47.Text = $"Sold : {totalSoldQuantity}";
        }
    }
}
