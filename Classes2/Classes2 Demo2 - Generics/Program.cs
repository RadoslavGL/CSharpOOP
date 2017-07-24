using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_Demo2___Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> ints = new GenericList<int>(); ;
            GenericList<string> strings = new GenericList<string>();

            ints.Add(5);
            ints.Add(7);

            strings.Add("Misho");

            Console.WriteLine(ints.Count);
            Console.WriteLine(strings.Count);

        }
    }
}
