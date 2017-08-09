using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class Program
    {
        public delegate void SimpleDelegate(string param);
        private static void Main(string[] args)
        {
            //Instantiate the delegate
            SimpleDelegate d = new SimpleDelegate(TestMethod);

            // the above can be do as below
            d = TestMethod;
            d += TestMethod2;

            //invocation of the method, pointed by delegate
            d("test");

        }
        private static void TestMethod(string param)
        {
            Console.WriteLine("I was called by a delegate.");
            Console.WriteLine("I got parameter: {0}.", param);
        }

        private static void TestMethod2(string param)
        {
            Console.WriteLine();
            Console.WriteLine("I was called by a delegate TOO.");
            Console.WriteLine("I got parameter AGAIN: {0}.", param);
        }
    }
}
