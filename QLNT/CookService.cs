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
        public override ThongTinHoaDon cooking(String maDoAn, String maKhach, String maPhong, List<ThongTinHoaDon> list)
        {
            ThongTinHoaDon thongTinHoaDon = null;
            //IService service = null;
            Console.WriteLine("----------------------Checking list-----------------------------");
            for (int i = 0; i < list.Count(); i++)
            {   
                Console.WriteLine("Mã khách: " + list[i].getMaKhach());
                Console.WriteLine("Cost: " + list[i].cost());
                Console.WriteLine("Description: " + list[i].getDescription());
                Console.WriteLine("----------------------End of this element-------------------------");
            }
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].getMaKhach().Equals(maKhach))
                    thongTinHoaDon = list[i];
            }
            if (thongTinHoaDon == null)
            {
                Console.WriteLine("Sai sai");
            }
            else
            {
                Console.WriteLine("Thông tin phòng đang thao tác");
                Console.WriteLine("Mã khách: " + thongTinHoaDon.getMaKhach());
                Console.WriteLine("Cost: " + thongTinHoaDon.cost());
                Console.WriteLine("Description: " + thongTinHoaDon.getDescription());
                Console.WriteLine("-----------------Add decoration-------------------");
            }
            try
            {               
                switch (maDoAn)
                {
                    case "DA001":
                        thongTinHoaDon = new MiGoi(thongTinHoaDon);
                        thongTinHoaDon.setMaKhach(maKhach);
                        break;
                    case "DA002":
                        thongTinHoaDon = new BunCa(thongTinHoaDon);
                        thongTinHoaDon.setMaKhach(maKhach);
                        break;
                    case "DA003":
                        thongTinHoaDon = new ComTam(thongTinHoaDon);
                        thongTinHoaDon.setMaKhach(maKhach);
                        break;
                    case "DA004":
                        thongTinHoaDon = new Snack(thongTinHoaDon);
                        thongTinHoaDon.setMaKhach(maKhach);
                        break;
                    default:
                        throw new Exception("This line should be unreachable");

                }               
            }
            catch(Exception ex)
            {
                Console.WriteLine("Phải tìm ra mã khách chứ sao lại throw exception? " + ex.Message);
                
            }
            
            return thongTinHoaDon;
        }
        public void order(String maDoAn, String maKhach, String maPhong, List<ThongTinHoaDon> list)
        {
            ThongTinHoaDon thd = cooking(maDoAn, maKhach, maPhong, list);
            thd.cook(maKhach, maPhong);
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].getMaKhach().Equals(maKhach))
                    list[i] = thd;
            }
            Console.WriteLine("Cost: " + thd.cost());
            Console.WriteLine("Description: " + thd.getDescription());
            Console.WriteLine("----------------------Complete adding decoration--------------------");
            dichVuBLL = new DichVuBLL();
            dichVuBLL.DatDichVu(maPhong, maKhach, maDoAn);
        }
    }
}
