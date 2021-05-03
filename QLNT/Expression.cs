using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    abstract class Expression
    {
        public abstract String vnd(double value);

        public abstract String dollars(double value);

        public abstract String euros(double value);
    }
}
