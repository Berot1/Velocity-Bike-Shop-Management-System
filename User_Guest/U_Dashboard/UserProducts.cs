using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Velocity_Bike_Shop_Managemennt_System.User_Guest.U_Dashboard.Products;
using static Guna.UI2.WinForms.Suite.Descriptions;
using Guna.UI2.WinForms.Suite;
using System.Data.OleDb;
using System.Globalization;
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Velocity_Bike_Shop_Managemennt_System.User_Guest.U_Dashboard
{
    public partial class UserProducts : Form
    {
        bool sidebarExpand;
        public Point mouseLocation;
        public UserControlBikes ucBikes;
        public UserControlComponents ucComponents;
        public UserControl currentUserControl;
        public UserControlAccessories ucAccessories;

        private string username;
        public UserProducts()
        {
            InitializeComponent();
            sidebarExpand = false;
            sidebar.Width = sidebar.MinimumSize.Width;

            ucBikes = new UserControlBikes();
            ucComponents = new UserControlComponents();
            ucAccessories = new UserControlAccessories();

            panel_main.Controls.Add(ucBikes);
            panel_main.Controls.Add(ucComponents);
            panel_main.Controls.Add(ucAccessories);

            ucBikes.BringToFront();

            ucBikes.DgvUBills = dgvUBills;
            ucComponents.DgvUBills = dgvUBills;
            ucAccessories.DgvUBills = dgvUBills;


            // Initialize the username label
            lblUsername.Text = username;
        }

        OleDbConnection? con;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        public DataGridView DgvUBills
        {
            set { dgvUBills = value; }
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                // Set the Text property of lblUsername to the username value
                lblUsername.Text = value;
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
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new startPage().Show();
            this.Hide();
        }

        private void btnUHome_Click(object sender, EventArgs e)
        {
            UsersDashboard usersDashboardForm = new UsersDashboard();
            usersDashboardForm.Username = this.Username; // Pass the username to the new form
            usersDashboardForm.Show();
            this.Hide();
        }

        private void btnUProducts_Click(object sender, EventArgs e)
        {
            UserProducts userProductsForm = new UserProducts();
            userProductsForm.Username = this.Username; // Pass the username to the new form
            userProductsForm.Show();
            this.Hide();
        }

        private void btnBikes_Click(object sender, EventArgs e)
        {
            if (currentUserControl == ucComponents)
            {
                ucComponents.Hide();
                ucBikes.Show();
                currentUserControl = ucBikes;
            }
            else if (currentUserControl == ucAccessories)
            {
                ucAccessories.Hide();
                ucBikes.Show();
                currentUserControl = ucBikes;
            }
            else
            {
                ucBikes.BringToFront();
                ucComponents.Hide();
                ucAccessories.Hide();
                currentUserControl = ucBikes;
            }
        }

        private void btnComponents_Click(object sender, EventArgs e)
        {
            if (currentUserControl == ucBikes)
            {
                ucBikes.Hide();
                ucComponents.Show();
                currentUserControl = ucComponents;
            }
            else if (currentUserControl == ucAccessories)
            {
                ucAccessories.Hide();
                ucComponents.Show();
                currentUserControl = ucComponents;
            }
            else
            {
                ucComponents.BringToFront();
                ucBikes.Hide();
                ucAccessories.Hide();
                currentUserControl = ucComponents;
            }
        }

        private void btnAccessories_Click(object sender, EventArgs e)
        {
            if (currentUserControl == ucBikes)
            {
                ucBikes.Hide();
                ucAccessories.Show();
                currentUserControl = ucAccessories;
            }
            else if (currentUserControl == ucComponents)
            {
                ucComponents.Hide();
                ucAccessories.Show();
                currentUserControl = ucAccessories;
            }
            else
            {
                ucAccessories.BringToFront();
                ucBikes.Hide();
                ucComponents.Hide();
                currentUserControl = ucAccessories;
            }
        }

        private void UpdateRowCount()
        {
            int rowCount = dgvUBills.Rows.Count - 1;
            tbxCart.Text = rowCount.ToString();
        }

        private void BDeductStocks(string productName, int quantity)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string queryUpdate = "UPDATE tbl_Bikes SET Stocks = Stocks - @Quantity WHERE Name = @Bname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandUpdate = new OleDbCommand(queryUpdate, connection);
                commandUpdate.Parameters.AddWithValue("@Quantity", quantity);
                commandUpdate.Parameters.AddWithValue("@Bname", productName);

                try
                {
                    connection.Open();
                    commandUpdate.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating stocks: " + ex.Message);
                }
            }
        }
        private void CDeductStocks(string productName, int quantity)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string queryUpdate = "UPDATE tbl_Components SET Stocks = Stocks - @Quantity WHERE ComponentName = @Cname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandUpdate = new OleDbCommand(queryUpdate, connection);
                commandUpdate.Parameters.AddWithValue("@Quantity", quantity);
                commandUpdate.Parameters.AddWithValue("@Cname", productName);

                try
                {
                    connection.Open();
                    commandUpdate.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating stocks: " + ex.Message);
                }
            }
        }
        private void ADeductStocks(string productName, int quantity)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string queryUpdate = "UPDATE tbl_Accessories SET Stocks = Stocks - @Quantity WHERE AccessoriesName = @Aname";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandUpdate = new OleDbCommand(queryUpdate, connection);
                commandUpdate.Parameters.AddWithValue("@Quantity", quantity);
                commandUpdate.Parameters.AddWithValue("@Aname", productName);

                try
                {
                    connection.Open();
                    commandUpdate.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating stocks: " + ex.Message);
                }
            }
        }

        private void dgvUBills_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotalBill();
            UpdateRowCount();
        }

        private void dgvUBills_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateRowCount();
        }

        private void dgvUBills_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUBills.Columns[e.ColumnIndex].Name == "Price")
            {
                // Check if the cell value is not null and is numeric
                if (e.Value != null && double.TryParse(e.Value.ToString(), out double value))
                {
                    // Format the numeric value with currency symbol and decimal formatting
                    string formattedValue = "₱" + value.ToString("N2");

                    // Set the formatted value to the cell
                    e.Value = formattedValue;

                    // Set text alignment to middle right
                    e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                    // Formatting applied
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove selected rows from the DataGridView
                foreach (DataGridViewRow row in dgvUBills.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvUBills.Rows.Remove(row);
                    }
                }
                CalculateTotalBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing item: " + ex.Message);
            }
        }
        private void CalculateTotalBill()
        {
            double totalBill = 0;

            // Iterate through DataGridView to calculate total bill
            foreach (DataGridViewRow row in dgvUBills.Rows)
            {
                // Check if the row is not a new row and cells are not null
                if (!row.IsNewRow && row.Cells["Price"].Value != null && row.Cells["Quantity"].Value != null)
                {
                    double price = Convert.ToDouble(row.Cells["Price"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    double totalPrice = price * quantity;
                    totalBill += totalPrice;
                }
            }

            // Display total bill in a text box
            tbxTotalBill.Text = totalBill.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"));
        }
        private void StoreOrderPaymentDetails(string username, double totalBill, double amountPaid, string paymentMethod)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string queryInsert = "INSERT INTO tbl_OrderPaymentDetails (Username, TotalBill, AmountPaid, PaymentMethod, PaymentDate) VALUES (@Username, @TotalBill, @AmountPaid, @PaymentMethod, @PaymentDate)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandInsert = new OleDbCommand(queryInsert, connection);
                commandInsert.Parameters.AddWithValue("@Username", username);
                commandInsert.Parameters.AddWithValue("@TotalBill", totalBill);
                commandInsert.Parameters.AddWithValue("@AmountPaid", amountPaid);
                commandInsert.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                commandInsert.Parameters.AddWithValue("@PaymentDate", DateTime.Now);

                try
                {
                    connection.Open();
                    commandInsert.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error storing payment details: " + ex.Message);
                }
            }
        }
        private void StoreOrderTransaction(string productName, double Price, int quantity, string username)
        {
            // Check for null parameters
            if (productName == null)
            {
                MessageBox.Show("Product name is null");
                return;
            }

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string queryInsert = "INSERT INTO tbl_OrderSalesRecord (ProductName, Price, Quantity, SaleDate, Username) VALUES (@ProductName, @Price, @Quantity, @SaleDate, @Username)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandInsert = new OleDbCommand(queryInsert, connection);
                commandInsert.Parameters.AddWithValue("@ProductName", productName);
                commandInsert.Parameters.AddWithValue("@Price", Price);
                commandInsert.Parameters.AddWithValue("@Quantity", quantity);
                commandInsert.Parameters.AddWithValue("@SaleDate", DateTime.Now);
                commandInsert.Parameters.AddWithValue("@Username", username); // Pass the username parameter

                try
                {
                    connection.Open();
                    commandInsert.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error storing transaction: " + ex.Message);
                }
            }
        }
        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                // Iterate through DataGridView to deduct stocks and store transaction details
                foreach (DataGridViewRow row in dgvUBills.Rows)
                {
                    // Check if the row is not a new row and cells are not null
                    if (!row.IsNewRow && row.Cells["Product"].Value != null && row.Cells["Price"].Value != null && row.Cells["Quantity"].Value != null)
                    {
                        string productName = row.Cells["Product"].Value.ToString(); // Adjust column name as per your DataGridView
                        double Price = Convert.ToDouble(row.Cells["Price"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                        // Deduct stocks
                        BDeductStocks(productName, quantity);
                        CDeductStocks(productName, quantity);
                        ADeductStocks(productName, quantity);

                        // Store transaction details in database, passing the username
                        StoreOrderTransaction(productName, Price, quantity, username);
                    }
                }

                // Calculate total bill before clearing the DataGridView
                CalculateTotalBill();

                // Generate receipt content after the payment and total bill calculation
                string receiptContent = GenerateReceipt();

                // Save the receipt to a file
                SaveReceiptToFile(receiptContent);

                // Store payment details
                double totalBill = double.Parse(tbxTotalBill.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("fil-PH"));
                double amountPaid = Convert.ToDouble(tbxAmount.Text);
                string paymentMethod = cmbPaymentMethod.SelectedItem.ToString(); // Get selected payment method
                StoreOrderPaymentDetails(username, totalBill, amountPaid, paymentMethod); // Pass the username

                // Clear the DataGridView after payment
                dgvUBills.Rows.Clear();

                MessageBox.Show("Payment successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the payment: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the DataGridView
                dgvUBills.Rows.Clear();

                // Reset total bill, amount paid, and change
                tbxTotalBill.Text = "₱0.00";
                tbxAmount.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting: " + ex.Message);
            }
        }
        private void SaveReceiptToFile(string receiptContent)
        {
            try
            {
                // Specify the file path to save the receipt PDF
                string folderPath = @"C:\Users\Gil Bernard\source\repos\Velocity_Bike Shop Managemennt System\Velocity_Bike Shop Managemennt System\bin\Debug\Receipts";
                string filePath = Path.Combine(folderPath, DateTime.Now.ToString("yyyyMMddHHmmss") + ".pdf");

                // Create a PDF document
                Document doc = new Document();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
                doc.Open();

                // Add logo to the PDF
                string logoPath = @"C:\Users\Gil Bernard\Pictures\Camera Roll\Black and White Simple Bicycle Accessories Logo (4).png";
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                logo.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                logo.ScaleToFit(200f, 200f);
                doc.Add(logo);

                // Add receipt content to the PDF
                Paragraph heading = new Paragraph("VELOCITY BIKE SHOP", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 18, iTextSharp.text.Font.BOLD));
                heading.Alignment = Element.ALIGN_CENTER;
                doc.Add(heading);

                Paragraph date = new Paragraph(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10));
                date.Alignment = Element.ALIGN_CENTER;
                doc.Add(date);

                Paragraph receiptHeader = new Paragraph("RECEIPT", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, iTextSharp.text.Font.BOLD));
                receiptHeader.Alignment = Element.ALIGN_CENTER;
                doc.Add(receiptHeader);

                doc.Add(new Chunk("\n"));

                doc.Add(new Paragraph(receiptContent));

                // Add horizontal line
                LineSeparator line = new LineSeparator();
                doc.Add(new Chunk(line));

                // Close the document
                doc.Close();

                MessageBox.Show("Receipt saved successfully", "Receipt Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving the receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GenerateReceipt()
        {
            StringBuilder receiptBuilder = new StringBuilder();

            try
            {
                // Capture transaction details
                double totalBill = double.Parse(tbxTotalBill.Text, System.Globalization.NumberStyles.Currency, CultureInfo.CreateSpecificCulture("fil-PH"));
                double amountPaid = Convert.ToDouble(tbxAmount.Text);             
                string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();

                // Generate receipt string
                receiptBuilder.AppendLine("Total Bill:".PadRight(115) + $"{totalBill.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"))}");
                receiptBuilder.AppendLine("Amount Paid:".PadRight(112) + $"{amountPaid.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"))}");
                receiptBuilder.AppendLine("Payment Method:".PadRight(110) + $"{paymentMethod}");

                // Add horizontal line
                receiptBuilder.AppendLine("----------------------------------------------------------------------------------------------------------------------------------");

                // Add item details from DataGridView
                receiptBuilder.AppendLine("Items Purchased:");
                foreach (DataGridViewRow row in dgvUBills.Rows)
                {
                    if (!row.IsNewRow && row.Cells["Product"].Value != null && row.Cells["Price"].Value != null && row.Cells["Quantity"].Value != null)
                    {
                        string productName = row.Cells["Product"].Value.ToString();
                        double price = Convert.ToDouble(row.Cells["Price"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                        string itemLine = $"{productName} (x{quantity})".PadRight(110) + $"{price.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"))}";
                        receiptBuilder.AppendLine(itemLine);
                    }
                }

                // Add horizontal line
                receiptBuilder.AppendLine("----------------------------------------------------------------------------------------------------------------------------------");

                // Thank you message
                receiptBuilder.AppendLine("\n");
                receiptBuilder.AppendLine("THANK YOU!");
                receiptBuilder.AppendLine("Visit us again at Velocity Bike Shop");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return receiptBuilder.ToString();
        }

    }
}
