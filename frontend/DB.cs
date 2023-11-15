using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace frontend
{
    internal class DB
    {
        public static string connstring = "Host=157.230.243.49;Port=5432;Username=postgres;Password=NcFighter;Database=calorie-planer";
        public static NpgsqlConnection conn = new NpgsqlConnection(connstring);

        public static bool insertFood(Makanan food)
        {
            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO food (name, calorie, fat, carbo, protein) VALUES (@name, @calorie, @fat, @carbo, @protein)";

                cmd.Parameters.AddWithValue("@name", food.FoodName);
                cmd.Parameters.AddWithValue("@calorie", food.Calorie);
                cmd.Parameters.AddWithValue("@fat", food.Fat);
                cmd.Parameters.AddWithValue("@carbo", food.Carbohydrate);
                cmd.Parameters.AddWithValue("@protein", food.Protein);

                if (cmd.ExecuteNonQuery() == 1)
                    return true;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return false;
        }

        public static List<Makanan> SelectFood()
        {
            List<Makanan> list = new List<Makanan>();
            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM food";
                NpgsqlDataReader reader = cmd.ExecuteReader();

                // Membaca hasil query
                while (reader.Read())
                {
                    Makanan food = new Makanan(reader.GetString(0));
                    food.Calorie = reader.GetFloat(1);
                    food.Fat = reader.GetFloat(2);
                    food.Carbohydrate = reader.GetFloat(3);
                    food.Protein = reader.GetFloat(4);
                    list.Append(food);
                }

                // Tutup koneksi dan reader setelah selesai menggunakan
                reader.Close();
                conn.Close();
                return list;
            }
            catch { 
                
            }
            return list;
            }
    }
}
