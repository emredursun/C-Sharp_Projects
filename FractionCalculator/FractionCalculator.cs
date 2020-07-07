using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionCalculatorLibrary;

namespace FractionCalculatorLibrary
{
    class FractionCalculator
    {
        static void Main(string[] args)
        {
            Greetings();
            
            OperationManu();

            Console.WriteLine("\nDruk op een knop om een andere opdracht te testen!");
            Console.ReadKey();
        }
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
    }

    public class Fraction
    {
        #region  Fields
        private int _numerator;
        private int _denominator;
        #endregion

        #region Properties
        /// <summary>Gets the numerator.</summary>
        /// <value>The numerator.</value>
        public int Numerator
        {
            get { return _numerator; }
        }

        /// <summary>Gets the denominator.</summary>
        /// <value>The denominator.</value>
        public int Denominator
        {
            get { return _denominator; }
        }
        #endregion


        #region Constructors
        /// <summary>Initializes a new instance of the <see cref="Fraction" /> class.</summary>
        /// <param name="numerator">The numerator.</param>
        /// <param name="denominator">The denominator.</param>
        /// <exception cref="ArgumentException">In a fraction, the denominator must not equal zero!</exception>
        public Fraction(int numerator, int denominator)
        {
            // Check for zero denominator
            if (denominator == 0)
                throw new ArgumentException("In a fraction, the denominator must not equal zero!");

            // Bump negative denominator then reasign the signs of numerator and denominator with opposite signs
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            _numerator = numerator;
            _denominator = denominator;
        }

        /// <summary>Initializes a new instance of the <see cref="Fraction" /> class.</summary>
        /// <param name="numerator">The numerator.</param>
        public Fraction(int numerator) : this(numerator, 1) { }
        #endregion


        #region Methods
        /// <summary>Multiplies with the specified fraction.</summary>
        /// <param name="fraction">The fraction.</param>
        /// <returns></returns>
        public Fraction Multiply(Fraction fraction)
        {
            int numerator = Numerator * fraction.Numerator;
            int denominator = Denominator * fraction.Denominator;
            return new Fraction(numerator, denominator);
        }

        /// <summary>Divides with the specified fraction.</summary>
        /// <param name="fraction">The fraction.</param>
        /// <returns></returns>
        public Fraction Divide(Fraction fraction)
        {
            int numerator = Numerator * fraction.Denominator;
            int denominator = Denominator * fraction.Numerator;
            return new Fraction(numerator, denominator);
        }

        /// <summary>Adds with the specified fraction.</summary>
        /// <param name="fraction">The fraction.</param>
        /// <returns></returns>
        public Fraction Add(Fraction fraction)
        {
            int numerator = Numerator * fraction.Denominator + fraction.Numerator * Denominator;
            int denominator = Denominator * fraction.Denominator;
            return new Fraction(numerator, denominator);
        }

        /// <summary>Subtracts with the specified fraction.</summary>
        /// <param name="fraction">The fraction.</param>
        /// <returns></returns>
        public Fraction Subtract(Fraction fraction)
        {
            int numerator = Numerator * fraction.Denominator - fraction.Numerator * Denominator;
            int denominator = Denominator * fraction.Denominator;
            return new Fraction(numerator, denominator);
        }

        /// <summary>Gets the numerator.</summary>
        /// <returns></returns>
        public int GetNumerator()
        {
            return _numerator;
        }

        /// <summary>Gets the denominator.</summary>
        /// <returns></returns>
        public int GetDenominator()
        {
            return _denominator;
        }


        /// <summary>Converts to string.</summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            string str;
            if (_denominator == 1)
            {
                //return String.Format("Fraction({0})", Numerator);
                str = _numerator.ToString();
                return str;
            }
            else
            {
                //return String.Format("Fraction({0}, {1})", Numerator, Denominator);
                str= _numerator.ToString() + "/" + _denominator.ToString();
                return str;
            }
        }


        /// <summary>Converts to double.</summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">In a fraction, the denominator must not equal zero!</exception>
        public double ToDouble()
        {
            if (Denominator == 0)
            {
                throw new ArgumentException("In a fraction, the denominator must not equal zero!");
            }
            double result = Math.Round((double)Numerator / (double)Denominator, 2);
            return result;
        }


