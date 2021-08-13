using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Demo
    {
        private int[] i = { 2, 5, 8, 7, 9 };
        private string[] s = { "Naveen", "Chaitu", "Vishal", "Anudeep" };
        private int x;
        private Boolean b;

        public void Mtd()
        {
            x = i [0];
            Console.WriteLine(s[0] + " is " + x + "nd in the class");
        }
      }
}
