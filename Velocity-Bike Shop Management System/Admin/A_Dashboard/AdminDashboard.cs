using Microsoft.Office.Interop.Access.Dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velocity_Bike_Shop_Managemennt_System.Admin.A_Dashboard;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Annotations;
using OxyPlot.Axes;
using OxyPlot.WindowsForms;
using System.Globalization;

namespace Velocity_Bike_Shop_Managemennt_System
{
    public partial class AdminDashboard : Form
    {
        bool sidebarExpand;
        public Point mouseLocation;
        public AdminDashboard()
        {
            InitializeComponent();
            sidebarExpand = false;
            sidebar.Width = sidebar.MinimumSize.Width;
            lblClock.Text = DateTime.Now.ToLongTimeString();
            Clock.Start();
        }

        public void loadform(object Form)
        {
            if (this.sidebar.Controls.Count > 0)
                this.sidebar.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Left;
            this.sidebar.Controls.Add(f);
            this.sidebar.Tag = f;
            f.Show();
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

        private void panelUsers_Paint(object sender, PaintEventArgs e)
        {
            // Establish a connection to your MS Access database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gil Bernard\source\repos\Velocity_Bike Shop Managemennt System\Velocity_Bike Shop Managemennt System\bin\Debug\Databases\DataBase_Velocity-Bike Shop Management System\db_Velocity-BikeShop.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // Execute a SQL query to retrieve the number of users
                string query = "SELECT COUNT(*) FROM tbl_Users";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    int userCount = (int)command.ExecuteScalar();

                    // Update the text of the Users panel with the user count
                    tbxNumberUsers.Text = userCount.ToString();
                }

                // Execute additional queries and update other panel text as needed
            }
        }

        private void panelTotalStocks_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gil Bernard\source\repos\Velocity_Bike Shop Managemennt System\Velocity_Bike Shop Managemennt System\bin\Debug\Databases\DataBase_Velocity-Bike Shop Management System\db_Velocity-BikeShop.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query1 = "SELECT SUM(Stocks) FROM tbl_Bikes";
                    string query2 = "SELECT SUM(Stocks) FROM tbl_Components";
                    string query3 = "SELECT SUM(Stocks) FROM tbl_Accessories";

                    double totalBikesStock = 0;
                    double totalComponentsStock = 0;
                    double totalAccessoriesStock = 0;

                    using (OleDbCommand command1 = new OleDbCommand(query1, connection))
                    {
                        object result = command1.ExecuteScalar();
                        if (result != null)
                        {
                            totalBikesStock = Convert.ToDouble(result);
                        }
                    }

                    using (OleDbCommand command2 = new OleDbCommand(query2, connection))
                    {
                        object result = command2.ExecuteScalar();
                        if (result != null)
                        {
                            totalComponentsStock = Convert.ToDouble(result);
                        }
                    }

                    using (OleDbCommand command3 = new OleDbCommand(query3, connection))
                    {
                        object result = command3.ExecuteScalar();
                        if (result != null)
                        {
                            totalAccessoriesStock = Convert.ToDouble(result);
                        }
                    }

                    double totalStocks = totalBikesStock + totalComponentsStock + totalAccessoriesStock;
                    tbxTotalStocks.Text = totalStocks.ToString();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"An error occurred while executing the query: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panelBrands_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gil Bernard\source\repos\Velocity_Bike Shop Managemennt System\Velocity_Bike Shop Managemennt System\bin\Debug\Databases\DataBase_Velocity-Bike Shop Management System\db_Velocity-BikeShop.accdb";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query1 = "SELECT COUNT(*) FROM (SELECT DISTINCT Brand FROM tbl_Bikes)";
                    string query2 = "SELECT COUNT(*) FROM (SELECT DISTINCT Brand FROM tbl_Components)";
                    string query3 = "SELECT COUNT(*) FROM (SELECT DISTINCT Brand FROM tbl_Accessories)";

                    int totalBikesBrands = 0;
                    int totalComponentsBrands = 0;
                    int totalAccessoriesBrands = 0;

                    Console.WriteLine($"Query 1: {query1}");
                    using (OleDbCommand command1 = new OleDbCommand(query1, connection))
                    {
                        totalBikesBrands = (int)command1.ExecuteScalar();
                        Console.WriteLine($"Total bikes brands: {totalBikesBrands}");
                    }

                    Console.WriteLine($"Query 2: {query2}");
                    using (OleDbCommand command2 = new OleDbCommand(query2, connection))
                    {
                        totalComponentsBrands = (int)command2.ExecuteScalar();
                        Console.WriteLine($"Total components brands: {totalComponentsBrands}");
                    }

