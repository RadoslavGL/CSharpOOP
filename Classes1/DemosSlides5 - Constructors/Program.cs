using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosSlides5___Constructors
{
    class Person
    {
        private string firstName;

        public Person(string firstName)
        {
            this.firstName = firstName;
        }

        public void PrintName()
        {
            Console.WriteLine(this.firstName);
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John");
            person.PrintName();
        }
    }
}
