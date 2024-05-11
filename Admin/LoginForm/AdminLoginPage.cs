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

namespace Velocity_Bike_Shop_Managemennt_System
{
    public partial class AdminLoginPage : Form
    {
        public Point mouseLocation;
        public AdminLoginPage()
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            new startPage().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.Open();

            // Corrected SQL query string
            string login = "SELECT * FROM tbl_Admin WHERE Username = '" + tbxUsername.Text + "' AND Password = '" + tbxPassword.Text + "'";

            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                new AdminDashboard().Show();
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
    }
}
