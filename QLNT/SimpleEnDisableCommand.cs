using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class SimpleEnDisableCommand : ISimpleCommandBase
    {

        public void disable(Control control)
        {
            control.Enabled = false;
        }

        public void enable(Control control)
        {
            control.Enabled = true;
        }
    }
}
