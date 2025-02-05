﻿using System;
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

		public DataTable LoadMaPhongOGhep()
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

		//Load danh sách các khách
		public DataTable LoadChiTietKhachThue(Dictionary<String, Object> dict)
		{
			DangKy dangkyphong = (DangKy)dict["DangKy"];
			String sql = "select k.MaKhach, TenKhach, QueQuan, NgheNghiep, CMND, NgayVaoPhong from CT_KHACH_THUE c join KHACH_THUE k on c.MaKhach = k.MaKhach where MaPhong = '" + dangkyphong.getMaPhong()+"'";
			DataTable table = manager.executeQuery(sql);
			return table;
		}

		public DataTable LoadThongTinDichVu(Dictionary<String, Object> dict)
		{
			DangKy dangkyphong = (DangKy)dict["DangKy"];
			String sql = "select GhiChu from CT_KHACH_THUE c join KHACH_THUE k on c.MaKhach = k.MaKhach where MaPhong = '" + dangkyphong.getMaPhong() + "'";
			DataTable table = manager.executeQuery(sql);
			return table;
		}

		//Thêm khách ở ghép
		public bool ThemKhachOghep(Dictionary<String, Object> dict)
		{
			DangKy dangkyphong = (DangKy)dict["DangKy"];
			SqlParameter p1 = new SqlParameter("@makhach", dangkyphong.getMaKhach());
			SqlParameter p2 = new SqlParameter("@maphong", dangkyphong.getMaPhong());
			SqlParameter p3 = new SqlParameter("@ngayvaophong", dangkyphong.getNgayVaoPhong());
			SqlParameter p4 = new SqlParameter("@ghichu", "");

			SqlParameter[] giatri = { p1, p2, p3, p4 };

			return manager.Update(@"dbo.[ThemKhachThueVaooGhep]", giatri);
		}

	//Thêm khách ở phòng mới
		public bool ThemKhachThueVaoPhongMoi(Dictionary<String, Object> dict)
		{
			DangKy dangkyphong = (DangKy)dict["DangKy"];
			SqlParameter p1 = new SqlParameter("@makhach", dangkyphong.getMaKhach());
			SqlParameter p2 = new SqlParameter("@maphong", dangkyphong.getMaPhong());
			SqlParameter p3 = new SqlParameter("@ngayvaophong", dangkyphong.getNgayVaoPhong());
			SqlParameter p4 = new SqlParameter("@ghichu", "");

			SqlParameter[] giatri = { p1, p2, p3, p4 };

			return manager.Update(@"dbo.[ThemKhachThueVaoPhongMoi]", giatri);
		}

		public bool ThemKhachThue(Dictionary<String, Object> dict)
		{
			DangKy dangkyphong = (DangKy)dict["DangKy"];
			SqlParameter p1 = new SqlParameter("@makhach", dangkyphong.getMaKhach());
			SqlParameter p2 = new SqlParameter("@maphong", dangkyphong.getMaPhong());
			SqlParameter p3 = new SqlParameter("@ngayvaophong", dangkyphong.getNgayVaoPhong());

			SqlParameter[] giatri = { p1, p2, p3 };

			return manager.Update(@"dbo.[ThemKhachThue]", giatri);
		}

		//Lấy danh sách các phòng còn chỗ trống cho khách mới ở ghép



		public bool KhachCheckout(Dictionary<String, Object> dict)
        {
			DangKy dangkyphong = (DangKy)dict["DangKy"];
			SqlParameter p1 = new SqlParameter("@maphong", dangkyphong.getMaPhong());

			SqlParameter[] giatri = { p1};

			return manager.Update(@"dbo.[KhachCheckout]", giatri);
        }
    }
}
