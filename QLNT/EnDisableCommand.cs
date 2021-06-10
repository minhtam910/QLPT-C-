using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class EnDisableCommand : ICommandBase
    {
        public override void disable()
        {
            foreach (Control c in this.controls)
            {
                c.Enabled = false;
            }
        }

        public override void enable()
        {
            foreach (Control c in this.controls)
            {
                c.Enabled = true;
            }
        }

    }
}
