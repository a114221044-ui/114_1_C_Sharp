using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string city; // the selected city

            // 修正: 檢查是否有選取項目
            if (cityListBox.SelectedIndex != -1)
            {
                city = cityListBox.SelectedItem.ToString();
                // 這裡可以加入後續處理 city 的程式碼
                
                switch(city)
                {                    
                    case "丹佛":
                        timeZoneLabel.Text = "山區時間 (UTC-7)";
                        break;
                    case "檀香山":
                        timeZoneLabel.Text = "夏威夷-阿留申標準時間 (UTC-10)";
                        break;
                    case "明尼亞波利斯":
                        timeZoneLabel.Text = "中部時間 (UTC-6)";
                        break;
                    case "紐約":
                        timeZoneLabel.Text = "東部時間 (UTC-5)";
                        break;
                    case "舊金山":
                        timeZoneLabel.Text = "太平洋時間 (UTC-8)";
                        break;
                    default:
                        timeZoneLabel.Text = "未知的城市";
                        break;
                }
            }
            else
            {
                MessageBox.Show("請選擇一個城市。");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
