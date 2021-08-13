using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    public class Parent
    {
        public int Add(int i)
        {
            int j = 10;
            int x = i + j;
            Console.WriteLine(x);
            return x;
        }

    public void Add(string s)
        {
            Console.WriteLine(s);
        }
    }
}
