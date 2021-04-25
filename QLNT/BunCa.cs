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

        public BunCa(ThongTinHoaDon hd)
        {
            this.wrapObj = hd;
            description = hd.getDescription();

        }


        override
        public double cost()
        {
            return 30000 + wrapObj.cost();
        }

        public override double cost(int time)
        {
            throw new NotImplementedException();
        }

        public override void cook(string maKhach, string maPhong)
        {
            MessageBox.Show("Bún cá đang được chuẩn bị cho khách " + maKhach + " tại phòng " + maPhong + "!");
            addDescription("Khách " + maKhach + "đặt món BÚN CÁ lúc " + DateTime.Now.ToString() + "\n");
        }
    }
    
}
