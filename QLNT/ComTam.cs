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
        public void cook(String maKhach, String maPhong)
        {
            MessageBox.Show("Cơm tấm đang được chuẩn bị cho khách " + maKhach + " tại phòng " + maPhong + "!");
        }

        public ComTam(ThongTinHD hd) {
            this.wrapObj = hd;
        }

        override
        public double cost()
        {
            return 25000 + wrapObj.cost();
        }

        
        
    }
}
