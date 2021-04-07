using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QLNT
{
    class DV_DoAn_Factory: DV_Factory
    {
		
		private DBAccess manager;
		

		public DV_DoAn_Factory()
		{
			manager = new DBAccess();
			manager.open();
		}

		public DataTable LoadDoAn()
		{
			String sql = "select MaDoAn, TenDoAn, PARSENAME(convert(varchar,convert(money,Gia),1),2 ) as Gia from DICH_VU";
			DataTable table = manager.executeQuery(sql);
			return table;
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


			SqlParameter[] giatri = { p1, p2, p3};
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
