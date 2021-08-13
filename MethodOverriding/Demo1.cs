using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    class Demo1 : Demo 
    {
        public override  void fun1()
        {
            Console.WriteLine("Functin 1 is again created");
        }

        public override void fun2()
        {
            Console.WriteLine("Function2 is again created");
        }
    }
}
