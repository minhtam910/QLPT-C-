using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class CostDichVu : CondimentDecorator
    {
        DichVu dichvu = new DichVu();

        public CostDichVu(TinhTienHD hd)
        {
            Console.WriteLine(cost());
        }

        override
        public double cost()
        {
            return dichvu.getGiaTien() + wrapObj.cost();
        }
    }
}
