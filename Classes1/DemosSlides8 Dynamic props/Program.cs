using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosSlides8_Dynamic_props
{
    class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FullName
        {
            get
            {
                return this.firstName + ' ' + this.lastName;
            }
        }

        public void PrintName()
        {
            Console.WriteLine(FullName);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ian", "McCaw");
            person.PrintName();
        }
    }
}
