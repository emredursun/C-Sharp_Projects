using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator_Part2
{
    /// <summary>
    /// Classes Contained:
    /// 	Fraction
    /// 	FractionCalculator
    /// 	FractionException
    /// </summary>


    /// <summary>
    /// The class demonstrates the Fraction class
    /// </summary>
    public class FractionCalculator
    {
        public static void Main()
        {
            try
            {
                Greetings();

                OperationManu();


                Console.WriteLine("\n\nPress any key to exit");
            }   //end try
            catch (FractionException exp)
            {
                Console.WriteLine("\nInternal error: " + exp.Message);
                throw exp;
            }
            catch (Exception exp)
            {
                Console.WriteLine("\nSystem error: " + exp.Message);
            }
            Console.Read();
        }   //end main


        #region Methods of Interface
        public static void OperationManu()
        {
            string userActionChoice;
            do
            {
                Console.Clear();
                Console.WriteLine("  ============================  ");
                Console.WriteLine("||  Fraction Operations Menu  ||");
                Console.WriteLine("||                            ||");
                Console.WriteLine("|| 1. Add                     ||");
                Console.WriteLine("|| 2. Subtract                || ");
                Console.WriteLine("|| 3. Multiply                ||");
                Console.WriteLine("|| 4. Divide                  ||");
                Console.WriteLine("|| 5. Quit                    ||");
                Console.WriteLine("||                            ||");
                Console.WriteLine("================================");
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
                    AddFractions();
                    break;
                case "2":
                    Console.Clear();
                    SubtractFractions();
                    break;
                case "3":
                    Console.Clear();
                    MultiplyFractions();
                    break;
                case "4":
                    Console.Clear();
                    DivideFractions();
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
                Console.WriteLine("\n  Please enter your fractions in the form (a/b) or (a) where a and b are both integers!\n");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("".PadRight(93, '*'));
                Console.WriteLine($"* Enter a fraction(a / b) or integer(a): " + "".PadRight(51, ' ') + "*");
                Console.WriteLine("".PadRight(93, '*'));
                Console.ResetColor();
                Console.CursorLeft = 41;
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

        public static void Greetings()
        {
            string Greetings;
            var time = DateTime.Now.Hour;
            if (time < 6) Greetings = "Good night";
            else if (time >= 6 && time < 12) Greetings = "Goodmorning";
            else if (time >= 12 && time <= 18) Greetings = "Good afternoon";
            else Greetings = "Good evening";
            Console.WriteLine(" \t ================================================================");
            Console.WriteLine($"\t\t {Greetings}, Welcome to the Fraction Calculator! ");
            Console.WriteLine($"\t                                                  ");
            Console.WriteLine($"\t\t\tPress a key to continue...                      ");
            Console.WriteLine(" \t ================================================================");

            Console.ReadKey();
        }
        #endregion

        public static void AddFractions()
        {
            var userInput1 = GetUserInput();
            Fraction F1 = new Fraction(userInput1);
            var userInput2 = GetUserInput();
            Fraction F2 = new Fraction(userInput2);

            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 2;

            System.Console.WriteLine("F1 = " + F1.ToString());
            System.Console.WriteLine("F2 = " + F2.ToString());
            Console.WriteLine("\nF1 + F2 = " + (F1 + F2).ToString());

            //If user would try this Method again
            string userChoice = TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                AddFractions();
            }
            else
            {
                OperationManu();
            }
        }

        public static void SubtractFractions()
        {
            var userInput1 = GetUserInput();
            Fraction F1 = new Fraction(userInput1);
            var userInput2 = GetUserInput();
            Fraction F2 = new Fraction(userInput2);

            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 2;

            System.Console.WriteLine("F1 = " + F1.ToString());
            System.Console.WriteLine("F2 = " + F2.ToString());
            Console.WriteLine("\nF1 - F2 = " + (F1 - F2).ToString());

            //If user would try this Method again
            string userChoice = TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                SubtractFractions();
            }
            else
            {
                OperationManu();
            }
        }

        public static void MultiplyFractions()
        {
            var userInput1 = GetUserInput();
            Fraction F1 = new Fraction(userInput1);
            var userInput2 = GetUserInput();
            Fraction F2 = new Fraction(userInput2);

            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 2;

            System.Console.WriteLine("F1 = " + F1.ToString());
            System.Console.WriteLine("F2 = " + F2.ToString());
            Console.WriteLine("\nF1 * F2 = " + (F1 * F2).ToString());

            //If user would try this Method again
            string userChoice = TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                MultiplyFractions();
            }
            else
            {
                OperationManu();
            }
        }

        public static void DivideFractions()
        {
            var userInput1 = GetUserInput();
            Fraction F1 = new Fraction(userInput1);
            var userInput2 = GetUserInput();
            Fraction F2 = new Fraction(userInput2);

            // Move cursor 2 lines down
            Console.CursorTop = Console.CursorTop + 2;

            System.Console.WriteLine("F1 = " + F1.ToString());
            System.Console.WriteLine("F2 = " + F2.ToString());
            Console.WriteLine("\nF1 / F2 = " + (F1 / F2).ToString());

            //If user would try this Method again
            string userChoice = TryAgain();
            if (userChoice.Equals("Y"))
            {
                Console.Clear();
                DivideFractions();
            }
            else
            {
                OperationManu();
            }
        }
    }//end class Application



    /// Properties:
    /// 	Numerator: Set/Get value for Numerator
    /// 	Denominator:  Set/Get value for Numerator
    /// 	Value:  Set an integer value for the fraction
    /// 
    /// Constructors:
    /// 	no arguments:	initializes fraction as 0/1
    /// 	(Numerator, Denominator): initializes fraction with the given numerator and denominator values
    /// 	(integer):	initializes fraction with the given integer value
    /// 	(long):	initializes fraction with the given long value
    /// 	(double):	initializes fraction with the given double value
    /// 	(string):	initializes fraction with the given string value
    /// 				the string can be an in the form of and integer, double or fraction.
    /// 				e.g it can be like "123" or "123.321" or "123/456"
    /// 
    /// Public Methods (Description is given with respective methods' definitions)
    /// 	(override) string ToString(Fraction)
    /// 	Fraction ToFraction(string)
    /// 	Fraction ToFraction(double)
    /// 	double ToDouble(Fraction)
    /// 	Fraction Duplicate()
    /// 	Fraction Inverse(integer)
    /// 	Fraction Inverse(Fraction)
    /// 	ReduceFraction(Fraction)
    /// 	Equals(object)
    /// 	GetHashCode()
    /// 
    ///	Private Methods (Description is given with respective methods' definitions)
    /// 	Initialize(Numerator, Denominator)
    /// 	Fraction Negate(Fraction)
    /// 	Fraction Add(Fraction1, Fraction2)
    /// 
    /// Overloaded Operators (overloaded for Fractions, Integers and Doubles)
    /// 	Unary: -
    /// 	Binary: +,-,*,/ 
    /// 	Relational and Logical Operators: ==,!=,<,>,<=,>=
    /// 
    /// Overloaded user-defined conversions
    /// 	Implicit:	From double/long/string to Fraction
    /// 	Explicit:	From Fraction to double/string
    /// </summary>
}
