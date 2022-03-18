using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction_Calculator
{
    class Fraction
    {
        // Variables
        private int denominator;

        // Properties
        public int Numerator { get; set; }
        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                // If denominator is set to 0, catch the exception and output text in main program.
                denominator = value;
                
            }
        }

        // Constructors
        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }
        public Fraction(Fraction fraction)
        {
            this.Numerator = fraction.Numerator;
            this.Denominator = fraction.Denominator;
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        // Private Methods
        private void Reduce()
        {
            int greatestCommonDenominator = GCD(Numerator, Denominator);
            Numerator = Numerator / greatestCommonDenominator;
            Denominator = Denominator / greatestCommonDenominator;
        }
        private int LowestCommonDenominator(Fraction x, Fraction y)
        {
            return (x.Denominator * y.Denominator) / GCD(x.Denominator, y.Denominator);
        }

        // Operator overloaded methods
        public static Fraction operator +(Fraction x, Fraction y)
        {
            Fraction result = new Fraction();
            int xTempNum;
            int yTempNum;

            result.Denominator = x.LowestCommonDenominator(x, y);

            xTempNum = (result.Denominator / x.Denominator) * x.Numerator;
            yTempNum = (result.Denominator / y.Denominator) * y.Numerator;
            result.Numerator = xTempNum + yTempNum;

            result.Reduce();

            return result;
        }
        public static Fraction operator -(Fraction x, Fraction y)
        {
            Fraction result = new Fraction();
            int xTempNum;
            int yTempNum;

            result.Denominator = x.LowestCommonDenominator(x, y);

            xTempNum = (result.Denominator / x.Denominator) * x.Numerator;
            yTempNum = (result.Denominator / y.Denominator) * y.Numerator;
            result.Numerator = xTempNum - yTempNum;

            result.Reduce();

            return result;
        }
        public static Fraction operator *(Fraction x, Fraction y)
        {
            Fraction result = new Fraction();

            result.Numerator = x.Numerator * y.Numerator;
            result.Denominator = x.Denominator * y.Denominator;

            result.Reduce();

            return result;
        }
        public static Fraction operator /(Fraction x, Fraction y)
        {
            
            Fraction result = new Fraction();

            result.Numerator = x.Numerator * y.Denominator;
            result.Denominator = x.Denominator * y.Numerator;

            result.Reduce();

            return result;
            
        }

        // Outputting methods
        public double ToDecimal(int decimalPlaces = 3)
        {
            double fractionDecimal = (double)Numerator / (double)Denominator;
            return Convert.ToDouble(fractionDecimal.ToString($"N{decimalPlaces}"));
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        // Misc Methods
        private int GCD(int a, int b)
        {
            if (b == 0) return a;
            return GCD(b, a % b);
        }
    }
}
