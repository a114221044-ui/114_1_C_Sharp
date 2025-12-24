namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.computerLabel = new System.Windows.Forms.Label();
            this.playerLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.computerPictureBox = new System.Windows.Forms.PictureBox();
            this.playerPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // computerLabel
            // 
            this.computerLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.computerLabel.Location = new System.Drawing.Point(131, -2);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(185, 70);
            this.computerLabel.TabIndex = 0;
            this.computerLabel.Text = "電腦出";
            this.computerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playerLabel
            // 
            this.playerLabel.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.playerLabel.Location = new System.Drawing.Point(506, 9);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(190, 49);
            this.playerLabel.TabIndex = 1;
            this.playerLabel.Text = "玩家出";
            this.playerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 139);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(505, 29);
            this.textBox1.TabIndex = 2;
            // 
            // computerPictureBox
            // 
            this.computerPictureBox.Location = new System.Drawing.Point(179, 71);
            this.computerPictureBox.Name = "computerPictureBox";
            this.computerPictureBox.Size = new System.Drawing.Size(100, 50);
            this.computerPictureBox.TabIndex = 3;
            this.computerPictureBox.TabStop = false;
            // 
            // playerPictureBox
            // 
            this.playerPictureBox.Location = new System.Drawing.Point(542, 61);
            this.playerPictureBox.Name = "playerPictureBox";
            this.playerPictureBox.Size = new System.Drawing.Size(100, 50);
            this.playerPictureBox.TabIndex = 4;
            this.playerPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "石頭";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 57);
            this.button2.TabIndex = 6;
            this.button2.Text = "剪刀 ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(568, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 57);
            this.button3.TabIndex = 7;
            this.button3.Text = "布";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(352, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(148, 47);
            this.button4.TabIndex = 8;
            this.button4.Text = "結束遊戲";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 369);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playerPictureBox);
            this.Controls.Add(this.computerPictureBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.computerLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.computerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox computerPictureBox;
        private System.Windows.Forms.PictureBox playerPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

