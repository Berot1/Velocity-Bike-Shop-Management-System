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

namespace Velocity_Bike_Shop_Managemennt_System.User_Guest.Forget_Password
{
    public partial class ForgetPasswordPage : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source = C:\\Users\\Gil Bernard\\source\\repos\\Velocity_Bike Shop Managemennt System\\Velocity_Bike Shop Managemennt System\\bin\\Debug\\Databases\\DataBase_Velocity-Bike Shop Management System\\db_Velocity-BikeShop.accdb");
        OleDbCommand cmd = new OleDbCommand();

        public ForgetPasswordPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new startPage().Show();
            this.Hide();
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text.Trim();
            string newPassword = tbxNewPassword.Text; // Get the new password from the textbox
            string confirmNewPassword = tbxConfirmNewPass.Text; // Get the confirm new password from the textbox

            // Check if the new password matches the confirm new password
            if (newPassword != confirmNewPassword)
            {
                MessageBox.Show("Password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxNewPassword.Text = "";
                tbxConfirmNewPass.Text = "";
                return;
            }

            try
            {
                con.Open();
                // Check if the username exists
                string checkUsernameQuery = "SELECT COUNT(*) FROM tbl_users WHERE Username = ?";
                using (OleDbCommand checkUsernameCmd = new OleDbCommand(checkUsernameQuery, con))
                {
                    checkUsernameCmd.Parameters.AddWithValue("@username", username);
                    int userCount = Convert.ToInt32(checkUsernameCmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        // Username exists, proceed with password reset
                        string updateQuery = "UPDATE tbl_users SET [password] = ? WHERE Username = ?";
                        using (OleDbCommand cmd = new OleDbCommand(updateQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@newPassword", newPassword);
                            cmd.Parameters.AddWithValue("@username", username);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Password reset successful.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Failed to reset password.", "Password Reset Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        // Username doesn't exist
                        MessageBox.Show("Failed to reset password. Username not found.", "Password Reset Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbxUsername.Text = "";
                    }
                }
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void cbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowPass.Checked)
            {
                tbxNewPassword.PasswordChar = '\0';
                tbxConfirmNewPass.PasswordChar = '\0';
            }
            else
            {
                tbxNewPassword.PasswordChar = '•';
                tbxConfirmNewPass.PasswordChar = '•';
            }
        }
    }
}
