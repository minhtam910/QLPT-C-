using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class BangGiaPhong
	{
		private int songuoi;
		private int giatien;

		public BangGiaPhong()
		{
			songuoi = giatien = 0;
		}

		public BangGiaPhong(int _songuoi, int _giatien)
		{
			giatien = _giatien;
			songuoi = _songuoi;
		}

		//Giá tiền
		public int getGiaTien()
		{
			return giatien;
		}

		public void setGiaTien(int _giatien)
		{
			giatien = _giatien;
		}

		//Số người
		public int getSoNguoi()
		{
			return songuoi;
		}

		public void setSoNguoi(int _songuoi)
		{
			songuoi = _songuoi;
		}
	}
}
