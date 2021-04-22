using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class DangKy
	{
		private String maphong;
		private String makhach;
		private DateTime ngayvaophong;

		public String getMaPhong()
		{
			return maphong;
		}

		public void setMaPhong(String _maphong)
		{
			maphong = _maphong;
		}

		//Mã khách
		public String getMaKhach()
		{
			return makhach;
		}

		public void setMaKhach(String _makhach)
		{
			makhach = _makhach;
		}

		//Mã phòng
		public DateTime getNgayVaoPhong()
		{
			return ngayvaophong;
		}

		public void setNgayVaoPhong(DateTime _ngayvaophong)
		{
			ngayvaophong = _ngayvaophong;
		}
	}
}
