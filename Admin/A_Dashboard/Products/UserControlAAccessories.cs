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
    public partial class UserControlAAccessories : UserControl
    {
        private DataGridView dgvBills;
        public UserControlAAccessories()
        {
            InitializeComponent();
            DisplayStock();
        }

        OleDbConnection? con;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        public DataGridView DgvBills
        {
            set { dgvBills = value; }
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

        private void btnSmith_Network_Mips_Click(object sender, EventArgs e)
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
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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

        private void btnGiro_Radix_Mips_Click(object sender, EventArgs e)
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
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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

        private void btnSpecialized_Body_Geometry_Dual_Click(object sender, EventArgs e)
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
                        string AccessoriesName = reader["AccessoriesName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity; // Set the quantity to initialQuantity

                        int stocks = Convert.ToInt32(reader["Stocks"]);
                        if (stocks > 0)
                        {
                            // Add item to DataGridView
                            dgvBills.Rows.Add(AccessoriesName, cost * quantity, quantity);
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
    }
}
