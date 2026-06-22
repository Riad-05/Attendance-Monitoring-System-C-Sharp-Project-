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
    public partial class DashBoardUserControl : UserControl
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;";

        public DashBoardUserControl()
        {
            InitializeComponent();
        }

        public void count()
        {
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();

            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM ClassesDB", con);
            int totalClasses = (int)cmd1.ExecuteScalar();
            TotalClassesLabel.Text = totalClasses.ToString();

            SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM UserDB WHERE User_Identity = 'Student'", con);
            int totalStudents = (int)cmd2.ExecuteScalar();
            TotalStudentsLabel.Text = totalStudents.ToString();

            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM UserDB WHERE User_Identity = 'Faculty'", con);
            int totalFaculties = (int)cmd3.ExecuteScalar();
            TotalfacultiesLabel.Text = totalFaculties.ToString();

            con.Close();
        }

        private void DashBoardUserControl_Load(object sender, EventArgs e)
        {
            count();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
