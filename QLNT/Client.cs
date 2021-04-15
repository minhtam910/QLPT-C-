using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    class Client : IObserver
    {
        private String maClient;
        private ThongBaoService service;

        public Client(ThongBaoService service, String maClient)
        {
            this.service = service;
            this.maClient = maClient;
        }
        public void update(List<ThongBao> listThongBao)
        {
            Console.WriteLine("Client: " + maClient);
            Console.WriteLine("Có thông báo mới");
            List<ThongBao> temp = service.getListThongBao();
            foreach(ThongBao tb in temp)
            {
                Console.WriteLine(tb.getNoiDung() + "/ " + tb.getNgayLap());
            }
        }
    }
}
