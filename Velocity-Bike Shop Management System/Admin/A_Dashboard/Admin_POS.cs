using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Collections.Generic;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using iTextSharp.text.pdf.draw;

namespace Velocity_Bike_Shop_Managemennt_System.Admin.A_Dashboard
{
    public partial class Admin_POS : Form
    {
        public Point mouseLocation;
        bool sidebarExpand;

        private UserControl currentUserControl;
        private UserControlABikes ucABikes;
        private UserControlAComponents ucAComponents;
        private UserControlAAccessories ucAAccessories;

        public Admin_POS()
        {
            InitializeComponent();
            sidebarExpand = false;
            sidebar.Width = sidebar.MinimumSize.Width;

            ucABikes = new UserControlABikes();
            ucAComponents = new UserControlAComponents();
            ucAAccessories = new UserControlAAccessories();

            panel_main.Controls.Add(ucABikes);
            panel_main.Controls.Add(ucAComponents);
            panel_main.Controls.Add(ucAAccessories);

            ucABikes.BringToFront();

            ucABikes.DgvBills = dgvBills;
            ucAAccessories.DgvBills = dgvBills;
            ucAComponents.DgvBills = dgvBills;
        }

        OleDbConnection? con;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;

        public DataGridView DgvBills
        {
            get { return dgvBills; }
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

        private void btnABikes_Click(object sender, EventArgs e)
        {
            if (currentUserControl == ucAComponents)
            {
                ucAComponents.Hide();
                ucABikes.Show();
                currentUserControl = ucABikes;
            }
            else if (currentUserControl == ucAAccessories)
            {
                ucAAccessories.Hide();
                ucABikes.Show();
                currentUserControl = ucABikes;
            }
            else
            {
                ucABikes.BringToFront();
                ucAComponents.Hide();
                ucAAccessories.Hide();
                currentUserControl = ucABikes;
            }
        }

        private void btnAComponents_Click(object sender, EventArgs e)
        {
            if (currentUserControl == ucABikes)
            {
                ucABikes.Hide();
                ucAComponents.Show();
                currentUserControl = ucAComponents;
            }
            else if (currentUserControl == ucAAccessories)
            {
                ucAAccessories.Hide();
                ucAComponents.Show();
                currentUserControl = ucAComponents;
            }
            else
            {
                ucAComponents.BringToFront();
                ucABikes.Hide();
                ucAAccessories.Hide();
                currentUserControl = ucAComponents;
            }
        }

        private void btnAAccessories_Click(object sender, EventArgs e)
        {
            if (currentUserControl == ucABikes)
            {
                ucABikes.Hide();
                ucAAccessories.Show();
                currentUserControl = ucAAccessories;
            }
            else if (currentUserControl == ucAComponents)
            {
                ucAComponents.Hide();
                ucAAccessories.Show();
                currentUserControl = ucAAccessories;
            }
            else
            {
                ucAAccessories.BringToFront();
                ucABikes.Hide();
                ucAComponents.Hide();
                currentUserControl = ucAAccessories;
            }
        }

        private void btnAProducts_Click(object sender, EventArgs e)
        {
            new Manage_Inventory().Show();
            this.Hide();
        }

        private void dgvBills_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBills.Columns[e.ColumnIndex].Name == "Price")
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
        private void StorePaymentDetails(double totalBill, double amountPaid, double change, string paymentMethod)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string queryInsert = "INSERT INTO tbl_CounterPaymentDetails (TotalBill, AmountPaid, Change, PaymentMethod, PaymentDate) VALUES (@TotalBill, @AmountPaid, @Change, @PaymentMethod, @PaymentDate)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandInsert = new OleDbCommand(queryInsert, connection);
                commandInsert.Parameters.AddWithValue("@TotalBill", totalBill);
                commandInsert.Parameters.AddWithValue("@AmountPaid", amountPaid);
                commandInsert.Parameters.AddWithValue("@Change", change);
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
        private void StoreTransaction(string productName, double Price, int quantity)
        {
            // Check for null parameters
            if (productName == null)
            {
                MessageBox.Show("Product name is null");
                return;
            }

            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb";

            string queryInsert = "INSERT INTO tbl_CounterSalesRecord (ProductName, Price, Quantity, SaleDate) VALUES (@ProductName, @Price, @Quantity, @SaleDate)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand commandInsert = new OleDbCommand(queryInsert, connection);
                commandInsert.Parameters.AddWithValue("@ProductName", productName);
                commandInsert.Parameters.AddWithValue("@Price", Price);
                commandInsert.Parameters.AddWithValue("@Quantity", quantity);
                commandInsert.Parameters.AddWithValue("@SaleDate", DateTime.Now);

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
        private void btnPay_Click(object sender, EventArgs e)
        {
            try
            {
                // Iterate through DataGridView to deduct stocks and store transaction details
                foreach (DataGridViewRow row in dgvBills.Rows)
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

                        // Store transaction details in database
                        StoreTransaction(productName, Price, quantity);
                    }
                }

                // Store payment details
                double totalBill = double.Parse(tbxTotalBill.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("fil-PH"));
                double amountPaid = Convert.ToDouble(tbxAmount.Text);
                double change = double.Parse(tbxChange.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("fil-PH"));
                string paymentMethod = cmbPaymentMethod.SelectedItem.ToString(); // Get selected payment method

                StorePaymentDetails(totalBill, amountPaid, change, paymentMethod);

                // Clear the DataGridView after payment
                dgvBills.Rows.Clear();
                tbxAmount.Text = "";
                tbxChange.Text = "";

                MessageBox.Show("Payment successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while processing the payment: " + ex.Message);
            }
        }
        private void CalculateTotalBill()
        {
            double totalBill = 0;

            // Iterate through DataGridView to calculate total bill
            foreach (DataGridViewRow row in dgvBills.Rows)
            {
                // Check if the row is not a new row and cells are not null
                if (!row.IsNewRow && row.Cells["Price"].Value != null && row.Cells["Quantity"].Value != null)
                {
                    double price = Convert.ToDouble(row.Cells["Price"].Value);
                    int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                    // Calculate total price for each item
                    double totalPrice = price * quantity;
                    totalBill += totalPrice; // Add to total bill
                }
            }

            // Display total bill in a text box
            tbxTotalBill.Text = totalBill.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"));
        }
        private void CalculateChange()
        {
            try
            {
                // Parse the amount paid by the customer
                double amountPaid = double.Parse(tbxAmount.Text);

                // Parse the total bill
                double totalBill = double.Parse(tbxTotalBill.Text, NumberStyles.Currency, CultureInfo.CreateSpecificCulture("fil-PH"));

                // Calculate the change
                double change = amountPaid - totalBill;

                // Display the change in a text box with currency formatting (PHP)
                tbxChange.Text = change.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"));
            }
            catch (FormatException)
            {
                // Handle the case where the amount paid is not a valid number
                tbxChange.Text = "₱0.00";
            }
        }

