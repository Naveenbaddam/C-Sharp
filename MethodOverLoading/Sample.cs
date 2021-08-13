using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    public class Sample
    {
        public void naveen(int i)
        {
            int k = 10;
            int p = 20;
            Console.WriteLine(i + k + p);
        }

        public void naveen(string s)
        {
            string w = " Mahesh";
            Console.WriteLine(s + " &" + w + " are our tutors");

        }

        public void naveen(int x , string k)
        {
            String q = x + " is the starting value of " + k;
            Console.WriteLine(q);
        }
    }
}
