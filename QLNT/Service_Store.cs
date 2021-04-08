using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public abstract class Service_Store
    {
        public abstract IService cooking(int num);

        public IService ord(int num)
        {
            IService service = cooking(num);
            return service;

        }
    }
}
