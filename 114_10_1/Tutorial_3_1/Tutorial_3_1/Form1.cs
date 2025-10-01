using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string dayOfWeek = dayOfweekTextbox.Text;
            string month = monthTextbox.Text;
            string year = yearTextbox.Text; 
            string dayOfMonth = dayOfweekTextbox.Text;

            string output = "中華民國" + year + " 年 " + month + " 月 " + dayOfMonth + " 日 " + " 星期 " + dayOfWeek;

            Dateoutputlabel.Text = output;


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            dayOfweekTextbox.Text = "";
            dayTextbox.Text = "";
            monthTextbox.Text = "";
            yearTextbox.Text = "";
            Dateoutputlabel.Text = "";


        }
    }
}
