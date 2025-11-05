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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.juiceradioButton = new System.Windows.Forms.RadioButton();
            this.redtearadioButton = new System.Windows.Forms.RadioButton();
            this.miketearadioButton = new System.Windows.Forms.RadioButton();
            this.coffeeradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.jellyradioButton = new System.Windows.Forms.RadioButton();
            this.hamSandwichcheckBox = new System.Windows.Forms.RadioButton();
            this.tunaradioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.juiceradioButton);
            this.groupBox1.Controls.Add(this.redtearadioButton);
            this.groupBox1.Controls.Add(this.miketearadioButton);
            this.groupBox1.Controls.Add(this.coffeeradioButton);
            this.groupBox1.Location = new System.Drawing.Point(25, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 363);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "飲料";
            // 
            // juiceradioButton
            // 
            this.juiceradioButton.AutoSize = true;
            this.juiceradioButton.Location = new System.Drawing.Point(105, 296);
            this.juiceradioButton.Name = "juiceradioButton";
            this.juiceradioButton.Size = new System.Drawing.Size(69, 22);
            this.juiceradioButton.TabIndex = 7;
            this.juiceradioButton.TabStop = true;
            this.juiceradioButton.Text = "果汁";
            this.juiceradioButton.UseVisualStyleBackColor = true;
            // 
            // redtearadioButton
            // 
            this.redtearadioButton.AutoSize = true;
            this.redtearadioButton.Location = new System.Drawing.Point(105, 197);
            this.redtearadioButton.Name = "redtearadioButton";
            this.redtearadioButton.Size = new System.Drawing.Size(69, 22);
            this.redtearadioButton.TabIndex = 6;
            this.redtearadioButton.TabStop = true;
            this.redtearadioButton.Text = "紅茶";
            this.redtearadioButton.UseVisualStyleBackColor = true;
            // 
            // miketearadioButton
            // 
            this.miketearadioButton.AutoSize = true;
            this.miketearadioButton.Location = new System.Drawing.Point(105, 113);
            this.miketearadioButton.Name = "miketearadioButton";
            this.miketearadioButton.Size = new System.Drawing.Size(69, 22);
            this.miketearadioButton.TabIndex = 5;
            this.miketearadioButton.TabStop = true;
            this.miketearadioButton.Text = "奶茶";
            this.miketearadioButton.UseVisualStyleBackColor = true;
            // 
            // coffeeradioButton
            // 
            this.coffeeradioButton.AutoSize = true;
            this.coffeeradioButton.Location = new System.Drawing.Point(105, 24);
            this.coffeeradioButton.Name = "coffeeradioButton";
            this.coffeeradioButton.Size = new System.Drawing.Size(69, 22);
            this.coffeeradioButton.TabIndex = 4;
            this.coffeeradioButton.TabStop = true;
            this.coffeeradioButton.Text = "咖啡";
            this.coffeeradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.jellyradioButton);
            this.groupBox2.Controls.Add(this.hamSandwichcheckBox);
            this.groupBox2.Controls.Add(this.tunaradioButton);
            this.groupBox2.Location = new System.Drawing.Point(342, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 363);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "三明治";
            // 
            // jellyradioButton
            // 
            this.jellyradioButton.AutoSize = true;
            this.jellyradioButton.Location = new System.Drawing.Point(62, 257);
            this.jellyradioButton.Name = "jellyradioButton";
            this.jellyradioButton.Size = new System.Drawing.Size(123, 22);
            this.jellyradioButton.TabIndex = 9;
            this.jellyradioButton.TabStop = true;
            this.jellyradioButton.Text = "果獎三明治";
            this.jellyradioButton.UseVisualStyleBackColor = true;
            // 
            // hamSandwichcheckBox
            // 
            this.hamSandwichcheckBox.AutoSize = true;
            this.hamSandwichcheckBox.Location = new System.Drawing.Point(62, 173);
            this.hamSandwichcheckBox.Name = "hamSandwichcheckBox";
            this.hamSandwichcheckBox.Size = new System.Drawing.Size(123, 22);
            this.hamSandwichcheckBox.TabIndex = 8;
            this.hamSandwichcheckBox.TabStop = true;
            this.hamSandwichcheckBox.Text = "火腿三明治";
            this.hamSandwichcheckBox.UseVisualStyleBackColor = true;
            // 
            // tunaradioButton
            // 
            this.tunaradioButton.AutoSize = true;
            this.tunaradioButton.Location = new System.Drawing.Point(62, 84);
            this.tunaradioButton.Name = "tunaradioButton";
            this.tunaradioButton.Size = new System.Drawing.Size(123, 22);
            this.tunaradioButton.TabIndex = 7;
            this.tunaradioButton.TabStop = true;
            this.tunaradioButton.Text = "鮪魚三明治";
            this.tunaradioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(646, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "送出訂單";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(617, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 60);
            this.button2.TabIndex = 10;
            this.button2.Text = "離開";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton juiceradioButton;
        private System.Windows.Forms.RadioButton redtearadioButton;
        private System.Windows.Forms.RadioButton miketearadioButton;
        private System.Windows.Forms.RadioButton coffeeradioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton jellyradioButton;
        private System.Windows.Forms.RadioButton hamSandwichcheckBox;
        private System.Windows.Forms.RadioButton tunaradioButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

