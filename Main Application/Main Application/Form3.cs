using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Application
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myConnectionString = "server=localhost;database=kundebestillinger;uid=root;pwd=toor;";

            MySqlConnection cnn;
            cnn = new MySqlConnection(myConnectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Opened! ");
                cnn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Cannot open connection... " + ex);
            }
        }


    }
}
