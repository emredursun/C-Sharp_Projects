using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculatorLibrary
{
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
            //set { _numerator = value; }
        }

        /// <summary>Gets the denominator.</summary>
        /// <value>The denominator.</value>
        public int Denominator
        {
            get 
            { 
                return _denominator; 
            }
            //set
            //{
            //    if (value != 0)
            //        _denominator = value;
            //    else
            //        throw new ArgumentException("Denominator cannot be assigned a ZERO Value");
            //}
        }
        #endregion


        #region Constructors

        public Fraction() : this(0, 1) { }

        /// <summary>Initializes a new instance of the <see cref="Fraction" /> class.</summary>
        /// <param name="numerator">The numerator.</param>
        public Fraction(int iWholeNumber) : this(iWholeNumber, 1) { }


        /// <summary>Initializes a new instance of the <see cref="Fraction" /> class.</summary>
        /// <param name="numerator">The numerator.</param>
        /// <param name="denominator">The denominator.</param>
        /// <exception cref="ArgumentException">In a fraction, the denominator must not equal zero!</exception>
        public Fraction(int numerator, int denominator)
        {
            // Check for zero denominator
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be assigned a ZERO Value");

            // Bump negative denominator then reasign the signs of numerator and denominator with opposite signs
            if (denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            _numerator = numerator;
            _denominator = denominator;
        }
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
            if (this.Denominator == 1)
            {
                str = this.Numerator.ToString();
                return str;
            }
            else
            {
                str= this.Numerator.ToString() + "/" + this.Denominator.ToString();
                return str;
            }
        }


        /// <summary>Converts to double.</summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException">In a fraction, the denominator must not equal zero!</exception>
        public double ToDouble()
        {
            return (Math.Round((double)Numerator / Denominator, 15));
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
