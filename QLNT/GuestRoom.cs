using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    public partial class GuestRoom : Form
    {
        private String maPhong, maKhach, maDichVu;
        DangKyBLL dangKyBLL;
        DichVuBLL dichVuBLL;
        DangKy dangKy;
        DataTable dt;
        public GuestRoom(String maPhong)
        {
            this.maPhong = maPhong;

            InitializeComponent();
            dangKyBLL = new DangKyBLL();
            dichVuBLL = new DichVuBLL();
            dangKy = new DangKy();
            dangKy.setMaPhong(maPhong);
        }

        private void GuestRoom_Load(object sender, EventArgs e)
        {
            txtRoomNumber.Text = maPhong;

            dt = dangKyBLL.LoadChiTietKhachThue(dangKy);
            txtGuestName.Text = dt.Rows[0][1].ToString();
            maKhach = dt.Rows[0][0].ToString();

            LoadAllInformation();
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            dichVuBLL.DatDichVu(maPhong, maKhach, maDichVu);
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maDichVu = dgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();    
        }

        public void LoadAllInformation()
        {           
            String info = "Thành viên phòng: @";

           
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                info += dt.Rows[i][1].ToString()  + "@";
            }

            info += "@";
            info += "Thông tin dịch vụ: @";
            DataTable dtdv = dichVuBLL.LoadDichVuDaDat(maKhach, maPhong);
            try
            {
                if(dtdv.Rows.Count == 0)
                {
                    info += "Chưa thực hiện yêu cầu dịch vụ nào!";
                }
                else
                {
                    for (int i = 0; i < dtdv.Rows.Count; i++)
                    {
                        info += dtdv.Rows[i][0].ToString() + "  , ngày đặt: " + dtdv.Rows[i][1].ToString() + "@";
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            info = info.Replace("@", " " + System.Environment.NewLine);
            txtRoomInfo.Text = info;

            dgvDichVu.DataSource = dichVuBLL.LoadDoAn();
            dgvDichVu.Columns["MaDoAn"].HeaderText = " Mã dịch Vụ";
            dgvDichVu.Columns["TenDoAn"].HeaderText = "Dịch Vụ";
            dgvDichVu.Columns["Gia"].HeaderText = "Giá tiền";

        }

    }
}
