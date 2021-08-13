using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePractice
{
    class Demo
    {
        public static void Main(string[] args)
        {
            GrandChild obj = new GrandChild();
            obj.Add(1);
            obj.Add("naveen");
            obj.Sample();
            obj.Name("Chaitu");
        }
    }
}
