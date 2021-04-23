using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class TongHD
    {
        public void Tongcost()
        {
            ThongTinHD hd = new PhongThueDH();
            hd = new ComTam(hd);
            hd.cost();
            hd = new Snack(hd);
            hd.cost();

            ThongTinHD hd1 = new PhongThueNH();
            hd1 = new MiGoi(hd1);
            hd1.cost();
            hd1 = new BunCa(hd1);
            hd1.cost();
        }
    }
}
