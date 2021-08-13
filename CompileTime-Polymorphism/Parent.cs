using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTime_Polymorphism
{
    public class Parent
    {
        public void fun1()
        {
            Console.WriteLine("Function1 is created");
        }

        public void fun2()
        {
            Console.WriteLine("Function2 is created");
        }

        public void fun3()
        {
            Console.WriteLine ("Function3 is created");
        }
    }
}
