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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void addFood_Click(object sender, EventArgs e)
        {
            FoodInfo foodInfo = new FoodInfo();
            foodInfo.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            List<Makanan> list = DB.SelectFood();
            groupBox1.Text = "List Food";
            foreach (Makanan makanan in list)
            {
                groupBox1.Text += "\n-" + makanan.FoodName + "\t" +makanan.Calorie +"\t"+ makanan.Fat + "\t" +makanan.Carbohydrate + "\t" +makanan.Protein;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
