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
using Velocity_Bike_Shop_Managemennt_System.Properties;
using Velocity_Bike_Shop_Managemennt_System.Rating;

namespace Velocity_Bike_Shop_Managemennt_System.User_Guest.U_Dashboard.Products
{
    public partial class UserControlAccessories : UserControl
    {
        private DataGridView dgvUBills;

        public UserControlAccessories()
        {
            InitializeComponent();
            DisplayStock();

            // List of product names
            List<string> productNames = new List<string>
            {
                "Smith Network MIPS Helmet",
             };
            // Iterate over each product name and retrieve the user's rating
            foreach (string productName in productNames)
            {
                int userRating = GetUserRating(productName);

                // Assuming you have a UserControlRating for each product, set the rating accordingly
                switch (productName)
                {
                    case "Smith Network MIPS Helmet":
                        userControlRatingbtnSmith_Network_MIPS.SetRating(userRating);
                        UpdateUserRating(productName, userRating);
                        break;
                    case "Giro Radix MIPS Helmet":
                        userControlRatingGiro_Radix_MIPS.SetRating(userRating);
                        UpdateUserRating(productName, userRating);
                        break;
                        // Add more cases for additional products if needed
                }
            }
        }

        public DataGridView DgvUBills
        {
            set { dgvUBills = value; }
        }

