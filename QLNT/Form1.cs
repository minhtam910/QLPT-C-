using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
	public partial class Form1 : Form
	{
		int indexRowKhach;
		int indexRowGia;
		String phongTrong, phongGhep, maPhong, maKhach;
		ThongBaoService service;

		KhachThueBLL khachThueBLL = new KhachThueBLL();
		BangGiaPhongBLL phongBLL = new BangGiaPhongBLL();
		PhongTroBLL phongTroBLL = new PhongTroBLL();
		DangKyBLL dangKyBLL = new DangKyBLL();
		ThongKeBLL thongKeBLL = new ThongKeBLL();
		HoaDonBLL hoaDonBLL = new HoaDonBLL();
		

		public Form1()
		{
			InitializeComponent();
			service = new ThongBaoService();
			Client test1 = new Client(service, "client1");
			Client test2 = new Client(service, "client2");
			service.registerObservers(test1);
			service.registerObservers(test2);
		}

		public void LoadDataGridView()
        {
			dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();
			dgvTrangThaiPhong.DataSource = phongTroBLL.LoadThongTinPhong();	
			dgvThongTinGiaThue.DataSource = phongBLL.LoadThongTinGiaThue();
			dgvDanhSachKhachChuaCoPhong.DataSource = dangKyBLL.LoadKhachThueChuaCoPhong();
			dgvPhongCoKhachThue.DataSource = dangKyBLL.LoadPhongDaCoKhach();
			//dgvThang.DataSource = thongKeBLL.Loadthang();
			txtCMND.Enabled = false;
			txtMaKhach.Enabled = false;
			txtNgheNghiep.Enabled = false;
			txtQueQuan.Enabled = false;
			txtTenKhach.Enabled = false;
			cbGioiTinh.Enabled = false;

			cbGioiTinh.SelectedItem = "Nam";
			cbTimKiem.SelectedItem = "Mã Khách";

			cbPhongTrong.DataSource = dangKyBLL.LoadPhongChuaCoKhach();
			cbPhongTrong.DisplayMember = "MaPhong";
			cbPhongTrong.ValueMember = "MaPhong";

			cbPhongOGhep.DataSource = dangKyBLL.LoadPhongDaiHan();
			cbPhongOGhep.DisplayMember = "MaPhong";
			cbPhongOGhep.ValueMember = "MaPhong";

			try
            {
				cbPhongOGhep.SelectedIndex = 0;
				cbPhongTrong.SelectedIndex = 0;
			}
			catch(Exception ex)
            {
				Console.WriteLine(ex.Message);
            }
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadDataGridView();
			
			txtCMND.Enabled = false;
			txtMaKhach.Enabled = false;
			txtNgheNghiep.Enabled = false;
			txtQueQuan.Enabled = false;
			txtTenKhach.Enabled = false;
			cbGioiTinh.Enabled = false;
		}



		private void btnThemMoi_Click(object sender, EventArgs e)
		{
			KhachThue khach = new KhachThue();

			if (txtCMND.Text.ToString() == "" || txtMaKhach.Text.ToString() == "" || txtNgheNghiep.Text.ToString() == null || txtQueQuan.Text.ToString() == null || txtTenKhach.Text.ToString() == null || cbGioiTinh.Text.ToString() == null)
			{
				MessageBox.Show("Hãy điền đầy đủ thông tin");
			}

			else
			{
				khach.setMaKhach(txtMaKhach.Text.ToString());
				khach.setCmnd(txtCMND.Text.ToString());
				khach.setNghenghiep(txtNgheNghiep.Text.ToString());
				khach.setQuequan(txtQueQuan.Text.ToString());
				khach.setTenKhach(txtTenKhach.Text.ToString());
				khach.setPhai(cbGioiTinh.Text.ToString());
				
				khachThueBLL.ThemKhachThueVaoPhongMoi(khach);
				//dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();
				LoadDataGridView();

				MessageBox.Show("Thêm khách thành công.");
			}
			txtCMND.Enabled = false;
			txtMaKhach.Enabled = false;
			txtNgheNghiep.Enabled = false;
			txtQueQuan.Enabled = false;
			txtTenKhach.Enabled = false;
			cbGioiTinh.Enabled = false;
		}

		private void dgvPhongCoKhachThue_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			maPhong = dgvPhongCoKhachThue.Rows[e.RowIndex].Cells[0].Value.ToString();
			DangKy dangKy = new DangKy();
			//MessageBox.Show(maphong);
			dangKy.setMaPhong(maPhong);
			dgvDanhSachKhachThuePhong.DataSource = dangKyBLL.LoadChiTietKhachThue(dangKy);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				int selectedIndex = dgvDSKhachThue.CurrentCell.RowIndex;
				if (selectedIndex > -1)
				{
					KhachThue khach = new KhachThue();
					khach.setMaKhach(txtMaKhach.Text.ToString());
					khachThueBLL.XoaKhachThue(khach);
					//dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();
				}
				LoadDataGridView();
			}
			catch (InvalidOperationException ex)
			{
				throw ex;
			}
		}

		private void dgvDSKhachThue_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			indexRowKhach = e.RowIndex;
			DataGridViewRow row = dgvDSKhachThue.Rows[indexRowKhach];

			txtMaKhach.Text = row.Cells[0].Value.ToString();
			txtTenKhach.Text = row.Cells[1].Value.ToString();
			cbGioiTinh.Text = row.Cells[2].Value.ToString();
			txtCMND.Text = row.Cells[3].Value.ToString();
			txtQueQuan.Text = row.Cells[4].Value.ToString();
			txtNgheNghiep.Text = row.Cells[5].Value.ToString();
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			DataGridViewRow updaterow = dgvDSKhachThue.Rows[indexRowKhach];
			if (updaterow.Cells[0].Value == null || updaterow.Cells[1].Value == null || updaterow.Cells[2].Value == null || updaterow.Cells[3].Value == null || updaterow.Cells[4].Value == null || updaterow.Cells[5].Value == null)
			{
				MessageBox.Show("Hãy chọn khách hàng cần cập nhật");
			}
			else
			{

				KhachThue khach = new KhachThue();
				khach.setMaKhach(txtMaKhach.Text.ToString());
				khach.setCmnd(txtCMND.Text.ToString());
				khach.setNghenghiep(txtNgheNghiep.Text.ToString());
				khach.setQuequan(txtQueQuan.Text.ToString());
				khach.setTenKhach(txtTenKhach.Text.ToString());
				khach.setPhai(cbGioiTinh.Text.ToString());

				khachThueBLL.SuaKhachThue(khach);
				//dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();
				LoadDataGridView();
			}
			txtCMND.Enabled = false;
			txtMaKhach.Enabled = false;
			txtNgheNghiep.Enabled = false;
			txtQueQuan.Enabled = false;
			txtTenKhach.Enabled = false;
			cbGioiTinh.Enabled = false;
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			txtCMND.Enabled = true;
			txtMaKhach.Enabled = true;
			txtNgheNghiep.Enabled = true;
			txtQueQuan.Enabled = true;
			txtTenKhach.Enabled = true;
			cbGioiTinh.Enabled = true;
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
			txtCMND.Enabled = true;
			txtMaKhach.Enabled = true;
			txtNgheNghiep.Enabled = true;
			txtQueQuan.Enabled = true;
			txtTenKhach.Enabled = true;
			cbGioiTinh.Enabled = true;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int index = cbTimKiem.SelectedIndex;
			String select = "select * from KHACH_THUE where ";
			SqlParameter p1 = new SqlParameter("@thamso", txtTimKiem.Text.ToString());

			SqlParameter[] parameters = { p1 };
			switch (index)
            {
				case 0: //ten
					select = select + "TenKhach=@thamso";
					break;
				case 1: //ma
					select = select + "MaKhach=@thamso";
					break;
				case 2: //que
					select = select + "QueQuan=@thamso";
					break;
				case 3: //nghe
					select = select + "NgheNghiep=@thamso";
					break;
				case 4: //phai
					select = select + "Phai=@thamso";
					break;
				case 5: //cmnd
					select = select + "CMND=@thamso";
					break;
			}

			dgvDSKhachThue.DataSource = khachThueBLL.TimKhachThue(select, parameters);
		}

		private void btnThemGiaPhong_Click(object sender, EventArgs e)
		{
			BangGiaPhong bangGiaPhong = new BangGiaPhong();

			int giatien = Convert.ToInt32(txtGiaTien.Text.ToString());
			int songuoi = Convert.ToInt32(txtSoNguoi.Text.ToString());

			if (txtGiaTien.Text.ToString() == "" || txtSoNguoi.Text.ToString() == "")
			{
				MessageBox.Show("Hãy điền đầy đủ thông tin");
			}

			else
			{
				bangGiaPhong.setGiaTien(giatien);
				bangGiaPhong.setSoNguoi(songuoi);

				phongBLL.ThemPhong(bangGiaPhong);
				//dgvThongTinGiaThue.DataSource = phongBLL.LoadThongTinGiaThue();
				MessageBox.Show("Thêm thành công.");
			}
		}

		private void btnCapNhatGiaPhong_Click(object sender, EventArgs e)
		{
			DataGridViewRow updaterow = dgvThongTinGiaThue.Rows[indexRowGia];
			if (updaterow.Cells[0].Value == null || updaterow.Cells[1].Value == null)
			{
				MessageBox.Show("Hãy chọn khách hàng cần cập nhật");
			}
			else
			{
				updaterow.Cells[0].Value = txtSoNguoi.Text;
				updaterow.Cells[1].Value = txtGiaTien.Text;
				MessageBox.Show("Cập nhật thành công");
			}
		}

		private void dgvThongTinGiaThue_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			indexRowGia = e.RowIndex;
			DataGridViewRow row = dgvThongTinGiaThue.Rows[indexRowGia];

			txtSoNguoi.Text = row.Cells[0].Value.ToString();
			txtGiaTien.Text = row.Cells[1].Value.ToString();
		}

		private void btnXoaGiaPhong_Click(object sender, EventArgs e)
		{
			try
			{
				int selectedIndex = dgvThongTinGiaThue.CurrentCell.RowIndex;
				if (selectedIndex > -1)
				{
					dgvThongTinGiaThue.Rows.RemoveAt(selectedIndex);
					dataGridView1.Refresh(); //
					MessageBox.Show("Xóa thành công");
				}
			}
			catch (InvalidOperationException ex)
			{
				throw ex;
			}
		}

		/*private void dgvThang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string thang = dgvThang.Rows[e.RowIndex].Cells[0].Value.ToString();
			ThongKe thongKe = new ThongKe();
			thongKe.setNgaylap(thang);
			dgvDanhSachHoaDon.DataSource = thongKeBLL.LoadHDTheothang(thongKe);
		}

		private void dgvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			maPhong = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
			ThongKe thongKe = new ThongKe();
			thongKe.setMaphong(maPhong);
			dgvTienPhong.DataSource = thongKeBLL.LoadTienPhongTheoMa(thongKe);
		}*/

		private void rbtnThuePhongMoi_CheckedChanged(object sender, EventArgs e)
		{
			cbPhongOGhep.Enabled = false;
			cbPhongTrong.Enabled = true;
		}

		private void rbtnOGhep_CheckedChanged(object sender, EventArgs e)
		{
			cbPhongTrong.Enabled = false;
			cbPhongOGhep.Enabled = true;
		}

		private void cbPhongTrong_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbPhongTrong.SelectedValue != null)
				phongTrong = cbPhongTrong.SelectedValue.ToString();
		}

		private void cbPhongOGhep_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(cbPhongOGhep.SelectedValue != null)
				phongGhep = cbPhongOGhep.SelectedValue.ToString();
		}

        private void btnThemKhachDangKy_Click(object sender, EventArgs e)
        {
            try 
			{
				DangKy dangKy = new DangKy();
				
				DataGridViewRow row = dgvDanhSachKhachChuaCoPhong.Rows[indexRowKhach];
				maKhach = row.Cells[0].Value.ToString();
				dangKy.setMaKhach(maKhach);
				dangKy.setNgayVaoPhong(DateTime.Now.ToString());
				if (cbPhongOGhep.Enabled == true)
				{
					dangKy.setMaPhong(phongGhep);
					dangKyBLL.ThemKhachOghep(dangKy);
				}
				else
				{
					dangKy.setMaPhong(phongTrong);
					dangKyBLL.ThemKhachThueVaoPhongMoi(dangKy);
				}
				MessageBox.Show("Thành công!");
				LoadDataGridView();
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
        }

        private void dgvChiTietPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
				indexRowKhach = e.RowIndex;
				DataGridViewRow row = dgvChiTietPhong.Rows[indexRowKhach];
				maKhach = row.Cells[0].Value.ToString();
				//MessageBox.Show(maKhach);
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
        }

        private void btnDangThongBao_Click(object sender, EventArgs e)
        {
			String noiDungThongBao = txtThongBao.Text.ToString();
			ThongBao tb = new ThongBao(noiDungThongBao, DateTime.Now);
			service.addThongBao(tb);
        }

        private void dgvTrangThaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			try
            {
				indexRowKhach = e.RowIndex;
				DataGridViewRow row = dgvTrangThaiPhong.Rows[indexRowKhach];
				maPhong = row.Cells[0].Value.ToString();
				DangKy dk = new DangKy();
				dk.setMaPhong(maPhong);

				dgvChiTietPhong.DataSource = dangKyBLL.LoadChiTietKhachThue(dk);

				DataTable dt = dangKyBLL.LoadThongTinDichVu(dk);
				if (dt.Rows.Count > 0)
					txtGhiChu.Text = dt.Rows[0][0].ToString();
				else
					txtGhiChu.Text = "Phòng trống";
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
		}

        private void btnReset_Click(object sender, EventArgs e)
        {
			try
            {
				DangKy dk = new DangKy();
				//if (!maKhach.Equals(""))
				//	dk.setMaKhach(maKhach);
				if (!maPhong.Equals(""))
					dk.setMaPhong(maPhong);
				dangKyBLL.ResetThongTinPhong(dk);
				LoadDataGridView();
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
        }

        private void dgvDanhSachKhachChuaCoPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			indexRowKhach = e.RowIndex;
			DataGridViewRow row = dgvDanhSachKhachChuaCoPhong.Rows[e.RowIndex];
			//MessageBox.Show(row.Cells[0].Value.ToString());
        }
    }
}
