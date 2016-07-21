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
    public partial class Form3 : Form
    {
        private Func<string> toString;

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(Func<string> toString)
        {
            this.toString = toString;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }


        public void orderUpdate()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source= C:\Users\Public\Documents\kundebestillinger.accdb";

            Form2 frm2 = new Form2();


            try
            {
                conn.Open();
                String navn = textBox1.Text.ToString();
                String telefon = textBox2.Text.ToString();
                String my_querry = "UPDATE kundebestillinger SET navn = '" + navn + "'";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kundebestiling opprettet!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noe var galt: " + ex.Message);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderUpdate();
        }
    }
}
