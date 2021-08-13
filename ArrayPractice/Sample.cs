using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    public class Sample
    {

        public void add()
        {
            Console.WriteLine("hi");
        }
        public static void Main (string [] args)
        {
            int[] i;
            i = new int[3];
            i[0] = 10;
            i[1] = 5;
            i[2] = 15;
            Console.WriteLine(i[0]);
            Console.WriteLine(i[1]);
            Console.WriteLine(i[2]);

            Sample obj = new Sample();
            obj.add();
        }
    }
}
