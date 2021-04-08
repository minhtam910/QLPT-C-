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
		
<<<<<<< HEAD
=======

>>>>>>> c2b4d2cf83785b2ed29daeef0779744c5a1b5241
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
