using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    class Euros : Expression
    {
        public override double euros(double value)
        {
            return value;
        }

        public override double dollars(double value)
        {
            return (value * 1.21);
        }

        public override double vnd(double value)
        {
            return (value * 27749);
        }
    }
}
