using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class HoaDonDAL
	{
		DataTable rs = null;
		DBAccess data = new DBAccess();

		//load dữ liệu dịch vụ vào table
		public DataTable loadDichVu()
		{
			String sql = "select DichVu from DICH_VU";
			rs = data.executeQuery(sql);
        return rs;
    }

	//Load dịch vụ theo mã khi click vào từng hàng trên table sẽ xuất ra tương ứng vào các textfiled
	/*public DataTable loadDichVuTheoMa(HoaDonDAL hoadondichvu)
	{
		String sql = "select MaDichVu, DichVu,PARSENAME(convert(varchar,convert(money,GiaDichVu),1),2 ) as GiaDichVu, QuyCach from DICH_VU where DichVu =  N'"+hoadondichvu.getDichvu()+"'";
		DataTable table = data.executeQuery(sql);
			return table;
	}*/

	//Lấy danh sách các phòng đang thuê và chưa có hóa đơn của ngày (tháng) hiện tại
	public DataTable loadPhongChuaCoHoaDon(HoaDon hoadondichvu)
	{
		String sql = "select maphong from PHONG_TRO where MaPhong in(select MaPhong from CT_KHACH_THUE) and MaPhong not in (select MaPhong from HOA_DON where right(convert(varchar(10),  NgayLap,103),7) = right(convert(varchar(10),  '"+hoadondichvu.getNgaylaphoadon()+"',103),7))";
		rs = data.executeQuery(sql);
        return rs;
	}

	//Lấy danh sách các phòng đang thuê và ĐÃ có hóa đơn của ngày (tháng) hiện tại()
	public DataTable loadPhongDaCoHoaDon(HoaDon hoadondichvu)
	{
		String sql = "select maphong from PHONG_TRO where MaPhong in(	select MaPhong from CT_KHACH_THUE) and MaPhong in (select MaPhong from HOA_DON where right(convert(varchar(10),  NgayLap,103),7) = right(convert(varchar(10), '"+hoadondichvu.getNgaylaphoadon()+"',103),7))";
		rs = data.executeQuery(sql);
        return rs;
	}

	//Lấy danh sách chi tiết dịch vụ của phòng đã sử dụng trong tháng khi click vào phóng đã có hóa đơn
	/*public DataTable loadCT_dichvu(HoaDon hoadondichvu)
	{
		String sql = "select HOA_DON.MaHoaDon, right(convert(varchar(10),  NgayLap,103),7) as ngaylap, MaPhong, CT_DICHVU.MaDichVu, PARSENAME(convert(varchar,convert(money,DonViSuDung*GiaDichVu),1),2 ) as chiphi from HOA_DON, CT_DICHVU, DICH_VU where HOA_DON.MaHoaDon = CT_DICHVU.MaHoaDon and DICH_VU.MaDichVu = CT_DICHVU.MaDichVu and right(convert(varchar(10),  NgayLap,103),7) = right(convert(varchar(10),  '"+hoadondichvu.getNgaylaphoadon()+"',103),7) and MaPhong = '"+hoadondichvu.getMaphong()+"'";
		rs = data.executeQuery(sql);
        return rs;
	}*/

	//Thêm mới 1 hóa đơn
	public bool ThemHoaDon(HoaDon hoadondichvu)
	{
		SqlParameter p1 = new SqlParameter("@makhach", hoadondichvu.getMaphong());
			SqlParameter p2 = new SqlParameter("@maphong", hoadondichvu.getNgaylaphoadon());
			

			SqlParameter[] giatri = { p1,p2 };

			return data.Update("ThemKhachThueVaooGhep", giatri);
	}

	//Thêm mới chi tiết sử dụng dịch vụ
	/*public int ThemChiTietDichVu(HoaDon hoadondichvu)
	{
		int thamso = 2;
		Object[] giatri = new Object[thamso];
		giatri[0] = hoadondichvu.getMadichvu();
		giatri[1] = hoadondichvu.getDonvisudung();

		return data.Update("{call ThemChiTietDichVu(?,?)}", giatri, thamso);
	}*/

	//Xóa hóa đơn theo mã
	public bool XoaHoaDon(HoaDon hoadondichvu)
	{
		SqlParameter p1 = new SqlParameter("@makhach", hoadondichvu.getMahoadon());
		
			SqlParameter[] giatri = { p1, };

		return data.Update("XoaHoaDon", giatri);
	}
}
}
