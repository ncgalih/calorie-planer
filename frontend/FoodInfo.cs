using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontend
{
    public partial class FoodInfo : Form
    {
        public Makanan food { get; set; }

        public FoodInfo()
        {
            InitializeComponent();
        }

        private void FoodInfo_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFood_Click(object sender, EventArgs e)
        {
            DB.insertFood(food);
            Dashboard.dashboard.LoadData();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            food = FoodAPI.getFoodInfo(tbFoodName.Text);

            calorieText.Text = food.Calorie.ToString();
            carboText.Text = food.Carbohydrate.ToString();
            fatText.Text = food.Fat.ToString();
            proteinText.Text = food.Protein.ToString();
        }
    }
}
