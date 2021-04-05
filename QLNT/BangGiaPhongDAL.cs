using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class BangGiaPhongDAL
	{
		private static BangGiaPhongDAL instance;
		public static BangGiaPhongDAL get()
		{
			if (instance == null)
			{
				instance = new BangGiaPhongDAL();
			}
			return instance;
		}

		private DBAccess manager;

		private BangGiaPhongDAL()
		{
			manager = new DBAccess();
			manager.open();
		}

		DBAccess data = new DBAccess();


		public DataTable LoadThongTinGiaThue()
		{
			String sql = "select SoNguoi, PARSENAME(convert(varchar,convert(money,GiaTien),1),2 ) as giatien from GIA_THUE";
			DataTable table = manager.executeQuery(sql);
			return table;
		}

		//Thêm phòng mới vào bảng giá phòng
		public bool ThemPhong(BangGiaPhong banggia)
		{
			SqlParameter p1 = new SqlParameter("@songuoi", banggia.getSoNguoi());
			SqlParameter p2 = new SqlParameter("@giatien", banggia.getGiaTien());

			SqlParameter[] giatri = { p1, p2 };

			return manager.Update("ThemPhong", giatri);
		}

		public void SuaPhong(BangGiaPhong banggia)
		{
			SqlParameter p1 = new SqlParameter("@songuoi", banggia.getSoNguoi());
			SqlParameter p2 = new SqlParameter("@giatien", banggia.getGiaTien());

			SqlParameter[] giatri = { p1, p2 };

			data.Update("SuaPhong", giatri);
		}
	}
}
