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
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            @"Data source= C:\Users\Public\Documents\test.accdb";

            try
            {
                conn.Open();
                String ticketno = textBox1.Text.ToString();
                String Purchaseprice = textBox2.Text.ToString();
                String my_querry = "INSERT INTO test(Navn,Kontakt)VALUES('" + ticketno + "','" + Purchaseprice + "')";



                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
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
    }
}
