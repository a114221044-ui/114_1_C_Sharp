using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    /// <summary>
    /// 主表單：提供計算燃油效率的功能（例如：公里/公升）。
    /// 注意：變數命名使用 kms 和 liters，代表 公里 和 公升（km / L）。
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單元件（由 Designer 自動產生的 InitializeComponent 方法）。
        /// InitializeComponent 會建立與配置畫面上的控制項，並將事件處理器連接起來。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        public int Kms { get; private set; }
        public int Liters { get; private set; }

        /// <summary>
        /// 計算按鈕的點擊事件處理器。
        /// - 從 milesTextBox 與 gallonsTextBox 讀取使用者輸入字串。
        /// - 使用 double.TryParse 逐一驗證並轉換數值（避免拋出例外）。
        /// - 若輸入有效則計算 kms / liters，並以兩位小數顯示為「公里/公升」。
        /// - 若任一輸入無效則顯示錯誤訊息並將焦點移回該 TextBox。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kms;
            double liters = 0; // 修正：初始化 liters 以避免 CS0165
            double fuelEconomy;

            if (double.TryParse(milesTextBox.Text, out kms))
            {
                if (double.TryParse(gallonsTextBox.Text, out liters))
                {
                    if (liters == 0)
                    {
                        MessageBox.Show("公升數不可為0");
                        gallonsTextBox.Focus();
                        return;
                    }
                    fuelEconomy = kms / liters;
                    mpgLabel.Text = fuelEconomy.ToString("n2") + " 公里/公升";
                }
                else
                {
                    MessageBox.Show("請輸入有效的公升數值。");
                    gallonsTextBox.Focus();
                }
            }
            else
            {
                MessageBox.Show("請輸入有效的公里數值。");
                milesTextBox.Focus();
            }
            if(Kms <=0)
            {
                MessageBox.Show("公里數必須大於0");
                milesTextBox.Focus();
                return;
            }
            if(Liters <=0)
            {
                MessageBox.Show("公升數必須大於0");
                gallonsTextBox.Focus();
                return;
            }
        }

       
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
