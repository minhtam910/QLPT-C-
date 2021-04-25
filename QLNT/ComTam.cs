using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class ComTam : CondimentDecorator, IService
    {
        public override void cook(String maKhach, String maPhong)
        {
            MessageBox.Show("Cơm tấm đang được chuẩn bị cho khách " + maKhach + " tại phòng " + maPhong + "!");
            addDescription("Khách " + maKhach + "đặt món CƠM TẤM lúc " + DateTime.Now.ToString() + "\n");
        }

        public ComTam(ThongTinHoaDon hd) {
            this.wrapObj = hd;
            description = hd.getDescription();
        }

        override
        public double cost()
        {
            return 25000 + wrapObj.cost();
        }

        public override double cost(int time)
        {
            throw new NotImplementedException();
        }
    }
}
