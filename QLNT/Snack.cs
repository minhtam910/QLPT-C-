using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    class Snack:IService
    {
        public void cook()
        {
            Console.WriteLine("Snack đã được thêm vào dịch vụ");
        }
    }
}
