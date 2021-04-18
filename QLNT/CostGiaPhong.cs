using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class CostGiaPhong : CondimentDecorator
    {
        BangGiaPhong BGP = new BangGiaPhong();

        

        override
        public double cost()
        {
            return BGP.getGiaTien() + wrapObj.cost();
        }

        public CostGiaPhong(TinhTienHD hd)
        {
            //String soNguoi = BGP.getSoNguoi().ToString();
            Console.WriteLine(cost());
        }
    }
}
