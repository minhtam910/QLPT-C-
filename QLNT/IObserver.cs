using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    public interface IObserver
    {
        void update(List<ThongBao> listThongBao);
        String getMaClient();
    }
}
