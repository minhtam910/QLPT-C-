using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class KhachThueBLL
	{
		KhachThueDAL khachthue = KhachThueDAL.get();

		public DataTable LoadKhachThue() 
		{
        return khachthue.Loadall();
    }

	/*public DataTable loadkhachthuedatphong() 
	{
        return khachthue.loadkhachthuedatphong();
	}*/


	//Thêm khách thuê không đặt phòng trước
	public bool ThemKhachThueVaoPhongMoi(KhachThue KhachThue)
	{
		return khachthue.ThemKhachthue(KhachThue);
	}

	//Thêm khách thuê có đặt phòng trước
	/*public bool ThemKhachThueDatPhong(KhachThue KhachThue)
	{
		return khachthue.ThemKhachThueDatPhong(KhachThue);
	}*/

	public bool SuaKhachThue(KhachThue KhachThue)
	{
		return khachthue.SuaKhachthue(KhachThue);
	}

	public bool XoaKhachThue(KhachThue KhachThue)
	{
		return khachthue.XoaKhach(KhachThue);
	}

	public DataTable TimKhachThueTheoTen(KhachThue KhachThue) 
	{
        return khachthue.TimKhachThueTheoTen(KhachThue);
	}

	public DataTable TimKhachThueTheoMa(KhachThue KhachThue)
	{
        return khachthue.TimKhachThueTheoMa(KhachThue);
	}

	public DataTable TimKhachThueTheoNghe(KhachThue KhachThue)
	{
        return khachthue.TimKhachThueTheoNgheNghiep(KhachThue);
	}

	public DataTable TimKhachThueTheoQueQuan(KhachThue KhachThue)
	{
        return khachthue.TimKhachThueTheoQueQuan(KhachThue);
	}
}
}
