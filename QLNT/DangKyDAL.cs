using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class DangKyDAL
	{

		private static DangKyDAL instance;
		public static DangKyDAL get()
		{
			if (instance == null)
			{
				instance = new DangKyDAL();
			}
			return instance;
		}

		private DBAccess manager;

		private DangKyDAL()
		{
			manager = new DBAccess();
			manager.open();
		}

		//Load các khách thuê chưa có phòng

		public DataTable LoadPhongDaiHan()
        {
			String sql = "select MaPhong from PHONG_TRO where LoaiPhong like  N'Dài hạn' and TrangThai = 1";
			DataTable table = manager.executeQuery(sql);
			return table;
		}
		public DataTable LoadKhachThueChuaCoPhong()
		{
			String sql = "select Makhach, TenKhach, Phai, QueQuan, NgheNghiep from KHACH_THUE where MaKhach not in (select MaKhach from CT_KHACH_THUE)";
			DataTable table = manager.executeQuery(sql);
			return table;
		}

	//Load các phòng chưa có khách vào combobox
		public DataTable LoadPhongChuaCoKhach()
		{
			String sql = "select MaPhong from PHONG_TRO where TrangThai = 0";
			DataTable table = manager.executeQuery(sql);
			return table;
		}

	//Load các phòng đã có khách vào combobox
		public DataTable LoadPhongDaCoKhach()
		{
			String sql = "select MaPhong from PHONG_TRO where TrangThai = 1";
			DataTable table = manager.executeQuery(sql);
			return table;
		}

		//Load danh sách các khách
		public DataTable LoadChiTietKhachThue(DangKy dangkyphong)
		{ 
			String sql = "select CT_KHACH_THUE.TenKhach, KHACH_THUE.Phai, KHACH_THUE.NgheNghiep, Convert(varchar,NgayVaoPhong,103) as NgayVaoPhong from CT_KHACH_THUE, KHACH_THUE where CT_KHACH_THUE.MaKhach = KHACH_THUE.MaKhach and MaPhong = '" + dangkyphong.getMaPhong()+"'";
			DataTable table = manager.executeQuery(sql);
			return table;
		}

		//Thêm khách ở ghép
		public bool ThemKhachOghep(DangKy dangkyphong)
		{
			SqlParameter p1 = new SqlParameter("@makhach", dangkyphong.getMaKhach());
			SqlParameter p2 = new SqlParameter("@maphong", dangkyphong.getMaPhong());
			SqlParameter p3 = new SqlParameter("@ngayvaophong", dangkyphong.getNgayVaoPhong());
			SqlParameter p4 = new SqlParameter("@ghichu", "");

			SqlParameter[] giatri = { p1, p2, p3, p4 };

			return manager.Update(@"dbo.[ThemKhachThueVaooGhep]", giatri);
		}

	//Thêm khách ở phòng mới
	public bool ThemKhachThueVaoPhongMoi(DangKy dangkyphong)
	{
			SqlParameter p1 = new SqlParameter("@makhach", dangkyphong.getMaKhach());
			SqlParameter p2 = new SqlParameter("@maphong", dangkyphong.getMaPhong());
			SqlParameter p3 = new SqlParameter("@ngayvaophong", dangkyphong.getNgayVaoPhong());
			SqlParameter p4 = new SqlParameter("@ghichu", "");

			SqlParameter[] giatri = { p1, p2, p3, p4 };

			return manager.Update(@"dbo.[ThemKhachThueVaoPhongMoi]", giatri);
		}

		public bool ThemKhachThue(DangKy dangkyphong)
		{
			SqlParameter p1 = new SqlParameter("@makhach", dangkyphong.getMaKhach());
			SqlParameter p2 = new SqlParameter("@maphong", dangkyphong.getMaPhong());
			SqlParameter p3 = new SqlParameter("@ngayvaophong", dangkyphong.getNgayVaoPhong());

			SqlParameter[] giatri = { p1, p2, p3 };

			return manager.Update(@"dbo.[ThemKhachThue]", giatri);
		}

		//Lấy danh sách các phòng còn chỗ trống cho khách mới ở ghép
		public DataTable loadMaPhongOGhep()
	{
		String sql = "select MaPhong from PHONG_TRO where MaPhong in (select MaPhong from CT_KHACH_THUE)";
			DataTable table = manager.executeQuery(sql);
			return table;
		}

	//Lấy danh sách các phòng còn chỗ trống cho khách mới thuê
	public DataTable LoadMaPhongMoi()
	{
		String sql = "select MaPhong from PHONG_TRO where MaPhong not in (select MaPhong from CT_KHACH_THUE)";
			DataTable table = manager.executeQuery(sql);
			return table;
	}
}
}
