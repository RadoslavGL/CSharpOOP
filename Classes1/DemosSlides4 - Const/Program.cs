using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosSlides4___Const
{
    public class Person
    {
        private const int Age = 10;
        private readonly int AgeAfterTen = Age + 10;

        public void PrintInfo()
        {
            Console.WriteLine(Age);
            Console.WriteLine(AgeAfterTen);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.PrintInfo();
        }
    }
}
