using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decider
{
    class SelectRandomQuestion
    {
        public SelectRandomQuestion()
        {
            // choose a random question from the question pool
            Random random = new Random();
            int randomNumber = random.Next(10);
            switch (randomNumber)
            {
                case 0:
                    Console.WriteLine("Are you a morning person?\n");
                    Console.WriteLine("(yes / no) => next question!");
                    Console.WriteLine("(exit) => close the console!");
                    break;
                case 1:
                    Console.WriteLine("Do you have any siblings?\n");
                    Console.WriteLine("(yes / no) => next question!");
                    Console.WriteLine("(exit) => close the console!");
                    break;
                case 2:
                    Console.WriteLine("Are you happy with your current relationship status?\n");
                    Console.WriteLine("(yes / no) => next question!");
                    Console.WriteLine("(exit) => close the console!");
                    break;
                case 3:
                    Console.WriteLine("Are you a risk-taker?\n");
                    Console.WriteLine("(yes / no) => next question!");
                    Console.WriteLine("(exit) => close the console!");
                    break;
                case 4:
                    Console.WriteLine("Do you sing in the shower?\n");
                    Console.WriteLine("(yes / no) => next question!");
                    Console.WriteLine("(exit) => close the console!");
                    break;
                case 5:
                    Console.WriteLine("Do you frequently use Twitter?\n");
                    Console.WriteLine("(yes / no) => next question!");
                    Console.WriteLine("(exit) => close the console!");
                    break;
                case 6:
                    Console.WriteLine("Have you ever dumped someone?\n");
                    Console.WriteLine("(yes / no) => next question!");
                    Console.WriteLine("(exit) => close the console!");
                    break;
                case 7:
                    Console.WriteLine("Do you like coffee?\n");
                    Console.WriteLine("(yes / no) => next question!");
                    Console.WriteLine("(exit) => close the console!");
                    break;
                case 8:
                    Console.WriteLine("Do you enjoy long car rides?\n");
                    Console.WriteLine("(yes / no) => next question!");
                    Console.WriteLine("(exit) => close the console!");
                    break;
                case 9:
                    Console.WriteLine("Do you like to gossip?\n");
                    Console.WriteLine("(yes / no) => next question!");
                    Console.WriteLine("(exit) => close the console!");
                    break;
            }
        }
    }
}
