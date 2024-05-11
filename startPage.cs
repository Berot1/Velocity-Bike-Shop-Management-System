using System;
using System.Data.OleDb;
using System.Windows.Forms;
using Velocity_Bike_Shop_Managemennt_System.User_Guest.Forget_Password;
using Velocity_Bike_Shop_Managemennt_System.User_Guest.U_Dashboard;

namespace Velocity_Bike_Shop_Managemennt_System
{
    public partial class startPage : Form
    {
        public Point mouseLocation;
        public startPage()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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
        private void lblClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMinize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            new SignupPage().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();

            // Corrected SQL query string
            string login = "SELECT * FROM tbl_Users WHERE Username = '" + tbxUsername.Text + "' AND Password = '" + tbxPassword.Text + "'";

            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string username = dr["Username"].ToString(); // Get the username from the database
                                                             // Create an instance of the UserProducts form
                UsersDashboard usersDashboardForm = new UsersDashboard();
                // Set the username using the public property
                usersDashboardForm.Username = username;
                usersDashboardForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxUsername.Text = "";
                tbxPassword.Text = "";
                tbxUsername.Focus();
            }

            con.Close();
        }

        private void cbxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowpassword.Checked)
            {
                tbxPassword.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '•';
            }
        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            new AdminLoginPage().Show();
            this.Hide();
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            new ForgetPasswordPage().Show();
            this.Hide();
        }
    }
}