using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalFunctions
{
    public static class ConsoleFunctions
    {
        public static void Exit()
        {
            Console.WriteLine("Press a key to exit the program ...");
            Console.ReadKey();
        }

        public static void WriteEmptyLines(int numberOfLines)
        {
            for (int i = 0; i < numberOfLines; i++)
            {
                Console.WriteLine(DateTime.Now.DayOfWeek.ToString());
            }
        }
    }
}
