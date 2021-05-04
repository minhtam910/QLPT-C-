using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    abstract class Expression
    {
        public abstract double vnd(double value);

        public abstract double dollars(double value);

        public abstract double euros(double value);
    }
}
