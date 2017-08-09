using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_IEnumerable_extensions
{
    public static class Extensions
    {
        public static T Sum<T>(this IEnumerable<T> enumerable)
        {
            T result = (dynamic)0;

            foreach (var item in enumerable)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> enumerable)
        {
            var result = (dynamic)1;

            foreach (var item in enumerable)
            {
                result *= (dynamic)item;
            }

            return result;
        }

        public static T MinValue<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Min();
        }

        public static T MaxValue<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Max();
        }

        public static double AverageValue<T>(this IEnumerable<T> enumerable)
        {
            return (double)(dynamic)enumerable.Sum() / enumerable.Count();
        }
    }
}
