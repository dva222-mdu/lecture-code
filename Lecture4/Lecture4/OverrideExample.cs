using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    
    class A
    {
        public virtual void F() { Console.WriteLine("A.F()"); }
    }

    class B : A 
    {
        public override void F() { base.F();  Console.WriteLine("B.F()"); }
    }

}
