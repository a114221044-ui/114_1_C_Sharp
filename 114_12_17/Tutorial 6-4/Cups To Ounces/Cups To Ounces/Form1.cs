using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cups_To_Ounces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The CupsToOunces method accepts a number
        // of cups as an argument and returns the
        // equivalent number of fluid ounces.
     

        private void convertButton_Click(object sender, EventArgs e)
        {
          double cups;    // To hold the number of cups
            double ounces;  // To hold the number of ounces

            if(double.TryParse(cupsTextBox.Text, out cups))
            {
                // Call the CupsToOunces method
                ounces = CupsToOunces(cups);
                // Display the result.
                ouncesLabel.Text = ounces.ToString("n2");
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Please enter a valid number for cups.");

            }
        }


        private double CupsToOunces(double cups)
        {
            double onces = cups * 8;
            return onces;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
