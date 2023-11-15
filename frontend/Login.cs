using System;
using System.Windows.Forms;
using Npgsql;

namespace frontend
{
    public partial class Login : Form
    {
        public static string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=CaloriePlaner";
        public static NpgsqlConnection conn = new NpgsqlConnection(connstring);

        public Login()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            string query = "SELECT * FROM User WHERE username = @username AND password = @password";
            await using var conn = new NpgsqlConnection(connstring);
            await conn.OpenAsync();

            await using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            await using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                MessageBox.Show("Login successful!");
                this.Close();
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
