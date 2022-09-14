using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Class2
    {
        static void Main()
        {
            Console.WriteLine("Enter number of eggs:");
            int n = int.Parse(Console.ReadLine());
            int gross = n / 144;
            int dozen = (n - gross*144) / 12;
            int left = n - gross*144 - dozen*12;
            Console.WriteLine("Your number of eggs is {0} gross, {1} dozen, and {2}", gross, dozen, left);
        }
    }
}
