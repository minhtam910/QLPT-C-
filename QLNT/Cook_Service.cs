using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public class Cook_Service
    {
        public IService cooking(int num)
        {
            IService service = null;
            switch(num)
            {
                case 1:
                    service = new MiGoi();
                    break;
                case 2:
                    service = new BunCa();
                    break;
                case 3:
                    service = new CamTam();
                    break;
  
                case 4:
                    service = new Snack();
                    break;
            }

            return service;

        }
    }
}
