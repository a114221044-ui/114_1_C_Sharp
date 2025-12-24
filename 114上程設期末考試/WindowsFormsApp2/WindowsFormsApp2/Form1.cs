using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Label[] lblNumbers;

        public Form1()
        {
            InitializeComponent(); // 保留由設計工具產生的初始化
            InitializeCustomComponents(); // 自訂元件/狀態初始化
        }

        private void InitializeCustomComponents()
        {
            // 建立並置放 5 個顯示號碼的 Label，使用 18pt 字級以符合可讀性需求
            lblNumbers = new Label[5];
            int startX = 20;
            int startY = 16;
            int gapX = 140;
            for (int i = 0; i < lblNumbers.Length; i++)
            {
                lblNumbers[i] = new Label
                {
                    Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold),
                    Size = new Size(110, 50),
                    Location = new Point(startX + i * gapX, startY),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BorderStyle = BorderStyle.FixedSingle,
                    Text = string.Empty
                };
                this.Controls.Add(lblNumbers[i]);
            }
            // 將以下程式碼片段：
            // if (btnGenerateNumbers != null && btnGenerateNumbers.Click == null)
            //     btnGenerateNumbers.Click += btnGenerateNumbers_Click;
            // if (btnOpenFile != null && btnOpenFile.Click == null)
            //     btnOpenFile.Click += btnOpenFile_Click;
            // if (btnExit != null && btnExit.Click == null)
            //     btnExit.Click += btnExit_Click;

            // 修正為（移除 Click == null 的檢查，直接用 += 綁定事件，這樣不會重複綁定且不會產生 CS0079）：

            if (btnGenerateNumbers != null)
                btnGenerateNumbers.Click += btnGenerateNumbers_Click;
            if (btnOpenFile != null)
                btnOpenFile.Click += btnOpenFile_Click;
            if (btnExit != null)
                btnExit.Click += btnExit_Click;
            // 設定由 Designer 建立的元件字級與初始狀態（若存在）
            if (btnGenerateNumbers != null)
                btnGenerateNumbers.Font = new Font(btnGenerateNumbers.Font.FontFamily, 18F, btnGenerateNumbers.Font.Style);
            if (btnOpenFile != null)
                btnOpenFile.Font = new Font(btnOpenFile.Font.FontFamily, 18F, btnOpenFile.Font.Style);
            if (btnExit != null)
                btnExit.Font = new Font(btnExit.Font.FontFamily, 18F, btnExit.Font.Style);
            if (listBoxLotteryNumbers != null)
                listBoxLotteryNumbers.Font = new Font(listBoxLotteryNumbers.Font.FontFamily, 18F, listBoxLotteryNumbers.Font.Style);
            if (lblResult != null)
            {
                lblResult.Font = new Font(lblResult.Font.FontFamily, 18F, lblResult.Font.Style);
                lblResult.Text = string.Empty;
            }

            // 確保按鈕事件已綁定（Designer 通常已綁定）
            // 若 Designer 未綁定，底下程式碼可以補上事件綁定：
            // 將下列程式碼片段：
            // if (btnGenerateNumbers != null && btnGenerateNumbers.Click == null)
            //     btnGenerateNumbers.Click += btnGenerateNumbers_Click;
            // if (btnOpenFile != null && btnOpenFile.Click == null)
            //     btnOpenFile.Click += btnOpenFile_Click;
            // if (btnExit != null && btnExit.Click == null)
            //     btnExit.Click += btnExit_Click;

            // 修正為（移除 Click == null 的檢查，直接用 += 綁定事件，這樣不會重複綁定且不會產生 CS0079）：

            if (btnGenerateNumbers != null)
                btnGenerateNumbers.Click += btnGenerateNumbers_Click;
            if (btnOpenFile != null)
                btnOpenFile.Click += btnOpenFile_Click;
            if (btnExit != null)
                btnExit.Click += btnExit_Click;
            // 將下列程式碼片段：
            // if (btnGenerateNumbers != null && btnGenerateNumbers.Click == null)
            //     btnGenerateNumbers.Click += btnGenerateNumbers_Click;
            // if (btnOpenFile != null && btnOpenFile.Click == null)
            //     btnOpenFile.Click += btnOpenFile_Click;
            // if (btnExit != null && btnExit.Click == null)
            //     btnExit.Click += btnExit_Click;

            // 全部移除，因為 .Click 事件不能這樣判斷（會產生 CS0079），只需保留如下：

            if (btnGenerateNumbers != null)
                btnGenerateNumbers.Click += btnGenerateNumbers_Click;
            if (btnOpenFile != null)
                btnOpenFile.Click += btnOpenFile_Click;
            if (btnExit != null)
                btnExit.Click += btnExit_Click;
            if (btnGenerateNumbers != null && btnGenerateNumbers. == null)
                btnGenerateNumbers.Click += btnGenerateNumbers_Click;
            if (btnOpenFile != null && btnOpenFile. == null)
                btnOpenFile.Click += btnOpenFile_Click;
            if (btnExit != null && btnExit.)
                btnExit.Click += btnExit_Click;
        }

        private void btnGenerateNumbers_Click(object sender, EventArgs e)
        {
            // 使用基本陣列與迴圈實作不重複亂數產生（1-49）
            Random random = new Random();
            int[] generatedNumbers = new int[5];

            for (int i = 0; i < generatedNumbers.Length; i++)
            {
                int number;
                bool exists;
                do
                {
                    number = random.Next(1, 50); // 1 到 49
                    exists = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (generatedNumbers[j] == number)
                        {
                            exists = true;
                            break;
                        }
                    }
                } while (exists);
                generatedNumbers[i] = number;
                lblNumbers[i].Text = number.ToString();
            }

            // 若已載入開獎號碼，立即比對並顯示結果
            if (listBoxLotteryNumbers != null && listBoxLotteryNumbers.Items.Count == 5)
            {
                CompareNumbers();
            }
            else if (lblResult != null)
            {
                lblResult.Text = "請載入開獎號碼檔案以比對結果。";
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "文字檔案 (*.txt)|*.txt",
                Title = "選擇開獎號碼檔案"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            string path = openFileDialog.FileName;
            try
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("檔案不存在。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = File.ReadAllLines(path);
                if (lines.Length != 5)
                {
                    MessageBox.Show("檔案內容必須為 5 行，每行一個數字。", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int[] lotteryNumbers = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    string text = lines[i].Trim();
                    int num;
                    if (!int.TryParse(text, out num))
                    {
                        MessageBox.Show(string.Format("第 {0} 行為非數字內容：\"{1}\"", i + 1, lines[i]), "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (num < 1 || num > 49)
                    {
                        MessageBox.Show(string.Format("第 {0} 行的數字超出範圍 (1-49)：{1}", i + 1, num), "數字範圍錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // 檢查檔案內是否有重複數字
                    for (int j = 0; j < i; j++)
                    {
                        if (lotteryNumbers[j] == num)
                        {
                            MessageBox.Show(string.Format("開獎檔案含重複數字：第 {0} 行 與 第 {1} 行 數字相同 ({2})", i + 1, j + 1, num), "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    lotteryNumbers[i] = num;
                }

                // 顯示在 ListBox（每行只放數字）
                listBoxLotteryNumbers.Items.Clear();
                for (int i = 0; i < 5; i++)
                {
                    listBoxLotteryNumbers.Items.Add(lotteryNumbers[i].ToString());
                }

                // 若已產生號碼，自動比對
                bool userHasNumbers = true;
                for (int i = 0; i < lblNumbers.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lblNumbers[i].Text))
                    {
                        userHasNumbers = false;
                        break;
                    }
                }
                if (userHasNumbers)
                {
                    CompareNumbers();
                }
                else if (lblResult != null)
                {
                    lblResult.Text = "已載入開獎號碼，請按「產生號碼」產生您的號碼以比對。";
                }
            }
            catch (IOException ioEx)
            {
                MessageBox.Show("檔案讀取失敗: " + ioEx.Message, "IO 錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CompareNumbers()
        {
            // 檢查介面狀態
            if (listBoxLotteryNumbers == null || listBoxLotteryNumbers.Items.Count != 5)
            {
                MessageBox.Show("請先載入有效的開獎號碼檔案（5 個號碼）。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int[] userNumbers = new int[5];
            for (int i = 0; i < lblNumbers.Length; i++)
            {
                if (!int.TryParse(lblNumbers[i].Text, out userNumbers[i]))
                {
                    MessageBox.Show("請先按「產生號碼」以建立您的號碼。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            int[] lotteryNumbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                int.TryParse(listBoxLotteryNumbers.Items[i].ToString(), out lotteryNumbers[i]);
            }

            // 計算中獎數量（使用基本迴圈）
            int matchCount = 0;
            for (int i = 0; i < userNumbers.Length; i++)
            {
                for (int j = 0; j < lotteryNumbers.Length; j++)
                {
                    if (userNumbers[i] == lotteryNumbers[j])
                    {
                        matchCount++;
                        break;
                    }
                }
            }

            string prize;
            if (matchCount == 5)
                prize = "恭喜！中頭獎！";
            else if (matchCount == 4)
                prize = "中四個號碼！";
            else if (matchCount == 3)
                prize = "中三個號碼！";
            else
                prize = "沒中獎！";

            if (lblResult != null)
                lblResult.Text = string.Format("比對結果：\r\n中 {0} 個號碼\r\n{1}", matchCount, prize);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
