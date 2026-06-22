using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Attendance_Monitoring_System
{
    public partial class RegistrationForm : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
            
            if (FullNameTextBox.Text == string.Empty
                    || EmailTextBox.Text == string.Empty
                    || StudentIdTextBox.Text == string.Empty
                    || PhoneTextBox.Text == string.Empty
                    || PasswordTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string userIdentity = "Student";
            string insertQuery = "INSERT INTO UserDB " +
                                 "(Student_Name, Student_Email, Student_ID, Student_Phone, Student_Pass, User_Identity) " +
                                 "VALUES " +
                                 "(@name, @email, @studentid, @phone, @password, @identity)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection)) 
                {
                    cmd.Parameters.AddWithValue("@name", FullNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@studentid", StudentIdTextBox.Text);
                    cmd.Parameters.AddWithValue("@phone", PhoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);
                    cmd.Parameters.AddWithValue("@identity", userIdentity);


                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Registration successful!");

            FullNameTextBox.Clear();
            EmailTextBox.Clear();
            StudentIdTextBox.Clear();
            PhoneTextBox.Clear();
            PasswordTextBox.Clear();

            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }
    }
}
