using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_StringConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            MainManu();

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }

        public static void MainManu()
        {
            string userActionChoice;
            string Greetings;
            do
            {
                var time = DateTime.Now.Hour;
                if (time < 6) Greetings = "Good night";
                else if (time >= 6 && time < 12) Greetings = "Goodmorning";
                else if (time >= 12 && time <= 18) Greetings = "Good afternoon";
                else Greetings = "Good evening";
                Console.Clear();
                Console.WriteLine("  ==================================================  ");
                Console.WriteLine($"   {Greetings}, Welcome to String Converter Menu");
                Console.WriteLine("||                                                  ||");
                Console.WriteLine("|| 1. Reverse                                       ||");
                Console.WriteLine("|| 2. Is Palindrom                                  || ");
                Console.WriteLine("|| 3. Pig Latin                                     ||");
                Console.WriteLine("|| 4. Shorthand                                     ||");
                Console.WriteLine("|| 5. Quit                                          ||");
                Console.WriteLine("||                                                  ||");
                Console.WriteLine("======================================================");
                Console.Write("Enter your option: ");
                userActionChoice = Console.ReadLine().ToUpper();
            }
            while
            (
                !userActionChoice.Equals("1") &&
                !userActionChoice.Equals("2") &&
                !userActionChoice.Equals("3") &&
                !userActionChoice.Equals("4") &&
                !userActionChoice.Equals("5")
            );

            switch (userActionChoice)
            {
                case "1":
                    Console.Clear();
                    StringConverter.Reverse();
                    break;
                case "2":
                    Console.Clear();
                    StringConverter.IsPalindrome();
                    break;
                case "3":
                    Console.Clear();
                    StringConverter.PigLatinate();
                    break;
                case "4":
                    Console.Clear();
                    StringConverter.Shorthand();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;

            }
        }


        // Get User Input Method
        public static string GetUserInput()
        {
            var userInput = "";
            do
            {
                Console.Clear();
                Console.WriteLine(" Enter your text to check it out (max. 70) :\n");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("".PadRight(80, '*'));
                Console.WriteLine("* Input:" + "".PadRight(71, ' ') + "*");
                Console.WriteLine("".PadRight(80, '*'));
                Console.ResetColor();
                Console.CursorLeft = 9;
                Console.CursorTop = Console.CursorTop - 2;
                userInput = Console.ReadLine();
            } while (userInput.Length < 1 || userInput.Length > 70);
            return userInput;
        }

        // Try Again Method
        public static string TryAgain()
        {
            Console.WriteLine("\n\tWould you like to try for any other examples?");
            Console.WriteLine("\t\t\t ------------------------- ");
            Console.WriteLine("\t\t\t|                         |");
            Console.WriteLine("\t\t\t|  (Y)es or (M)ain Menu   |");
            Console.WriteLine("\t\t\t|                         |");
            Console.WriteLine("\t\t\t ------------------------- ");
            Console.Write("\n\tEnter your option: ");
            string userChoice = Console.ReadLine().ToUpper();
            return userChoice;
        }
    }
}