                    Console.WriteLine($"Query 3: {query3}");
                    using (OleDbCommand command3 = new OleDbCommand(query3, connection))
                    {
                        totalAccessoriesBrands = (int)command3.ExecuteScalar();
                        Console.WriteLine($"Total accessories brands: {totalAccessoriesBrands}");
                    }

                    int totalBrands = totalBikesBrands + totalComponentsBrands + totalAccessoriesBrands;
                    tbxTotalBrands.Text = totalBrands.ToString();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadSalesData();
            AddPieChart();
            AddBarChart();
            GenerateWeeklySalesReport();
        }
        private void LoadSalesData()
        {
            const string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    OleDbCommand cmd = new OleDbCommand("SELECT TOP 15 ProductName, Sum(Quantity) as TotalQuantity FROM tbl_SalesQuery GROUP BY ProductName ORDER BY Sum(Quantity) ASC", conn);
                    OleDbDataReader reader = cmd.ExecuteReader();

                    var plotModel = CreatePlotModel(reader);

                    var plotView = new OxyPlot.WindowsForms.PlotView
                    {
                        Model = plotModel,
                        Dock = DockStyle.Fill
                    };

                    PanelBarGraph.Controls.Add(plotView);
                }
                catch (Exception ex)
                {
                    // Handle exception
                    MessageBox.Show("Error loading sales data: " + ex.Message);
                }
            }
        }

        private PlotModel CreatePlotModel(OleDbDataReader reader)
        {
            var plotModel = new PlotModel { Title = "Count of purchased products" };

            var lineSeries = new LineSeries
            {
                MarkerType = MarkerType.Circle,
                MarkerSize = 4,
                MarkerStroke = OxyColors.White
            };

            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Bottom,
                Angle = -18,  // Rotate labels 45 degrees counter-clockwise
                FontSize = 7  // Set font size to 8
            };

            int index = 0;
            while (reader.Read())
            {
                var productName = reader["ProductName"].ToString();
                var totalQuantity = (double)reader["TotalQuantity"];

                lineSeries.Points.Add(new DataPoint(index, totalQuantity));
                categoryAxis.Labels.Add(productName);
                index++;
            }

            plotModel.Series.Add(lineSeries);
            plotModel.Axes.Add(categoryAxis);

            return plotModel;
        }

        private void AddPieChart()
        {
            try
            {
                // Instantiate a PlotModel
                var pieModel = new PlotModel { Title = "Sales Payment Details" };

                // Create a PieSeries
                var pieSeries = new PieSeries
                {
                    StrokeThickness = 2.0,
                    InsideLabelPosition = 0.8,
                    AngleSpan = 360,
                    StartAngle = 0
                };

                // Connection string to your MS Access database
                string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gil Bernard\source\repos\Velocity_Bike Shop Managemennt System\Velocity_Bike Shop Managemennt System\bin\Debug\Databases\DataBase_Velocity-Bike Shop Management System\db_Velocity-BikeShop.accdb";

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT [PaymentMethod], COUNT([PaymentMethod]) as [Count] FROM [tbl_SalesPaymentDetailsQuery] GROUP BY [PaymentMethod]", conn);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string paymentMethod = Convert.ToString(reader["PaymentMethod"]);
                            double count = Convert.ToDouble(reader["Count"]);
                            pieSeries.Slices.Add(new PieSlice(paymentMethod, count));
                        }
                    }
                }

                // Add the PieSeries to the PlotModel
                pieModel.Series.Add(pieSeries);

                // Create a PlotView to display the PlotModel
                var plotView = new OxyPlot.WindowsForms.PlotView
                {
                    Model = pieModel,
                    Dock = DockStyle.Fill // Fill the entire container control
                };

                // Add the PlotView to a Panel or any other suitable container control
                panelPieChart.Controls.Clear(); // Clear existing controls
                panelPieChart.Controls.Add(plotView); // Assuming panelPieChart is the name of your container control
            }
            catch (Exception ex)
            {
                // Handle exceptions, log them, or display an error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelTotalStocksperProduct_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // Query for Accessories total stocks
                    string queryAccessories = "SELECT SUM(Stocks) FROM tbl_Accessories";
                    OleDbCommand commandAccessories = new OleDbCommand(queryAccessories, connection);
                    object resultAccessories = commandAccessories.ExecuteScalar();
                    double totalAccessories = Convert.ToDouble(resultAccessories);

                    // Query for Bikes total stocks
                    string queryBikes = "SELECT SUM(Stocks) FROM tbl_Bikes";
                    OleDbCommand commandBikes = new OleDbCommand(queryBikes, connection);
                    object resultBikes = commandBikes.ExecuteScalar();
                    double totalBikes = Convert.ToDouble(resultBikes);

                    // Query for Components total stocks
                    string queryComponents = "SELECT SUM(Stocks) FROM tbl_Components";
                    OleDbCommand commandComponents = new OleDbCommand(queryComponents, connection);
                    object resultComponents = commandComponents.ExecuteScalar();
                    double totalComponents = Convert.ToDouble(resultComponents);

                    // Display the results in the form's text boxes
                    tbxAccessories.Text = totalAccessories.ToString();
                    tbxBikes.Text = totalBikes.ToString();
                    tbxComponents.Text = totalComponents.ToString();
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnViewInventoryList_Click(object sender, EventArgs e)
        {
            new View_Inventory_List().Show();
            this.Hide();
        }

        private void AddBarChart()
        {
            try
            {
                // Instantiate a PlotModel
                var barModel = new PlotModel { Title = "Average Income Per Purchase of Each Product" };

                // Create a BarSeries
                var barSeries = new BarSeries();

                // Create a CategoryAxis
                var categoryAxis = new CategoryAxis { Position = AxisPosition.Left, FontSize = 6 }; // Set the font size here

                // Connection string to your MS Access database
                string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gil Bernard\source\repos\Velocity_Bike Shop Managemennt System\Velocity_Bike Shop Managemennt System\bin\Debug\Databases\DataBase_Velocity-Bike Shop Management System\db_Velocity-BikeShop.accdb";

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT ProductName, SUM(Price * Quantity) / SUM(Quantity) AS AvgIncomePerPurchase FROM tbl_SalesQuery GROUP BY ProductName;", conn);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string productName = Convert.ToString(reader["ProductName"]);
                            double avgIncomePerPurchase = Convert.ToDouble(reader["AvgIncomePerPurchase"]);

                            barSeries.Items.Add(new BarItem { Value = avgIncomePerPurchase });
                            categoryAxis.Labels.Add(productName);
                        }
                    }
                }

                // Add the BarSeries to the PlotModel
                barModel.Series.Add(barSeries);

                // Add the CategoryAxis to the PlotModel
                barModel.Axes.Add(categoryAxis);

                // Create a PlotView to display the PlotModel
                var plotView = new OxyPlot.WindowsForms.PlotView
                {
                    Model = barModel,
                    Dock = DockStyle.Fill // Fill the entire container control
                };

                // Add the PlotView to a Panel or any other suitable container control
                panel_AvgIncomePerProductPurchase.Controls.Clear(); // Clear existing controls
                panel_AvgIncomePerProductPurchase.Controls.Add(plotView); // Assuming panel_AvgIncomePerProductPurchase is the name of your container control
            }
            catch (Exception ex)
            {
                // Handle exceptions, log them, or display an error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GenerateWeeklySalesReport()
        {
            try
            {
                // Instantiate a PlotModel
                var plotModel = new PlotModel { Title = "Weekly Sales Data" };

                // Create a CategoryAxis for the X-axis
                var categoryAxis = new CategoryAxis { Position = AxisPosition.Bottom };

                // Create a LineSeries and set the color to red
                var lineSeries = new LineSeries { Title = "Weekly Sales Over Time", Color = OxyColors.Blue };

                // Connection string to your MS Access database
                string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Gil Bernard\source\repos\Velocity_Bike Shop Managemennt System\Velocity_Bike Shop Managemennt System\bin\Debug\Databases\DataBase_Velocity-Bike Shop Management System\db_Velocity-BikeShop.accdb";

                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand("SELECT Format(SaleDate,'MM-dd-yyyy') AS SaleDate, SUM(Price) as DailySales FROM tbl_SalesQuery GROUP BY Format(SaleDate,'MM-dd-yyyy')", conn);
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        int i = 0;
                        while (reader.Read())
                        {
                            var dailySales = double.Parse(reader["DailySales"].ToString());
                            lineSeries.Points.Add(new DataPoint(i++, dailySales));

                            // Parse the date string to a DateTime object and format it to 'MM-dd-yyyy'
                            var saleDate = DateTime.Parse(reader["SaleDate"].ToString());
                            var formattedDate = saleDate.ToString("MM-dd-yyyy HH:mm tt");

                            categoryAxis.Labels.Add(formattedDate);
                        }

                    }
                }

                // Add the LineSeries to the PlotModel
                plotModel.Series.Add(lineSeries);

                // Add the CategoryAxis to the PlotModel
                plotModel.Axes.Add(categoryAxis);

                // Create a PlotView to display the PlotModel
                var plotView = new OxyPlot.WindowsForms.PlotView
                {
                    Model = plotModel,
                    Dock = DockStyle.Fill // Fill the entire container control
                };

                // Add the PlotView to a Panel or any other suitable container control
                panel_WeeklySalesReport.Controls.Clear(); // Clear existing controls
                panel_WeeklySalesReport.Controls.Add(plotView); // Assuming panel_WeeklySalesReport is the name of your container control
            }
            catch (Exception ex)
            {
                // Handle exceptions, log them, or display an error message
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
