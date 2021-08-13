using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has_A_RelationshipPractice
{
    class Sample1
    {
        private Sample p;
        public void fun3()
        {
            Console.WriteLine("Function three");
            p = new Sample();
            p.fun1();
            p.fun2();
        }
    }
}
