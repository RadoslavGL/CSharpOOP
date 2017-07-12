using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosSlides1
{
    class Person
    {
        public string Name
        {
            get;
            set;
        }

        public void Speak()
        {
            Console.WriteLine("Hello I'm {0}", this.Name);
        }
            
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "John";
            person.Speak();
        }
    }
}
