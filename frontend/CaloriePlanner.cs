using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frontend
{
    internal class CaloriePlanner
    {
        private static User currentUser;
        private static Makanan foundFood;

        public static User CurrentUser { get { return currentUser; } }
        public static Makanan FoundFood { get { return foundFood; }

        public static List<Makanan> ListMakanan { get; } = new();

        public static bool cariMakanan(string foodName)
        {
            // cari data makanan dari API

            // if found
            if (true)
            {
                foundFood = new Makanan();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void simpanMakanan()
        {
            ListMakanan.Append(foundFood);
            currentUser.CalorieCount(foundFood.Calorie);
        }

        public static void removeMakanan(int id)
        {
            currentUser.TotalCalories -= ListMakanan[id].Calorie;
            ListMakanan.RemoveAt(id);
        }

        public static double hitungKaloriTotal()
        {
            return currentUser.TotalCalories;
        }
    }
}
