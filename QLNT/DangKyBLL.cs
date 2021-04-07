using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class DangKyBLL
	{
		

	public DataTable loadKhachThueChuaCoPhong() 
	{
		return DangKyDAL.getInstance().loadKhachThueChuaCoPhong();
	}

	public DataTable LoadPhongChuaCOKhach() 
	{
        return DangKyDAL.getInstance().LoadPhongChuaCOKhach();
	}

	public DataTable LoadPhongDaCoKhach()
	{
        return DangKyDAL.getInstance().LoadPhongDaCoKhach();
	}

	public DataTable loadChiTietKhachThue(DangKy dangKyPhong) 
	{
        return DangKyDAL.getInstance().loadChiTietKhachThue(dangKyPhong);
	}

	//Thêm khách ở ghép
	public bool ThemKhachOghep(DangKy dangKyPhong)
	{
        return DangKyDAL.getInstance().ThemKhachOghep(dangKyPhong);
	}

	//Thêm khách ở phòng mới
	public bool ThemKhachThueVaoPhongMoi(DangKy dangKyPhong) 
	{
        return DangKyDAL.getInstance().ThemKhachThueVaoPhongMoi(dangKyPhong);
	}

	//Load danh sách phòng có thể ở ghép
	public DataTable loadMaPhongOGhep()
	{
        return DangKyDAL.getInstance().loadMaPhongOGhep();
	}

	//Load danh sách phòng có thể thuê mới
	public DataTable LoadMaPhongMoi()
	{
        return DangKyDAL.getInstance().LoadMaPhongMoi();
	}

	
}
}
