using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FractionCalculator
{
    class Fraction
    {
        #region  Instance Variables 
        private int _numerator;
        private int _denominator;
        #endregion

        #region Properties
        public int Numerator
        {
            get { return _numerator; }
        }
        public int Denominator
        {
            get { return _numerator; }
        }
        #endregion

        #region Constructors
        public Fraction()
        {
            _numerator = 0;
            _denominator = 1;
        }
        public Fraction(int numerator) 
        {
            int denominator = 1;
            CreateFraction(numerator, denominator);
        }
        public Fraction(int numerator, int denominator)
        {
            CreateFraction(numerator, denominator);
        }
        #endregion

        #region Methods
        public void CreateFraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("'Who divides by zero is a kid!'", "In a division, the divisor must not equal zero!");
            }
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }

            _numerator = numerator;
            _denominator = denominator;
            Console.WriteLine($"Fraction = {_numerator} / {_denominator}");
        }
        #endregion
    }
}
