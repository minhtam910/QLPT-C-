using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    public abstract class ICommandBase
    {

        protected List<Control> controls;

        public void setListControls(List<Control> controls)
        {
            this.controls = controls;
        }

        public List<Control> getControls()
        {
            return controls;
        }

        public abstract void enable();

        public abstract void disable();
    }
}
