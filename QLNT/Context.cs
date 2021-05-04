using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNT
{
    class Context
    {
        String output = "";
        String from = "";
        String to = "";
        double value;

        public Context(double value, String from, String to)
        {
 
            this.value = value;

            this.from = from;

            this.to = to;
        }

        public String getFrom()
        {
            return from;
        }

        public String getTo()
        {
            return to;
        }

        public double getValue()
        {
            return value;
        }

        public object GetInstance(string strFullyQualifiedName)
        {
            Type type = Type.GetType(strFullyQualifiedName);
            if (type != null)
                return Activator.CreateInstance(type);
            return null;
        }
    }
}
                                                                                                                                