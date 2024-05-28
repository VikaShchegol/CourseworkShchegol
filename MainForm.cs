using System;
using System.Data.Common;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace course
{
    public partial class MainForm : Form
    {
        private bool isLoggedIn = false; 
        private MySqlConnection conn;
        private int userId;
        private string userRole;

        public MainForm()
        {
            InitializeComponent();
            conn = DBUtils.GetDBConnection();
        }
        private void buttonVouchers_Click(object sender, EventArgs e)
        {
                VouchersForm vouchersForm = new VouchersForm(conn, false);
                vouchersForm.Show();
                this.Hide();
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            ServicesForm servicesForm = new ServicesForm(conn, isLoggedIn);
            servicesForm.Show();
            this.Hide();
        }

        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm(conn);
            scheduleForm.Show();
            this.Hide();
        }

        private void вхідToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (LoginForm loginForm = new LoginForm(conn))
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    isLoggedIn = true;
                    userId = loginForm.UserId;
                    userRole = loginForm.UserRole;

                    MessageBox.Show($"Вхід виконано. ID користувача: {userId}, роль: {userRole}");


                    switch (userRole)
                    {
                        case "Співробітник":
                        case "Адмін":
                            EmployeeForm employeeForm = new EmployeeForm(userId, userRole);
                            employeeForm.Show();
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        private void реєстраціяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }
    }
}
