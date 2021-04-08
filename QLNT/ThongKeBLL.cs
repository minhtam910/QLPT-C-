using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class ThongKeBLL
	{
		ThongKeDAL khachthue = ThongKeDAL.get();

		public DataTable Loadthang()
		{
        return khachthue.loadthang();
    }

	public DataTable LoadHDTheothang(ThongKe thongke) 
	{
        return khachthue.loadHDtheoThang(thongke);
	}

	//Load tiền phòng theo mã
	public DataTable LoadTienPhongTheoMa(ThongKe thongke) 
	{
        return khachthue.loadTienPhongTheoMa(thongke);
	}

	//Load tiền dịch vụ theo mã
	/*public DataTable loadTienDichVuTheoMa(ThongKe thongke) 
	{
        return khachthue.loadTienDichVuTheoMa(thongke);
	}

	//Tổng tiền
	public DataTable TongTien() 
	{
        return khachthue.TongTien();
	}*/

	//Tổng tiền theo tháng
	public DataTable TongTienTheoThang(ThongKe thongke) 
	{
        return khachthue.TongTienTheoThang(thongke);
	}

	//Tổng tiền theo tháng của phòng
	public DataTable TongTienTheoThangCuaPhong(ThongKe thongke) 
	{
        return khachthue.TongTienTheoThangCuaPhong(thongke);
	}
}
}
