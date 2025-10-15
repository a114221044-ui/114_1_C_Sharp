namespace Payroll_with_Overtime
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應釋放受控資源則為 true，否則為 false。</param>
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
        /// 設計工具所需的方法 - 請勿使用程式碼編輯器修改
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.hourlyPayRateTextBox = new System.Windows.Forms.TextBox();
            this.hoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.hourlyPayRatePromptLabel = new System.Windows.Forms.Label();
            this.hoursWorkedPromptLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.exitButton.Location = new System.Drawing.Point(649, 456);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(190, 101);
            this.exitButton.TabIndex = 26;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.clearButton.Location = new System.Drawing.Point(348, 456);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(218, 101);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.calculateButton.Location = new System.Drawing.Point(42, 456);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(228, 101);
            this.calculateButton.TabIndex = 24;
            this.calculateButton.Text = "計算薪資";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.grossPayLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.grossPayLabel.Location = new System.Drawing.Point(347, 256);
            this.grossPayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(403, 62);
            this.grossPayLabel.TabIndex = 23;
            this.grossPayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.outputDescriptionLabel.Location = new System.Drawing.Point(51, 232);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(200, 55);
            this.outputDescriptionLabel.TabIndex = 22;
            this.outputDescriptionLabel.Text = "總薪資：";
            // 
            // hourlyPayRateTextBox
            // 
            this.hourlyPayRateTextBox.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.hourlyPayRateTextBox.Location = new System.Drawing.Point(347, 128);
            this.hourlyPayRateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hourlyPayRateTextBox.Name = "hourlyPayRateTextBox";
            this.hourlyPayRateTextBox.Size = new System.Drawing.Size(148, 66);
            this.hourlyPayRateTextBox.TabIndex = 21;
            // 
            // hoursWorkedTextBox
            // 
            this.hoursWorkedTextBox.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.hoursWorkedTextBox.Location = new System.Drawing.Point(348, 25);
            this.hoursWorkedTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hoursWorkedTextBox.Name = "hoursWorkedTextBox";
            this.hoursWorkedTextBox.Size = new System.Drawing.Size(148, 66);
            this.hoursWorkedTextBox.TabIndex = 20;
            // 
            // hourlyPayRatePromptLabel
            // 
            this.hourlyPayRatePromptLabel.AutoSize = true;
            this.hourlyPayRatePromptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.hourlyPayRatePromptLabel.Location = new System.Drawing.Point(95, 131);
            this.hourlyPayRatePromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hourlyPayRatePromptLabel.Name = "hourlyPayRatePromptLabel";
            this.hourlyPayRatePromptLabel.Size = new System.Drawing.Size(156, 55);
            this.hourlyPayRatePromptLabel.TabIndex = 19;
            this.hourlyPayRatePromptLabel.Text = "時薪：";
            // 
            // hoursWorkedPromptLabel
            // 
            this.hoursWorkedPromptLabel.AutoSize = true;
            this.hoursWorkedPromptLabel.Font = new System.Drawing.Font("微軟正黑體", 22F);
            this.hoursWorkedPromptLabel.Location = new System.Drawing.Point(95, 36);
            this.hoursWorkedPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoursWorkedPromptLabel.Name = "hoursWorkedPromptLabel";
            this.hoursWorkedPromptLabel.Size = new System.Drawing.Size(156, 55);
            this.hoursWorkedPromptLabel.TabIndex = 18;
            this.hoursWorkedPromptLabel.Text = "工時：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 608);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.hourlyPayRateTextBox);
            this.Controls.Add(this.hoursWorkedTextBox);
            this.Controls.Add(this.hourlyPayRatePromptLabel);
            this.Controls.Add(this.hoursWorkedPromptLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "加班薪資計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 定義表單上的所有控制項
        internal System.Windows.Forms.Button exitButton; // 離開按鈕
        internal System.Windows.Forms.Button clearButton; // 清除按鈕
        internal System.Windows.Forms.Button calculateButton; // 計算薪資按鈕
        internal System.Windows.Forms.Label grossPayLabel; // 顯示總薪資的標籤
        internal System.Windows.Forms.Label outputDescriptionLabel; // "總薪資："說明標籤
        internal System.Windows.Forms.TextBox hourlyPayRateTextBox; // 輸入時薪的文字方塊
        internal System.Windows.Forms.TextBox hoursWorkedTextBox; // 輸入工時的文字方塊
        internal System.Windows.Forms.Label hourlyPayRatePromptLabel; // "時薪："說明標籤
        internal System.Windows.Forms.Label hoursWorkedPromptLabel; // "工時："說明標籤
    }
}

