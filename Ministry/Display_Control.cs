using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Ministry
{
    public partial class Display_Control : UserControl
    {
        OleDbConnection conection;
        OleDbDataAdapter adapter;
        public Display_Control()
        {
            conection = new OleDbConnection(Algorithm_cLasss.oleStr);
            conection.Open();
            adapter = new OleDbDataAdapter("Select * from Members", conection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conection.Close();

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Delete_Click(object sender, System.EventArgs e)
        {
            Algorithm_cLasss cl = new Algorithm_cLasss();
           

            if (cl.DeleteMember(textBox1.Text))
            {
                MessageBox.Show("Member Deleted");

                conection = new OleDbConnection(Algorithm_cLasss.oleStr);
                conection.Open();
                adapter = new OleDbDataAdapter("Select * from Members", conection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                conection.Close();

            }

            else
            {
                MessageBox.Show("Not Saved Make sure You Enter or three names");
            }
        }
    }
}
