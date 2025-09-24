using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial_2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            countryLabel.Font = new Font(countryLabel.Font.FontFamily, 24);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "芬蘭";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "法國";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "德國";
        }
    }
}
