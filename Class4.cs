using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    internal class Class4
    {
        static void Main()
        {
            Console.WriteLine("Enter number for red:");
            byte red = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for green:");
            byte green = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter number for blue:");
            byte blue = byte.Parse(Console.ReadLine());
            if (red == 0 && green == 0 && blue > 0)
                Console.WriteLine("bluish");
            else if (red == 0 && green > 0 && blue == 0)
                Console.WriteLine("greenish");
            else if (red > 0 && green == 0 && blue == 0)
                Console.WriteLine("reddish");
            else
                Console.WriteLine("some color");
        }
    }
}
