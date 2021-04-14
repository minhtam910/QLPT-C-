using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class DangKyBLL
	{
		DangKyDAL data = DangKyDAL.get();

		public DataTable LoadKhachThueChuaCoPhong() 
		{
        return data.LoadKhachThueChuaCoPhong();
		}

		public DataTable LoadPhongDaiHan()
		{
				return data.LoadPhongDaiHan();
		}
		public DataTable LoadPhongChuaCoKhach() 
		{
			return data.LoadPhongChuaCoKhach();
		}

		public DataTable LoadPhongDaCoKhach()
		{
			return data.LoadPhongDaCoKhach();
		}

		public DataTable LoadChiTietKhachThue(DangKy dangKyPhong) 
		{
			return data.LoadChiTietKhachThue(dangKyPhong);
		}

		public DataTable LoadThongTinDichVu(DangKy dangKyPhong)
		{
			return data.LoadThongTinDichVu(dangKyPhong);
		}

			//Thêm khách ở ghép
		public bool ThemKhachOghep(DangKy dangKyPhong)
		{
			return data.ThemKhachOghep(dangKyPhong);
		}

		//Thêm khách ở phòng mới
		public bool ThemKhachThueVaoPhongMoi(DangKy dangKyPhong) 
		{
			return data.ThemKhachThueVaoPhongMoi(dangKyPhong);
		}

		//Load danh sách phòng có thể ở ghép
		public DataTable LoadMaPhongOGhep()
		{
			return data.LoadMaPhongOGhep();
		}

		//Load danh sách phòng có thể thuê mới
		public DataTable LoadMaPhongMoi()
		{
			return data.LoadMaPhongMoi();
		}

		public void ResetThongTinPhong(DangKy dangKyPhong)
        {
			data.ResetThongTinPhong(dangKyPhong);
        }
	}
}
