using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class Snack : CondimentDecorator, IService
    {
        public void cook(String maKhach, String maPhong)
        {
            MessageBox.Show("Snack đang được chuẩn bị cho khách " + maKhach + " tại phòng " + maPhong + "!");
        }


        public Snack(ThongTinHD hd)
        {
            this.wrapObj = hd;
        }

        override
        public double cost()
        {
            return 15000 + wrapObj.cost();
        }

        
    }
}
