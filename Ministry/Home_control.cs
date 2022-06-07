using System;
using System.Windows.Forms;

namespace Ministry
{
    public partial class Home_control : UserControl
    {

        data_Control dc = null;

        public Home_Page home { get; set; }
        public Home_control()
        {

            InitializeComponent();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Display dis = new Display();
            dis.ShowDialog();
            dis.BringToFront();

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            CreateAcount cr = new CreateAcount();
            cr.Show();
        }
    }
}
