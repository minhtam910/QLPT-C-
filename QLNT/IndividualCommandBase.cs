using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    abstract class IndividualCommandBase
    {

        protected Control control;

        public void setControls(Control control)
        {
            this.control = control;
        }

        public Control getListControls()
        {
            return control;
        }
        public abstract void enable();

        public abstract void disable();

        public abstract void delText();
    }
}
