using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Attendance_Monitoring_System
{
    public partial class FogetForm : Form
    {

        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;";
        public FogetForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (EmailTextBox.Text == string.Empty || NewPasswordTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string checkQuery = "SELECT COUNT(*) FROM UserDB WHERE Student_Email = @email";
            string updateQuery = "UPDATE UserDB SET Student_Pass = @password WHERE Student_Email = @email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 1)
                    {

                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@password", NewPasswordTextBox.Text);
                            updateCmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show("Password Reset Successful!");


                            LoginForm loginform = new LoginForm();
                            loginform.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email does not exist.");
                    }

                }

            }
        }
    }
}
