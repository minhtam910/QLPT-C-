namespace QLNT
{
    partial class GuestRoom
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
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtRoomInfo = new System.Windows.Forms.TextBox();
            this.Notification = new System.Windows.Forms.TabPage();
            this.dgvThongBao = new System.Windows.Forms.DataGridView();
            this.ServiceDetail = new System.Windows.Forms.TabPage();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.btnDatMon = new System.Windows.Forms.Button();
            this.txtThongBao = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.Notification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).BeginInit();
            this.ServiceDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROOM";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Enabled = false;
            this.txtRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(115, 7);
            this.txtRoomNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(176, 32);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "GUEST";
            // 
            // txtGuestName
            // 
            this.txtGuestName.Enabled = false;
            this.txtGuestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(654, 6);
            this.txtGuestName.Margin = new System.Windows.Forms.Padding(2);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(176, 32);
            this.txtGuestName.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabInfo);
            this.groupBox1.Location = new System.Drawing.Point(15, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(815, 416);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Inf";
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tabPage1);
            this.tabInfo.Controls.Add(this.Notification);
            this.tabInfo.Controls.Add(this.ServiceDetail);
            this.tabInfo.Location = new System.Drawing.Point(4, 17);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(811, 392);
            this.tabInfo.TabIndex = 0;
            this.tabInfo.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtRoomInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(803, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtRoomInfo
            // 
            this.txtRoomInfo.Enabled = false;
            this.txtRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomInfo.Location = new System.Drawing.Point(3, 5);
            this.txtRoomInfo.Margin = new System.Windows.Forms.Padding(2);
            this.txtRoomInfo.Multiline = true;
            this.txtRoomInfo.Name = "txtRoomInfo";
            this.txtRoomInfo.Size = new System.Drawing.Size(794, 362);
            this.txtRoomInfo.TabIndex = 0;
            this.txtRoomInfo.Text = "Thông tin khách hàng từ DB sẽ được fill vào đây";
            // 
            // Notification
            // 
            this.Notification.Controls.Add(this.txtThongBao);
            this.Notification.Controls.Add(this.dgvThongBao);
            this.Notification.Location = new System.Drawing.Point(4, 22);
            this.Notification.Margin = new System.Windows.Forms.Padding(2);
            this.Notification.Name = "Notification";
            this.Notification.Padding = new System.Windows.Forms.Padding(2);
            this.Notification.Size = new System.Drawing.Size(803, 366);
            this.Notification.TabIndex = 1;
            this.Notification.Text = "Thông báo của nhà trọ";
            this.Notification.UseVisualStyleBackColor = true;
            // 
            // dgvThongBao
            // 
            this.dgvThongBao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongBao.Location = new System.Drawing.Point(5, 5);
            this.dgvThongBao.Name = "dgvThongBao";
            this.dgvThongBao.Size = new System.Drawing.Size(793, 82);
            this.dgvThongBao.TabIndex = 0;
            // 
            // ServiceDetail
            // 
            this.ServiceDetail.Controls.Add(this.btnBack);
            this.ServiceDetail.Controls.Add(this.dgvDichVu);
            this.ServiceDetail.Controls.Add(this.btnDatMon);
            this.ServiceDetail.Location = new System.Drawing.Point(4, 22);
            this.ServiceDetail.Margin = new System.Windows.Forms.Padding(2);
            this.ServiceDetail.Name = "ServiceDetail";
            this.ServiceDetail.Padding = new System.Windows.Forms.Padding(2);
            this.ServiceDetail.Size = new System.Drawing.Size(803, 366);
            this.ServiceDetail.TabIndex = 2;
            this.ServiceDetail.Text = "Dịch vụ";
            this.ServiceDetail.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(642, 338);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Location = new System.Drawing.Point(5, 3);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(793, 150);
            this.dgvDichVu.TabIndex = 2;
            this.dgvDichVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDichVu_CellClick);
            // 
            // btnDatMon
            // 
            this.btnDatMon.Location = new System.Drawing.Point(723, 338);
            this.btnDatMon.Name = "btnDatMon";
            this.btnDatMon.Size = new System.Drawing.Size(75, 23);
            this.btnDatMon.TabIndex = 1;
            this.btnDatMon.Text = "Đặt món";
            this.btnDatMon.UseVisualStyleBackColor = true;
            this.btnDatMon.Click += new System.EventHandler(this.btnDatMon_Click);
            // 
            // txtThongBao
            // 
            this.txtThongBao.Location = new System.Drawing.Point(9, 98);
            this.txtThongBao.Name = "txtThongBao";
            this.txtThongBao.Size = new System.Drawing.Size(788, 117);
            this.txtThongBao.TabIndex = 1;
            this.txtThongBao.Text = "";
            // 
            // GuestRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GuestRoom";
            this.Text = "GuestRoom";
            this.Load += new System.EventHandler(this.GuestRoom_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabInfo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Notification.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongBao)).EndInit();
            this.ServiceDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage Notification;
        private System.Windows.Forms.TextBox txtRoomInfo;
        private System.Windows.Forms.TabPage ServiceDetail;
        private System.Windows.Forms.Button btnDatMon;
        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridView dgvThongBao;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox txtThongBao;
    }
}