using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has_A_Relation
{
    class Abc
    {
        private Sample p = new Sample(); //user defined datatype
        public Abc() //constructor
         {
            Console.WriteLine("Constructor created");
          //  p = new Sample();
            p.fun1();
            p.fun2();


        }
    }
}
