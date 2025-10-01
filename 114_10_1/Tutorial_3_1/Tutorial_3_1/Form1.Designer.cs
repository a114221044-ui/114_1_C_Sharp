namespace Tutorial_3_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dayOfweekTextbox = new System.Windows.Forms.TextBox();
            this.monthTextbox = new System.Windows.Forms.TextBox();
            this.yearTextbox = new System.Windows.Forms.TextBox();
            this.dayTextbox = new System.Windows.Forms.TextBox();
            this.showDateButton = new System.Windows.Forms.Button();
            this.Dateoutputlabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(86, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "星期:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(134, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "月:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(134, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "日:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(134, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 48);
            this.label4.TabIndex = 3;
            this.label4.Text = "年:";
            // 
            // dayOfweekTextbox
            // 
            this.dayOfweekTextbox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayOfweekTextbox.Location = new System.Drawing.Point(233, 36);
            this.dayOfweekTextbox.Name = "dayOfweekTextbox";
            this.dayOfweekTextbox.Size = new System.Drawing.Size(247, 65);
            this.dayOfweekTextbox.TabIndex = 4;
            // 
            // monthTextbox
            // 
            this.monthTextbox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.monthTextbox.Location = new System.Drawing.Point(233, 112);
            this.monthTextbox.Name = "monthTextbox";
            this.monthTextbox.Size = new System.Drawing.Size(247, 65);
            this.monthTextbox.TabIndex = 5;
            // 
            // yearTextbox
            // 
            this.yearTextbox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearTextbox.Location = new System.Drawing.Point(233, 254);
            this.yearTextbox.Name = "yearTextbox";
            this.yearTextbox.Size = new System.Drawing.Size(247, 65);
            this.yearTextbox.TabIndex = 6;
            // 
            // dayTextbox
            // 
            this.dayTextbox.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dayTextbox.Location = new System.Drawing.Point(233, 183);
            this.dayTextbox.Name = "dayTextbox";
            this.dayTextbox.Size = new System.Drawing.Size(247, 65);
            this.dayTextbox.TabIndex = 6;
            // 
            // showDateButton
            // 
            this.showDateButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showDateButton.Location = new System.Drawing.Point(26, 381);
            this.showDateButton.Name = "showDateButton";
            this.showDateButton.Size = new System.Drawing.Size(219, 57);
            this.showDateButton.TabIndex = 7;
            this.showDateButton.Text = "顯示日期";
            this.showDateButton.UseVisualStyleBackColor = true;
            this.showDateButton.Click += new System.EventHandler(this.showDateButton_Click);
            // 
            // Dateoutputlabel
            // 
            this.Dateoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Dateoutputlabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Dateoutputlabel.Location = new System.Drawing.Point(139, 333);
            this.Dateoutputlabel.Name = "Dateoutputlabel";
            this.Dateoutputlabel.Size = new System.Drawing.Size(632, 45);
            this.Dateoutputlabel.TabIndex = 8;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(286, 381);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(219, 57);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(552, 381);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(219, 57);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.Dateoutputlabel);
            this.Controls.Add(this.showDateButton);
            this.Controls.Add(this.dayTextbox);
            this.Controls.Add(this.yearTextbox);
            this.Controls.Add(this.monthTextbox);
            this.Controls.Add(this.dayOfweekTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dayOfweekTextbox;
        private System.Windows.Forms.TextBox monthTextbox;
        private System.Windows.Forms.TextBox yearTextbox;
        private System.Windows.Forms.TextBox dayTextbox;
        private System.Windows.Forms.Button showDateButton;
        private System.Windows.Forms.Label Dateoutputlabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

