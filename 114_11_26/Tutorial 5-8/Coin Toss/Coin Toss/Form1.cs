using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        private int headsCount = 0;
        private int tailsCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            int sideUp;
            Random randomNumber = new Random();
            sideUp = randomNumber.Next(2);

            if (sideUp == 0)
            {
                headsPictureBox.Visible = false;
                tailsPictureBox.Visible = true;
                tailsCount++;
                tailsCountValueLabel.Text = tailsCount.ToString();
            }
            else
            {
                headsPictureBox.Visible = true;
                tailsPictureBox.Visible = false;
                headsCount++;
                headsCountValueLabel.Text = headsCount.ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
