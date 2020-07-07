using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decider
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAnswer = "";
            Console.Write("Would you like to get a few random questions? (yes/exit): ");
            userAnswer = Console.ReadLine();
            while (userAnswer != "exit")
            {
                Console.Clear();
                switch (userAnswer)
                {
                    case "yes":
                        new SelectRandomQuestion();
                        userAnswer = Console.ReadLine();
                        break;
                    case "no":
                        new SelectRandomQuestion();
                        userAnswer = Console.ReadLine();
                        break;
                    case "exit":
                        Console.WriteLine("Bye bye ...");
                        System.Threading.Thread.Sleep(1000);
                        return;
                    default:
                        // Show for 1 second a message to make the user aware of an invalid choise and the show then manu again
                        Console.WriteLine($"Invalid input => '{userAnswer}'\nNext question ...");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        new SelectRandomQuestion();
                        userAnswer = Console.ReadLine();
                        break;
                }
            }
        }
    }
}
