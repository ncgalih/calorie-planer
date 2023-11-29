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

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteColumn";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;

            dgvFood.Columns.Add(deleteButtonColumn);

            dgvFood.CellContentClick += new DataGridViewCellEventHandler(dgvFood_CellContentClick);

            LoadData();
        }
        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFood.Columns["DeleteColumn"].Index && e.RowIndex >= 0)
            {

                string foodName = dgvFood.Rows[e.RowIndex].Cells["name"].Value.ToString();

                DB.DeleteFood(foodName);

                LoadData();
            }
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

            double totalCalories = 0;
            foreach (DataRow row in data.Rows)
            {
                double calorie = Convert.ToDouble(row["calorie"]);
                totalCalories += calorie;
            }

            // Menampilkan total kalori ke dalam tbTotalCalorie
            tbTotalCalorie.Text = totalCalories.ToString();
        }

        private void tbTotalCalorie_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
