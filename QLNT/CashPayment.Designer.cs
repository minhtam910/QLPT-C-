
namespace QLNT
{
    partial class CashPayment
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.lbChange = new System.Windows.Forms.Label();
            this.lbPay = new System.Windows.Forms.Label();
            this.rdUSD = new System.Windows.Forms.RadioButton();
            this.rdEuro = new System.Windows.Forms.RadioButton();
            this.rdVND = new System.Windows.Forms.RadioButton();
            this.btnDoIt = new System.Windows.Forms.Button();
            this.lbCost = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.txtChangeCurrency = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.07692F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÁCH TRẢ TIỀN MẶT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số tiền cần thanh toán: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền khách thanh toán: :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 184);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền thừa sau thanh toán : ";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(233, 57);
            this.txtCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(282, 22);
            this.txtCost.TabIndex = 4;
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(233, 99);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(282, 22);
            this.txtPayment.TabIndex = 5;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(233, 182);
            this.txtChange.Margin = new System.Windows.Forms.Padding(4);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(282, 22);
            this.txtChange.TabIndex = 6;
            // 
            // lbChange
            // 
            this.lbChange.AutoSize = true;
            this.lbChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChange.Location = new System.Drawing.Point(523, 185);
            this.lbChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbChange.Name = "lbChange";
            this.lbChange.Size = new System.Drawing.Size(39, 18);
            this.lbChange.TabIndex = 7;
            this.lbChange.Text = "VND";
            // 
            // lbPay
            // 
            this.lbPay.AutoSize = true;
            this.lbPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPay.Location = new System.Drawing.Point(523, 102);
            this.lbPay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPay.Name = "lbPay";
            this.lbPay.Size = new System.Drawing.Size(39, 18);
            this.lbPay.TabIndex = 8;
            this.lbPay.Text = "VND";
            // 
            // rdUSD
            // 
            this.rdUSD.AutoSize = true;
            this.rdUSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdUSD.Location = new System.Drawing.Point(105, 7);
            this.rdUSD.Margin = new System.Windows.Forms.Padding(4);
            this.rdUSD.Name = "rdUSD";
            this.rdUSD.Size = new System.Drawing.Size(83, 22);
            this.rdUSD.TabIndex = 9;
            this.rdUSD.TabStop = true;
            this.rdUSD.Text = "Dollars";
            this.rdUSD.UseVisualStyleBackColor = true;
            this.rdUSD.CheckedChanged += new System.EventHandler(this.rdUSD_CheckedChanged);
            // 
            // rdEuro
            // 
            this.rdEuro.AutoSize = true;
            this.rdEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdEuro.Location = new System.Drawing.Point(4, 7);
            this.rdEuro.Margin = new System.Windows.Forms.Padding(4);
            this.rdEuro.Name = "rdEuro";
            this.rdEuro.Size = new System.Drawing.Size(74, 22);
            this.rdEuro.TabIndex = 10;
            this.rdEuro.TabStop = true;
            this.rdEuro.Text = "Euros";
            this.rdEuro.UseVisualStyleBackColor = true;
            this.rdEuro.CheckedChanged += new System.EventHandler(this.rdEuro_CheckedChanged);
            // 
            // rdVND
            // 
            this.rdVND.AutoSize = true;
            this.rdVND.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdVND.Location = new System.Drawing.Point(204, 7);
            this.rdVND.Margin = new System.Windows.Forms.Padding(4);
            this.rdVND.Name = "rdVND";
            this.rdVND.Size = new System.Drawing.Size(63, 22);
            this.rdVND.TabIndex = 11;
            this.rdVND.TabStop = true;
            this.rdVND.Text = "VND";
            this.rdVND.UseVisualStyleBackColor = true;
            this.rdVND.CheckedChanged += new System.EventHandler(this.rdVND_CheckedChanged);
            // 
            // btnDoIt
            // 
            this.btnDoIt.BackColor = System.Drawing.SystemColors.Window;
            this.btnDoIt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoIt.Location = new System.Drawing.Point(409, 264);
            this.btnDoIt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDoIt.Name = "btnDoIt";
            this.btnDoIt.Size = new System.Drawing.Size(151, 40);
            this.btnDoIt.TabIndex = 12;
            this.btnDoIt.Text = "Do it!";
            this.btnDoIt.UseVisualStyleBackColor = false;
            this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCost.Location = new System.Drawing.Point(523, 58);
            this.lbCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(39, 18);
            this.lbCost.TabIndex = 13;
            this.lbCost.Text = "VND";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdEuro);
            this.panel1.Controls.Add(this.rdUSD);
            this.panel1.Controls.Add(this.rdVND);
            this.panel1.Location = new System.Drawing.Point(233, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 36);
            this.panel1.TabIndex = 14;
            // 
            // lbCurrency
            // 
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrency.Location = new System.Drawing.Point(523, 229);
            this.lbCurrency.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(39, 18);
            this.lbCurrency.TabIndex = 17;
            this.lbCurrency.Text = "VND";
            // 
            // txtChangeCurrency
            // 
            this.txtChangeCurrency.Location = new System.Drawing.Point(233, 223);
            this.txtChangeCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.txtChangeCurrency.Name = "txtChangeCurrency";
            this.txtChangeCurrency.Size = new System.Drawing.Size(282, 22);
            this.txtChangeCurrency.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.753846F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 225);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "hoặc :";
            // 
            // CashPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(573, 317);
            this.Controls.Add(this.lbCurrency);
            this.Controls.Add(this.txtChangeCurrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.btnDoIt);
            this.Controls.Add(this.lbPay);
            this.Controls.Add(this.lbChange);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CashPayment";
            this.Text = "CashPayment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.Label lbChange;
        private System.Windows.Forms.Label lbPay;
        private System.Windows.Forms.RadioButton rdUSD;
        private System.Windows.Forms.RadioButton rdEuro;
        private System.Windows.Forms.RadioButton rdVND;
        private System.Windows.Forms.Button btnDoIt;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCurrency;
        private System.Windows.Forms.TextBox txtChangeCurrency;
        private System.Windows.Forms.Label label6;
    }
}