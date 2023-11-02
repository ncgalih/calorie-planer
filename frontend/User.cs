using frontend;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Cryptography;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public double TotalCalories { get; set; }
    
    private static List<User> userList = new List<User>();

    public static bool Register(User user)
    {
        try
        {
            DB.conn.Open();
            string sql = @"select * from st_register(:_firstname, :_lastname, :_username, :_password)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql,DB.conn);
            cmd.Parameters.AddWithValue("_firstname", user.FirstName);
            cmd.Parameters.AddWithValue("_lastname", user.LastName);
            cmd.Parameters.AddWithValue("_username", user.Username);
            cmd.Parameters.AddWithValue("_password", user.Password);

            if((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("Register user berhasil", "Register", MessageBoxButtons.OK);
            }
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error: " + ex.Message, "Register Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    public static bool Login(string username, string password)
    {
        User user = userList.Find(u => u.Username == username && u.Password == password);

        if (user != null)
        {
            Console.WriteLine($"Selamat datang, {user.FirstName} {user.LastName}!");
            return true;
        }
        else
        {
            Console.WriteLine("Username atau password salah. Silakan coba lagi.");
            return false;
        }
    }

    public void CalorieCount(double calories)
    {
        TotalCalories += calories;
        Console.WriteLine($"Total kalori saat ini: {TotalCalories} kalori.");
    }
}
