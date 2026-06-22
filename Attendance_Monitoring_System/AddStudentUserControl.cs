using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;
using Microsoft.IdentityModel.Tokens;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Attendance_Monitoring_System
{
    public partial class AddStudentUserControl : UserControl
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;";


        public AddStudentUserControl()
        {
            InitializeComponent();
            LoadUpdateStudentData();
            LoadStudentData();
            LoadDeleteStudentData();
        }

        private void LoadStudentData()
        {
            string query = "SELECT Student_Name AS [Full Name], Student_Email AS [Email], Student_ID AS [ID], Student_Phone AS [Phone Number], Student_Pass AS [Password], User_Identity AS [User Identity] FROM UserDB  WHERE User_Identity = 'Student'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connection);

                DataTable dtTb = new DataTable();
                sqlDA.Fill(dtTb);

                AddStudentDataGridView.DataSource = dtTb;
            }
        }

        private void LoadUpdateStudentData()
        {
            string query = "SELECT Student_Name AS [Full Name], Student_Email AS [Email], Student_ID AS [ID], Student_Phone AS [Phone Number], Student_Pass AS [Password], User_Identity AS [User Identity] FROM UserDB  WHERE User_Identity = 'Student'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connection);

                DataTable dtTb = new DataTable();
                sqlDA.Fill(dtTb);

                UpdateStudentDataGridView.DataSource = dtTb;
            }
        }

        private void LoadDeleteStudentData()
        {
            string query = "SELECT Student_Name AS [Full Name], Student_Email AS [Email], Student_ID AS [ID], Student_Phone AS [Phone Number], Student_Pass AS [Password], User_Identity AS [User Identity] FROM UserDB  WHERE User_Identity = 'Student'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connection);

                DataTable dtTb = new DataTable();
                sqlDA.Fill(dtTb);

                DeleteStudentDataGridView.DataSource = dtTb;
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

            MessageBox.Show("Submission Successful!");

            FullNameTextBox.Clear();
            EmailTextBox.Clear();
            StudentIdTextBox.Clear();
            PhoneTextBox.Clear();
            PasswordTextBox.Clear();

            LoadStudentData();
            LoadDeleteStudentData();
            LoadUpdateStudentData();
        }

        private void InsertStudentTabPage_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Student Updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Student Name not found!");
                    }
                }
            }

            UpdateFullNameTextBox.Clear();
            UpdateEmailTextBox.Clear();
            UpdateStudentIdTextBox.Clear();
            UpdatePhoneTextBox.Clear();
            UpdatePasswordTextBox.Clear();

            LoadStudentData();
            LoadDeleteStudentData();
            LoadUpdateStudentData();
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
                        MessageBox.Show("Student deleted successfully!");

                        DeleteFullNameTextBox.Clear();
                        DeleteStudentIdTextBox.Clear();

                        LoadStudentData();
                        LoadDeleteStudentData();
                        LoadUpdateStudentData();

                    }
                    else
                    {
                        MessageBox.Show("No student found with this Name and ID.");
                    }
                }
            }

        }
    }
}
