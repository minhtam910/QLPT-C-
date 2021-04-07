using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLNT
{
	class KhachThueBLL
	{
		

	public DataTable LoadKhachThue() 
	{
		return KhachThueDAL.getInstance().Loadall();
	}

	/*public DataTable loadkhachthuedatphong() 
	{
        return khachthue.loadkhachthuedatphong();
	}*/


	//Thêm khách thuê không đặt phòng trước
	public void ThemKhachThueVaoPhongMoi(KhachThue KhachThue)
	{
			KhachThueDAL.getInstance().ThemKhachthue(KhachThue);
	}

	//Thêm khách thuê có đặt phòng trước
	/*public bool ThemKhachThueDatPhong(KhachThue KhachThue)
	{
		return khachthue.ThemKhachThueDatPhong(KhachThue);
	}*/

	public bool SuaKhachThue(KhachThue KhachThue)
	{
		return KhachThueDAL.getInstance().SuaKhachthue(KhachThue);
	}

	public void XoaKhachThue(KhachThue KhachThue)
	{
			KhachThueDAL.getInstance().XoaKhach(KhachThue);
	}

	public DataTable TimKhachThue(String sql, SqlParameter[] parameters)
	{
		return KhachThueDAL.getInstance().TimKhachThue(sql, parameters);
	}
		public DataTable TimKhachThueTheoTen(KhachThue KhachThue) 
	{
        return KhachThueDAL.getInstance().TimKhachThueTheoTen(KhachThue);
	}

	public DataTable TimKhachThueTheoMa(KhachThue KhachThue)
	{
        return KhachThueDAL.getInstance().TimKhachThueTheoMa(KhachThue);
	}

	public DataTable TimKhachThueTheoNghe(KhachThue KhachThue)
	{
        return KhachThueDAL.getInstance().TimKhachThueTheoNgheNghiep(KhachThue);
	}

	public DataTable TimKhachThueTheoQueQuan(KhachThue KhachThue)
	{
        return KhachThueDAL.getInstance().TimKhachThueTheoQueQuan(KhachThue);
	}
}
}
