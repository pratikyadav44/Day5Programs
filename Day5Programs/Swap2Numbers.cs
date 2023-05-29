using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Programs
{
    internal class Swap2Numbers
    {
        public static void swap()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("After swapping:\nFirst number is {0}\nSecond number is {1}", a, b);
        }
    }
}
