using System;

namespace GenericMethod
{
    public class GenericMethods
    {
        public static T Min<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
