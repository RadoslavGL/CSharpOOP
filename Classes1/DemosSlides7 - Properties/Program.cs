using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosSlides7___Properties
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

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }


        public void PrintName()
        {
            Console.WriteLine(this.firstName + ' ' +this.lastName);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "Mitsov");
            person.PrintName();
        }
    }
}
