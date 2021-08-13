using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Use_A_Relationship
{
   public class Example
    {
        public void fun3(Sample s)
        {
            s.fun1();
            s.fun2();
            Console.WriteLine("Function3 is created");
        }
    }
}
