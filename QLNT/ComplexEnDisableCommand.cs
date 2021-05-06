using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class ComplexEnDisableCommand : IComplexCommandBase
    {
        public void delText(List<Control> controls)
        {
            foreach (Control c in controls)
            {
                c.Text = "";
            }
        }

        public void disable(List<Control> controls)
        {
            foreach(Control c in controls)
            {
                c.Enabled = false;
            }
        }

        public void enable(List<Control> controls)
        {
            foreach (Control c in controls)
            {
                c.Enabled = true;
            }
        }
    }
}
