using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = SumNumbers(5, 15);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static int SumNumbers(int firstNum, int secondNum)
        {
            return (firstNum + secondNum);
        }
    }
}
