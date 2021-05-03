using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    public partial class Checkout : Form
    {
        ThongBaoService service;
        List<ThongTinHoaDon> list;
        Dictionary<String, Object> listObject;
        String maKhach;
        double cost;
        public Checkout(ThongBaoService service, List<ThongTinHoaDon> list, Dictionary<String, Object> listObject, String maKhach)
        {
            this.service = service;
            this.list = list;
            this.listObject = listObject;
            this.maKhach = maKhach;
            InitializeComponent();
            
            LoadInformation();
        }

        public void LoadInformation()
        {
            String info = "";
            ThongTinHoaDon thongTinHoaDon = null;

            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine(list[i].getMaKhach());
                if (list[i].getMaKhach().Equals(maKhach))
                {
                    thongTinHoaDon = list[i];
                }
            }
            String tempString = thongTinHoaDon.getDescription();
            String[] infoParts = tempString.Split(new String[] { "hạn"  }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(infoParts.Length);
            info += "Loại phòng: " + infoParts[0] + "hạn @@";
            info += "Các dịch vụ đã yêu cầu: ";
            if(infoParts.Length >= 2)
            {
                for(int i = 1; i < infoParts.Length; i++)
                {
                    info += infoParts[i] + "@";
                }
            }
            else
            {
                info += "Chưa có yêu cầu dịch vụ! @";
            }
            info += "Tổng chi phí: ";
            info += thongTinHoaDon.cost();
            cost = thongTinHoaDon.cost();
            info = info.Replace("@", " " + System.Environment.NewLine);
            txtHoaDon.Text = info;
        }
    }
}
