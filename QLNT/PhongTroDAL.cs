using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class PhongTroDAL
	{
		private static PhongTroDAL instance;
		public static PhongTroDAL get()
		{
			if (instance == null)
			{
				instance = new PhongTroDAL();
			}
			return instance;
		}

		private DBAccess manager;

		private PhongTroDAL()
		{
			manager = new DBAccess();
			manager.open();
		}
		DataTable rs = null;
		DBAccess data = new DBAccess();

		//load thông tin các phòng
		public DataTable LoadThongTinPhong()
		{
			String sql = "select MaPhong, (case when TrangThai = '1' THEN N'Phòng đã thuê' else N'Phòng còn trống' end) as TrangThai, ThongTinPhong, (case when SoNguoi IS NULL THEN 0 else SoNguoi end) as SoNguoi from PHONG_TRO";
			rs = manager.executeQuery(sql);
			return rs;
		}

		//load chi tiết khách thuê phòng
		public DataTable LoadChiTietThuePhong(PhongTro phongtro)
		{
			String sql = "select PHONG_TRO.MaPhong, CT_KHACH_THUE.MaKhach, CT_KHACH_THUE.TenKhach, KHACH_THUE.Phai, KHACH_THUE.NgheNghiep, CT_KHACH_THUE.NgayVaoPhong from PHONG_TRO, CT_KHACH_THUE, KHACH_THUE where PHONG_TRO.MaPhong = CT_KHACH_THUE.MaPhong and	CT_KHACH_THUE.MaKhach = KHACH_THUE.MaKhach and PHONG_TRO.MaPhong = '" + phongtro.getMaPhong() + "'";
			rs = manager.executeQuery(sql);
			return rs;
		}
	}
}
