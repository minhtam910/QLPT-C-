using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	public class DichVu
    {
		private string MaDoAn;
		private string TenDoAn;
		private int giatien;
		
		public DichVu()
		{
			MaDoAn = "";
			TenDoAn = "";
			giatien = 0;
		}
		public DichVu(string __MaDoAn, string __TenDoAn, int __Gia)
		{
			MaDoAn = __MaDoAn;
			TenDoAn = __TenDoAn;
			giatien = __Gia;
		}


		public string getMaDoAn()
		{
			return MaDoAn;
		}

		public void setMaDoAn(string __MaDoAn)
		{
			MaDoAn = __MaDoAn;
		}

		public string getTenDoAn()
		{
			return TenDoAn;
		}

		public void setTenDoAn(string ___TenDoAn)
		{
			TenDoAn = ___TenDoAn;
		}
		//Giá tiền
		public int getGiaTien()
		{
			return giatien;
		}

		public void setGiaTien(int __Gia)
		{
			giatien = __Gia;
		}
	}
}
