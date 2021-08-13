using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_A_Relationship
{
    class Demo
    {
        public static void Main(string [] args)
        {
            Sample o = new Sample();
            Example ob = new Example();
            ob.fun3(o);
        }
    }
}
