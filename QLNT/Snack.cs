using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class Snack : CondimentDecorator, IFood
    {
        public override void cook(String maKhach, String maPhong)
        {
            MessageBox.Show("Snack đang được chuẩn bị cho khách " + maKhach + " tại phòng " + maPhong + "!");
            addDescription("Khách " + maKhach + "đặt món SNACK lúc " + DateTime.Now.ToString() + "\n");
        }


        public Snack(ThongTinHoaDon hd)
        {
            this.wrapObj = hd;
            description = hd.getDescription();
        }

        override
        public double cost()
        {
            return 15000 + wrapObj.cost();
        }

        public override double cost(int time)
        {
            throw new NotImplementedException();
        }
    }
}
