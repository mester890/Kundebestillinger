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
    }
}
