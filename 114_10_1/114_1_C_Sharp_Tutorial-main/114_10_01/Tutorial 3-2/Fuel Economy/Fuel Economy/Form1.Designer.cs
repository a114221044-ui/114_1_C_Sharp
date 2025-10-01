namespace Fuel_Economy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.milesPromptLabel = new System.Windows.Forms.Label();
            this.gallonsPromptLabel = new System.Windows.Forms.Label();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.gallonsTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.mpgLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // milesPromptLabel
            // 
            this.milesPromptLabel.AutoSize = true;
            this.milesPromptLabel.Location = new System.Drawing.Point(30, 42);
            this.milesPromptLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.milesPromptLabel.Name = "milesPromptLabel";
            this.milesPromptLabel.Size = new System.Drawing.Size(375, 36);
            this.milesPromptLabel.TabIndex = 0;
            this.milesPromptLabel.Text = "請輸入行駛的英里數：";
            // 
            // gallonsPromptLabel
            // 
            this.gallonsPromptLabel.AutoSize = true;
            this.gallonsPromptLabel.Location = new System.Drawing.Point(30, 125);
            this.gallonsPromptLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.gallonsPromptLabel.Name = "gallonsPromptLabel";
            this.gallonsPromptLabel.Size = new System.Drawing.Size(447, 36);
            this.gallonsPromptLabel.TabIndex = 1;
            this.gallonsPromptLabel.Text = "請輸入使用的汽油加侖數：";
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(557, 34);
            this.milesTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(308, 51);
            this.milesTextBox.TabIndex = 2;
            // 
            // gallonsTextBox
            // 
            this.gallonsTextBox.Location = new System.Drawing.Point(557, 110);
            this.gallonsTextBox.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.gallonsTextBox.Name = "gallonsTextBox";
            this.gallonsTextBox.Size = new System.Drawing.Size(308, 51);
            this.gallonsTextBox.TabIndex = 3;
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(30, 218);
            this.outputDescriptionLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(375, 36);
            this.outputDescriptionLabel.TabIndex = 4;
            this.outputDescriptionLabel.Text = "您的車每公升公里數：";
            this.outputDescriptionLabel.Click += new System.EventHandler(this.outputDescriptionLabel_Click);
            // 
            // mpgLabel
            // 
            this.mpgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mpgLabel.Location = new System.Drawing.Point(557, 218);
            this.mpgLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.mpgLabel.Name = "mpgLabel";
            this.mpgLabel.Size = new System.Drawing.Size(312, 60);
            this.mpgLabel.TabIndex = 5;
            this.mpgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(203, 372);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(236, 96);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算每加侖英里數";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(460, 372);
            this.exitButton.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(236, 96);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 502);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.mpgLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.gallonsTextBox);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.gallonsPromptLabel);
            this.Controls.Add(this.milesPromptLabel);
            this.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "Form1";
            this.Text = "油耗計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label milesPromptLabel;
        private System.Windows.Forms.Label gallonsPromptLabel;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.TextBox gallonsTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label mpgLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
    }
}

