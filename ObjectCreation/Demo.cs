using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCreation
{
    class Demo
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();

            Console.WriteLine(obj.i);
            Console.WriteLine(obj.s);
        }
    }
    
}
