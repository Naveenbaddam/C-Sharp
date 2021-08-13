using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_classes
{
    class Demo2 : Demo1 
    {
        public override void fun1()
        {
            Console.WriteLine("first function is created");
        }

        public override void fun3()
        {
            Console.WriteLine("function3 is created");
        }
    }
}
