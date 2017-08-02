using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritanceDemo
{
    public class SimpleInheritance
    {
        static void Main(string[] args)
        {
            Dog joe = new Dog(15, "KOker");
            joe.Sleep();
            joe.WagTail();

            Console.WriteLine("{0}\n{1}", joe.Breed, joe.Age);

            Console.WriteLine();

            Cat cat = new Cat(15);
            cat.SayMyau();
        }
    }
}
