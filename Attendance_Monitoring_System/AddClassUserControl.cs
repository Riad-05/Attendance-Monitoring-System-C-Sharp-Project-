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
    public partial class AddClassUserControl : UserControl
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;";

        public AddClassUserControl()
        {
            InitializeComponent();
            LoadInsertClassData();
            LoadDeleteClassData();
            LoadSearchClassData();
        }

        private void LoadInsertClassData()
        {
            string query = "SELECT Class_ID AS [Class ID], Department AS [Department Name], Subject_Name AS [Subject Name], Section AS [Section], Total_Student AS [Total Student] FROM ClassesDB";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connection);

                DataTable dtTb = new DataTable();
                sqlDA.Fill(dtTb);

                InsertClassDataGridView.DataSource = dtTb;
            }
        }

        private void LoadDeleteClassData()
        {
            string query = "SELECT Class_ID AS [Class ID], Department AS [Department Name], Subject_Name AS [Subject Name], Section AS [Section], Total_Student AS [Total Student] FROM ClassesDB";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connection);

                DataTable dtTb = new DataTable();
                sqlDA.Fill(dtTb);

                DeleteClassDataGridView.DataSource = dtTb;
            }
        }

        private void LoadSearchClassData()
        {
            string query = "SELECT Class_ID AS [Class ID], Department AS [Department Name], Subject_Name AS [Subject Name], Section AS [Section], Total_Student AS [Total Student] FROM ClassesDB";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter(query, connection);

                DataTable dtTb = new DataTable();
                sqlDA.Fill(dtTb);

                SearchClassDataGridView.DataSource = dtTb;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (DepartmentTextBox.Text == string.Empty
                    || ClassNameTextBox.Text == string.Empty
                    || SectionTextBox.Text == string.Empty
                    || TotalStudentTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string insertQuery = "INSERT INTO ClassesDB " +
                                 "(Department, Subject_Name, Section, Total_Student) " +
                                 "VALUES " +
                                 "( @department, @subjectName, @section, @totalStudent)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@department", DepartmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@subjectName", ClassNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@section", SectionTextBox.Text);
                    cmd.Parameters.AddWithValue("@totalStudent", TotalStudentTextBox.Text);

                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Submission Successful!");

            DepartmentTextBox.Clear();
            ClassNameTextBox.Clear();
            SectionTextBox.Clear();
            TotalStudentTextBox.Clear();

            LoadInsertClassData();
            LoadDeleteClassData();
            LoadSearchClassData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (DeleteDepartmentTextBox.Text == string.Empty ||
                    DeleteClassNameTextBox.Text == string.Empty||
                    DeleteSectionTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            string deleteQuery = "DELETE FROM ClassesDB " +
                                 "WHERE Department = @department AND Subject_Name = @subjectName AND Section = @section";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@department", DeleteDepartmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@subjectName", DeleteClassNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@section", DeleteSectionTextBox.Text);

                    int count = cmd.ExecuteNonQuery();

                    if (count > 0)
                    {
                        MessageBox.Show("Class deleted successfully!");

                        DeleteDepartmentTextBox.Clear();
                        DeleteClassNameTextBox.Clear();
                        DeleteSectionTextBox.Clear();

                        LoadInsertClassData();
                        LoadDeleteClassData();
                        LoadSearchClassData();

                    }
                    else
                    {
                        MessageBox.Show("No Class found with this Subject Name and Section.");
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            {
                string query = "SELECT * FROM ClassesDB " +
                               "WHERE Department LIKE @department " +
                               "AND Subject_Name LIKE @subjectName " +
                               "AND Section LIKE @section";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@department", "%" + SearchDepartmentTextBox.Text + "%");
                    cmd.Parameters.AddWithValue("@subjectName", "%" + SearchClassNameTextBox.Text + "%");
                    cmd.Parameters.AddWithValue("@section", "%" + SearchSectionTextBox.Text + "%");

                    SqlDataAdapter sqlDA = new SqlDataAdapter(cmd);

                    DataTable dtTb = new DataTable();

                    sqlDA.Fill(dtTb);

                    SearchClassDataGridView.DataSource = dtTb;
                }
            }
        }
    }
}
