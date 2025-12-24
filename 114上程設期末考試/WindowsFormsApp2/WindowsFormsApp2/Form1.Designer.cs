namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btnGenerateNumbers;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBoxLotteryNumbers;
        private System.Windows.Forms.Label lblResult;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerateNumbers = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.listBoxLotteryNumbers = new System.Windows.Forms.ListBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateNumbers
            // 
            this.btnGenerateNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateNumbers.Location = new System.Drawing.Point(20, 90);
            this.btnGenerateNumbers.Name = "btnGenerateNumbers";
            this.btnGenerateNumbers.Size = new System.Drawing.Size(220, 60);
            this.btnGenerateNumbers.TabIndex = 0;
            this.btnGenerateNumbers.Text = "產生號碼";
            this.btnGenerateNumbers.UseVisualStyleBackColor = true;
            this.btnGenerateNumbers.Click += new System.EventHandler(this.btnGenerateNumbers_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnOpenFile.Location = new System.Drawing.Point(260, 90);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(220, 60);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "開獎號碼";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnExit.Location = new System.Drawing.Point(500, 90);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 60);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // listBoxLotteryNumbers
            // 
            this.listBoxLotteryNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.listBoxLotteryNumbers.FormattingEnabled = true;
            this.listBoxLotteryNumbers.ItemHeight = 40;
            this.listBoxLotteryNumbers.Location = new System.Drawing.Point(20, 186);
            this.listBoxLotteryNumbers.Name = "listBoxLotteryNumbers";
            this.listBoxLotteryNumbers.Size = new System.Drawing.Size(360, 164);
            this.listBoxLotteryNumbers.TabIndex = 3;
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult.Location = new System.Drawing.Point(400, 170);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(320, 180);
            this.lblResult.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 380);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.listBoxLotteryNumbers);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnGenerateNumbers);
            this.Name = "Form1";
            this.Text = "樂透號碼產生器";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

