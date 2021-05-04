using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    class VND : Expression
    {
        public override double dollars(double value)
        {
            return (value / 23022);
        }

        public override double euros(double value)
        {
            return (value / 27745);
        }

        public override double vnd(double value)
        {
            return value ;
        }
    }
}
