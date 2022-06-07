using System;
using System.Windows.Forms;

namespace Ministry
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Algorithm_cLasss cl = new Algorithm_cLasss();
            if (cl.ReadAndLogIn(User.Text, pass.Text))
            {
                Home_Page home = new Home_Page();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or password");
            }

        }

        private void User_Enter(object sender, EventArgs e)
        {
            if (User.Text == "User Name")
            {
                User.Text = "";
            }
        }

        private void User_Leave(object sender, EventArgs e)
        {
            if (User.Text == "")
            {
                User.Text = "User Name";
            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Password")
            {
                pass.Text = "";
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {
            if (pass.Text == "")
            {
                pass.Text = "Password";
            }
        }
    }
}
