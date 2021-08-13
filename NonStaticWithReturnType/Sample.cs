using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticWithReturnType
{
    public class Sample
    {
        private int i = 10;
        private string s = "Naveen";

        public int add()
        {

            return i;
        }

        public string str()
        {
            return s;
         }

    }

}
