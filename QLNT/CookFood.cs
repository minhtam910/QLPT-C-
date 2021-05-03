using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public abstract class CookFood
    {      
        public abstract ThongTinHoaDon cooking(String maDoAn, String maKhach, String maPhong, List<ThongTinHoaDon> list);

    }
}
