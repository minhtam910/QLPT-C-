using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    class DichVuBLL
    {
        DichVuDAL dichVuDAL = DichVuDAL.get();

        public void DatDichVu(String maPhong, String maKhach, String maDichVu)
        {
            dichVuDAL.DatDichVu(maPhong, maKhach, maDichVu);
        }

        public DataTable LoadDichVuDaDat(String maKhach, String maPhong)
        {
           return dichVuDAL.LoadDichVuDaDat(maPhong, maKhach);
        }

        public DataTable LoadThongBao()
        {
            return dichVuDAL.LoadThongBao();
        }

        public void ThemDichVu(DichVu dichvu)
        {
            dichVuDAL.ThemDichVu(dichvu);
        }
        public DataTable LoadDoAn()
        {
            return dichVuDAL.LoadDoAn();
        }

        public bool SuaDichVu(DichVu dichvu)
        {
            return dichVuDAL.SuaDichVu(dichvu);
        }

        public void XoaDichVu(DichVu dichvu)
        {
            dichVuDAL.XoaDichVu(dichvu);
        }

    }
}
