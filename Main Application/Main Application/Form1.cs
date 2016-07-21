using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Application
{
    public partial class Form1 : Form
    {
        public string myConnectionString = "server=localhost;database=kundebestillinger;uid=root;pwd=toor;";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appendData();   
        }

        private void appendData()
        {

            MySqlConnection conn;
            conn = new MySqlConnection(myConnectionString);
            try
            {
                conn.Open();
                String navn = textBox1.Text.ToString();
                String telefon = textBox2.Text.ToString();
                String varekode = textBox3.Text.ToString();
                String beskrivelse = textBox4.Text.ToString();
                String leverandor = textBox5.Text.ToString();
                String dato = dateTimePicker1.Text.ToString();
                String kundebehandler = comboBox1.Text.ToString();
                String status = comboBox2.Text.ToString();
                String kommentar = richTextBox1.Text.ToString();
                String my_querry = "INSERT INTO kundebestillinger(navn,telefon,varekode,beskrivelse,leverandor,dato,kundebehandler,status,kommentar)VALUES('" + navn + "','" + telefon + "','" + varekode + "','" + beskrivelse + "','" + leverandor + "','" + dato + "','" + kundebehandler + "','" + status + "','" + kommentar + "')";


                MySqlCommand cmd = new MySqlCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kundebestiling opprettet!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Noe var galt: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            richTextBox1.Text = "";
        }

        private void avsluttToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void visKundebestillingerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 visning = new Form2();
            visning.Show();
        }

        private void oppdaterBestillingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }
    }
}
