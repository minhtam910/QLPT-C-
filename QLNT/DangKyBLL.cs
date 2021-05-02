using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
	class DangKyBLL : ObjectBLL
	{
		DangKyDAL data = DangKyDAL.get();

		public DangKyBLL(Dictionary<String,Object> dict)
        {
			setListObject(dict);
        }

		public DataTable LoadKhachThueChuaCoPhong() 
		{
			return data.LoadKhachThueChuaCoPhong();
		}

		public DataTable LoadPhongDaiHan()
		{
			return data.LoadPhongDaiHan();
		}
		public DataTable LoadPhongChuaCoKhach() 
		{
			return data.LoadPhongChuaCoKhach();
		}

		public DataTable LoadPhongDaCoKhach()
		{
			return data.LoadPhongDaCoKhach();
		}

		public DataTable LoadChiTietKhachThue() 
		{
			return data.LoadChiTietKhachThue(interactObjects);
		}

		public DataTable LoadThongTinDichVu()
		{
			return data.LoadThongTinDichVu(interactObjects);
		}

			//Thêm khách ở ghép
		public bool ThemKhachOghep()
		{
			return data.ThemKhachOghep(interactObjects);
		}

		//Thêm khách ở phòng mới
		public bool ThemKhachThueVaoPhongMoi() 
		{
			return data.ThemKhachThueVaoPhongMoi(interactObjects);
		}

		//Load danh sách phòng có thể ở ghép
		public DataTable LoadMaPhongOGhep()
		{
			return data.LoadMaPhongOGhep();
		}

		//Load danh sách phòng có thể thuê mới
		public DataTable LoadMaPhongMoi()
		{
			return data.LoadMaPhongMoi();
		}

		public bool KhachCheckout()
        {
			return data.KhachCheckout(interactObjects);
        }

        public override void editObject()
        {
            throw new NotImplementedException();
        }

        public override DataTable findObject()
        {
			return LoadChiTietKhachThue();
        }

        public override void addObject()
        {
            throw new NotImplementedException();
        }

        public override void deleteObject()
        {
			KhachCheckout();
        }
    }
}
