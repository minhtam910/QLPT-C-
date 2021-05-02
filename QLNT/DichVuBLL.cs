using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class DichVuBLL : ObjectBLL
    {
        DichVuDAL dichVuDAL = DichVuDAL.get();

        public DichVuBLL(Dictionary<String, Object> dict)
        {
            setListObject(dict);
        }

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

        
        public DataTable LoadDoAn()
        {
            return dichVuDAL.LoadDoAn();
        }

        public void ThemDichVu()
        {
            dichVuDAL.ThemDichVu(interactObjects);
        }

        public bool SuaDichVu()
        {
            return dichVuDAL.SuaDichVu(interactObjects);
        }

        public void XoaDichVu()
        {
            dichVuDAL.XoaDichVu(interactObjects);
        }

        public override void editObject()
        {
            SuaDichVu();
        }

        public override DataTable findObject()
        {
            throw new NotImplementedException();
        }

        public override void addObject()
        {
            ThemDichVu();
        }

        public override void deleteObject()
        {
            XoaDichVu();
        }
    }
}
