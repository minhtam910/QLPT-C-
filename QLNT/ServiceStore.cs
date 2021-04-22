using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public abstract class ServiceStore
    {
        
        public abstract IService cooking(String maDoAn, String maKhach, String maPhong);

       
    }
}
