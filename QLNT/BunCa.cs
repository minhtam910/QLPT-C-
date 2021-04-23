using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class BunCa : CondimentDecorator, IService
    {
        public void cook(String maKhach, String maPhong)
        {
            MessageBox.Show("Bún cá đang được chuẩn bị cho khách " + maKhach + " tại phòng " + maPhong + "!");
        }

        public BunCa(ThongTinHD hd)
        {
            this.wrapObj = hd;
        }


        override
        public double cost()
        {
            return 30000 + wrapObj.cost();
        }

       
        
    }
    
}
