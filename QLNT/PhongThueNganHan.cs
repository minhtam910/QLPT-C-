using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class PhongThueNganHan : ThongTinHoaDon
    {
        public PhongThueNganHan(String maKhach)
        {
            description = "Phòng ngắn hạn \n";
            this.maKhach = maKhach;
        }

        public override void cook(string maKhach, string maPhong)
        {
            throw new NotImplementedException();
        }

        override
        public double cost(int time)
        {
            return 400000*time;
        }

        public override double cost()
        {
            return 400000;
        }
    }
}
