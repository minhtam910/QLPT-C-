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
        DV_DoAn_Factory dv = new DV_DoAn_Factory();

        public void ThemDichVu(DichVu dichvu)
        {
            dv.ThemDichVu(dichvu);
        }
        public DataTable LoadDoAn()
        {
            return dv.LoadDoAn();
        }

        public bool SuaDichVu(DichVu dichvu)
        {
            return dv.SuaDichVu(dichvu);
        }

        public void XoaDichVu(DichVu dichvu)
        {
            dv.XoaDichVu(dichvu);
        }
    }
}
