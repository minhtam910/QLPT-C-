using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class CostKhachThueNH : TinhTienHD
    {
        BangGiaPhong gia;
       
        override
        public double cost()
        {
            return gia.getGiaTien();
        }
    }
}
