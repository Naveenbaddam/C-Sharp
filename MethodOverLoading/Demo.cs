using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class Demo
    {
        static void Main(string[] args)
        {
            Sample obj = new Sample();
            obj.naveen(5);
            obj.naveen("Raj");
            obj.naveen(1, "interger");
        }
    }
}
