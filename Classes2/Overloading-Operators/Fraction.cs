using System;

namespace Overloading_Operators
{
    public class Fraction
    {
        private long numerator;
        private long denomerator;

        public Fraction(long numerator, long denomerator)
        {
            long gcd = GreatestCommonDivisor(numerator, denomerator);
            this.numerator = numerator / gcd;
            this.denomerator = denomerator / gcd;

            if (this.denomerator < 0)
            {
                this.numerator = -numerator;
                this.denomerator = -denomerator;
            }
        }

        private static long GreatestCommonDivisor(
            long firstNumber, long secondNumber)
        {
            firstNumber = Math.Abs(firstNumber);
            secondNumber = Math.Abs(secondNumber);

            while (firstNumber > 0)
            {
                long newNumber = secondNumber % firstNumber;
                secondNumber = firstNumber;
                firstNumber = newNumber;
            }
            return secondNumber;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denomerator +
                f2.numerator * f1.denomerator;
            long denom = f1.denomerator * f2.denomerator;

            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denomerator -
            f2.numerator * f1.denomerator;
            long denom = f1.denomerator * f2.denomerator;

            return new Fraction(num, denom);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.numerator;
            long denom = f1.denomerator * f2.denomerator;

            return new Fraction(num, denom);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denomerator;
            long denom = f1.denomerator * f2.numerator;

            return new Fraction(num, denom);
        }

        //unary minus operator
        public static Fraction operator -(Fraction fraction)
        {
            long num = -fraction.numerator;
            long denom = fraction.denomerator;

            return new Fraction(num, denom);
        }

        //++ uniry
        public static Fraction operator ++(Fraction fraction)
        {
            long num = fraction.numerator + fraction.denomerator;
            long denom = fraction.denomerator;

            return new Fraction(num, denom);
        }

        //-- uniry
        public static Fraction operator --(Fraction fraction)
        {
            long num = fraction.numerator - fraction.denomerator;
            long denom = fraction.denomerator;

            return new Fraction(num, denom);
        }

        //bool

        public static bool operator true(Fraction fraction)
        {
            return fraction.numerator != 0;
        }

        public static bool operator false(Fraction fraction)
        {
            return fraction.numerator == 0;
        }

        //conversion of the double operator

        public static explicit operator double(Fraction fraction)
        {
            return (double)fraction.numerator / fraction.denomerator;
        }

        public static implicit operator Fraction(double value)
        {
            double num = value;
            long denom = 1;
            while ((num - Math.Floor(num) > 0))
            {
                num = num * 10;
                denom = denom * 10;
            }

            return new Fraction((long)num, denom);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", numerator, denomerator);
        }
    }
}
