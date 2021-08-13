using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticFunctionWithReturnType
{
    public class Sample
    {
        public static string names()
        {
            int i = 1;
            String s = "Integer should starts with ";
            String str = s + i;
            Console.WriteLine(str);
            return str;
        }
    }
}
