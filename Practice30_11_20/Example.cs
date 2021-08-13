using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice30_11_20
{
    class Example
    {
        public static void Main(string[] args)
        {
            Demo obj = new Demo(10);
            obj.fun2();
            obj.fun5();
            obj.fun1(10);
            obj.fun1(1, 2, 2);
            Sample.fun3();
            Sample.fun4();
            


        }
    }
}
