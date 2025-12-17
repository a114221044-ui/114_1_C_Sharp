namespace Cups_To_Ounces
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源 (包含元件容器)。
        /// </summary>
        /// <param name="disposing">若為 true，則會處置受控資源；否則僅釋放非受控資源。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// 此為設計工具所需的方法 - 請勿使用程式碼編輯器修改
        /// 初始化表單上的所有元件，並設定其文字為繁體中文、字型大小為 18，及調整大小與位置。
        /// 以下的註解皆為繁體中文，說明每個元件的用途與設定變更。
        /// </summary>
        private void InitializeComponent()
        {
            // 標題文字：顯示應用程式名稱，使用粗體字以醒目顯示
            this.bannerLabel = new System.Windows.Forms.Label();
            // 輸入提示：告知使用者應輸入「杯數」
            this.cupsPromptLabel = new System.Windows.Forms.Label();
            // 輸入欄位：讓使用者輸入杯數，字型放大以利閱讀
            this.cupsTextBox = new System.Windows.Forms.TextBox();
            // 輸出顯示：顯示換算後的盎司數值，使用邊框置中顯示結果
            this.ouncesLabel = new System.Windows.Forms.Label();
            // 輸出描述：標示輸出欄位的用途（液體盎司）
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            // 轉換按鈕：執行杯數轉盎司的計算
            this.convertButton = new System.Windows.Forms.Button();
            // 離開按鈕：關閉表單
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bannerLabel
            // 
            this.bannerLabel.AutoSize = true;
            // 將標題字型調為 18pt 並加粗，提升可讀性
            this.bannerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 調整標題位置，置於表單上方
            this.bannerLabel.Location = new System.Drawing.Point(18, 10);
            this.bannerLabel.Name = "bannerLabel";
            // AutoSize 為 true，Size 由系統依字型與文字決定
            this.bannerLabel.TabIndex = 0;
            // 將標題文字改為繁體中文
            this.bannerLabel.Text = "杯數轉液體盎司換算器";
            // 
            // cupsPromptLabel
            // 
            this.cupsPromptLabel.AutoSize = true;
            // 將提示字型調為 18pt
            this.cupsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 提示放置於左側靠上位置，與輸入欄對齊
            this.cupsPromptLabel.Location = new System.Drawing.Point(24, 60);
            this.cupsPromptLabel.Name = "cupsPromptLabel";
            this.cupsPromptLabel.TabIndex = 1;
            // 將提示文字改為繁體中文（包含全形冒號）
            this.cupsPromptLabel.Text = "杯數：";
            // 
            // cupsTextBox
            // 
            // 將輸入欄字型調為 18pt，便於輸入與閱讀
            this.cupsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 調整輸入欄位置與寬度，以符合放大的字型
            this.cupsTextBox.Location = new System.Drawing.Point(120, 56);
            this.cupsTextBox.Name = "cupsTextBox";
            this.cupsTextBox.Size = new System.Drawing.Size(220, 35);
            this.cupsTextBox.TabIndex = 2;
            // 
            // ouncesLabel
            // 
            // 輸出欄為有邊框的標籤，置中顯示結果，字型也改為 18pt
            this.ouncesLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ouncesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouncesLabel.Location = new System.Drawing.Point(120, 100);
            this.ouncesLabel.Name = "ouncesLabel";
            // 調整輸出欄高度以配合 18pt 字型
            this.ouncesLabel.Size = new System.Drawing.Size(220, 40);
            this.ouncesLabel.TabIndex = 3;
            this.ouncesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 內容預設為空字串（由事件處理器填入）
            this.ouncesLabel.Text = "";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            // 說明文字字型改為 18pt
            this.outputDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 放置於輸出欄左側以標示用途
            this.outputDescriptionLabel.Location = new System.Drawing.Point(18, 108);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.TabIndex = 4;
            // 將說明文字改為繁體中文
            this.outputDescriptionLabel.Text = "液體盎司：";
            // 
            // convertButton
            // 
            // 轉換按鈕字型 18pt，尺寸放大，置中偏左
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(70, 160);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(120, 45);
            this.convertButton.TabIndex = 5;
            // 按鈕文字改為繁體中文
            this.convertButton.Text = "轉換";
            this.convertButton.UseVisualStyleBackColor = true;
            // 維持原本的事件綁定，按下後呼叫 convertButton_Click
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            // 離開按鈕字型 18pt，尺寸放大，置中偏右
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(220, 160);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(120, 45);
            this.exitButton.TabIndex = 6;
            // 按鈕文字改為繁體中文
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            // 維持原本的事件綁定，按下後呼叫 exitButton_Click
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            // 調整整個表單的大小以容納放大的字型與元件
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 將表單客戶區尺寸放大，並保留適當邊界
            this.ClientSize = new System.Drawing.Size(370, 230);
            // 依新位置順序加入控制項
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.ouncesLabel);
            this.Controls.Add(this.cupsTextBox);
            this.Controls.Add(this.cupsPromptLabel);
            this.Controls.Add(this.bannerLabel);
            this.Name = "Form1";
            // 將視窗標題改為繁體中文
            this.Text = "杯數轉盎司";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bannerLabel;
        private System.Windows.Forms.Label cupsPromptLabel;
        private System.Windows.Forms.TextBox cupsTextBox;
        private System.Windows.Forms.Label ouncesLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
    }
}

