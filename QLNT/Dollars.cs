using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Dollars : Expression
    {
        public override string dollars(double value)
        {
            return value.ToString();
        }

        public override string euros(double value)
        {
            return (value / 1.21).ToString();
        }       

        public override string vnd(double value)
        {
            return (value * 23022).ToString();  
        }
    }
}
