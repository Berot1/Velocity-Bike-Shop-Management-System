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
    public partial class UserControlAComponents : UserControl
    {
        private DataGridView dgvBills;
        public UserControlAComponents()
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
        private void DisplayStock()
        {
            DisplayStockSanta_Cruz_Stigmata_4_CC();
            DisplayStockNiner_RLT_9_RDO();
            DisplayStockNiner_RLT_9();
            DisplayStockGiant_TCR_Advanced_SL_Disc_LTD();
            DisplayStockCervelo_Aspero_5();
            DisplayStockMarzocchi_Bomber_Z1_29();
            DisplayStockRockshox_Lyrik_Ultmate_Charger_3_RC2();
            DisplayStockWolf_Tooth_Waveform();
            DisplayStockShimano_Ultegra_PD_R8000_SPD_SL();
            DisplayStockWTB_Volt_Stee();
            DisplayStockChromag_Trailmaster_DT();
            DisplayStockRoval_Rapide();
            DisplayStockRenthal_Fatbar_Carbon_Riser_35_mm();
            DisplayStockErgon_GE1_Evo();
            DisplayStockLizard_Skins_DSP_Bar_Tape_32_mm();
            DisplayStock795_Blade();
        }

        private void btnSanta_Cruz_Stigmata_4_CC_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Santa Cruz Stigmata 4 CC Frameset";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockSanta_Cruz_Stigmata_4_CC()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Santa Cruz Stigmata 4 CC Frameset";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxSanta_Cruz_Stigmata_4_CC.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnNiner_RLT_9_RDO_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Niner RLT 9 RDO Frameset";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockNiner_RLT_9_RDO()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Niner RLT 9 RDO Frameset";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxNiner_RLT_9_RDO.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnNiner_RLT_9_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Niner RLT 9 Frameset";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockNiner_RLT_9()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Niner RLT 9 Frameset";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxNiner_RLT_9.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnGiant_TCR_Advanced_SL_Disc_LTD_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant TCR Advanced SL Disc LTD Frameset 2022";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockGiant_TCR_Advanced_SL_Disc_LTD()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Giant TCR Advanced SL Disc LTD Frameset 2022";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxGiant_TCR_Advanced_SL_Disc_LTD.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnCervelo_Aspero_5_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Cervelo Aspero-5 Frameset";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockCervelo_Aspero_5()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Cervelo Aspero-5 Frameset";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxCervelo_Aspero_5.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnMarzocchi_Bomber_Z1_29_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Marzocchi Bomber Z1 29 Fork";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockMarzocchi_Bomber_Z1_29()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Marzocchi Bomber Z1 29 Fork";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxMarzocchi_Bomber_Z1_29.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnRockshox_Lyrik_Ultmate_Charger_3_RC2_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "ROCKSHOX Lyrik Ultimate Charger 3 RC2 27.5 Fork";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockRockshox_Lyrik_Ultmate_Charger_3_RC2()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "ROCKSHOX Lyrik Ultimate Charger 3 RC2 27.5 Fork";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxRockshox_Lyrik_Ultmate_Charger_3_RC2.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnWolf_Tooth_Waveform_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Wolf Tooth Waveform Pedals";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockWolf_Tooth_Waveform()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Wolf Tooth Waveform Pedals";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxWolf_Tooth_Waveform.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnShimano_Ultegra_PD_R8000_SPD_SL_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Shimano Ultegra PD-R8000 SPD-SL Pedals";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockShimano_Ultegra_PD_R8000_SPD_SL()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Shimano Ultegra PD-R8000 SPD-SL Pedals";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxShimano_Ultegra_PD_R8000_SPD_SL.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnWTB_Volt_Stee_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "WTB Volt Steel Saddle";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockWTB_Volt_Stee()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "WTB Volt Steel Saddle";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxWTB_Volt_Stee.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnChromag_Trailmaster_DT_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Chromag Trailmaster DT Saddle";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockChromag_Trailmaster_DT()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Chromag Trailmaster DT Saddle";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxChromag_Trailmaster_DT.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnRoval_Rapide_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Roval Rapide Handlebar";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockRoval_Rapide()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Roval Rapide Handlebar";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxRoval_Rapide.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnRenthal_Fatbar_Carbon_Riser_35_mm_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Renthal Fatbar Carbon Riser 35.0mm Bar";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockRenthal_Fatbar_Carbon_Riser_35_mm()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Renthal Fatbar Carbon Riser 35.0mm Bar";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxRenthal_Fatbar_Carbon_Riser_35_mm.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnErgon_GE1_Evo_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Ergon GE1 Evo Grips";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockErgon_GE1_Evo()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Ergon GE1 Evo Grips";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxErgon_GE1_Evo.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btnLizard_Skins_DSP_Bar_Tape_32_mm_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Lizard Skins DSP Bar Tape 3.2 mm";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStockLizard_Skins_DSP_Bar_Tape_32_mm()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Lizard Skins DSP Bar Tape 3.2 mm";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbxLizard_Skins_DSP_Bar_Tape_32_mm.Text = $"Stock : {stocks}"; // Display stock in textbox
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

        private void btn795_Blade_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Look 795 Blade Frameset";
            int initialQuantity = 1;

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        string AccessoriesName = reader["ComponentName"].ToString();
                        double cost = Convert.ToDouble(reader["Price"]);
                        int quantity = initialQuantity;

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
        private void DisplayStock795_Blade()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string productName = "Look 795 Blade Frameset";

            string querySelect = "SELECT ComponentName, Price, Stocks FROM tbl_Components WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandSelect = new OleDbCommand(querySelect, connection);
                commandSelect.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    OleDbDataReader reader = commandSelect.ExecuteReader();

                    if (reader.Read())
                    {
                        int stocks = Convert.ToInt32(reader["Stocks"]);

                        if (stocks > 0)
                        {
                            tbx795_Blade.Text = $"Stock : {stocks}"; // Display stock in textbox
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
