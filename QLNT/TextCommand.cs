using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class TextCommand : ICommandBase
    {
        public override void disable()
        {
            foreach (Control c in this.controls)
            {
                c.Text = "";
            }
        }

        public override void enable()
        {
            throw new NotImplementedException();
        }
    }
}
