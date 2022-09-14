using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Class1
    {
        static void Main()
        {
            int a = 1, b = 2;
            Console.WriteLine("before swap a={0} b={1}", a, b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("after swap a={0} b={1}", a, b);
        }
    }
}