        public void DisplayStock()
        {
            DisplayStockSmith_Network_MIPS_Helmet();
            DisplayStockGiro_Radix_Mips();
            DisplayStockLeatt_Enduro_3_V23();
            DisplayStockSmith_Wildcat_cycling_Sunglasses();
            DisplayStockTifosi_Tsali_Sunglasses();
            DisplayStockLeatt_Goggle_Velocity_45();
            DisplayStockSpecialized_Body_Geometry_Dual();
            DisplayStockFox_Dirtpaw();
            DisplayStockLeatt_Glove_MTB_2_XFlow();
            DisplayStockLeatt_3Df_6();
            DisplayStockEndura_MT500_D30();
            DisplayStockGForm_Pro_Rugged();
            DisplayStockLeatt_Knee_Guard_ReaFlex_Pro();
            DisplayStockUSWE_Hydro_8();
            DisplayStockSpecialized_Bm_2nd_Gen();
            DisplayStockNiterider_Lumina_Dual_1800();
            DisplayStockNiterider_VMAX_150();
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

        private int GetUserRating(string productName)
        {
            int rating = 0;
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";
            string selectQuery = "SELECT Rating FROM tbl_Accessories WHERE ProductName = @ProductName";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", productName);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out rating))
                        {
                            // Rating retrieved successfully
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            return rating;
        }

        private void UpdateUserRating(string productName, int newRating)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";
            string updateQuery = "UPDATE tbl_Accessories SET Rating = @Rating WHERE ProductName = @ProductName";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                using (OleDbCommand command = new OleDbCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Rating", newRating);
                    command.Parameters.AddWithValue("@ProductName", productName);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void btnSmith_Network_MIPS_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Smith Network MIPS Helmet";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockSmith_Network_MIPS_Helmet()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Smith Network MIPS Helmet";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxSmith_Network_MIPS.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantitySmithNetworkMips("Smith Network MIPS Helmet"); // Display SoldQuantity in label
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
        private void DisplaySoldQuantitySmithNetworkMips(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_SmithNetworkMips.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnGiro_Radix_MIPS_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giro Radix MIPS Helmet";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockGiro_Radix_Mips()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giro Radix MIPS Helmet";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxGiro_Radix_Mips.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityGiro_Radix_Mips("Giro Radix MIPS Helmet");
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
        private void DisplaySoldQuantityGiro_Radix_Mips(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Giro_Radix_MIPS.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnLeatt_Enduro_3_V23_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Leatt Enduro 3.0 V23 Helmet";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockLeatt_Enduro_3_V23()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Leatt Enduro 3.0 V23 Helmet";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxLeatt_Enduro_3_V23.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityLeatt_Enduro_3_V23("Leatt Enduro 3.0 V23 Helmet");
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
        private void DisplaySoldQuantityLeatt_Enduro_3_V23(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Leatt_Enduro_3_V23.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnSmith_Wildcat_cycling_Sunglasses_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Smith Wildcat Cycling Sunglasses";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockSmith_Wildcat_cycling_Sunglasses()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Smith Wildcat Cycling Sunglasses";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxSmith_Wildcat_cycling_Sunglasses.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantitySmith_Wildcat_cycling_Sunglasses("Smith Wildcat Cycling Sunglasses");
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
        private void DisplaySoldQuantitySmith_Wildcat_cycling_Sunglasses(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Smith_Wildcat_cycling_Sunglasses.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnTifosi_Tsali_Sunglasses_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Tifosi Tsali Interchangeable Sunglasses";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockTifosi_Tsali_Sunglasses()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Tifosi Tsali Interchangeable Sunglasses";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxTifosi_Tsali_Sunglasses.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityTifosi_Tsali_Sunglasses("Tifosi Tsali Interchangeable Sunglasses");
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
        private void DisplaySoldQuantityTifosi_Tsali_Sunglasses(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Tifosi_Tsali_Sunglasses.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnLeatt_Goggle_Velocity_45_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Leatt Goggle Velocity 4.5";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockLeatt_Goggle_Velocity_45()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Leatt Goggle Velocity 4.5";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxLeatt_Goggle_Velocity_45.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityLeatt_Goggle_Velocity_45("Leatt Goggle Velocity 4.5");
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
        private void DisplaySoldQuantityLeatt_Goggle_Velocity_45(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Leatt_Goggle_Velocity_45.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnSpecialized_Body_Geometry_Dual_Gel_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Specialized Body Geometry Dual-Gel LF Gloves";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockSpecialized_Body_Geometry_Dual()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Specialized Body Geometry Dual-Gel LF Gloves";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxSpecialized_Body_Geometry_Dual.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantitySpecialized_Body_Geometry_Dual("Specialized Body Geometry Dual-Gel LF Gloves");
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
        private void DisplaySoldQuantitySpecialized_Body_Geometry_Dual(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Specialized_Body_Geometry_Dual_Gel.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnFox_Dirtpaw_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Fox Dirtpaw Gloves";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockFox_Dirtpaw()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Fox Dirtpaw Gloves";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxFox_Dirtpaw.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityFox_Dirtpaw("Fox Dirtpaw Gloves");
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
        private void DisplaySoldQuantityFox_Dirtpaw(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Fox_Dirtpaw.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnLeatt_Glove_MTB_2_XFlow_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Leatt Glove MTB 2.0 X-Flow";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockLeatt_Glove_MTB_2_XFlow()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Leatt Glove MTB 2.0 X-Flow";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxLeatt_Glove_MTB_2_XFlow.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityLeatt_Glove_MTB_2_XFlow("Leatt Glove MTB 2.0 X-Flow");
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
        private void DisplaySoldQuantityLeatt_Glove_MTB_2_XFlow(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Leatt_Glove_MTB_2_XFlow.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnLeatt_3Df_6_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Leatt 3Df 6.0 Elbow Guards";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockLeatt_3Df_6()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Leatt 3Df 6.0 Elbow Guards";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxLeatt_3Df_6.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityLeatt_3Df_6("Leatt 3Df 6.0 Elbow Guards");
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
        private void DisplaySoldQuantityLeatt_3Df_6(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Leatt_3Df_6.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnEndura_MT500_D30_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Endura MT500 D3O Ghost Elbow Pad";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockEndura_MT500_D30()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Endura MT500 D3O Ghost Elbow Pad";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxEndura_MT500_D30.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityEndura_MT500_D30("Endura MT500 D3O Ghost Elbow Pad");
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
        private void DisplaySoldQuantityEndura_MT500_D30(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Endura_MT500_D30.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnGForm_Pro_Rugged_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "G-Form Pro Rugged Knee Guards";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockGForm_Pro_Rugged()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "G-Form Pro Rugged Knee Guards";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxGForm_Pro_Rugged.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityGForm_Pro_Rugged("G-Form Pro Rugged Knee Guards");
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
        private void DisplaySoldQuantityGForm_Pro_Rugged(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_GForm_Pro_Rugged.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnLeatt_Knee_Guard_ReaFlex_Pro_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Leatt Knee Guard ReaFlex Pro";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockLeatt_Knee_Guard_ReaFlex_Pro()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Leatt Knee Guard ReaFlex Pro";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxLeatt_Knee_Guard_ReaFlex_Pro.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityLeatt_Knee_Guard_ReaFlex_Pro("Leatt Knee Guard ReaFlex Pro");
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
        private void DisplaySoldQuantityLeatt_Knee_Guard_ReaFlex_Pro(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Leatt_Knee_Guard_ReaFlex_Pro.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnUSWE_Hydro_8_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "USWE Hydro 8 Hydration Pack";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockUSWE_Hydro_8()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "USWE Hydro 8 Hydration Pack";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxUSWE_Hydro_8.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityUSWE_Hydro_8("USWE Hydro 8 Hydration Pack");
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
        private void DisplaySoldQuantityUSWE_Hydro_8(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_USWE_Hydro_8.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnSpecialized_Bm_2nd_Gen_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Specialized Bm 2nd Gen Bottle Wordmark";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockSpecialized_Bm_2nd_Gen()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Specialized Bm 2nd Gen Bottle Wordmark";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxSpecialized_Bm_2nd_Gen.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantitySpecialized_Bm_2nd_Gen("Specialized Bm 2nd Gen Bottle Wordmark");
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
        private void DisplaySoldQuantitySpecialized_Bm_2nd_Gen(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Specialized_Bm_2nd_Gen.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnNiterider_Lumina_Dual_1800_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Niterider Lumina Dual 1800 Light";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockNiterider_Lumina_Dual_1800()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Niterider Lumina Dual 1800 Light";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxNiterider_Lumina_Dual_1800.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityNiterider_Lumina_Dual_1800("Niterider Lumina Dual 1800 Light");
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
        private void DisplaySoldQuantityNiterider_Lumina_Dual_1800(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Niterider_Lumina_Dual_1800.Text = $"Sold : {totalSoldQuantity}";
        }

        private void btnNiterider_VMAX_150_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "NiteRider VMAX+ 150 Taillight";
            int initialQuantity = 1;

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["AccessoriesName"].ToString(); // Fix typo here
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvUBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
        private void DisplayStockNiterider_VMAX_150()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "NiteRider VMAX+ 150 Taillight";

            string querySelect = "SELECT AccessoriesName, Price, Stocks FROM tbl_Accessories WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxNiterider_VMAX_150.Text = $"Stock : {stocks}"; // Display stock in textbox
                            DisplaySoldQuantityNiterider_VMAX_150("NiteRider VMAX+ 150 Taillight");
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
        private void DisplaySoldQuantityNiterider_VMAX_150(string productName)
        {
            int totalSoldQuantity = GetTotalSoldQuantity(productName);
            lblSoldQuantity_Niterider_VMAX_150.Text = $"Sold : {totalSoldQuantity}";
        }

        private void pbxGForm_Pro_Rugged_Click(object sender, EventArgs e)
        {

        }

        
    }
}
