using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class HoaDonBLL
	{
		HoaDonDAL hoadon = new HoaDonDAL();
		/*public DataTable loadDichVu()
		{
        return hoadon.loadDichVu();
		}

	public DataTable loadDichVuTheoMa(HoaDon hoadondichvu) throws Exception
	{
        return hoadon.loadDichVuTheoMa(hoadondichvu);
	}*/

	public DataTable loadPhongChuaCoHoaDon(HoaDon hoadondichvu)
	{
        return hoadon.loadPhongChuaCoHoaDon(hoadondichvu);
	}

	public DataTable loadPhongDaCoHoaDon(HoaDon hoadondichvu)
	{
        return hoadon.loadPhongDaCoHoaDon(hoadondichvu);
	}

	/*public DataTable loadCT_dichvu(HoaDon hoadondichvu) 
	{
        return hoadon.loadCT_dichvu(hoadondichvu);
	}*/

	public bool ThemHoaDon(HoaDon hoadondichvu) 
	{
        return hoadon.ThemHoaDon(hoadondichvu);
	}

	/*public int ThemChiTietDichVu(HoaDon hoadondichvu) 
	{
        return hoadon.ThemChiTietDichVu(hoadondichvu);
	}*/

	public bool XoaHoaDon(HoaDon hoadondichvu)
	{
        return hoadon.XoaHoaDon(hoadondichvu);
	}
}
}
