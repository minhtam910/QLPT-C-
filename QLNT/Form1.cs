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
<<<<<<< Updated upstream
		DichVuBLL dichvu = new DichVuBLL();
=======
		ThongBaoService service;
		List<ThongTinHoaDon> listThongTin;
		Dictionary<String, Object> listObject;
		IndividualEnDisableCommand iCommand;
		EnDisableCommand complexCommand;
		ComplexControlsAdapter complexAdapter;
>>>>>>> Stashed changes

		public Form1()
		{
			InitializeComponent();
<<<<<<< Updated upstream
			cbGioiTinh.SelectedItem = "Nam";
			cbTimKiem.SelectedItem = "Mã Khách";
=======
			this.service = service;
			listThongTin = list;
			this.listObject = listObject;
			complexCommand = new EnDisableCommand();
			

			dangKyBLL = new DangKyBLL(listObject);
			khachThueBLL = new KhachThueBLL(listObject);

			Console.WriteLine("Number of observers: " + service.getListObservers().Count);
			Console.WriteLine("Number of booked room: " + listThongTin.Count);
			foreach (ThongTinHoaDon thd in listThongTin)
            {
				Console.WriteLine(thd.getMaKhach());
				Console.WriteLine(thd.getDescription());
				Console.WriteLine(thd.cost());
			}
>>>>>>> Stashed changes
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();
<<<<<<< Updated upstream
			dgvTrangThaiPhong.DataSource = phongTroBLL.loadThongTinPhong();
			dgvThongTinGiaThue.DataSource = phongBLL.LoadThongTinGiaThue();
			dgvDanhSachKhachChuaCoPhong.DataSource = dangKyBLL.loadKhachThueChuaCoPhong();
=======
			dgvTrangThaiPhong.DataSource = phongTroBLL.LoadThongTinPhong();	
			
			dgvDanhSachKhachChuaCoPhong.DataSource = dangKyBLL.LoadKhachThueChuaCoPhong();
>>>>>>> Stashed changes
			dgvPhongCoKhachThue.DataSource = dangKyBLL.LoadPhongDaCoKhach();
			dgvThang.DataSource = thongKeBLL.loadthang();
			dgvDichVu.DataSource = dichvu.LoadDoAn();


			txtCMND.Enabled = false;
			txtMaKhach.Enabled = false;
			txtNgheNghiep.Enabled = false;
			txtQueQuan.Enabled = false;
			txtTenKhach.Enabled = false;
			cbGioiTinh.Enabled = false;

<<<<<<< Updated upstream
			txtMaDoAn.Enabled = false;
			txtTenDoAn.Enabled = false;
			txtGiaDoAn.Enabled = false;
=======
			cbGioiTinh.SelectedItem = "Nam";
			cbTimKiem.SelectedItem = "Mã Khách";

			cbPhongTrong.DataSource = dangKyBLL.LoadPhongChuaCoKhach();
			cbPhongTrong.DisplayMember = "MaPhong";
			cbPhongTrong.ValueMember = "MaPhong";

			cbPhongOGhep.DataSource = dangKyBLL.LoadPhongDaiHan();
			cbPhongOGhep.DisplayMember = "MaPhong";
			cbPhongOGhep.ValueMember = "MaPhong";

			List<Control> listTxtControls = new List<Control>() { txtCMND, txtMaKhach, txtNgheNghiep, txtQueQuan, txtTenKhach, cbGioiTinh, btnCapNhat, btnSua, btnThemMoi, btnXoa, btnCheckOut, btnThemKhachDangKy, cbPhongOGhep, cbPhongTrong, btnDangThongBao };
			complexCommand.setListControls(listTxtControls);
			complexCommand.disable();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadDataGridView();
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
=======


			complexCommand.setListControls(new List<Control>(){ btnSua });
			complexAdapter = new ComplexControlsAdapter(complexCommand);
			complexAdapter.enable();

			complexCommand.setListControls(new List<Control>(){ btnThem });
			complexAdapter = new ComplexControlsAdapter(complexCommand);
			complexAdapter.disable();
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream

=======
				List<Control> listTxtControls = new List<Control>() { txtCMND, txtMaKhach, txtNgheNghiep, txtQueQuan, txtTenKhach, cbGioiTinh, btnCapNhat };
				complexCommand.setListControls(listTxtControls);
				complexCommand.disable();
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
			txtCMND.Enabled = true;
			txtMaKhach.Enabled = true;
			txtNgheNghiep.Enabled = true;
			txtQueQuan.Enabled = true;
			txtTenKhach.Enabled = true;
			cbGioiTinh.Enabled = true;
=======
			List<Control> listTxtControls = new List<Control>() { txtCMND, txtMaKhach, txtNgheNghiep, txtQueQuan, txtTenKhach, cbGioiTinh, btnThemMoi };

			complexCommand.setListControls(listTxtControls);
			complexCommand.enable();

			complexCommand.setListControls(new List<Control>(){ btnCapNhat });
			complexAdapter = new ComplexControlsAdapter(complexCommand);
			complexAdapter.disable();
>>>>>>> Stashed changes
		}

		private void btnSua_Click(object sender, EventArgs e)
		{
<<<<<<< Updated upstream
			txtCMND.Enabled = true;
			txtMaKhach.Enabled = true;
			txtNgheNghiep.Enabled = true;
			txtQueQuan.Enabled = true;
			txtTenKhach.Enabled = true;
			cbGioiTinh.Enabled = true;
=======
			if(!txtMaKhach.Text.Equals(""))
            {
				List<Control> listTxtControls = new List<Control>() { txtCMND, txtMaKhach, txtNgheNghiep, txtQueQuan, txtTenKhach, cbGioiTinh, btnCapNhat};

				complexCommand.setListControls(listTxtControls);
				complexCommand.enable();

				listTxtControls = new List<Control>() { btnThemMoi };
				complexAdapter = new ComplexControlsAdapter(complexCommand);
				complexAdapter.disable();
			}
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
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
=======
		
>>>>>>> Stashed changes

		

<<<<<<< Updated upstream
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
=======
		
>>>>>>> Stashed changes

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
<<<<<<< Updated upstream
			cbPhongOGhep.Enabled = false;
			cbPhongTrong.Enabled = true;
=======
			complexCommand.setListControls(new List<Control>() { cbPhongOGhep });
			complexAdapter = new ComplexControlsAdapter(complexCommand);
			complexAdapter.disable();

			complexCommand.setListControls(new List<Control>() { cbPhongTrong, btnThemKhachDangKy });
			complexCommand.enable();
>>>>>>> Stashed changes
		}

		private void rbtnOGhep_CheckedChanged(object sender, EventArgs e)
		{
<<<<<<< Updated upstream
			cbPhongTrong.Enabled = false;
			cbPhongOGhep.Enabled = true;
=======
			complexCommand.setListControls(new List<Control>() { cbPhongTrong });
			complexAdapter = new ComplexControlsAdapter(complexCommand);
			complexAdapter.disable();

			complexCommand.setListControls(new List<Control>() { cbPhongTrong, btnThemKhachDangKy });
			complexCommand.enable();
>>>>>>> Stashed changes
		}

		private void cbPhongTrong_SelectedIndexChanged(object sender, EventArgs e)
		{
			cbPhongTrong.Items.Add(dangKyBLL.LoadPhongChuaCOKhach());
		}

		private void cbPhongOGhep_SelectedIndexChanged(object sender, EventArgs e)
		{
			 
		}

