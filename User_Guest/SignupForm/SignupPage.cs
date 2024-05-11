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
    public partial class SignupPage : Form
    {
        public Point mouseLocation;
        public SignupPage()
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "" || tbxCreatePass.Text == "" || tbxConfirmPass.Text == "")
            {
                MessageBox.Show("Username and Password fields are required", "Creating Account failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbxCreatePass.Text == tbxConfirmPass.Text)
            {
                con.Open();
                string checkQuery = "SELECT COUNT(*) FROM tbl_users WHERE username = @username";
                cmd = new OleDbCommand(checkQuery, con);
                cmd.Parameters.AddWithValue("@username", tbxUsername.Text);
                int userCount = (int)cmd.ExecuteScalar();
                con.Close();

                if (userCount > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Creating Account Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbxUsername.Text = "";
                    tbxUsername.Focus();
                }
                else
                {
                    con.Open();
                    string signup = "INSERT INTO tbl_users ([Username], [password]) VALUES (@username, @password)";
                    cmd = new OleDbCommand(signup, con);
                    cmd.Parameters.AddWithValue("@username", tbxUsername.Text);
                    cmd.Parameters.AddWithValue("@password", tbxCreatePass.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();

                    tbxUsername.Text = "";
                    tbxCreatePass.Text = "";
                    tbxConfirmPass.Text = "";

                    MessageBox.Show("Your Account has been Successfully Created", "Signing Up Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match, Please Re-enter", "Creating Account Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxCreatePass.Text = "";
                tbxConfirmPass.Text = "";
                tbxCreatePass.Focus();
            }
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                tbxCreatePass.PasswordChar = '\0';
                tbxConfirmPass.PasswordChar = '\0';
            }
            else
            {
                tbxCreatePass.PasswordChar = '•';
                tbxConfirmPass.PasswordChar = '•';
            }
        }

        private void lblLoginNow_Click(object sender, EventArgs e)
        {
            new startPage().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new startPage().Show();
            this.Hide();
        }
    }
}
