using System;
using System.Collections.Generic;

namespace ActionAndFunc
{
    public static class ActionAndFunc
    {
        public static void Main(string[] args)
        {
            //Action<int> LogNumber = Console.WriteLine;
            Action<int> logNumber = (number) => Console.WriteLine(number);
            logNumber(5);

            Action<string, int> logNameAge = (name, age) =>
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Age: " + age);
            };
            logNameAge("Pesho", 5);

            Func<string> magic = () =>
            {
                return "Magic";
            };

            Console.WriteLine(magic());
            Console.WriteLine();

            Func<string, int> parser = int.Parse;
            int someNumber = parser("454");
            Console.WriteLine(someNumber);

            Console.WriteLine();

            string[] someStrings = { "Pesho", "Ivaylo", "Gosho", "Niki" };
            someStrings.Each(Console.WriteLine);
            someStrings.Each(str =>
                {
                    Console.Write(str + " ");
                }
                );
            Console.WriteLine();
        }

        public static void Each<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}
