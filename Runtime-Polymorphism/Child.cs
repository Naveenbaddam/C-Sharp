using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism
{
    class Child : Parent 
    {
        public override  void fun1()
        {
            Console.WriteLine("Function1 is again created");
        }

        public override void fun2()
        {
            Console.WriteLine("Function 2 is again created");
        }

        
           
   
    }
}
