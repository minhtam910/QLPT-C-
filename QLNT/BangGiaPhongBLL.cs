using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLNT
{
	class BangGiaPhongBLL
	{
		BangGiaPhongDAL data = BangGiaPhongDAL.get();

		public DataTable LoadThongTinGiaThue()
		{
			return data.LoadThongTinGiaThue();
		}

		public void ThemPhong(BangGiaPhong banggia)
		{
			data.ThemPhong(banggia);
		}

		public void SuaPhong(BangGiaPhong banggia)
		{
			data.SuaPhong(banggia);
		}
	}
}
