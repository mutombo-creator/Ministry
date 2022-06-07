using System;
using System.Windows.Forms;

namespace Ministry
{
    public partial class CreateAcount : Form
    {
        public CreateAcount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Code.Text == "PGONDWE2022")
            {
                Algorithm_cLasss cl = new Algorithm_cLasss();
                cl.SavingAcount(UserName.Text, Pass.Text);
                MessageBox.Show("Acount Created");
            }
            else
            {
                MessageBox.Show("Access Code Incorect");
            }
        }
    }
}
