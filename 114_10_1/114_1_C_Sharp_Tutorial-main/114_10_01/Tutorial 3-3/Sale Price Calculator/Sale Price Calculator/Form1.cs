using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent(); // 初始化表單上的所有控制項
        }

        // 當使用者點擊「計算特價」按鈕時觸發此事件
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 這裡可以加入計算特價的程式碼
            decimal originalPrice;
            decimal discountPercentage;
            decimal salePrice;

            //嘗試將使用者輸入的原價和折扣百分比轉換為decimal類型
            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);

            //計算特價
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);

            //顯示特價，格式化為貨幣格式
            salePriceLabel.Text = salePrice.ToString("C");
        }

        // 當使用者點擊「離開」按鈕時觸發此事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
