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
        public Makanan makanan { get; set; }

        public FoodInfo(Makanan _makanan)
        {
            makanan = _makanan;
            InitializeComponent();
        }

        private void FoodInfo_Load(object sender, EventArgs e)
        {
            foodname.Text = makanan.FoodName;
            calorieText.Text = makanan.Calorie.ToString();
            carboText.Text = makanan.Carbohydrate.ToString();
            fatText.Text = makanan.Fat.ToString();
            proteinText.Text = makanan.Protein.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFood_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
