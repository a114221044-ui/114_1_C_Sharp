using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnShowMax.Click += BtnShowMax_Click;
            this.btnExit.Click += BtnExit_Click;
        }

        private void BtnShowMax_Click(object sender, EventArgs e)
        {
            string surname = txtLastName.Text;
            string givenName = txtFirstName.Text;
            int quiz1 = 0, quiz2 = 0, quiz3 = 0; // 明確初始化 quiz2

            if (
                int.TryParse(txtQuiz1.Text, out quiz1) &&
                int.TryParse(txtQuiz2.Text, out quiz2) &&
                int.TryParse(txtQuiz3.Text, out quiz3))
            {
                ShowResults(surname, givenName, quiz1, quiz2, quiz3);
            }
            else
            {
                MessageBox.Show("Please enter valid integer scores for all quizzes.", "Input Error");
                ClearTextBoxes();
            }
            MessageBox.Show(string.Format("小考2 = {0}", quiz2)); // 修正格式化字串
        }

        private void ShowResults(string surname, string givenName, int quiz1, int quiz2, int quiz3)
        {
            int highestScore;
            if (quiz1 >= quiz2 && quiz1 >= quiz3)
            {
                highestScore = quiz1;
            }
            else if (quiz2 >= quiz1 && quiz2 >= quiz3)
            {
                highestScore = quiz2;
            }
            else
            {
                highestScore = quiz3;
            }
            lblResult.Text = string.Format("The highest quiz score for {0} {1} is: {2}", givenName, surname, highestScore);
        }

        // 新增 btnShowMax_Click 事件處理方法
        private void btnShowMax_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入
            string lastName = txtLastName.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            int quiz1, quiz2, quiz3;

            // 驗證分數輸入
            bool valid1 = int.TryParse(txtQuiz1.Text.Trim(), out quiz1);
            bool valid2 = int.TryParse(txtQuiz2.Text.Trim(), out quiz2);
            bool valid3 = int.TryParse(txtQuiz3.Text.Trim(), out quiz3);

            if (!valid1 || !valid2 || !valid3)
            {
                lblResult.Text = "請輸入有效的分數（整數）";
                return;
            }

            // 顯示結果
            ShowResults(lastName, firstName, quiz1, quiz2, quiz3);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 新增 btnExit_Click 事件處理方法
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // 新增此方法於 Form1 類別內
        private void ClearTextBoxes()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtQuiz1.Text = "";
            txtQuiz2.Text = "";
            txtQuiz3.Text = "";
        }
    }
}

