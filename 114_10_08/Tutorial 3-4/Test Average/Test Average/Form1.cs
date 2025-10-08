using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
        //建構子:初始化表單元件
    {
        public Form1()
        {
            InitializeComponent();


            //計算按鈕的事件處理涵式
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double test1, test2, test3;

            try
            {
                test1 = Convert.ToDouble(test1TextBox.Text);
                test2 = Convert.ToDouble(test2TextBox.Text);
                test3 = Convert.ToDouble(test3TextBox.Text);

                double average = (test1 + test2 + test3) / 3.0;
                averageLabel.Text = average.ToString("n2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "舉例發生");
            }
        }
            
                

            
        

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the input and output controls.
            test1TextBox.Text = "";
            test2TextBox.Text = "";
            test3TextBox.Text = "";
            averageLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            test1TextBox.Focus();
            this.Close();
        }
    }
}
