using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_Demo5___overloading_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 2);
            Fraction f2 = new Fraction(1, 2);

            Console.WriteLine($"{f1} + {f2} = {f1 + f2}");
        }
    }
}
