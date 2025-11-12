using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            const decimal INTEREST_RATE = 0.005m;      //假設月利率為0.5%      
            decimal startingBalance;
            int months;
            int count = 1;

            if (decimal.TryParse(startingBalTextBox.Text, out startingBalance))
            {
                if (int.TryParse(monthsTextBox.Text, out months) && months > 0)
                {
                    detailListBox.Items.Clear();
                    while (count <= months)
                    {
                        startingBalance *= (1 + INTEREST_RATE);
                        detailListBox.Items.Add("第" + count + "個月結餘:" + startingBalance.ToString("c"));
                        count++;
                    }
                    // Display the ending balance.
                    endingBalanceLabel.Text = startingBalance.ToString("c2");
                }
                else
                {
                    // Invalid months value was entered.
MessageBox.Show("請輸入有效的月份數量(正整數)。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    monthsTextBox.Focus();
                }
            }
            else
            {
                               // Invalid starting balance value was entered.
                MessageBox.Show("請輸入有效的起始餘額和月份數量。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                startingBalTextBox.Focus();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the TextBoxes, the endingBalanceLabel control,
            // and the ListBox.
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // Reset the focus.
            startingBalTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
