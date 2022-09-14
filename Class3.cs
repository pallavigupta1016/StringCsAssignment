using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Class3
    {
        static void Main()
        {
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());
            if (year % 4 == 0)
                Console.WriteLine("Leap year");
            else
                Console.WriteLine("Not a leap year");
        }
    }
}
