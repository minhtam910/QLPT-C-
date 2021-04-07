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
		

		public DataTable LoadThongTinGiaThue()
		{
			return BangGiaPhongDAL.getInstance().LoadThongTinGiaThue();
		}

		public void ThemPhong(BangGiaPhong banggia)
		{
			BangGiaPhongDAL.getInstance().ThemPhong(banggia);
		}

		public void SuaPhong(BangGiaPhong banggia)
		{
			BangGiaPhongDAL.getInstance().SuaPhong(banggia);
		}
	}
}
