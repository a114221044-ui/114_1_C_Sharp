using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        // 費用常數
        private const decimal OIL_CHANGE = 780m;
        private const decimal LUBRICATION = 540m;
        private const decimal RADIATOR = 900m;
        private const decimal TRANS = 2400m;
        private const decimal INSPECTION = 450m;
        private const decimal MUFFLER = 3000m;
        private const decimal TIRE_ROTATE = 600m;
        private const decimal HOURLY_RATE = 600m;
        private const decimal PARTS_TAX_RATE = 0.06m;

        private readonly CultureInfo taiwanCi = new CultureInfo("zh-TW");

        public Form1()
        {
            InitializeComponent();
            // 預設計算一次以初始化顯示
            UpdateTotals();
            this.FormClosing += Form1_FormClosing;
        }

        private void Control_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotals();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            UpdateTotals();
            MessageBox.Show("已更新費用摘要。", "計算完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // 清除所有勾選與欄位
            chkOilChange.Checked = false;
            chkLubrication.Checked = false;
            chkRadiator.Checked = false;
            chkTrans.Checked = false;
            chkInspection.Checked = false;
            chkMuffler.Checked = false;
            chkTireRotate.Checked = false;

            txtParts.Text = "0";
            txtHours.Text = "0";

            UpdateTotals();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveReportToDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // 判斷是否需要詢問儲存：若有選擇或輸入非零
            bool hasSelection = chkOilChange.Checked || chkLubrication.Checked ||
                                chkRadiator.Checked || chkTrans.Checked ||
                                chkInspection.Checked || chkMuffler.Checked || chkTireRotate.Checked;

            decimal parts = ParseDecimal(txtParts.Text);

            decimal hours = ParseDecimal(txtHours.Text);

            if (hasSelection || parts > 0m || hours > 0m)
            {
                var dr = MessageBox.Show("是否在離開前儲存維修明細？\n選擇「取消」可中斷關閉動作。", "儲存明細", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (!SaveReportToDialog())
                    {
                        // 若使用者在儲存視窗取消，則不要關閉
                        e.Cancel = true;
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                // No -> 直接離開
            }
        }

        private void UpdateTotals()
        {
            // 計算服務費用
            decimal serviceFees = 0m;
            if (chkOilChange.Checked) serviceFees += OIL_CHANGE;
            if (chkLubrication.Checked) serviceFees += LUBRICATION;
            if (chkRadiator.Checked) serviceFees += RADIATOR;
            if (chkTrans.Checked) serviceFees += TRANS;
            if (chkInspection.Checked) serviceFees += INSPECTION;
            if (chkMuffler.Checked) serviceFees += MUFFLER;
            if (chkTireRotate.Checked) serviceFees += TIRE_ROTATE;

            // 解析零件與工時（容錯）
            decimal parts = ParseDecimal(txtParts.Text);
            decimal hours = ParseDecimal(txtHours.Text);

            decimal labor = hours * HOURLY_RATE;
            decimal serviceAndLabor = serviceFees + labor;
            decimal tax = Math.Round(parts * PARTS_TAX_RATE, 0); // 無小數
            decimal total = serviceAndLabor + parts + tax;

            // 顯示格式化金額（台灣）
            txtServiceLabor.Text = serviceAndLabor.ToString("C0", taiwanCi);
            txtPartsCost.Text = parts.ToString("C0", taiwanCi);
            txtTax.Text = tax.ToString("C0", taiwanCi);
            txtTotal.Text = total.ToString("C0", taiwanCi);
        }

        private decimal ParseDecimal(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0m;
            s = s.Trim();
            decimal v;
            // 嘗試以當地格式解析，也接受純數字
            if (decimal.TryParse(s, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, taiwanCi, out v))
            {
                if (v < 0) return 0m;
                return v;
            }
            // 若解析失敗，嘗試去掉非數字字元
            var cleaned = new System.Text.RegularExpressions.Regex(@"[^\d\.]").Replace(s, "");
            if (decimal.TryParse(cleaned, NumberStyles.Number, CultureInfo.InvariantCulture, out v))
            {
                if (v < 0) return 0m;
                return v;
            }
            return 0m;
        }

        private bool SaveReportToDialog()
        {
            UpdateTotals();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog1.FileName, BuildReportContent(), Encoding.UTF8);
                    MessageBox.Show("已儲存維修明細。", "儲存成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("儲存失敗：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return false;
        }

        private string BuildReportContent()
        {
            var sb = new StringBuilder();
            sb.AppendLine("=== 汽車維修服務明細 ===");
            sb.AppendLine("日期：" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
            sb.AppendLine();

            sb.AppendLine("服務項目：");
            if (chkOilChange.Checked) sb.AppendLine($" - 更換機油：{OIL_CHANGE.ToString("C0", taiwanCi)}");
            if (chkLubrication.Checked) sb.AppendLine($" - 潤滑保養：{LUBRICATION.ToString("C0", taiwanCi)}");
            if (chkRadiator.Checked) sb.AppendLine($" - 水箱清洗：{RADIATOR.ToString("C0", taiwanCi)}");
            if (chkTrans.Checked) sb.AppendLine($" - 變速箱清洗：{TRANS.ToString("C0", taiwanCi)}");
            if (chkInspection.Checked) sb.AppendLine($" - 檢驗：{INSPECTION.ToString("C0", taiwanCi)}");
            if (chkMuffler.Checked) sb.AppendLine($" - 更換消音器：{MUFFLER.ToString("C0", taiwanCi)}");
            if (chkTireRotate.Checked) sb.AppendLine($" - 輪胎換位：{TIRE_ROTATE.ToString("C0", taiwanCi)}");
            if (!chkOilChange.Checked && !chkLubrication.Checked && !chkRadiator.Checked && !chkTrans.Checked && !chkInspection.Checked && !chkMuffler.Checked && !chkTireRotate.Checked)
            {
                sb.AppendLine(" - 無");
            }

            sb.AppendLine();
            decimal parts = ParseDecimal(txtParts.Text);
            decimal hours = ParseDecimal(txtHours.Text);
            decimal labor = hours * HOURLY_RATE;

            sb.AppendLine("零件金額：" + parts.ToString("C0", taiwanCi));
            sb.AppendLine("工時：" + hours.ToString("0.##") + " 小時");
            sb.AppendLine("工時費率：" + HOURLY_RATE.ToString("C0", taiwanCi));
            sb.AppendLine("工資合計：" + labor.ToString("C0", taiwanCi));
            sb.AppendLine();

            // 已計算的欄位
            // 重新計算以確保一致
            decimal serviceFees = 0m;
            if (chkOilChange.Checked) serviceFees += OIL_CHANGE;
            if (chkLubrication.Checked) serviceFees += LUBRICATION;
            if (chkRadiator.Checked) serviceFees += RADIATOR;
            if (chkTrans.Checked) serviceFees += TRANS;
            if (chkInspection.Checked) serviceFees += INSPECTION;
            if (chkMuffler.Checked) serviceFees += MUFFLER;
            if (chkTireRotate.Checked) serviceFees += TIRE_ROTATE;

            decimal serviceAndLabor = serviceFees + labor;
            decimal tax = Math.Round(parts * PARTS_TAX_RATE, 0);
            decimal total = serviceAndLabor + parts + tax;

            sb.AppendLine("服務與工資合計：" + serviceAndLabor.ToString("C0", taiwanCi));
            sb.AppendLine("稅金 (6%)：" + tax.ToString("C0", taiwanCi));
            sb.AppendLine("總費用：" + total.ToString("C0", taiwanCi));
            sb.AppendLine();
            sb.AppendLine("=== 感謝您的使用 ===");

            return sb.ToString();
        }

        private void TextBox_Numeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允許數字、控制鍵、小數點（單一）
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // 單一小數點
            var tb = sender as TextBox;
            if (e.KeyChar == '.' && tb != null && tb.Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
