using Microsoft.Data.SqlClient;

namespace Attendance_Monitoring_System
{
    public partial class LoginForm : Form
    {
        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True;TrustServerCertificate=True;";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text == string.Empty
               || PasswordTextBox.Text == string.Empty)
            {
                MessageBox.Show("User name and password both requried");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string loginQuery = $"SELECT * " +
                    $"FROM UserDB " +
                    $"WHERE Student_Name = @userName " +
                    $"AND Student_Pass = @password";

                using (SqlCommand cmd = new SqlCommand(loginQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@userName", UserNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text);

                    SqlDataReader reader = cmd.ExecuteReader();
                    //int count = (int)cmd.ExecuteScalar();

                    if (reader.Read())
                    {
                        string userName = reader["Student_Name"].ToString();
                        string identity = reader["User_Identity"].ToString();

                        DashboardForm dashboardform = new DashboardForm();

                        dashboardform.UserName = userName;
                        dashboardform.Identity = identity;
                        dashboardform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed, please try again!");
                    }
                    connection.Close();
                }
            }
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void ForgetLabel_Click(object sender, EventArgs e)
        {
            FogetForm forgetForm = new FogetForm();
            forgetForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
