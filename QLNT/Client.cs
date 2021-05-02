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
        private String maPhong;
        private List<ThongTinHoaDon> list;
        private Dictionary<String, Object> listObject;

        public Client(ThongBaoService service, String maClient, String maPhong, List<ThongTinHoaDon> list, Dictionary<String, Object> listObject)
        {
            this.service = service;
            this.maClient = maClient;
            this.maPhong = maPhong;
            this.list = list;
            this.listObject = listObject;
        }
        public void update(List<ThongBao> listThongBao)
        {
            GuestRoom fg = new GuestRoom(maPhong, service, list, listObject);
            fg.Show();
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
