using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class ThongKe
	{
		private int mahoadon;
		private int tongtien;
		private String ngaylap;
		private String maphong;

		public int getMahoadon()
		{
			return mahoadon;
		}

		public void setMahoadon(int mahoadon)
		{
			this.mahoadon = mahoadon;
		}

		public int getTongtien()
		{
			return tongtien;
		}

		public void setTongtien(int tongtien)
		{
			this.tongtien = tongtien;
		}

		public String getNgaylap()
		{
			return ngaylap;
		}

		public void setNgaylap(String ngaylap)
		{
			this.ngaylap = ngaylap;
		}

		public String getMaphong()
		{
			return maphong;
		}

		public void setMaphong(String maphong)
		{
			this.maphong = maphong;
		}
	}
}
