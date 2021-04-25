using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public abstract class ThongTinHoaDon:IService
    {
        protected String maKhach;

        public String description = "";

        public abstract double cost(int time);
        public abstract double cost();

        public abstract void cook(string maKhach, string maPhong);


        public void setMaKhach(String mk)
        {
            maKhach = mk;
        }

        public String getMaKhach()
        {
            return maKhach;
        }

        public String getDescription()
        {           
            return description;
        }

        public void addDescription(string description)
        {
            this.description += description;
        }

        
    }
}
