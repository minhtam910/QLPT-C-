using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class PhongThueDaiHan: ThongTinHoaDon
    {
        public PhongThueDaiHan(String maKhach)
        {
            description = "Phòng dài hạn \n";
            this.maKhach = maKhach;
        }

        public override void cook(string maKhach, string maPhong)
        {
            throw new NotImplementedException();
        }

        public override double cost(int time)
        {
            return 300000*time;
        }

        public override double cost()
        {
            return 300000;
        }
    }
}
