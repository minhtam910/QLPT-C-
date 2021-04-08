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
		int indexRowThang;

		KhachThueBLL khachThueBLL = new KhachThueBLL();
		BangGiaPhongBLL phongBLL = new BangGiaPhongBLL();
		PhongTroBLL phongTroBLL = new PhongTroBLL();
		DangKyBLL dangKyBLL = new DangKyBLL();
		ThongKeBLL thongKeBLL = new ThongKeBLL();
		HoaDonBLL hoaDonBLL = new HoaDonBLL();

		public Form1()
		{
			InitializeComponent();
			cbGioiTinh.SelectedItem = "Nam";
			cbTimKiem.SelectedItem = "Mã Khách";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();
			dgvTrangThaiPhong.DataSource = phongTroBLL.loadThongTinPhong();
			dgvThongTinGiaThue.DataSource = phongBLL.LoadThongTinGiaThue();
			dgvDanhSachKhachChuaCoPhong.DataSource = dangKyBLL.loadKhachThueChuaCoPhong();
			dgvPhongCoKhachThue.DataSource = dangKyBLL.LoadPhongDaCoKhach();
			dgvThang.DataSource = thongKeBLL.loadthang();
			
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
				dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();

				MessageBox.Show("Thêm khách thành công.");
			}
			txtCMND.Enabled = false;
			txtMaKhach.Enabled = false;
			txtNgheNghiep.Enabled = false;
			txtQueQuan.Enabled = false;
			txtTenKhach.Enabled = false;
			cbGioiTinh.Enabled = false;
		}

		private void dgvTrangThaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string maphong = dgvTrangThaiPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
			PhongTro phongtro = new PhongTro();
			phongtro.setMaPhong(maphong);
			dgvChiTietPhong.DataSource =  phongTroBLL.LoadChiTietThuePhong(phongtro);
		}

		private void dgvPhongCoKhachThue_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string maphong = dgvTrangThaiPhong.Rows[e.RowIndex].Cells[0].Value.ToString();
			DangKy dangKy = new DangKy();
			dangKy.setMaPhong(maphong);
			dgvDanhSachKhachThuePhong.DataSource = dangKyBLL.loadChiTietKhachThue(dangKy);
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			try
			{
				int selectedIndex = dgvDSKhachThue.CurrentCell.RowIndex;
				if (selectedIndex > -1)
				{
					string message = "Roi co muon xoa hay la khong";
					string title = "Suy nghi cho ky";
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					DialogResult result = MessageBox.Show(message, title, buttons);
					if (result == DialogResult.Yes)
					{
						KhachThue khach = new KhachThue();
						khach.setMaKhach(txtMaKhach.Text.ToString());
						khachThueBLL.XoaKhachThue(khach);
						dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();
						MessageBox.Show("Goy xong, xoa luon goy hic");
					}
					else
					{
						this.Close();
					}
					
				}
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
				dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();
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
				dgvThongTinGiaThue.DataSource = phongBLL.LoadThongTinGiaThue();
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
					string message = "Xoa chua hay chua xoa";
					string title = "Xoa ha";
					MessageBoxButtons buttons = MessageBoxButtons.YesNo;
					DialogResult result = MessageBox.Show(message, title, buttons);
					if (result == DialogResult.Yes)
					{
						dgvThongTinGiaThue.Rows.RemoveAt(selectedIndex);
						dataGridView1.Refresh(); //
						MessageBox.Show("Xóa thành công");
					}
					else
					{
						this.Close();
					}
					
				}
			}
			catch (InvalidOperationException ex)
			{
				throw ex;
			}
		}

		private void dgvThang_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string thang = dgvThang.Rows[e.RowIndex].Cells[0].Value.ToString();
			ThongKe thongKe = new ThongKe();
			thongKe.setNgaylap(thang);
			dgvDanhSachHoaDon.DataSource = thongKeBLL.loadHDTheothang(thongKe);
		}

		private void dgvDanhSachHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string maphong = dgvDanhSachHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString();
			ThongKe thongKe = new ThongKe();
			thongKe.setMaphong(maphong);
			dgvTienPhong.DataSource = thongKeBLL.loadTienPhongTheoMa(thongKe);
		}

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
			cbPhongTrong.Items.Add(dangKyBLL.LoadPhongChuaCOKhach());
		}

		private void cbPhongOGhep_SelectedIndexChanged(object sender, EventArgs e)
		{
			 
		}

        private void tabPage1_Click(object sender, EventArgs e)
        {
			dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();
		}
    }
}
