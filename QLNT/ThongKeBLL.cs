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
	

	public DataTable loadthang()
	{
        return ThongKeDAL.getInstance().loadthang();
    }

	public DataTable loadHDTheothang(ThongKe thongke) 
	{
        return ThongKeDAL.getInstance().loadHDtheoThang(thongke);
	}

	//Load tiền phòng theo mã
	public DataTable loadTienPhongTheoMa(ThongKe thongke) 
	{
        return ThongKeDAL.getInstance().loadTienPhongTheoMa(thongke);
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
        return ThongKeDAL.getInstance().TongTienTheoThang(thongke);
	}

	//Tổng tiền theo tháng của phòng
	public DataTable TongTienTheoThangCuaPhong(ThongKe thongke) 
	{
        return ThongKeDAL.getInstance().TongTienTheoThangCuaPhong(thongke);
	}
}
}
