using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_Polymorphism
{
    class Demo
    {
        public static void Main(String [] args)
        {
            Parent p = new Child();
            p.fun1();
            p.fun2();
            p.fun3();
           
        }
    }
}
