using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operators
{
    public class TestFractions
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 4);
            //Fraction f1 = (double)10 / 350;
            Console.WriteLine("f1 = {0}", f1);
            Fraction f2 = (double)7 / 10;
            Console.WriteLine("f2 = {0}", f2);
            Console.WriteLine("-f1 = {0}", ++f1);
            Console.WriteLine("f1 - f2 = {0}", f1 - f2);

            Console.WriteLine("-(f1+f2)*(f1-f2/f1) = {0}", -(f1 + f2) * (f1 - f2 / f1));

        }
    }
}
