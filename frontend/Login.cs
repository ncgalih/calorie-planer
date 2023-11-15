using System;
using System.Windows.Forms;
using Npgsql;

namespace frontend
{
    public partial class Login : Form
    {
        public static string connstring = "Host=157.230.243.49;Port=5432;Username=postgres;Password=NcFighter;Database=calorie-planer";
        public static NpgsqlConnection conn = new NpgsqlConnection(connstring);

        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            string query = "SELECT * FROM tb_user WHERE username = @username AND password = @password";
            await using var conn = new NpgsqlConnection(connstring);
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            await using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                MessageBox.Show("Login successful!");
                this.Hide();
                Dashboard dashboardForm = new Dashboard();
                dashboardForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.Show();
        }
    }
}
