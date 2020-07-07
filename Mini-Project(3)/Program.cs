using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddsOrEvens
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1 - Pick odds or evens
            Console.WriteLine("\n\tLet’s play a game called 'Odds and Evens'");

            Console.Write("\n What is your name? ");
            string playerName = Console.ReadLine();

        TRYAGAIN:
            Console.Write($"\n Hi {playerName}, which do you choose? (O)dds or (E)vens? ");
            string playerChoice = Console.ReadLine();

            if (playerChoice == "O" || playerChoice == "o")
            {
                Console.WriteLine($"\n\t{playerName} has picked odds! The computer will be evens.");
            }
            else if (playerChoice == "E" || playerChoice == "e")
            {
                Console.WriteLine($"\n\t{playerName} has picked evens! The computer will be odds.");
            }
            else
            {
                Console.WriteLine("\n\tYou entered an invalid value, please try again!");
                goto TRYAGAIN;
            }


            // Part 2 - Play the Game
            int userNumber = 0;
            do
            {
                Console.Write("\n\tHow many 'fingers' do you throw? \n\t(1, 2, 3, 4, or 5 fingers only) => ");
                userNumber = Convert.ToInt32(Console.ReadLine());
            } while (userNumber <= 0 || userNumber > 5);
            Console.WriteLine($"\n\t => You play {userNumber} 'fingers'.");

            int computerNumber = new Random().Next(1, 6);
            Console.WriteLine($"\n\t => The computer plays {computerNumber} 'fingers'.");

            int sum = userNumber + computerNumber;
            Console.WriteLine($"\n\t => {userNumber} + {computerNumber} = {sum}");

            if (sum % 2 == 0)
            {
                Console.WriteLine($"\n\t => {sum} is an even number.");
                if (playerChoice == "E" || playerChoice == "e")
                {
                    Console.WriteLine($"\n\t => That means {playerName} wins!");
                }
                else
                {
                    Console.WriteLine($"\n\t => That means the computer wins!");
                }
            }
            else
            {
                Console.WriteLine($"\n\t => {sum} is an odd number.");
                if (playerChoice == "O" || playerChoice == "o")
                {
                    Console.WriteLine($"\n\t => That means {playerName} wins!");
                }
                else
                {
                    Console.WriteLine($"\n\t => That means the computer wins!");
                }
            }

            Console.WriteLine("\nPress any key to close the Console Window!");
            Console.ReadKey();
        }
    }
}
