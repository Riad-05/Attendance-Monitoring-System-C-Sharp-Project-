using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Attendance_Monitoring_System
{
    public partial class AddFacultyUserControl : UserControl
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;";

        public AddFacultyUserControl()
        {
            InitializeComponent();
            LoadFacultyData();
            LoadUpdateFacultyData();
            LoadDeleteFacultyData();
        }

        private void LoadFacultyData()
        {
            string query = "SELECT Student_Name AS [Full Name], Student_Email AS [Email], Student_ID AS [ID], Student_Phone AS [Phone Number], Student_Pass AS [Password], User_Identity AS [User Identity] FROM UserDB  WHERE User_Identity = 'Faculty'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connection);

                DataTable dtTb = new DataTable();
                sqlDA.Fill(dtTb);

                FacultyDataGridView.DataSource = dtTb;
            }
        }

        private void LoadUpdateFacultyData()
        {
            string query = "SELECT Student_Name AS [Full Name], Student_Email AS [Email], Student_ID AS [ID], Student_Phone AS [Phone Number], Student_Pass AS [Password], User_Identity AS [User Identity] FROM UserDB  WHERE User_Identity = 'Faculty'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connection);

                DataTable dtTb = new DataTable();
                sqlDA.Fill(dtTb);

                UpdateFacultyDataGridView.DataSource = dtTb;
            }
        }

        private void LoadDeleteFacultyData()
        {
            string query = "SELECT Student_Name AS [Full Name], Student_Email AS [Email], Student_ID AS [ID], Student_Phone AS [Phone Number], Student_Pass AS [Password], User_Identity AS [User Identity] FROM UserDB  WHERE User_Identity = 'Faculty'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connection);

                DataTable dtTb = new DataTable();
                sqlDA.Fill(dtTb);

                DeleteFacultyDataGridView.DataSource = dtTb;
            }
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

            string userIdentity = "Faculty";
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

            MessageBox.Show("Submission Successful!");

            FullNameTextBox.Clear();
            EmailTextBox.Clear();
            StudentIdTextBox.Clear();
            PhoneTextBox.Clear();
            PasswordTextBox.Clear();

            LoadFacultyData();
            LoadUpdateFacultyData();
            LoadDeleteFacultyData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (UpdateFullNameTextBox.Text == string.Empty
                    || UpdateEmailTextBox.Text == string.Empty
                    || UpdateStudentIdTextBox.Text == string.Empty
                    || UpdatePhoneTextBox.Text == string.Empty
                    || UpdatePasswordTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string updateQuery = "UPDATE UserDB SET " +
                                 "Student_ID = @studentid, " +
                                 "Student_Email = @email, " +
                                 "Student_Phone = @phone, " +
                                 "Student_Pass = @password " +
                                 "WHERE Student_Name = @name";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", UpdateFullNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@email", UpdateEmailTextBox.Text);
                    cmd.Parameters.AddWithValue("@phone", UpdatePhoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@password", UpdatePasswordTextBox.Text);
                    cmd.Parameters.AddWithValue("@studentid", UpdateStudentIdTextBox.Text);

                    int count = cmd.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show("Faculty Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Faculty Name not found!");
                    }
                }
            }

            UpdateFullNameTextBox.Clear();
            UpdateEmailTextBox.Clear();
            UpdateStudentIdTextBox.Clear();
            UpdatePhoneTextBox.Clear();
            UpdatePasswordTextBox.Clear();

            LoadFacultyData();
            LoadUpdateFacultyData();
            LoadDeleteFacultyData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteFullNameTextBox.Text == string.Empty ||
                    DeleteStudentIdTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string deleteQuery = "DELETE FROM UserDB " +
                                 "WHERE Student_Name = @name AND Student_ID = @id";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@name", DeleteFullNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@id", DeleteStudentIdTextBox.Text);

                    int count = cmd.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show("Faculty deleted successfully!");

                        DeleteFullNameTextBox.Clear();
                        DeleteStudentIdTextBox.Clear();

                        LoadFacultyData();
                        LoadUpdateFacultyData();
                        LoadDeleteFacultyData();

                    }
                    else
                    {
                        MessageBox.Show("No Faculty found with this Name and ID.");
                    }
                }
            }
        }
    }
}
