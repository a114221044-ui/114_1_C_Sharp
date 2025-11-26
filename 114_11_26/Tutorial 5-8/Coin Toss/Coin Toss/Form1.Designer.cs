namespace Coin_Toss
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
            this.components = new System.ComponentModel.Container();
            this.tailsPictureBox = new System.Windows.Forms.PictureBox();
            this.headsPictureBox = new System.Windows.Forms.PictureBox();
            this.tossButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.headsCountLabel = new System.Windows.Forms.Label();
            this.tailsCountLabel = new System.Windows.Forms.Label();
            this.headsCountValueLabel = new System.Windows.Forms.Label();
            this.tailsCountValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tailsPictureBox
            // 
            this.tailsPictureBox.Image = global::Coin_Toss.Properties.Resources.Tails1;
            this.tailsPictureBox.Location = new System.Drawing.Point(33, 12);
            this.tailsPictureBox.Name = "tailsPictureBox";
            this.tailsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.tailsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailsPictureBox.TabIndex = 1;
            this.tailsPictureBox.TabStop = false;
            this.tailsPictureBox.Visible = false;
            // 
            // headsPictureBox
            // 
            this.headsPictureBox.Image = global::Coin_Toss.Properties.Resources.Heads1;
            this.headsPictureBox.Location = new System.Drawing.Point(33, 12);
            this.headsPictureBox.Name = "headsPictureBox";
            this.headsPictureBox.Size = new System.Drawing.Size(170, 170);
            this.headsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headsPictureBox.TabIndex = 0;
            this.headsPictureBox.TabStop = false;
            // 
            // tossButton
            // 
            this.tossButton.Location = new System.Drawing.Point(40, 194);
            this.tossButton.Name = "tossButton";
            this.tossButton.Size = new System.Drawing.Size(75, 23);
            this.tossButton.TabIndex = 2;
            this.tossButton.Text = "擲硬幣";
            this.tossButton.UseVisualStyleBackColor = true;
            this.tossButton.Click += new System.EventHandler(this.tossButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(121, 194);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "退出";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // headsCountLabel
            // 
            this.headsCountLabel.AutoSize = true;
            this.headsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.headsCountLabel.Location = new System.Drawing.Point(220, 30);
            this.headsCountLabel.Name = "headsCountLabel";
            this.headsCountLabel.Size = new System.Drawing.Size(110, 29);
            this.headsCountLabel.TabIndex = 4;
            this.headsCountLabel.Text = "正面次數";
            // 
            // tailsCountLabel
            // 
            this.tailsCountLabel.AutoSize = true;
            this.tailsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tailsCountLabel.Location = new System.Drawing.Point(220, 80);
            this.tailsCountLabel.Name = "tailsCountLabel";
            this.tailsCountLabel.Size = new System.Drawing.Size(110, 29);
            this.tailsCountLabel.TabIndex = 5;
            this.tailsCountLabel.Text = "反面次數";
            // 
            // headsCountValueLabel
            // 
            this.headsCountValueLabel.AutoSize = true;
            this.headsCountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.headsCountValueLabel.Location = new System.Drawing.Point(350, 30);
            this.headsCountValueLabel.Name = "headsCountValueLabel";
            this.headsCountValueLabel.Size = new System.Drawing.Size(26, 29);
            this.headsCountValueLabel.TabIndex = 6;
            this.headsCountValueLabel.Text = "0";
            // 
            // tailsCountValueLabel
            // 
            this.tailsCountValueLabel.AutoSize = true;
            this.tailsCountValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.tailsCountValueLabel.Location = new System.Drawing.Point(350, 80);
            this.tailsCountValueLabel.Name = "tailsCountValueLabel";
            this.tailsCountValueLabel.Size = new System.Drawing.Size(26, 29);
            this.tailsCountValueLabel.TabIndex = 7;
            this.tailsCountValueLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 229);
            this.Controls.Add(this.tailsCountValueLabel);
            this.Controls.Add(this.headsCountValueLabel);
            this.Controls.Add(this.tailsCountLabel);
            this.Controls.Add(this.headsCountLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.tossButton);
            this.Controls.Add(this.headsPictureBox);
            this.Controls.Add(this.tailsPictureBox);
            this.Name = "Form1";
            this.Text = "擲硬幣";
            ((System.ComponentModel.ISupportInitialize)(this.tailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox headsPictureBox;
        private System.Windows.Forms.PictureBox tailsPictureBox;
        private System.Windows.Forms.Button tossButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label headsCountLabel;
        private System.Windows.Forms.Label tailsCountLabel;
        private System.Windows.Forms.Label headsCountValueLabel;
        private System.Windows.Forms.Label tailsCountValueLabel;
    }
}
