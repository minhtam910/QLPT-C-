using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class KhachThueDAL
	{
		private static KhachThueDAL instance;
		public static KhachThueDAL get()
		{
			if (instance == null)
			{
				instance = new KhachThueDAL();
			}
			return instance;
		}

		private DBAccess manager;

		private KhachThueDAL()
		{
			manager = new DBAccess();
			manager.open();
		}
		DataTable rs = null;
		DBAccess data = new DBAccess();

		//load tất cả các khách thuê
		public DataTable Loadall()
		{
			String sql = "select KHACH_THUE .*, Username from KHACH_THUE left join USER_KHACHTHUE on KHACH_THUE.MaKhach = USER_KHACHTHUE.MaKhach";
			DataTable table = manager.executeQuery(sql);
			return table;
		}
		/*Load khách thuê đặt phòng
		public DataTable loadkhachthuedatphong() 
		{
			String sql = "select username, Tenkhach, email, phai, cmnd, quequan, nghenghiep, dienthoai  from USER_KHACHTHUE where Tinhtrang = 1";
			rs = data.executeQuery(sql);
			return rs;
		}*/

		//Tìm khách thuê theo tên
		public DataTable TimKhachThueTheoTen(KhachThue khachthue)
		{
			String sql = "select * from KHACH_THUE where TenKhach like N'%" + khachthue.getTenKhach() + "%'";
			rs = manager.executeQuery(sql);
			return rs;
		}

		//Tìm khách thuê theo mã khách thuê
		public DataTable TimKhachThueTheoMa(KhachThue khachthue)
		{
			String sql = "select * from KHACH_THUE where MaKhach like N'%" + khachthue.getMaKhach() + "%'";
			rs = manager.executeQuery(sql);
			return rs;
		}

		//Tìm khách thuê theo quê quán
		public DataTable TimKhachThueTheoQueQuan(KhachThue khachthue)
		{
			String sql = "select * from KHACH_THUE where QueQuan like N'%" + khachthue.getQuequan() + "%'";
			rs = manager.executeQuery(sql);
			return rs;
		}

		//Tìm khách thuê theo nghề nghiệp
		public DataTable TimKhachThueTheoNgheNghiep(KhachThue khachthue)
		{
			String sql = "select * from KHACH_THUE where NgheNghiep like N'%" + khachthue.getNgheNghiep() + "%'";
			rs = manager.executeQuery(sql);
			return rs;
		}

		//thêm khách thuê
		public bool ThemKhachthue(KhachThue khachthue)
		{
			SqlParameter p1 = new SqlParameter("@makhach", khachthue.getMaKhach());
			SqlParameter p2 = new SqlParameter("@tenkhach", khachthue.getTenKhach());
			SqlParameter p3 = new SqlParameter("@phai", khachthue.getPhai());
			SqlParameter p4 = new SqlParameter("@cmnd", khachthue.getCmnd());
			SqlParameter p5 = new SqlParameter("@quequan", khachthue.getQuequan());
			SqlParameter p6 = new SqlParameter("@nghenghiep", khachthue.getNgheNghiep());



			SqlParameter[] giatri = { p1, p2, p3, p4, p5, p6 };

			return manager.Update("ThemKhachThue", giatri);
		}

		//thêm khách thuê có đặt phòng trước
		/*public bool ThemKhachThueDatPhong(KhachThue khachthue)
		{
				SqlParameter p1 = new SqlParameter("@makhach", khachthue.getMaKhach());
				SqlParameter p2 = new SqlParameter("@tenkhach", khachthue.getTenKhach());
				SqlParameter p3 = new SqlParameter("@phai", khachthue.getPhai());
				SqlParameter p4 = new SqlParameter("@cmnd", khachthue.getCmnd());
				SqlParameter p5 = new SqlParameter("@quequan", khachthue.getQuequan());
				SqlParameter p6 = new SqlParameter("@nghenghiep", khachthue.getNgheNghiep());



				SqlParameter[] giatri = { p1, p2, p3, p4, p5, p6 };

				return data.Update("ThemKhachThueDatPhong", giatri);
		}*/

		//Xóa khách thuê
		public bool XoaKhach(KhachThue khachthue)
		{
			SqlParameter p1 = new SqlParameter("@makhach", khachthue.getMaKhach());

			SqlParameter[] giatri = { p1 };

			return data.Update("XoaKhach", giatri);

		}

		//Sửa khách thuê
		public bool SuaKhachthue(KhachThue khachthue)
		{
			SqlParameter p1 = new SqlParameter("@makhach", khachthue.getMaKhach());
			SqlParameter p2 = new SqlParameter("@tenkhach", khachthue.getTenKhach());
			SqlParameter p3 = new SqlParameter("@phai", khachthue.getPhai());
			SqlParameter p4 = new SqlParameter("@cmnd", khachthue.getCmnd());
			SqlParameter p5 = new SqlParameter("@quequan", khachthue.getQuequan());
			SqlParameter p6 = new SqlParameter("@nghenghiep", khachthue.getNgheNghiep());


			SqlParameter[] giatri = { p1, p2, p3, p4, p5, p6 };
			return data.Update("SuaKhachThue", giatri);
		}
	}
}
