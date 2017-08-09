using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy7and3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrNumbers = {21, 42, 63, 84, 1235 };

            var devisableNumbersLambda = arrNumbers.Where(x => (x % 3 == 0 && x % 7 == 0));
            var devisableNumbersLinq = from number in arrNumbers
                                       where number % 3 == 0
                                       where number % 7 == 0
                                       select number;


        }
    }
}
