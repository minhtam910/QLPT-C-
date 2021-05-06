using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    interface IComplexCommandBase
    {
        void enable(List<Control> control);

        void disable(List<Control> control);

        void delText(List<Control> control);
    }
}
