using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAccessibility
{
    class InheritanceAndAccessibility
    {
        static void Main(string[] args)
        {
            Dog joe = new Dog("Sharo", 15, "Bal");
            joe.Sleep();
            Console.WriteLine("Breed:{0}", joe.Breed);
            joe.Wagtail();
            joe.Walk();
        }
    }
}
