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
		

		public DataTable loadThongTinPhong()
		{
			return PhongTroDAL.getInstance().LoadThongTinPhong();
		}

		public DataTable LoadChiTietThuePhong(PhongTro phongtro)
		{
			return PhongTroDAL.getInstance().LoadChiTietThuePhong(phongtro);
		}
	}
}
