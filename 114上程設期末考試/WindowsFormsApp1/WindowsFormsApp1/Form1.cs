using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum Choice { Rock = 0, Paper = 1, Scissors = 2 }

        private readonly Random _rnd = new Random();
        private int _playerWins = 0;
        private int _cpuWins = 0;

        private PictureBox pbPlayer;
        private PictureBox pbCPU;
        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private Button btnExit;
        private Label lblResult;
        private Label lblScore;

        public Form1()
        {
            InitializeComponent();
            CreateRuntimeUI();
            ResetRoundDisplay();
        }

        private void CreateRuntimeUI()
        {
            // Form
            this.Text = "猜拳遊戲";
            this.ClientSize = new Size(520, 300);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Player PictureBox
            pbPlayer = new PictureBox
            {
                Location = new Point(30, 30),
                Size = new Size(180, 180),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.White
            };
            this.Controls.Add(pbPlayer);

            // CPU PictureBox
            pbCPU = new PictureBox
            {
                Location = new Point(310, 30),
                Size = new Size(180, 180),
                BorderStyle = BorderStyle.FixedSingle,
                SizeMode = PictureBoxSizeMode.CenterImage,
                BackColor = Color.White
            };
            this.Controls.Add(pbCPU);

            // Result label
            lblResult = new Label
            {
                Location = new Point(30, 220),
                Size = new Size(380, 30),
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };
            this.Controls.Add(lblResult);

            // Score label
            lblScore = new Label
            {
                Location = new Point(420, 220),
                Size = new Size(100, 30),
                Font = new Font("Segoe UI", 9),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblScore);

            // Buttons for choices
            btnRock = new Button
            {
                Text = "石頭",
                Location = new Point(30, 260),
                Size = new Size(110, 28)
            };
            btnRock.Click += (s, e) => PlayRound(Choice.Rock);
            this.Controls.Add(btnRock);

            btnPaper = new Button
            {
                Text = "布",
                Location = new Point(150, 260),
                Size = new Size(110, 28)
            };
            btnPaper.Click += (s, e) => PlayRound(Choice.Paper);
            this.Controls.Add(btnPaper);

            btnScissors = new Button
            {
                Text = "剪刀",
                Location = new Point(270, 260),
                Size = new Size(110, 28)
            };
            btnScissors.Click += (s, e) => PlayRound(Choice.Scissors);
            this.Controls.Add(btnScissors);

            // Exit button
            btnExit = new Button
            {
                Text = "結束遊戲",
                Location = new Point(390, 260),
                Size = new Size(110, 28)
            };
            btnExit.Click += (s, e) => ExitGame();
            this.Controls.Add(btnExit);
        }

        private void ResetRoundDisplay()
        {
            // 初始圖片區域為空白
            DisposeImageIfAny(pbPlayer);
            DisposeImageIfAny(pbCPU);
            pbPlayer.Image = null;
            pbCPU.Image = null;

            lblResult.Text = "請選擇：石頭 / 布 / 剪刀";
            UpdateScoreLabel();
        }

        private void UpdateScoreLabel()
        {
            lblScore.Text = $"你 { _playerWins } : CPU { _cpuWins }";
        }

        private void PlayRound(Choice playerChoice)
        {
            var cpuChoice = (Choice)_rnd.Next(0, 3);

            // 顯示雙方圖片：先嘗試載入自定義圖片，沒有時用程式繪圖
            var playerImg = LoadCustomOrGeneratedImage(playerChoice, pbPlayer.Width - 6, pbPlayer.Height - 6);
            var cpuImg = LoadCustomOrGeneratedImage(cpuChoice, pbCPU.Width - 6, pbCPU.Height - 6);

            DisposeImageIfAny(pbPlayer);
            DisposeImageIfAny(pbCPU);

            pbPlayer.Image = playerImg;
            pbCPU.Image = cpuImg;

            // 判斷結果
            var resultText = DetermineRoundResult(playerChoice, cpuChoice);
            lblResult.Text = $"你: {ChoiceToString(playerChoice)}  電腦: {ChoiceToString(cpuChoice)}  ⇒  {resultText}";

            UpdateScoreLabel();
        }

        private string DetermineRoundResult(Choice player, Choice cpu)
        {
            if (player == cpu) return "平手";

            // 石頭贏剪刀、剪刀贏布、布贏石頭
            bool playerWins =
                (player == Choice.Rock && cpu == Choice.Scissors) ||
                (player == Choice.Scissors && cpu == Choice.Paper) ||
                (player == Choice.Paper && cpu == Choice.Rock);

            if (playerWins)
            {
                _playerWins++;
                return "你贏了！";
            }
            else
            {
                _cpuWins++;
                return "你輸了。";
            }
        }

        private string ChoiceToString(Choice c)
        {
            switch (c)
            {
                case Choice.Rock: return "石頭";
                case Choice.Paper: return "布";
                case Choice.Scissors: return "剪刀";
                default: return "";
            }
        }

        // -------------- 新增或修改：優先從執行目錄載入自定義圖片，若不存在則呼叫 CreateChoiceImage 繪圖 --------------
        private Bitmap LoadCustomOrGeneratedImage(Choice c, int width, int height)
        {
            Image src = null;
            bool disposeSrc = false;

            // 1) 嘗試從專案資源取得（需在 __Project__ > __Properties__ > __Resources__ 中新增命名為 rock/paper/scissors 的圖片）
            try
            {
                switch (c)
                {
                    case Choice.Rock: src = Properties.Resources.rock; break;
                    case Choice.Paper: src = Properties.Resources.paper; break;
                    case Choice.Scissors: src = Properties.Resources.scissors; break;
                }
            }
            catch
            {
                src = null;
            }

            // 2) 若資源不存在，再嘗試從執行目錄載入檔案（rock.png / paper.png / scissors.png）
            if (src == null)
            {
                string fileName = c == Choice.Rock ? "rock.png" : c == Choice.Paper ? "paper.png" : "scissors.png";
                string path = Path.Combine(Application.StartupPath, fileName);
                if (File.Exists(path))
                {
                    try
                    {
                        src = Image.FromFile(path);
                        disposeSrc = true; // 從檔案載入要在繪製後釋放
                    }
                    catch
                    {
                        src = null;
                    }
                }
            }

            // 3) 若取得到圖片，等比縮放並回傳 Bitmap；否則回退到程式繪圖
            if (src != null)
            {
                try
                {
                    var bmp = new Bitmap(Math.Max(1, width), Math.Max(1, height));
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(Color.White);
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                        float srcAspect = (float)src.Width / src.Height;
                        float dstAspect = (float)bmp.Width / bmp.Height;
                        Rectangle dstRect;
                        if (srcAspect > dstAspect)
                        {
                            int newW = bmp.Width;
                            int newH = (int)(bmp.Width / srcAspect);
                            dstRect = new Rectangle(0, (bmp.Height - newH) / 2, newW, newH);
                        }
                        else
                        {
                            int newH = bmp.Height;
                            int newW = (int)(bmp.Height * srcAspect);
                            dstRect = new Rectangle((bmp.Width - newW) / 2, 0, newW, newH);
                        }

                        g.DrawImage(src, dstRect);
                    }
                    return bmp;
                }
                finally
                {
                    if (disposeSrc)
                    {
                        try { src.Dispose(); } catch { }
                    }
                }
            }

            // 最後回退：使用程式繪圖產生圖案
            return CreateChoiceImage(c, width, height);
        }
        // --------------------------------------------------------------------------------------------

        private Bitmap CreateChoiceImage(Choice c, int width, int height)
        {
            var bmp = new Bitmap(Math.Max(1, width), Math.Max(1, height));
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                int cx = bmp.Width / 2;
                int cy = bmp.Height / 2;
                int size = Math.Min(bmp.Width, bmp.Height) - 20;

                switch (c)
                {
                    case Choice.Rock:
                        Rectangle rockRect = new Rectangle(cx - size / 2, cy - size / 2, size, size);
                        using (Brush b = new SolidBrush(Color.LightGray))
                        using (Pen p = new Pen(Color.DimGray, 3))
                        {
                            g.FillEllipse(b, rockRect);
                            g.DrawEllipse(p, rockRect);
                        }
                        break;

                    case Choice.Paper:
                        Rectangle paperRect = new Rectangle(cx - size / 2, cy - size / 2, size, size);
                        using (Brush shadowBrush = new SolidBrush(Color.FromArgb(40, Color.Black)))
                            g.FillRectangle(shadowBrush, new Rectangle(paperRect.X + 6, paperRect.Y + 6, paperRect.Width, paperRect.Height));

                        using (Brush paperBrush = new SolidBrush(Color.White))
                        using (Pen borderPen = new Pen(Color.DodgerBlue, 3))
                        {
                            g.FillRectangle(paperBrush, paperRect);
                            g.DrawRectangle(borderPen, paperRect);

                            // 摺角
                            int fold = Math.Max(12, size / 6);
                            Point[] foldPoly = {
                                new Point(paperRect.Right - fold, paperRect.Top),
                                new Point(paperRect.Right, paperRect.Top),
                                new Point(paperRect.Right, paperRect.Top + fold)
                            };
                            using (Brush foldBrush = new SolidBrush(Color.FromArgb(230, Color.LightGray)))
                                g.FillPolygon(foldBrush, foldPoly);
                            using (Pen foldPen = new Pen(Color.Gray, 2))
                                g.DrawPolygon(foldPen, foldPoly);

                            // 中間文字提示（可移除）
                            using (Font f = new Font("Segoe UI", Math.Max(14, size / 6), FontStyle.Bold))
                            using (Brush tb = new SolidBrush(Color.DodgerBlue))
                            {
                                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                                Rectangle textRect = new Rectangle(paperRect.X + 6, paperRect.Y + 6, paperRect.Width - 12, paperRect.Height - 12);
                                g.DrawString("布", f, tb, textRect, sf);
                            }
                        }
                        break;

                    case Choice.Scissors:
                        using (Pen blade = new Pen(Color.DarkSlateGray, Math.Max(4, size / 12)))
                        using (Pen handle = new Pen(Color.RoyalBlue, Math.Max(6, size / 10)))
                        {
                            g.DrawLine(blade, cx - size / 2, cy - size / 4, cx + size / 2, cy + size / 4);
                            g.DrawLine(blade, cx - size / 2, cy + size / 4, cx + size / 2, cy - size / 4);

                            int r = Math.Max(6, size / 8);
                            g.DrawEllipse(handle, cx - size / 2 - r / 2, cy - r / 2, r, r);
                            g.DrawEllipse(handle, cx - size / 2 - r / 2, cy + r / 2, r, r);
                        }
                        break;
                }
            }
            return bmp;
        }

        private void DisposeImageIfAny(PictureBox pb)
        {
            if (pb?.Image != null)
            {
                var old = pb.Image;
                pb.Image = null;
                try { old.Dispose(); } catch { }
            }
        }

        private void ExitGame()
        {
            string stats = $"遊戲結束\r\n\r\n玩家贏場數: {_playerWins}\r\n電腦贏場數: {_cpuWins}\r\n\r\n按確定關閉程式。";
            MessageBox.Show(stats, "遊戲統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // 確保釋放圖片資源
            DisposeImageIfAny(pbPlayer);
            DisposeImageIfAny(pbCPU);
            base.OnFormClosing(e);
        }
    }
}
