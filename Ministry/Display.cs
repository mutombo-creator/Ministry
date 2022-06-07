using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;


namespace Ministry
{
    public partial class Display : Form
    {
        OleDbConnection conection;
        OleDbDataAdapter adapter;
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            conection = new OleDbConnection(Algorithm_cLasss.oleStr);
            conection.Open();
            adapter = new OleDbDataAdapter("Select * from Members", conection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Exporting data to excell
            if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Application.Workbooks.Add(Type.Missing);

                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    excelApp.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;

                }

                for (int o = 0; o < dataGridView1.Rows.Count; o++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excelApp.Cells[o + 2, j + 1] = dataGridView1.Rows[o].Cells[j].Value.ToString();

                    }


                }

                excelApp.Columns.AutoFit();
                excelApp.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_BeginPrint(object sender, PrintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
