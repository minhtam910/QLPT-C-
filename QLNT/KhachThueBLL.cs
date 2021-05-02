using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLNT
{
	class KhachThueBLL : ObjectBLL
	{
		KhachThueDAL khachthue = KhachThueDAL.get();

		public KhachThueBLL(Dictionary<String, Object> dict)
		{
			setListObject(dict);
		}

		public DataTable LoadKhachThue() 
		{
			return khachthue.Loadall();
		}



		//Thêm khách thuê không đặt phòng trước
		public void ThemKhachThueVaoPhongMoi()
		{
			khachthue.ThemKhachthue(interactObjects);
		}


		public bool SuaKhachThue()
		{
			return khachthue.SuaKhachthue(interactObjects);
		}

		public void XoaKhachThue()
		{
			khachthue.XoaKhach(interactObjects);
		}

		public DataTable TimKhachThue(String sql, SqlParameter[] parameters)
		{
			return khachthue.TimKhachThue(sql, parameters);
		}
			public DataTable TimKhachThueTheoTen() 
		{
			return khachthue.TimKhachThueTheoTen(interactObjects);
		}

		public DataTable TimKhachThueTheoMa()
		{
			return khachthue.TimKhachThueTheoMa(interactObjects);
		}

		public DataTable TimKhachThueTheoNghe()
		{
			return khachthue.TimKhachThueTheoNgheNghiep(interactObjects);
		}

		public DataTable TimKhachThueTheoQueQuan()
		{
			return khachthue.TimKhachThueTheoQueQuan(interactObjects);
		}

        public override void editObject()
        {
			SuaKhachThue();
        }

        public override DataTable findObject()
        {
            throw new NotImplementedException();
        }

        public override void addObject()
        {
			ThemKhachThueVaoPhongMoi();
        }

        public override void deleteObject()
        {
			XoaKhachThue();
        }
    }
}
