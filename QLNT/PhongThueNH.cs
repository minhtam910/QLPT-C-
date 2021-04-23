using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class PhongThueNH : ThongTinHD
    {

        String description;

        public PhongThueNH()
        {
            description = "Phong Thue Ngan Han";
        }

        override
        public double cost()
        {
            return 400000;
        }
    }
}
