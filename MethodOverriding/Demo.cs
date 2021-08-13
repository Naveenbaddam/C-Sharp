using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Demo
    {
        public virtual void fun1()
        {
            Console.WriteLine("Function1 is created");
        }

        public virtual void fun2()
        {
            Console.WriteLine("Function2 is created");
        }

        public void fun3()
        {
            Console.WriteLine("Function3 is created");
        }
    }
}
