using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class CookService : ServiceStore
    {
        DichVuBLL dichVuBLL;
        public override IService cooking(String maDoAn, String maKhach, String maPhong)
        {
            IService service = null;
            switch(maDoAn)
            {
                case "DA001":
                    service = new MiGoi();
                    break;
                case "DA002":
                    service = new BunCa();
                    break;
                case "DA003":
                    service = new ComTam();
                    break;
                case "DA004":
                    service = new Snack();
                    break;
                default:
                    throw new Exception("This line should be unreachable");

            }
            return service;
        }
        public void order(String maDoAn, String maKhach, String maPhong)
        {
            IService service = cooking(maDoAn, maKhach, maPhong);
            service.cook(maKhach, maPhong);
            dichVuBLL = new DichVuBLL();
            dichVuBLL.DatDichVu(maPhong, maKhach, maDoAn);
        }
    }
}
