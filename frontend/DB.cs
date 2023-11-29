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
            bool status = false;
            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO food (name, calorie, fat, carbo, protein, username) VALUES (@name, @calorie, @fat, @carbo, @protein, @username)";

                cmd.Parameters.AddWithValue("@name", food.FoodName);
                cmd.Parameters.AddWithValue("@calorie", food.Calorie);
                cmd.Parameters.AddWithValue("@fat", food.Fat);
                cmd.Parameters.AddWithValue("@carbo", food.Carbohydrate);
                cmd.Parameters.AddWithValue("@protein", food.Protein);
                cmd.Parameters.AddWithValue("@username", Dashboard.username);

                if (cmd.ExecuteNonQuery() == 1)
                    status = true;
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return status;
        }

        public static DataTable SelectFood()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT name, calorie, fat, carbo, protein FROM food WHERE username = @username";
                cmd.Parameters.AddWithValue("@username", Dashboard.username);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public static bool DeleteFood(string foodName)
        {
            bool status = false;
            try
            {
                conn.Open();
                var cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM food WHERE name = @name AND username = @username";

                cmd.Parameters.AddWithValue("@name", foodName);
                cmd.Parameters.AddWithValue("@username", Dashboard.username);

                if (cmd.ExecuteNonQuery() > 0)
                    status = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            return status;
        }
    }
}
