using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLNT
{
    class DichVuDAL
    {
		private static DichVuDAL instance;
		public static DichVuDAL get()
		{
			if (instance == null)
			{
				instance = new DichVuDAL();
			}
			return instance;
		}

		private DBAccess manager;

		private DichVuDAL()
		{
			manager = new DBAccess();
			manager.open();
		}

		public DataTable LoadDoAn()
		{
			String sql = "select MaDoAn, TenDoAn, PARSENAME(convert(varchar,convert(money,Gia),1),2 ) as Gia from DICH_VU where TrangThai = 1";
			DataTable table = manager.executeQuery(sql);
			return table;
		}

		public void DatDichVu(String maPhong, String maKhach, String maDichVu)
        {
			SqlParameter p1 = new SqlParameter("@maDoAn", maDichVu);
			SqlParameter p2 = new SqlParameter("@ngayDat", DateTime.Now);
			SqlParameter p3 = new SqlParameter("@maPhong", maPhong);
			SqlParameter p4 = new SqlParameter("@maKhach", maKhach);
			String sql = "insert into CT_DICH_VU(MaDoAn,NgayDat,MaPhong,MaKhach) values (@maDoAn,@ngayDat,@maPhong,@maKhach)";
			SqlParameter[] parameters = { p1, p2, p3, p4 };
			manager.Insert(sql, parameters);
        }

		public DataTable LoadDichVuDaDat(String maPhong, String maKhach)
        {
			SqlParameter p1 = new SqlParameter("@maPhong", maPhong);
			SqlParameter p2 = new SqlParameter("@maKhach", maKhach);
			String sql = "select TenDoAn, NgayDat from CT_DICH_VU c join DICH_VU d on c.MaDoAn = d.MaDoAn where c.MaPhong = @maPhong and c.MaKhach = @maKhach";
			SqlParameter[] sqlParameters = { p1, p2 };
			DataTable dt = manager.Select(sql,sqlParameters);
			return dt;
		}

		public void ThemDichVu(DichVu dv)
		{
			SqlParameter p1 = new SqlParameter("@MaDoAn", dv.getMaDoAn());
			SqlParameter p2 = new SqlParameter("@TenDoAn", dv.getTenDoAn());
			SqlParameter p3 = new SqlParameter("@giatien", dv.getGiaTien());

			SqlParameter[] giatri = { p1, p2, p3 };


			manager.Update(@"dbo.[ThemDichVu]", giatri);
		}

		public bool SuaDichVu(DichVu dv)
		{
			SqlParameter p1 = new SqlParameter("@MaDoAn", dv.getMaDoAn());
			SqlParameter p2 = new SqlParameter("@TenDoAn", dv.getTenDoAn());
			SqlParameter p3 = new SqlParameter("@giatien", dv.getGiaTien());


			SqlParameter[] giatri = { p1, p2, p3 };
			return manager.Update(@"dbo.[SuaDichVu]", giatri);
		}

		public void XoaDichVu(DichVu dv)
		{
			SqlParameter p1 = new SqlParameter("@MaDoAn", dv.getMaDoAn());

			SqlParameter[] giatri = { p1 };

			String delete = "delete from CT_DICH_VU where MaDoAn = @MaDoAn; delete from DICH_VU where MaDoAn = @MaDoAn";

			manager.Delete(delete, giatri);

		}
	}
}
