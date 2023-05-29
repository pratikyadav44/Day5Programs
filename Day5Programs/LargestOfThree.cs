using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5Programs
{
    internal class LargestOfThree
    {
        public static void Largest()
        {
            Console.Write("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int largest;
            if (a > b)
            {
                largest = a;
            }
            else
            {
                largest = b;
            }

            if (c > largest)
            {
                largest = c;
            }
            Console.WriteLine("Largest number among these 3 numbers is: " + largest);
        }
    }
}
