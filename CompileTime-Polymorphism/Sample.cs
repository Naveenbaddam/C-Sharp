﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompileTime_Polymorphism
{
    class Sample
    {
       public static void Main (string [] args)
        {
            Parent p = new Child();
            p.fun1();
            p.fun2();
            p.fun3();
        }
    }
}
