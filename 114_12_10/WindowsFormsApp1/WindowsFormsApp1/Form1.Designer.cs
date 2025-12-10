namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Label 控制項
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblQuiz1;
        private System.Windows.Forms.Label lblQuiz2;
        private System.Windows.Forms.Label lblQuiz3;
        
        // TextBox 控制項
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtQuiz1;
        private System.Windows.Forms.TextBox txtQuiz2;
        private System.Windows.Forms.TextBox txtQuiz3;
        
        // Button 控制項
        private System.Windows.Forms.Button btnShowMax;
        private System.Windows.Forms.Button btnExit;
        
        // Result Label
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
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblQuiz1 = new System.Windows.Forms.Label();
            this.lblQuiz2 = new System.Windows.Forms.Label();
            this.lblQuiz3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtQuiz1 = new System.Windows.Forms.TextBox();
            this.txtQuiz2 = new System.Windows.Forms.TextBox();
            this.txtQuiz3 = new System.Windows.Forms.TextBox();
            this.btnShowMax = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLastName.Location = new System.Drawing.Point(126, 48);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(68, 55);
            this.lblLastName.TabIndex = 0;
            this.lblLastName.Text = "姓";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblFirstName.Location = new System.Drawing.Point(126, 153);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(68, 55);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "名";
            // 
            // lblQuiz1
            // 
            this.lblQuiz1.AutoSize = true;
            this.lblQuiz1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQuiz1.Location = new System.Drawing.Point(112, 259);
            this.lblQuiz1.Name = "lblQuiz1";
            this.lblQuiz1.Size = new System.Drawing.Size(138, 55);
            this.lblQuiz1.TabIndex = 2;
            this.lblQuiz1.Text = "小考1";
            // 
            // lblQuiz2
            // 
            this.lblQuiz2.AutoSize = true;
            this.lblQuiz2.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQuiz2.Location = new System.Drawing.Point(112, 356);
            this.lblQuiz2.Name = "lblQuiz2";
            this.lblQuiz2.Size = new System.Drawing.Size(138, 55);
            this.lblQuiz2.TabIndex = 3;
            this.lblQuiz2.Text = "小考2";
            // 
            // lblQuiz3
            // 
            this.lblQuiz3.AutoSize = true;
            this.lblQuiz3.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblQuiz3.Location = new System.Drawing.Point(112, 448);
            this.lblQuiz3.Name = "lblQuiz3";
            this.lblQuiz3.Size = new System.Drawing.Size(138, 55);
            this.lblQuiz3.TabIndex = 4;
            this.lblQuiz3.Text = "小考3";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLastName.Location = new System.Drawing.Point(329, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 66);
            this.txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFirstName.Location = new System.Drawing.Point(329, 142);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 66);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtQuiz1
            // 
            this.txtQuiz1.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuiz1.Location = new System.Drawing.Point(329, 248);
            this.txtQuiz1.Name = "txtQuiz1";
            this.txtQuiz1.Size = new System.Drawing.Size(150, 66);
            this.txtQuiz1.TabIndex = 7;
            // 
            // txtQuiz2
            // 
            this.txtQuiz2.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuiz2.Location = new System.Drawing.Point(329, 345);
            this.txtQuiz2.Name = "txtQuiz2";
            this.txtQuiz2.Size = new System.Drawing.Size(150, 66);
            this.txtQuiz2.TabIndex = 8;
            // 
            // txtQuiz3
            // 
            this.txtQuiz3.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtQuiz3.Location = new System.Drawing.Point(329, 445);
            this.txtQuiz3.Name = "txtQuiz3";
            this.txtQuiz3.Size = new System.Drawing.Size(150, 66);
            this.txtQuiz3.TabIndex = 9;
            // 
            // btnShowMax
            // 
            this.btnShowMax.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowMax.Location = new System.Drawing.Point(100, 594);
            this.btnShowMax.Name = "btnShowMax";
            this.btnShowMax.Size = new System.Drawing.Size(200, 60);
            this.btnShowMax.TabIndex = 10;
            this.btnShowMax.Text = "顯示最高分";
            this.btnShowMax.UseVisualStyleBackColor = true;
            this.btnShowMax.Click += new System.EventHandler(this.btnShowMax_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExit.Location = new System.Drawing.Point(400, 594);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 60);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(620, 90);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(550, 471);
            this.lblResult.TabIndex = 12;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 737);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShowMax);
            this.Controls.Add(this.txtQuiz3);
            this.Controls.Add(this.txtQuiz2);
            this.Controls.Add(this.txtQuiz1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblQuiz3);
            this.Controls.Add(this.lblQuiz2);
            this.Controls.Add(this.lblQuiz1);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Name = "Form1";
            this.Text = "成績管理系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}

