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
        public static Dashboard dashboard;
        public static string username;
        public Dashboard(string _username)
        {
            dashboard = this;
            username = _username;
            InitializeComponent();
            LoadData();
        }

        private void addFood_Click(object sender, EventArgs e)
        {
            FoodInfo foodInfo = new FoodInfo();
            foodInfo.Show();
        }

        public void LoadData()
        {
            DataTable data = DB.SelectFood();
            dgvFood.DataSource = data;
        }
    }
}
