using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class ComplexControlsAdapter : ISimpleCommandBase
    {
        private IComplexCommandBase iComplex;

        public ComplexControlsAdapter()
        {
            iComplex = new ComplexEnDisableCommand();
        }

        public void disable(Control control)
        {
            List<Control> c = new List<Control>() { control };
            iComplex.disable(c);
        }

        public void enable(Control control)
        {
            List<Control> c = new List<Control>() { control };
            iComplex.enable(c);
        }
    }
}
