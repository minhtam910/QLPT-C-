using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class ThongBao
    {
        private String NoiDung;
        private DateTime NgayLap;

        public ThongBao()
        {

        }

        public ThongBao(String nd, DateTime ngaylap)
        {
            NoiDung = nd;
            NgayLap = ngaylap;
        }

        public void setNoiDung(String nd)
        {
            NoiDung = nd;
        }

        public void setNgay(DateTime ngay)
        {
            NgayLap = ngay;
        }

        public String getNoiDung()
        {
            return NoiDung;
        }

        public DateTime getNgayLap()
        {
            return NgayLap;
        }
    }
}
