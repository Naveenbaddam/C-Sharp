using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticWithReturnType
{
    class Demo
    {
        public static void Main(String[] args)
        {
            Sample obj = new Sample();

            int x = obj.add();
            Console.WriteLine(x);

            string s = obj.str();
            Console.WriteLine(s);

        }
        
    }
}
