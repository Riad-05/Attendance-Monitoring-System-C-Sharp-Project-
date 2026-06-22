using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Attendance_Monitoring_System
{
    public partial class DashboardForm : Form
    {
        public String UserName, Identity;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = UserName;
            IdentityLabel.Text = Identity;

            if (Identity == "Admin")
            {
                DashBoardButton.Visible = true;
                AddClassButton.Visible = true;
                AddStudentButton.Visible = true;
                AddFacultyButton.Visible = true;
                AttendanceButton.Visible = true;
                ReportButton.Visible = true;
            }

            if (Identity == "Faculty")
            {
                DashBoardButton.Visible = true;
                AddClassButton.Visible = false;
                AddStudentButton.Visible = false;
                AddFacultyButton.Visible = false;
                AttendanceButton.Visible = true;
                ReportButton.Visible = true;
            }

            if (Identity == "Student")
            {
                DashBoardButton.Visible = true;
                AddClassButton.Visible = false;
                AddStudentButton.Visible = false;
                AddFacultyButton.Visible = false;
                AttendanceButton.Visible = false;
                ReportButton.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(DashBoardButton);
            dashBoardUserControl1.count();
            dashBoardUserControl1.Visible = true;
            addClassUserControl1.Visible = false;
            addFacultyUserControl1.Visible = false;
            addStudentUserControl1.Visible = false;
            attendanceUserControl1.Visible = false;
            reportUserControl1.Visible = false;
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(AddClassButton);
            addClassUserControl1.Visible = true;
            dashBoardUserControl1.Visible = false;
            addFacultyUserControl1.Visible = false;
            addStudentUserControl1.Visible = false;
            attendanceUserControl1.Visible = false;
            reportUserControl1.Visible = false;
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(AddStudentButton);
            addStudentUserControl1.Visible = true;
            dashBoardUserControl1.Visible = false;
            addClassUserControl1.Visible = false;
            addFacultyUserControl1.Visible = false;
            attendanceUserControl1.Visible = false;
            reportUserControl1.Visible = false;

        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(ReportButton);
            reportUserControl1.Visible = true;
            dashBoardUserControl1.Visible = false;
            addClassUserControl1.Visible = false;
            addFacultyUserControl1.Visible = false;
            addStudentUserControl1.Visible = false;
            attendanceUserControl1.Visible = false;
        }

        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(AttendanceButton);
            attendanceUserControl1.Visible = true;
            dashBoardUserControl1.Visible = false;
            addFacultyUserControl1.Visible = false;
            addClassUserControl1.Visible = false;
            addStudentUserControl1.Visible = false;
            reportUserControl1.Visible = false;
        }

        private void AddFacultyButton_Click(object sender, EventArgs e)
        {
            MoveSidePanel(AddFacultyButton);
            addFacultyUserControl1.Visible = true;
            dashBoardUserControl1.Visible = false;
            addClassUserControl1.Visible = false;
            addStudentUserControl1.Visible = false;
            attendanceUserControl1.Visible = false;
            reportUserControl1.Visible = false;
        }


        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            ExpandPanel.Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }

        private void MoveSidePanel(Control button)
        {
            SliderPanel1.Location = new Point(button.Location.X - button.Location.X, button.Location.Y - 95);
        }

        private void ExpandBox_Click(object sender, EventArgs e)
        {
            if (ExpandPanel.Visible)
            {
                ExpandPanel.Visible = false;
            }
            else
            {
                ExpandPanel.Visible = true;
            }
        }

        private void IDLabel_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportUserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
