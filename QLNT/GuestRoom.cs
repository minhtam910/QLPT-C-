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
        CookService cookService;
        ThongBaoService service;
        List<ThongTinHoaDon> listThongTin;

        public GuestRoom(String maPhong, ThongBaoService service, List<ThongTinHoaDon> list)
        {
            this.maPhong = maPhong;
            this.service = service;
            listThongTin = list;

            InitializeComponent();
            dangKyBLL = new DangKyBLL();
            dichVuBLL = new DichVuBLL();
            cookService = new CookService();
            dangKy = new DangKy();
            dangKy.setMaPhong(maPhong);
            Console.WriteLine("List count: " + listThongTin.Count);
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

            cookService.order(maDichVu, maKhach, maPhong, listThongTin);
            //dichVuBLL.DatDichVu(maPhong, maKhach, maDichVu);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(service, listThongTin);
            f1.Show();
            this.Hide();
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

            dgvThongBao.DataSource = dichVuBLL.LoadThongBao();
            dgvThongBao.Columns["NoiDung"].HeaderText = "Nội dung";
            dgvThongBao.Columns["NgayLap"].HeaderText = "Ngày đăng";

        }

    }
}
