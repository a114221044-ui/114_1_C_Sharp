using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊「檢查資格」按鈕時觸發此事件
        private void checkButton_Click(object sender, EventArgs e)
        {
            // 定義最低年薪常數（單位：元）
            const decimal MIN_SALARY = 1200000m; // 最低年薪
            // 定義現職最低年數常數
            const int MIN_YEARS = 2;             // 最低年資

            decimal salary; // 年薪
            int yearsOOnJob;      // 年資

            try
            {
                salary = decimal.Parse(salaryTextBox.Text);
                yearsOOnJob = int.Parse(yearsTextBox.Text);

                if (salary >= MIN_SALARY && yearsOOnJob >= MIN_YEARS)
                {
                    decisionLabel.Text = "符合資格";
                }
                else
                {
                    decisionLabel.Text = "不符合資格";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // 當使用者點擊「清除」按鈕時觸發此事件
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清空年薪與現職年數輸入框，以及決策標籤
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";

            // 將游標焦點設回年薪輸入框，方便使用者繼續輸入
            salaryTextBox.Focus();
        }

        // 當使用者點擊「離開」按鈕時觸發此事件
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單，結束程式
            this.Close();
        }
    }
}
