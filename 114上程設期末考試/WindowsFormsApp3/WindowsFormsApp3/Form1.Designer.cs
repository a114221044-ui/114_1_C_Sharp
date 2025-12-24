namespace WindowsFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox gbOil;
        private System.Windows.Forms.CheckBox chkOilChange;
        private System.Windows.Forms.CheckBox chkLubrication;

        private System.Windows.Forms.GroupBox gbWash;
        private System.Windows.Forms.CheckBox chkRadiator;
        private System.Windows.Forms.CheckBox chkTrans;

        private System.Windows.Forms.GroupBox gbOther;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.CheckBox chkMuffler;
        private System.Windows.Forms.CheckBox chkTireRotate;

        private System.Windows.Forms.GroupBox gbPartsLabor;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtHours;

        private System.Windows.Forms.GroupBox gbSummary;
        private System.Windows.Forms.Label lblServiceLabor;
        private System.Windows.Forms.TextBox txtServiceLabor;
        private System.Windows.Forms.Label lblPartsCost;
        private System.Windows.Forms.TextBox txtPartsCost;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.gbOil = new System.Windows.Forms.GroupBox();
            this.chkOilChange = new System.Windows.Forms.CheckBox();
            this.chkLubrication = new System.Windows.Forms.CheckBox();

            this.gbWash = new System.Windows.Forms.GroupBox();
            this.chkRadiator = new System.Windows.Forms.CheckBox();
            this.chkTrans = new System.Windows.Forms.CheckBox();

            this.gbOther = new System.Windows.Forms.GroupBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.chkMuffler = new System.Windows.Forms.CheckBox();
            this.chkTireRotate = new System.Windows.Forms.CheckBox();

            this.gbPartsLabor = new System.Windows.Forms.GroupBox();
            this.lblParts = new System.Windows.Forms.Label();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();

            this.gbSummary = new System.Windows.Forms.GroupBox();
            this.lblServiceLabor = new System.Windows.Forms.Label();
            this.txtServiceLabor = new System.Windows.Forms.TextBox();
            this.lblPartsCost = new System.Windows.Forms.Label();
            this.txtPartsCost = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();

            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();

            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();

            // Form
            this.SuspendLayout();
            this.ClientSize = new System.Drawing.Size(560, 360);
            this.Text = "汽車維修服務";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            // gbOil
            this.gbOil.Text = "機油與潤滑";
            this.gbOil.Location = new System.Drawing.Point(12, 12);
            this.gbOil.Size = new System.Drawing.Size(170, 90);
            this.gbOil.Controls.Add(this.chkOilChange);
            this.gbOil.Controls.Add(this.chkLubrication);

            // chkOilChange
            this.chkOilChange.Text = "更換機油 (NT$780)";
            this.chkOilChange.Location = new System.Drawing.Point(12, 24);
            this.chkOilChange.AutoSize = true;
            this.chkOilChange.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);

            // chkLubrication
            this.chkLubrication.Text = "潤滑保養 (NT$540)";
            this.chkLubrication.Location = new System.Drawing.Point(12, 50);
            this.chkLubrication.AutoSize = true;
            this.chkLubrication.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);

            // gbWash
            this.gbWash.Text = "清洗服務";
            this.gbWash.Location = new System.Drawing.Point(196, 12);
            this.gbWash.Size = new System.Drawing.Size(170, 90);
            this.gbWash.Controls.Add(this.chkRadiator);
            this.gbWash.Controls.Add(this.chkTrans);

            // chkRadiator
            this.chkRadiator.Text = "水箱清洗 (NT$900)";
            this.chkRadiator.Location = new System.Drawing.Point(12, 24);
            this.chkRadiator.AutoSize = true;
            this.chkRadiator.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);

            // chkTrans
            this.chkTrans.Text = "變速箱清洗 (NT$2,400)";
            this.chkTrans.Location = new System.Drawing.Point(12, 50);
            this.chkTrans.AutoSize = true;
            this.chkTrans.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);

            // gbOther
            this.gbOther.Text = "其他服務";
            this.gbOther.Location = new System.Drawing.Point(380, 12);
            this.gbOther.Size = new System.Drawing.Size(170, 130);
            this.gbOther.Controls.Add(this.chkInspection);
            this.gbOther.Controls.Add(this.chkMuffler);
            this.gbOther.Controls.Add(this.chkTireRotate);

            // chkInspection
            this.chkInspection.Text = "檢驗 (NT$450)";
            this.chkInspection.Location = new System.Drawing.Point(12, 24);
            this.chkInspection.AutoSize = true;
            this.chkInspection.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);

            // chkMuffler
            this.chkMuffler.Text = "更換消音器 (NT$3,000)";
            this.chkMuffler.Location = new System.Drawing.Point(12, 50);
            this.chkMuffler.AutoSize = true;
            this.chkMuffler.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);

            // chkTireRotate
            this.chkTireRotate.Text = "輪胎換位 (NT$600)";
            this.chkTireRotate.Location = new System.Drawing.Point(12, 76);
            this.chkTireRotate.AutoSize = true;
            this.chkTireRotate.CheckedChanged += new System.EventHandler(this.Control_ValueChanged);

            // gbPartsLabor
            this.gbPartsLabor.Text = "零件與工時";
            this.gbPartsLabor.Location = new System.Drawing.Point(12, 110);
            this.gbPartsLabor.Size = new System.Drawing.Size(354, 80);
            this.gbPartsLabor.Controls.Add(this.lblParts);
            this.gbPartsLabor.Controls.Add(this.txtParts);
            this.gbPartsLabor.Controls.Add(this.lblHours);
            this.gbPartsLabor.Controls.Add(this.txtHours);

            // lblParts
            this.lblParts.Text = "零件 (NT$)：";
            this.lblParts.Location = new System.Drawing.Point(12, 28);
            this.lblParts.AutoSize = true;

            // txtParts
            this.txtParts.Location = new System.Drawing.Point(90, 24);
            this.txtParts.Size = new System.Drawing.Size(120, 23);
            this.txtParts.Text = "0";
            this.txtParts.TextChanged += new System.EventHandler(this.Control_ValueChanged);
            this.txtParts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Numeric_KeyPress);

            // lblHours
            this.lblHours.Text = "工時 (小時)：";
            this.lblHours.Location = new System.Drawing.Point(220, 28);
            this.lblHours.AutoSize = true;

            // txtHours
            this.txtHours.Location = new System.Drawing.Point(300, 24);
            this.txtHours.Size = new System.Drawing.Size(40, 23);
            this.txtHours.Text = "0";
            this.txtHours.TextChanged += new System.EventHandler(this.Control_ValueChanged);
            this.txtHours.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_Numeric_KeyPress);

            // gbSummary
            this.gbSummary.Text = "費用摘要";
            this.gbSummary.Location = new System.Drawing.Point(12, 200);
            this.gbSummary.Size = new System.Drawing.Size(538, 110);
            this.gbSummary.Controls.Add(this.lblServiceLabor);
            this.gbSummary.Controls.Add(this.txtServiceLabor);
            this.gbSummary.Controls.Add(this.lblPartsCost);
            this.gbSummary.Controls.Add(this.txtPartsCost);
            this.gbSummary.Controls.Add(this.lblTax);
            this.gbSummary.Controls.Add(this.txtTax);
            this.gbSummary.Controls.Add(this.lblTotal);
            this.gbSummary.Controls.Add(this.txtTotal);

            // lblServiceLabor
            this.lblServiceLabor.Text = "服務與工資：";
            this.lblServiceLabor.Location = new System.Drawing.Point(12, 28);
            this.lblServiceLabor.AutoSize = true;

            // txtServiceLabor
            this.txtServiceLabor.Location = new System.Drawing.Point(110, 24);
            this.txtServiceLabor.Size = new System.Drawing.Size(150, 23);
            this.txtServiceLabor.ReadOnly = true;

            // lblPartsCost
            this.lblPartsCost.Text = "零件：";
            this.lblPartsCost.Location = new System.Drawing.Point(12, 58);
            this.lblPartsCost.AutoSize = true;

            // txtPartsCost
            this.txtPartsCost.Location = new System.Drawing.Point(110, 54);
            this.txtPartsCost.Size = new System.Drawing.Size(150, 23);
            this.txtPartsCost.ReadOnly = true;

            // lblTax
            this.lblTax.Text = "稅金 (6%)：";
            this.lblTax.Location = new System.Drawing.Point(280, 28);
            this.lblTax.AutoSize = true;

            // txtTax
            this.txtTax.Location = new System.Drawing.Point(360, 24);
            this.txtTax.Size = new System.Drawing.Size(150, 23);
            this.txtTax.ReadOnly = true;

            // lblTotal
            this.lblTotal.Text = "總費用：";
            this.lblTotal.Location = new System.Drawing.Point(280, 58);
            this.lblTotal.AutoSize = true;

            // txtTotal
            this.txtTotal.Location = new System.Drawing.Point(360, 54);
            this.txtTotal.Size = new System.Drawing.Size(150, 23);
            this.txtTotal.ReadOnly = true;

            // btnCalculate
            this.btnCalculate.Text = "計算總額";
            this.btnCalculate.Location = new System.Drawing.Point(110, 320);
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // btnClear
            this.btnClear.Text = "清除";
            this.btnClear.Location = new System.Drawing.Point(230, 320);
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnSave
            this.btnSave.Text = "儲存明細";
            this.btnSave.Location = new System.Drawing.Point(350, 320);
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnExit
            this.btnExit.Text = "離開";
            this.btnExit.Location = new System.Drawing.Point(470, 320);
            this.btnExit.Size = new System.Drawing.Size(80, 28);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // saveFileDialog1
            this.saveFileDialog1.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "維修明細.txt";

            // Add controls to form
            this.Controls.Add(this.gbOil);
            this.Controls.Add(this.gbWash);
            this.Controls.Add(this.gbOther);
            this.Controls.Add(this.gbPartsLabor);
            this.Controls.Add(this.gbSummary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnExit);

            this.ResumeLayout(false);
        }

        #endregion
    }
}