        /// <summary>Converts to lowestterms.</summary>
        /// <returns></returns>
        public Fraction ToLowestTerms()
        {
            var gcd = GCD(Numerator, Denominator);

            return new Fraction(Numerator / gcd, Denominator / gcd);
        }

        /// <summary>Converts the current fraction to the lowestterms.</summary>
        //public Fraction ToLowestTerms()
        //{
        //    int reminder = 0, gcd = 0;
        //    int up = _numerator, bottom = _denominator;

        //    while (up != 0 && bottom != 0)
        //    {
        //        reminder = up % bottom;
        //        up = bottom;
        //        bottom = reminder;
        //        gcd = up;
        //    }
        //    _numerator /= gcd;
        //    _denominator /= gcd;
        //    return new Fraction(_numerator, _denominator);
        //    //return _numerator.ToString() + " / " + _denominator.ToString();
        //    //Console.WriteLine($"The lowest terms of your fraction: {_numerator} / {_denominator}");
        //}


        /// <summary>GCDs the specified numerator.</summary>
        /// <param name="numerator">The numerator.</param>
        /// <param name="denominator">The denominator.</param>
        /// <returns></returns>
        public static int GCD(int numerator, int denominator)
        {
            if (numerator < 0)
                numerator = -numerator;
            if (denominator < 0)
                denominator = -denominator;

            while (numerator != 0 && denominator != 0)
            {
                if (numerator > denominator)
                    numerator %= denominator;
                else
                    denominator %= numerator;
            }

            return numerator == 0 ? denominator : numerator;
        }



        /// <summary>Determines whether the specified object is equal to the current object.</summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns>
        ///   <span class="keyword">
        ///     <span class="languageSpecificText">
        ///       <span class="cs">true</span>
        ///       <span class="vb">True</span>
        ///       <span class="cpp">true</span>
        ///     </span>
        ///   </span>
        ///   <span class="nu">
        ///     <span class="keyword">true</span> (<span class="keyword">True</span> in Visual Basic)</span> if the specified object  is equal to the current object; otherwise, <span class="keyword"><span class="languageSpecificText"><span class="cs">false</span><span class="vb">False</span><span class="cpp">false</span></span></span><span class="nu"><span class="keyword">false</span> (<span class="keyword">False</span> in Visual Basic)</span>.
        /// </returns>
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                //This object is created for
                Fraction compareObject = (Fraction)obj;

                //converting to the lowest terms to compare
                compareObject = compareObject.ToLowestTerms();

                //Find gcd and converting the original object to the lowest terms to compare
                var gcd = GCD(Numerator, Denominator);

                // Compare the data members and return accordingly
                return (Numerator / gcd == compareObject.Numerator) && (Denominator / gcd == compareObject.Denominator);
            }
        }






        //public override bool Equals(Object obj)
        //{

        //    // If the object is compared with itself then return true
        //    if (obj == this)
        //    {
        //        return true;
        //    }

        //    /* check if o is an instance of Complex or not
        //      "null instanceof [type]" also returns false */
        //    if ((obj == null) || !this.GetType().Equals(obj.GetType()))
        //    {
        //        return false;
        //    }

        //    //This object is created for
        //    Fraction compareObject = new Fraction(this.GetNumerator(), this.GetDenominator());
        //    compareObject.ToLowestTerms();

        //    // typecast o to Fraction so that we can compare data members
        //    Fraction x = (Fraction)obj;

        //    //converting to the lowest terms to compare
        //    ((Fraction)obj).ToLowestTerms();

        //    // Compare the data members and return accordingly
        //    return (compareObject.GetNumerator() == x.GetNumerator() && compareObject.GetDenominator() == x.GetDenominator());
        //}



        //// Equality operators

        //public static bool operator ==(Fraction a, Fraction b)
        //{
        //    return Equals(a, b);
        //}

        //public static bool operator !=(Fraction a, Fraction b)
        //{
        //    return !Equals(a, b);
        //}
        #endregion
    }
}
