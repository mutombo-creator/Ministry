using System;
using System.Windows.Forms;

namespace Ministry
{
    public partial class Register_member : UserControl
    {
        Algorithm_cLasss cs = new Algorithm_cLasss();
        public Register_member()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output = cs.SaveDataToDatabase(fname.Text, mname.Text, lname.Text, Status.Text, long.Parse(contact.Text), location.Text, Gender.Text, int.Parse(age.Text));
            MessageBox.Show(output);
        }

        private void fname_MouseEnter(object sender, EventArgs e)
        {
            if (fname.Text == "First Name")
            {
                fname.Text = "";
            }

        }


        private void mname_MouseEnter(object sender, EventArgs e)
        {

            if (mname.Text == "Middle Name(Optional)")
            {
                mname.Text = "";
            }

        }
        private void mname_MouseLeave(object sender, EventArgs e)
        {

            if (mname.Text == "")
            {
                mname.Text = "Middle Name(Optional)";
            }

        }
        private void lname_MouseEnter(object sender, EventArgs e)
        {


        }
        private void lname_MouseLeave(object sender, EventArgs e)
        {


        }

        private void fname_MouseHover(object sender, EventArgs e)
        {

        }

        private void fname_MouseLeave_1(object sender, EventArgs e)
        {

            if (fname.Text == "")
            {
                fname.Text = "First Name";
            }
        }

        private void mname_Enter(object sender, EventArgs e)
        {
            if (mname.Text == "Middle Name(Optional)")
            {
                mname.Text = "";
            }
        }

        private void mname_Leave(object sender, EventArgs e)
        {
            if (mname.Text == "")
            {
                mname.Text = "Middle Name(Optional)";
            }
        }

        private void lname_Enter(object sender, EventArgs e)
        {
            if (lname.Text == "Last Name")
            {
                lname.Text = "";
            }
        }

        private void lname_Leave(object sender, EventArgs e)
        {
            if (lname.Text == "")
            {
                lname.Text = "Last Name";
            }
        }

        private void contact_Enter(object sender, EventArgs e)
        {
            if (contact.Text == "Contact")
            {
                contact.Text = "";
            }
        }

        private void contact_Leave(object sender, EventArgs e)
        {
            if (contact.Text == "")
            {
                contact.Text = "Contact";
            }
        }

        private void location_Enter(object sender, EventArgs e)
        {
            if (location.Text == "Location")
            {
                location.Text = "";
            }
        }

        private void location_Leave(object sender, EventArgs e)
        {
            if (location.Text == "")
            {
                location.Text = "Location";
            }
        }

        private void Gender_Enter(object sender, EventArgs e)
        {
            if (Gender.Text == "Gender(M or F)")
            {
                Gender.Text = "";
            }
        }

        private void Gender_Leave(object sender, EventArgs e)
        {
            if (Gender.Text == "")
            {
                Gender.Text = "Gender(M or F)";
            }
        }

        private void age_Enter(object sender, EventArgs e)
        {
            if (age.Text == "Age")
            {
                age.Text = "";
            }
        }

        private void age_Leave(object sender, EventArgs e)
        {
            if (age.Text == "")
            {
                age.Text = "Age";
            }
        }
    }
}
