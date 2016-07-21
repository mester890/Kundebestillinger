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
    public partial class Form2 : Form
    {
        Form1 frm1 = new Form1();


        public Form2()
        {
            InitializeComponent();
            getRecords();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void getRecords()
        {
            MySqlConnection con = new MySqlConnection(frm1.myConnectionString);
            con.Open();
            MySqlCommand command = new MySqlCommand();

            command.Connection = con;
            MySqlDataAdapter MyDA = new MySqlDataAdapter();
            string sqlSelectAll = "SELECT * from kundebestillinger";
            MyDA.SelectCommand = new MySqlCommand(sqlSelectAll, con);

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;


            dataGridView1.DataSource = bSource;
        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            DataRow row = currentDataRowView.Row;
            textBox6.Text = row[0].ToString();
            textBox1.Text = row[1].ToString();
            textBox2.Text = row[2].ToString();
            textBox3.Text = row[3].ToString();
            textBox4.Text = row[4].ToString();
            textBox5.Text = row[5].ToString();
            dateTimePicker1.Text = row[6].ToString();
            comboBox1.Text = row[7].ToString();
            comboBox2.Text = row[8].ToString();
            richTextBox1.Text = row[9].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            updateRecord();
        }

        public void updateRecord()
        {
            MySqlConnection conn;
            conn = new MySqlConnection(frm1.myConnectionString);


            try
            {
                conn.Open();
                String id = textBox6.Text.ToString();
                String navn = textBox1.Text.ToString();
                String telefon = textBox2.Text.ToString();
                String varekode = textBox3.Text.ToString();
                String beskrivelse = textBox4.Text.ToString();
                String leverandor = textBox5.Text.ToString();
                String dato = dateTimePicker1.Text.ToString();
                String kundebehandler = comboBox1.Text.ToString();
                String status = comboBox2.Text.ToString();
                String kommentar = richTextBox1.Text.ToString();
                String my_querry = "UPDATE kundebestillinger SET navn = '" + navn + 
                    "', telefon = '" + telefon + 
                    "', varekode = '" + varekode + 
                    "', beskrivelse = '" + beskrivelse + 
                    "', leverandor = '" + leverandor + 
                    "', dato = '" + dato + 
                    "', kundebehandler = '" + kundebehandler + 
                    "', status = '" + status + 
                    "', kommentar = '" + kommentar + "' WHERE ID = " + id +"";

                MySqlCommand cmd = new MySqlCommand(my_querry, conn);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kundebestiling oppdatert!");
                getRecords();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            deleteRecord();
        }
        public void deleteRecord()
        {
            MySqlConnection conn;
            conn = new MySqlConnection(frm1.myConnectionString);

            try
            {
                conn.Open();
                String id = textBox6.Text.ToString();
                String navn = textBox1.Text.ToString();
                String telefon = textBox2.Text.ToString();
                String varekode = textBox3.Text.ToString();
                String beskrivelse = textBox4.Text.ToString();
                String leverandor = textBox5.Text.ToString();
                String dato = dateTimePicker1.Text.ToString();
                String kundebehandler = comboBox1.Text.ToString();
                String status = comboBox2.Text.ToString();
                String kommentar = richTextBox1.Text.ToString();
                String my_querry = "DELETE FROM kundebestillinger WHERE ID = " + id;

                MySqlCommand cmd = new MySqlCommand(my_querry, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kundebestiling slettet!");
                getRecords();
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

        private void button3_Click(object sender, EventArgs e)
        {
            getRecords();
        }
    }
}
