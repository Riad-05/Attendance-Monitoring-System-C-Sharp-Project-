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
    public partial class ReportUserControl : UserControl
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;";

        public ReportUserControl()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (FullNameTextBox.Text == string.Empty &&
                   StudentIDTextBox.Text == string.Empty )
            {
                MessageBox.Show("Please fill at least one field.");
                return;
            }

            string query = "SELECT " +
                           "Student_ID AS [Student ID], Student_Name AS [Student Name],Department AS [Department], Class_Name AS [Subject Name],Section,Attendance_Date AS [Date], " +

                           "CASE " +
                           "WHEN SUM(CASE WHEN Attendance_Status = 'Present' THEN 1 ELSE 0 END) > 0 " +
                           "THEN 'Present' " +
                           "ELSE 'Absent' " +
                           "END AS Final_Status " +
                           "FROM AttendDB " +

                           "WHERE Student_Name LIKE @FullName " +
                           "AND Student_ID LIKE @StudentID " +

                           "GROUP BY " +
                           "Student_ID,Student_Name,Department,Class_Name,Section,Attendance_Date";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@FullName", "%" + FullNameTextBox.Text + "%");
                cmd.Parameters.AddWithValue("@StudentID", "%" + StudentIDTextBox.Text + "%");

                SqlDataAdapter sqlDA = new SqlDataAdapter(cmd);

                DataTable dtTb = new DataTable();

                sqlDA.Fill(dtTb);

                GenerateReportDataGridView.DataSource = dtTb;
            }
        }
    }
}
