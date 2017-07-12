using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosSlides2
{
    class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Speak()
        {
            Console.WriteLine("I'm {0}", this.name);
        }

        public void CalculateYears(int yearAfter)
        {
            Console.WriteLine("After {0} I will be {1} years old", yearAfter, age + yearAfter);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Hogh", 10);
            person.Speak();
            person.CalculateYears(10);
        }
    }
}
