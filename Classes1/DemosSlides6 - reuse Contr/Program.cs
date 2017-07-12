using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosSlides6___reuse_Contr
{
    class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName)
        {
            this.firstName = firstName;
        }

        public Person(string firstName, string lastName)
            : this(firstName)
        {
            this.lastName = lastName;
        }

        public void printName()
        {
            Console.WriteLine(this.firstName + ' ' + this.lastName);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Pesho");
            person.printName();

            Person person1 = new Person("Pesho", "DaBest");
            person1.printName();
        }
    }
}
