using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class IndividualEnDisableCommand : IndividualCommandBase
    {

        public override void delText()
        {
            control.Text = "";
        }

        public override void disable()
        {
            control.Enabled = false;
        }

        public override void enable()
        {
            control.Enabled = true;
        }
    }
}
