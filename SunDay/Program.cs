using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunDay
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                This project challenges you to create a C# program that counts from 1 to 100,
                following the rules below:
                Print each number from 1 to 100 on its own line, with the following exceptions:
                If the number is evenly divisible by 3, print "Sun!".
                If the number is evenly divisible by 5, print "Day!".
                If the number is evenly divisible by 3 and 5, print "SunDay!"
            */
            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine($"{i} - SunDay!");
                else if (i % 3 == 0)
                    Console.WriteLine($"{i} - Day!");
                else if (i % 5 == 0)
                    Console.WriteLine($"{i} - Sun!");
                else
                    Console.WriteLine($"{i}");
            }

            Console.WriteLine("\nPress any key to close the Console Window!");
            Console.ReadKey();
        }
    }
}
