using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTime_Polymorphism
{
    class Child : Parent 
    {
        public void fun4()
        {
            Console.WriteLine("Function4 is created");
        }

        public void fun5()
        {
            Console.WriteLine("Function5 is created");
        }
    }
}
