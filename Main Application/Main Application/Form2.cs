using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Application
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kundebestillingerDataSet.kundebestillinger' table. You can move, or remove it, as needed.
            this.kundebestillingerTableAdapter.Fill(this.kundebestillingerDataSet.kundebestillinger);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.kundebestillingerTableAdapter.Fill(this.kundebestillingerDataSet.kundebestillinger);

        }

        public string selectedID;
        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedID = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
            Form3 frm3 = new Form3(selectedID.ToString);
            label1.Text = "Valgt id: " + selectedID;
            //frm3.textBox1.Text = selectedID;
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }
    }
}
