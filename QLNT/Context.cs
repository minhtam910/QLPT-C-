using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    class Context
    {
        String input = "";
        String output = "";
        String from = "";
        String to = "";
        double value;
        String[] listComp;

        public Context(String input)
        {
            this.input = input;

            listComp = input.Split(char.Parse(" "));

            value = Double.Parse(listComp[0]);

            from = listComp[1];

            to = listComp[3];
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
                                                                                                                                