        private void dgvBills_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotalBill();
        }

        private void tbxAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // Remove selected rows from the DataGridView
                foreach (DataGridViewRow row in dgvBills.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvBills.Rows.Remove(row);
                    }
                }

                // Recalculate total bill
                CalculateTotalBill();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while removing item: " + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear the DataGridView
                dgvBills.Rows.Clear();

                // Reset total bill, amount paid, and change
                tbxTotalBill.Text = "₱0.00";
                tbxAmount.Text = "";
                tbxChange.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while resetting: " + ex.Message);
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            try
            {
                // Generate receipt content
                string receiptContent = GenerateReceipt();

                // Save the receipt to a file
                SaveReceiptToFile(receiptContent);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating the receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                double change = double.Parse(tbxChange.Text, System.Globalization.NumberStyles.Currency, CultureInfo.CreateSpecificCulture("fil-PH"));
                string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();

                // Generate receipt string
                receiptBuilder.AppendLine("Total Bill:".PadRight(115) + $"{totalBill.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"))}");
                receiptBuilder.AppendLine("Amount Paid:".PadRight(112) + $"{amountPaid.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"))}");
                receiptBuilder.AppendLine("Change:".PadRight(114) + $"{change.ToString("C", CultureInfo.CreateSpecificCulture("fil-PH"))}");
                receiptBuilder.AppendLine("Payment Method:".PadRight(110) + $"{paymentMethod}");

                // Add horizontal line
                receiptBuilder.AppendLine("----------------------------------------------------------------------------------------------------------------------------------");

                // Add item details from DataGridView
                receiptBuilder.AppendLine("Items Purchased:");
                foreach (DataGridViewRow row in dgvBills.Rows)
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

        private void btnViewInventoryList_Click(object sender, EventArgs e)
        {
            new View_Inventory_List().Show();
            this.Hide();
        }
    }
}
