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
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string account = textBoxAccount.Text;
            string password = textBoxPassword.Text;

            //if (account == "admin" && password == "12345678")
            //{
            //labelResult.Text = "登入成功！";
            //labelResult.ForeColor = Color.Green;
            //}
            //else
            //{
            //labelResult.Text = "登入失敗，請檢查帳號或密碼。";
            //labelResult.ForeColor = Color.Red;
            if (account.Length == 0 || password.Length == 0)
            {
                labelResult.Text = "請輸入帳號及密碼";
            }
            else
            {
                if (string.Compare(account, "admin") == 0)
                {
                    if (string.Compare(password, "12345678") == 0)
                    {
                        labelResult.Text = "登入成功！";
                        labelResult.ForeColor = Color.Green;
                    }
                    else
                    {
                        labelResult.Text = "密碼錯誤";
                    }
                }
                else
                {
                    labelResult.Text = "帳號錯誤";
                }

            }
        }
    }
}

