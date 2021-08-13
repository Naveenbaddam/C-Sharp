using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class GrandChild : Child 
    {
        public string Name(string str)
        {
            string z = str;
            Console.WriteLine(z);
            return z;
        }
    }
}
