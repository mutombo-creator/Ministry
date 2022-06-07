using System;
using System.Windows.Forms;

namespace Ministry
{
    public partial class Start : Form
    {

        Timer timer1 = new Timer();




        public Start()
        {
            InitializeComponent();
            timer1.Interval = 10000; //10 sec interval

            timer1.Tick += new EventHandler(Tick); //Tick event

            timer1.Start(); //start timer

        }

        private void Tick(object sender, EventArgs e)
        {

            label2.Text += ".";

            Home_Page Next = new Home_Page();
            Next.Show();
            this.Hide();
            // this.Dispose();
            timer1.Stop(); //Stop timer after tick once
        }

    }
}
