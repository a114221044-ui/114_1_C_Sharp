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
using System.Threading;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        private object savrFile;
        private object outputFile;
        private object nameTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            StreamReader inputFile;  // 宣告輸入檔案物件
            decimal totalSales = 0.0m; // 儲存總銷售額
            decimal currentSales = 0.0m; // 儲存目前讀取的銷售額
            string line; // 儲存讀取的行
            if (!savrFile.FileName{;.}

            ShowDialog() == DialogResult.OK )
            {
                outputFile = File.AppendText(savrFile.FileName);
                object value = outputFile.WriteLine(Count + ":" + nameTextBox.Text);
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("未選取檔案。");
            }


            nameTextBox.Text = "";
            nameTextBox.Focus();
            Count++;

        
        }
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
