using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FractionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            GetUserInput();

            #region Check out
            Console.WriteLine("\nPress any key to close the Console Window!");
            Console.ReadKey();
            #endregion
        }

        // Get User Input Method
        public static void GetUserInput()
        {
            var useFractionClass = new Fraction();
            int numerator, denominator;
            try
            {
                Console.Write("\nNumerator: ");
                numerator = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nDenominator: ");
                denominator = Convert.ToInt32(Console.ReadLine());

                // Move cursor 1 lines down
                Console.CursorTop = Console.CursorTop + 1;
                useFractionClass.CreateFraction(numerator, denominator);
                Console.WriteLine("Above fraction was created successfully.");
                Console.WriteLine("\n\tNumerator: {0}\n\tDenominator: {1}\n\tQuotient: {2}", numerator, denominator, (decimal)numerator / (decimal)denominator);
                Console.WriteLine("=========================================================");
            }
            catch (ArgumentException ex)
            {
                // Move cursor 1 lines down
                Console.CursorTop = Console.CursorTop + 1;
                Console.WriteLine("================================================================");
                Console.WriteLine("Failed! Fraction could not be created!");
                Console.WriteLine(ex.Message);
                Console.WriteLine("================================================================");
            }
            finally
            {
                //If user would try this Method again
                string userChoice = TryAgain();
                if (userChoice.Equals("Y"))
                {
                    Console.Clear();
                    GetUserInput();
                }
                else
                {
                    Environment.Exit(0);
                }
            }
        }

        // Tey Again Method
        public static string TryAgain()
        {
            Console.WriteLine("\n\tWould you like to try for any other examples?");
            Console.WriteLine("\t\t\t  =====================  ");
            Console.WriteLine("\t\t\t||                     ||");
            Console.WriteLine("\t\t\t||  (Y)es or (Q)uit    ||");
            Console.WriteLine("\t\t\t||                     ||");
            Console.WriteLine("\t\t\t  =====================  ");
            Console.Write("\n\tEnter your option: ");
            string userChoice = Console.ReadLine().ToUpper();
            return userChoice;
        }
    }
}

