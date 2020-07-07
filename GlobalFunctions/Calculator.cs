using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalFunctions
{
    public static class Calculator
    {
        /// <summary>
        /// Calculates the sum of two numbers.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns>The sum</returns>
        public static double Add(double firstNumber, double secondNumber)
        {
            var result = secondNumber + firstNumber;
            return result;
        }

        /// <summary>
        /// Subtracts two numbers.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns>The difference</returns>
        public static double Subtract(double firstNumber, double secondNumber)
        {
            var result = firstNumber - secondNumber;
            return result;
        }

        /// <summary>
        /// Multiplies the specified numbers.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns>The product</returns>
        public static double Multiply(double firstNumber, double secondNumber)
        {
            var result = firstNumber * secondNumber;
            return result;
        }

        /// <summary>
        /// Divides the first number by the second number.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns>The quotient</returns>
        public static double Divide(double firstNumber, double secondNumber)
        {
            var result = firstNumber / secondNumber;
            return result;
        }

        /// <summary>
        /// Calculates the modulus of the first number divided .
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <returns></returns>
        public static double Mod(double firstNumber, double secondNumber)
        {
            var result = firstNumber % secondNumber;
            return result;
        }

        /// <summary>
        /// Calculates sum, product, difference and quotient.
        /// </summary>
        /// <param name="firstNumber">The first number.</param>
        /// <param name="secondNumber">The second number.</param>
        /// <param name="sum">The sum.</param>
        /// <param name="difference">The difference.</param>
        /// <param name="product">The product.</param>
        /// <param name="quotient">The quotient.</param>
        public static void Calculate(double firstNumber, double secondNumber, out double sum, out double difference,
            out double product, out double quotient, out double mod)
        {
            sum = firstNumber + secondNumber;
            difference = firstNumber - secondNumber;
            product = firstNumber * secondNumber;
            quotient = firstNumber / secondNumber;
            mod = firstNumber % secondNumber;
        }
    }
}
