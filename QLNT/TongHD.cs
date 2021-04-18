using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class TongHD
    {
        public void cost()
        {
            TinhTienHD hd1 = new CostKhachThueDH();
            hd1 = new CostDichVu(hd1);
            hd1 = new CostGiaPhong(hd1);

            TinhTienHD hd2 = new CostKhachThueNH();
            hd2 = new CostDichVu(hd2);
            hd2 = new CostGiaPhong(hd2);

        }
    }
}
