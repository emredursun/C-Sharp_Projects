using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Init function calls private static void init() method to greet users.
            Init();

            // Generate random number and assign it to a variable.
            int answer = new Random().Next(1, 101);

            // Play game function calls private static void play(int answer) method.
            Play(answer);

            Console.WriteLine("\nPress any key to close the Console Window!");
            Console.ReadKey();
        }

        private static void Init()
        {
            // Welcome users
            Console.WriteLine("Welcome to inputGuess Game!");

            // Ask user for input
            Console.WriteLine("\nPlease enter your guess between 1 and 100!");
        }

        private static void Play(int answer)
        {
            int inputGuess;
            int countInputGuess = 0;
            Boolean userWin = false;
            do
            {
                inputGuess = Convert.ToInt32(Console.ReadLine());

                if (inputGuess < answer)
                {
                    countInputGuess++;
                    Console.WriteLine($"\nGuess is too low! You have attempted { countInputGuess } times.");
                    continue;
                }
                else if (inputGuess > answer)
                {
                    countInputGuess++;
                    Console.WriteLine($"\nGuess is too high! You have attempted { countInputGuess } times.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"\nYOU WIN. The number is { answer } and you found the answer in { countInputGuess } attempts. Congratulations... :) \n");
                    userWin = true;
                }
            }
            while (userWin == false);
        }

    }
}
