using System;
using System.Collections.Generic;

public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public double TotalCalories { get; set; }
    
    private static List<User> userList = new List<User>();

    public static bool Register(string firstName, string lastName, string username, string password, string confirmPassword)
    {
        if (userList.Exists(u => u.Username == username))
        {
            Console.WriteLine("Username sudah digunakan. Silakan pilih username lain.");
            return false;
        }

        if (password != confirmPassword)
        {
            Console.WriteLine("Password dan konfirmasi password tidak cocok.");
            return false;
        }

        User newUser = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Username = username,
            Password = password,
            TotalCalories = 0 // 
        };

        userList.Add(newUser);
        Console.WriteLine("Registrasi berhasil.");
        return true;
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
