using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_Demo5___overloading_operators
{
    public class Fraction
    {
        #region Fields
        private long numerator;
        private long denomerator;
        #endregion

        #region Constructors
        public Fraction(long numerator, long denomerator)
        {
            this.numerator = numerator;
            this.denomerator = denomerator;
        }
        #endregion


        #region Methods
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denomerator + f1.denomerator * f2.numerator;
            long denom = f1.denomerator * f2.denomerator;
            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.denomerator - f2.numerator * f1.denomerator;
            long denom = f1.denomerator * f2.denomerator;
            return new Fraction(num, denom);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            long num = f1.numerator * f2.numerator;
            long denom = f1.denomerator * f2.denomerator;
            return new Fraction(num, denom);
        }

        public static Fraction operator -(Fraction fraction)
        {
            long num = -fraction.numerator;
            long denom = -fraction.denomerator;
            return new Fraction(num, denom);
        }

        public static Fraction operator ++(Fraction fraction)
        {
            long num = fraction.numerator + fraction.numerator;
            long denom = fraction.denomerator + fraction.denomerator;
            return new Fraction(num, denom);
        }

        public override string ToString()
        {
            return ((double) this.numerator / this.denomerator).ToString();
        }

        #endregion


    }
}
