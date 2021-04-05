using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class PhongTroBLL
	{
		PhongTroDAL data = PhongTroDAL.get();

		public DataTable loadThongTinPhong()
		{
			return data.LoadThongTinPhong();
		}

		public DataTable LoadChiTietThuePhong(PhongTro phongtro)
		{
			return data.LoadChiTietThuePhong(phongtro);
		}
	}
}
