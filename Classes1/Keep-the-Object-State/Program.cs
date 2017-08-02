using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_the_Object_State
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age:");
            int age = int.Parse(Console.ReadLine());

            try
            {
                Person person = new Person(name, age);
                Console.WriteLine("Hello, {0}!", person.Name);
                Console.WriteLine("Your age is {0}!", person.Age);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Can't create a person object: " + ex);
            }
        }
    }
}
