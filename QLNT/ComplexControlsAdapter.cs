using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNT
{
    class ComplexControlsAdapter :  ICommandBase
    {
        private IndividualCommandBase iCommand;

        public ComplexControlsAdapter(ICommandBase cmdBase)
        {
            iCommand = new IndividualEnDisableCommand();
            Control c = cmdBase.getControls()[0]; ;
            iCommand.setControls(c);
        }

        public override void disable()
        {
            iCommand.disable();
        }

        public override void enable()
        {
            iCommand.enable();
        }
    }
}
