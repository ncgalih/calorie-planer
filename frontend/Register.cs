using System;
using System.Windows.Forms;
using Npgsql;

namespace frontend
{
    public partial class Register : Form
    {
        public static string connstring = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=CaloriePlaner";
        public static NpgsqlConnection conn = new NpgsqlConnection(connstring);

        public Register()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            await using var conn = new NpgsqlConnection(connstring);
            await conn.OpenAsync();

            var checkCmd = new NpgsqlCommand("SELECT * FROM User WHERE username = @username", conn);
            checkCmd.Parameters.AddWithValue("@username", tbUsername.Text);

            await using var reader = await checkCmd.ExecuteReaderAsync();
            if (await reader.ReadAsync())
            {
                MessageBox.Show("Username already exists!");
                return;
            }
            reader.Close();

            var insertCmd = new NpgsqlCommand("INSERT INTO User (first_name, last_name, username, password) VALUES (@first_name, @last_name, @username, @password)", conn);
            insertCmd.Parameters.AddWithValue("@first_name", tbFirstName.Text);
            insertCmd.Parameters.AddWithValue("@last_name", tbLastName.Text);
            insertCmd.Parameters.AddWithValue("@username", tbUsername.Text);
            insertCmd.Parameters.AddWithValue("@password", tbPassword.Text);
            await insertCmd.ExecuteNonQueryAsync();

            MessageBox.Show("Registration successful!");

            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}
