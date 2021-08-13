using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice30_11_20
{
    class Demo : Sample
    {
        //method overriding

        public string fun2()
        {
            string myName = "Naveen";
            Console.WriteLine("Override function2 - " + myName);
            return myName;
        }

        public override void fun5()
        {
            Console.WriteLine("Override function5");
        }

        //Paremeterised Constructor

        public Demo(int i)
        {
            int x = i + 5;
            Console.WriteLine("this is 2nd line , answer is " + x);

        }
    }
}
