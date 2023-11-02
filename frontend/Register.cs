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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            if(tbConfirmPassword.Text != tbPassword.Text)
            {
                MessageBox.Show("Konfirm passoword salah", "Confirm Password", MessageBoxButtons.OK);
                return;
            }
            User user = new User();
            user.FirstName = tbFirstName.Text;
            user.LastName = tbLastName.Text;
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;

            User.Register(user);
        }
    }
}
