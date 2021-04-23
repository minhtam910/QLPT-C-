using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class PhongThueDH: ThongTinHD
    {
        String description;

        public PhongThueDH()
        {
            description = "Phong Thue Dai Han";
        }

        override
        public double cost()
        {
            return 300000;
        }
    }
}
