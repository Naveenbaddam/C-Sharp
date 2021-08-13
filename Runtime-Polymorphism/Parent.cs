using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism
{
    public class Parent
    {
        public virtual  void fun1()
        {
            Console.WriteLine("Function1 is created");
        }

        public virtual void fun2()
        {
            Console.WriteLine("Function2 is created");
        }

        public void fun3()
        {
            Console.WriteLine("Function three");
        }
    }
}
