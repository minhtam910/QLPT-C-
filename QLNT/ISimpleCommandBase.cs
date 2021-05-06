using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    public interface ISimpleCommandBase
    {
        void enable(Control control);

        void disable(Control control);
    }
}
