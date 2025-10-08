using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENTS = 5.0m;
        const decimal TEN_CENTS = 10.0m;
        const decimal TWENTY_FIVE_CENTS = 25.0m;
        const decimal FIFTY_CENTS = 50.0m;
        private decimal total;

        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            
            total = total = FIVE_CENTS;
            totalLabel.Text = total.ToString();

        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
           
            total = total + TEN_CENTS;
            totalLabel.Text = total.ToString();
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
           
            total = total + TWENTY_FIVE_CENTS;
            totalLabel.Text = total.ToString();
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
           
            total = total + FIFTY_CENTS;
            totalLabel.Text = total.ToString();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
