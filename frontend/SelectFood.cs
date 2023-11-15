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
    public partial class SelectFood : Form
    {
        public SelectFood()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectFood_Load(object sender, EventArgs e)
        {
            listFoundFood.Items.Add("Makanan 1");
            listFoundFood.Items.Add("Makanan 2");
        }

        private void selectedFood(object sender, EventArgs e)
        {
            if (listFoundFood.SelectedIndex != -1)
            {
                Makanan makanan = new Makanan(listFoundFood.SelectedItem.ToString());
                makanan.Calorie = 10;
                makanan.Carbohydrate = 20;
                makanan.Fat = 30;
                makanan.Protein = 40;
                FoodInfo foodInfo = new FoodInfo(makanan);
                this.Close();
                foodInfo.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Makanan food = FoodAPI.getFoodInfo(tbFoodName.Text);
            MessageBox.Show(food.Calorie.ToString() + "\n" + food.Fat.ToString() + '\n' + food.Carbohydrate.ToString());
        }
    }
}
