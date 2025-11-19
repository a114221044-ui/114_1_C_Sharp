using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 計算按鈕點擊事件處理
            StreamReader inputFile;
            decimal totalSales = 0;
            decimal currentSales = 0;

            try
            {
                inputFile = File.OpenText("Sales.txt");
                while (!inputFile.EndOfStream)
                {
                    string line = inputFile.ReadLine();
                    currentSales = decimal.Parse(inputFile.ReadLine());
                    totalSales += currentSales;
                    totalSales += currentSales;

                }
                inputFile.Close();
                totalLabel.Text = totalSales.ToString("C");
            }
            catch(Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message);
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
