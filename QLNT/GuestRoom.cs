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
        CookWhat cookService;
        ThongBaoService service;
        List<ThongTinHoaDon> listThongTin;
        Dictionary<String, Object> listObject;
        ComplexControlsAdapter complexAdapter;
        EnDisableCommand complexCommand;

        public GuestRoom(String maPhong, ThongBaoService service, List<ThongTinHoaDon> list, Dictionary<String, Object> listObject)
        {
            this.maPhong = maPhong;
            this.service = service;
            listThongTin = list;
            this.listObject = listObject;
            DangKy dk = new DangKy();
            dk.setMaPhong(maPhong);
            this.listObject["DangKy"] = dk;

            InitializeComponent();
            dangKyBLL = new DangKyBLL(this.listObject);
            dichVuBLL = new DichVuBLL(this.listObject);
            cookService = new CookWhat(dichVuBLL);
            dangKy = new DangKy();
            dangKy.setMaPhong(maPhong);
            Console.WriteLine("List count: " + listThongTin.Count);

            complexCommand = new EnDisableCommand();

        }

       private void GuestRoom_Load(object sender, EventArgs e)
        {
           txtRoomNumber.Text = maPhong;

           dt = dangKyBLL.LoadChiTietKhachThue();
           txtGuestName.Text = dt.Rows[0][1].ToString();
           maKhach = dt.Rows[0][0].ToString();

           LoadAllInformation();
        }

        private void btnDatMon_Click(object sender, EventArgs e)
        {
            cookService.order(maDichVu, maKhach, maPhong, listThongTin);
            dichVuBLL.DatDichVu(maPhong, maKhach, maDichVu);
            LoadAllInformation();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1(service, listThongTin, listObject);
            f1.Show();
            this.Hide();
        }

        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maDichVu = dgvDichVu.Rows[e.RowIndex].Cells[0].Value.ToString();
            complexCommand.setListControls(new List<Control>() { btnDatMon });
            complexAdapter = new ComplexControlsAdapter(complexCommand);
            complexAdapter.enable();
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
            ThongTinHoaDon thongTinHoaDon = null;

            for (int i = 0; i < listThongTin.Count(); i++)
            {
                Console.WriteLine(listThongTin[i].getMaKhach());
                if (listThongTin[i].getMaKhach().Equals(maKhach))
                {
                    thongTinHoaDon = listThongTin[i];
                }
            }

            info += thongTinHoaDon.getDescription();

            info = info.Replace("@", " " + System.Environment.NewLine);
            txtRoomInfo.Text = info;

            dgvDichVu.DataSource = dichVuBLL.LoadDoAn();
            dgvDichVu.Columns["MaDoAn"].HeaderText = " Mã dịch Vụ";
            dgvDichVu.Columns["TenDoAn"].HeaderText = "Dịch Vụ";
            dgvDichVu.Columns["Gia"].HeaderText = "Giá tiền";

            dgvThongBao.DataSource = dichVuBLL.LoadThongBao();
            dgvThongBao.Columns["NoiDung"].HeaderText = "Nội dung";
            dgvThongBao.Columns["NgayLap"].HeaderText = "Ngày đăng";


            String tb = "";
            foreach(ThongBao thongBao in service.getListThongBao())
            {
                tb += thongBao.getNgayLap() + "/ " + thongBao.getNoiDung() + "@";
            }

            tb = tb.Replace("@", " " + System.Environment.NewLine);
            txtThongBao.Text = tb;

            complexCommand.setListControls(new List<Control>() { btnDatMon });
            complexAdapter = new ComplexControlsAdapter(complexCommand);
            complexAdapter.disable();
        }

    }
}
