using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ministry
{
    public partial class Home_Page : Form
    {
        private bool _dragging = false;
        private Point _offset;
        private Point _start_point = new Point(0, 0);

        public Home_Page()
        {
            InitializeComponent();

            home_control1.BringToFront();
            register_member1.Visible = false;
            data_Control1.Visible = false;

        }

        private void Dashboad_Click(object sender, EventArgs e)
        {
            pos_indicator.Height = Dashboad.Height;
            pos_indicator.Location = Dashboad.Location;
            home_control1.BringToFront();
            home_control1.Visible = true;
            register_member1.Visible = false;
            data_Control1.Visible = false;
        }

        private void Register_Click(object sender, EventArgs e)
        {

            pos_indicator.Height = Register.Height;
            pos_indicator.Location = Register.Location;
            register_member1.BringToFront();
            register_member1.Visible = true;
            data_Control1.Visible = false;
            home_control1.Visible = false;



        }

        private void Members_Click(object sender, EventArgs e)
        {
            pos_indicator.Height = Members.Height;
            pos_indicator.Location = Members.Location;

            data_Control1.BringToFront();
            register_member1.Visible = false;
            home_control1.Visible = false;
            data_Control1.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Home_Page_Load(object sender, EventArgs e)
        {

        }
        public void MyContrlSettings()
        {
            this.register_member1.BringToFront();
        }

        private void data_Control1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;  // _dragging is your variable flag
            _start_point = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
