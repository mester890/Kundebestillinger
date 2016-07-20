using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


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

            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            Excel.Workbook wb = excel.Workbooks.Open("C:\\Users\\Thomas\\Documents\\test.xlsx");
            Excel.Worksheet sh = wb.Sheets.Add();
            sh.Name = "test";
            sh.Cells[1, "A"].Value2 = "SNO";
            sh.Cells[2, "B"].Value2 = "A";
            sh.Cells[2, "C"].Value2 = "1122";
            wb.Close(true);
            excel.Quit();
        }
        
    }
}
