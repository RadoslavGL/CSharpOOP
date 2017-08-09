using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_IEnumerable_extensions
{
    public class IEnumerableExtensions
    {
        public static void Main(string[] args)
        {
            int[] intList = { 5, 12, 55, 1, 7, 557, 328 };

            Console.WriteLine(intList.Average());
            Console.WriteLine(intList.Sum());
            Console.WriteLine(intList.MaxValue());
            Console.WriteLine(intList.MinValue());
            Console.WriteLine(intList.Product());
        }
    }
}