<<<<<<< HEAD
        private void tabPage1_Click(object sender, EventArgs e)
        {
			dgvDSKhachThue.DataSource = khachThueBLL.LoadKhachThue();
		}
    }
=======
        private void label26_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream

=======
            try
            {
				indexRowKhach = e.RowIndex;
				DataGridViewRow row = dgvChiTietPhong.Rows[indexRowKhach];
				maKhach = row.Cells[0].Value.ToString();
				complexCommand.setListControls(new List<Control>() { btnCheckOut });
				complexAdapter = new ComplexControlsAdapter(complexCommand);
				complexAdapter.enable();
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
        }

        private void btnDangThongBao_Click(object sender, EventArgs e)
        {
			
>>>>>>> Stashed changes
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
			indexRowKhach = e.RowIndex;
			DataGridViewRow row = dgvDichVu.Rows[indexRowKhach];

			txtMaDoAn.Text = row.Cells[0].Value.ToString();
			txtTenDoAn.Text = row.Cells[1].Value.ToString();
			txtGiaDoAn.Text = row.Cells[2].Value.ToString();
			
		}

        private void dgvDSKhachThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream

        }

		private void button4_Click(object sender, EventArgs e)
		{
			


				string message = "Do you want to close this window?";
				string title = "Close Window";
				MessageBoxButtons buttons = MessageBoxButtons.YesNo;
				DialogResult result = MessageBox.Show(message, title, buttons);
				if (result == DialogResult.Yes)
				{
					try
=======
			complexCommand.setListControls(new List<Control>() { btnXoa });
			complexAdapter = new ComplexControlsAdapter(complexCommand);
			if (txtMaKhach.Text.Equals(""))
				complexAdapter.disable();
			else
				complexAdapter.enable();
        }

        private void txtThongBao_TextChanged(object sender, EventArgs e)
        {
			complexCommand.setListControls(new List<Control>() { btnDangThongBao });
			complexAdapter = new ComplexControlsAdapter(complexCommand);
			if (!txtThongBao.Text.Equals(""))
				complexAdapter.enable();
			else
				complexAdapter.disable();
		}

        private void button1_Click_1(object sender, EventArgs e)
        {
			SelectInfo selectInfo = new SelectInfo(service, listThongTin, listObject);
			selectInfo.Show();
			this.Hide();
		}

        private void dgvTrangThaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
			try
            {
				complexCommand.setListControls(new List<Control>() { btnCheckOut });
				complexAdapter = new ComplexControlsAdapter(complexCommand);
				complexAdapter.disable();
				indexRowKhach = e.RowIndex;
				DataGridViewRow row = dgvTrangThaiPhong.Rows[indexRowKhach];
				maPhong = row.Cells[0].Value.ToString();
				DangKy dk = new DangKy();
				dk.setMaPhong(maPhong);
				dangKyBLL.getListObject()["DangKy"] = dk;
				dgvChiTietPhong.DataSource = dangKyBLL.LoadChiTietKhachThue();


				if(dgvChiTietPhong.Rows.Count > 1)
				{ 
					String makhach = dgvChiTietPhong.Rows[0].Cells[0].Value.ToString();
					ThongTinHoaDon thongTinHoaDon = null;

					for (int i = 0; i < listThongTin.Count(); i++)
>>>>>>> Stashed changes
					{
						int selectedIndex = dgvDichVu.CurrentCell.RowIndex;
						if (selectedIndex > -1)
						{
							DichVu dichVu = new DichVu();
							dichVu.setMaDoAn(txtMaDoAn.Text.ToString());
							dichvu.XoaDichVu(dichVu);
							dgvDichVu.DataSource = dichvu.LoadDoAn();
						}
					}

					catch (InvalidOperationException ex)
					{
						throw ex;
					}
				}
				else
				{
					this.Close();
				}

		}

        private void btnThem_DV_Click(object sender, EventArgs e)
        {
			txtMaDoAn.Enabled = true;
			txtTenDoAn.Enabled = true;
			txtGiaDoAn.Enabled = true;
			
		}



        private void btnEdit_DV_Click(object sender, EventArgs e)
        {


			txtMaDoAn.Enabled = false;
			txtTenDoAn.Enabled = true;
			txtGiaDoAn.Enabled = true;

			btnThem_DV.Enabled = false;
			btnXoa_DV.Enabled = false;
			btnEdit_DV.Enabled = false;
		}



		private void txtGiaDoAn_TextChanged(object sender, EventArgs e)
        {
			

		}

        private void button1_Click(object sender, EventArgs e)
        {
			DataGridViewRow updaterow = dgvDichVu.Rows[indexRowKhach];
			if (updaterow.Cells[0].Value == null || updaterow.Cells[1].Value == null || updaterow.Cells[2].Value == null)
			{
				MessageBox.Show("Hãy chọn khách hàng cần cập nhật");
			}
			else
			{

				DichVu dichVu = new DichVu();
				dichVu.setMaDoAn(txtMaDoAn.Text.ToString());
				dichVu.setTenDoAn(txtTenDoAn.Text.ToString());
				dichVu.setGiaTien(Convert.ToInt32(txtGiaDoAn.Text.ToString()));


				dichvu.SuaDichVu(dichVu);
				dgvDichVu.DataSource = dichvu.LoadDoAn();
			}

			txtMaDoAn.Enabled = false;
			txtTenDoAn.Enabled = false;
			txtGiaDoAn.Enabled = false;
			btnThem_DV.Enabled = true;
			btnXoa_DV.Enabled = true;
			btnEdit_DV.Enabled = true;
		}

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
			DichVu dv = new DichVu();

			string MaDoAn = txtMaDoAn.Text.ToString();
			string TenDoAn = txtTenDoAn.Text.ToString();



			if (txtMaDoAn.Text.ToString() == "" || txtTenDoAn.Text.ToString() == "" || txtGiaDoAn.Text.ToString() == "")
			{
				MessageBox.Show("Hãy điền đầy đủ thông tin");
			}

			else
			{
				dv.setMaDoAn(MaDoAn);
				dv.setTenDoAn(TenDoAn);
				dv.setGiaTien(Convert.ToInt32(txtGiaDoAn.Text.ToString()));

				dichvu.ThemDichVu(dv);
				dgvDichVu.DataSource = dichvu.LoadDoAn();
				MessageBox.Show("Thêm thành công.");
			}

			txtMaDoAn.Enabled = false;
			txtTenDoAn.Enabled = false;
			txtGiaDoAn.Enabled = false;

		}
	}
>>>>>>> e60da6275badb0aec4f6e8c5029a6786f369a23b
=======
			indexRowKhach = e.RowIndex;
			DataGridViewRow row = dgvDanhSachKhachChuaCoPhong.Rows[e.RowIndex];
			complexCommand.setListControls(new List<Control>() { rbtnOGhep, rbtnThuePhongMoi });
			complexCommand.enable();
        }
    }
>>>>>>> Stashed changes
}
