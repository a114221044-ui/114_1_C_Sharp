using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = "點餐內容: ";
            string drink = "";
            string sandwich = "";

            if ( coffeeradioButton.Checked)
             {
                drink = "咖啡 "; 
            }
            else if (miketearadioButton.Checked)
            {
                drink = "奶茶 ";
            }
          else if(redtearadioButton.Checked)
                    {
                drink = "紅茶 ";
                }
            else if(juiceradioButton.Checked)
                {
                drink = "果汁 ";
            }
            else {
                drink = "無飲料 ";
            }
            
            if (hamSandwichcheckBox.Checked)
            {
                sandwich += "火腿三明治 ";
            }
            else if (tunaradioButton.Checked)
            {
                sandwich = "鮪魚三明治 ";
            }
            else if (jellyradioButton.Checked)
            {
                sandwich += "果醬三明治 ";
            }
            else
            {
                sandwich += "無三明治 ";
            }
            message += drink + "、" + sandwich;
            MessageBox.Show(message);

            {

            }
        }
    }
}
