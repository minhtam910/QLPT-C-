
namespace QLNT
{
    partial class Checkout
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
            this.txtHoaDon = new System.Windows.Forms.RichTextBox();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnEBanking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.06154F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 1;
            // 
            // txtHoaDon
            // 
            this.txtHoaDon.Location = new System.Drawing.Point(4, 73);
            this.txtHoaDon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoaDon.Name = "txtHoaDon";
            this.txtHoaDon.Size = new System.Drawing.Size(671, 379);
            this.txtHoaDon.TabIndex = 2;
            this.txtHoaDon.Text = "";
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(493, 460);
            this.btnCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(182, 51);
            this.btnCash.TabIndex = 3;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnEBanking
            // 
            this.btnEBanking.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEBanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEBanking.Location = new System.Drawing.Point(4, 460);
            this.btnEBanking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEBanking.Name = "btnEBanking";
            this.btnEBanking.Size = new System.Drawing.Size(182, 51);
            this.btnEBanking.TabIndex = 4;
            this.btnEBanking.Text = "E-Banking";
            this.btnEBanking.UseVisualStyleBackColor = false;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(684, 531);
            this.Controls.Add(this.btnEBanking);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.txtHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Checkout";
            this.Text = "Checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtHoaDon;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnEBanking;
    }
}