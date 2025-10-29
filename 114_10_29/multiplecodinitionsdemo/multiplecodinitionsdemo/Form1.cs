using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplecodinitionsdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJudge_Click(object sender, EventArgs e)
        {
            try
            {
                int score = int.Parse(txtScore.Text);
                string grade;
                if (score >= 90) grade = "A";
                else if (score >= 80) grade = "B";
                else if (score >= 70) grade = "C";
                else if (score >= 60) grade = "D";
                else grade = "F";
                lblGrade.Text = grade;

                MessageBox.Show($"成績等級：{grade}");
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入有效的整數成績。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblGrade.Text = "";
                return;
            }
        }
        
    }
}

