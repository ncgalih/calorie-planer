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
            SelectFood selectFood = new SelectFood();
            selectFood.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display food info and it calories from postgres database here
            

        }
    }
}
