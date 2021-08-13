using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice30_11_20
{
  
    public abstract class Sample
    {
     
        
        //Non Static function with out return type
        public void fun1(int i, int j,int k)
        {
            int x = i + j + k;
            Console.WriteLine(x);
        }

        //Non static function with return type

        public string fun2(string a, string b, string c)
        {
            string s = a + b + c;
            return s;
        }
       
        //Static function with out return value

        public static void fun3()
        {
            for(int i=0; i<=5; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Static function with return value

        public static int fun4()
        {
            int x = 10;
            Console.WriteLine(x);
            return x;
        }

        //Constructor
        public Sample()
        {
            Console.WriteLine("Constructor executed first");
        }

       
        

        //method overloading
        public void fun1(int k)
        {
            Console.WriteLine(k);
        }

        // Abstract class

        public abstract void fun5();

    }
}
