using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Attendance_Monitoring_System
{
    public partial class AttendanceUserControl : UserControl
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;";

        public AttendanceUserControl()
        {
            InitializeComponent();
        }

        private void LoadAttendanceData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO AttendDB( Student_ID,Student_Name, Department,Class_Name,Section, Attendance_Date,Attendance_Status) SELECT U.Student_ID,U.Student_Name,C.Department,C.Class_Name,C.Section,@date,'Absent' FROM UserDB U INNER JOIN StudentClassDB C ON U.Student_ID = C.Student_ID WHERE U.User_Identity = 'Student' AND C.Department = @department AND C.Class_Name = @className AND C.Section = @section AND NOT EXISTS( SELECT 1 FROM AttendDB A WHERE A.Student_ID = U.Student_ID AND A.Attendance_Date = @date  AND A.Class_Name = C.Class_Name AND A.Section = C.Section)";

                SqlCommand cmd =
                    new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue(
                    "@department",
                    DepartmentTextBox.Text);

                cmd.Parameters.AddWithValue(
                    "@className",
                    SubjectNameTextBox.Text);

                cmd.Parameters.AddWithValue(
                    "@section",
                    SectionTextBox.Text);

                cmd.Parameters.AddWithValue(
                    "@date",
                    AttendanceDatePicker.Value.Date);

                cmd.ExecuteNonQuery();

                string selectQuery = @"
                                    SELECT *
                                    FROM AttendDB
                                    WHERE Department = @department
                                    AND Class_Name = @className
                                    AND Section = @section
                                    AND Attendance_Date = @date";

                SqlDataAdapter sqlDA =
                    new SqlDataAdapter(selectQuery, connection);

                sqlDA.SelectCommand.Parameters.AddWithValue(
                    "@department",
                    DepartmentTextBox.Text);

                sqlDA.SelectCommand.Parameters.AddWithValue(
                    "@className",
                    SubjectNameTextBox.Text);

                sqlDA.SelectCommand.Parameters.AddWithValue(
                    "@section",
                    SectionTextBox.Text);

                sqlDA.SelectCommand.Parameters.AddWithValue(
                    "@date",
                    AttendanceDatePicker.Value.Date);

                DataTable dtTb = new DataTable();
                sqlDA.Fill(dtTb);

                AttendnceDataGridView.DataSource = dtTb;
            }

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO StudentClassDB(Student_ID, Department, Class_Name,Section) SELECT Student_ID,@department, @className, @section FROM UserDB  WHERE User_Identity = 'Student' AND Student_ID NOT IN(SELECT Student_ID FROM StudentClassDB WHERE Department = @department AND Class_Name = @className AND Section = @section)";

            using (SqlConnection con =
                new SqlConnection(connectionString))
            {
                SqlCommand cmd =
                    new SqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@department",
                    DepartmentTextBox.Text);

                cmd.Parameters.AddWithValue(
                    "@className",
                    SubjectNameTextBox.Text);

                cmd.Parameters.AddWithValue(
                    "@section",
                    SectionTextBox.Text);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadAttendanceData();
        }

        private void SaveAttancanceButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (DataGridViewRow row in AttendnceDataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    string studentName = row.Cells["Student_Name"].Value?.ToString();
                    string studentID = row.Cells["Student_ID"].Value?.ToString();

                    bool Present = false;

                    if (row.Cells["Present"].Value != null)
                    {
                        Present = Convert.ToBoolean(row.Cells["Present"].Value);
                    }

                    string attendanceStatus = Present ? "Present" : "Absent";

                    string query = @"INSERT INTO AttendDB
                            (Department, Class_Name, Section, Attendance_Date,Student_Name, Student_ID, Attendance_Status)
                            VALUES
                            (@Department, @SubjectName, @Section, @Date,@StudentName, @StudentID, @AttendanceStatus)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Department", DepartmentTextBox.Text);
                        cmd.Parameters.AddWithValue("@SubjectName", SubjectNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Section", SectionTextBox.Text);
                        cmd.Parameters.AddWithValue("@Date", AttendanceDatePicker.Value.Date);
                        cmd.Parameters.AddWithValue("@StudentName", studentName);
                        cmd.Parameters.AddWithValue("@StudentID", studentID);
                        cmd.Parameters.AddWithValue("@AttendanceStatus", attendanceStatus);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Attendance Saved Successfully!");
            }
        }

        private void ViewAttendanceButton_Click(object sender, EventArgs e)
        {
            string query = @"SELECT 
                     Student_ID AS [Student ID],
                     Student_Name AS [Student Name],
                     Department,
                     Class_Name AS [Subject Name],
                     Section,
                     Attendance_Date AS [Date],
                     Attendance_Status AS [Attendance Status]
                     FROM AttendDB";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlDataAdapter sqlDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();

                sqlDA.Fill(dt);

                AttendnceDataGridView.DataSource = dt;

            }
        }

        private void DeleteAttendanceButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = @"DELETE FROM AttendDB
                             WHERE Department = @Department
                             AND Class_Name = @ClassName
                             AND Section = @Section
                             AND Attendance_Date = @Date";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Department", DepartmentTextBox.Text);
                    cmd.Parameters.AddWithValue("@ClassName", SubjectNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Section", SectionTextBox.Text);
                    cmd.Parameters.AddWithValue("@Date", AttendanceDatePicker.Value.Date);

                    cmd.ExecuteNonQuery();
                }
            }

            AttendnceDataGridView.DataSource = null;

        }
    }
}
