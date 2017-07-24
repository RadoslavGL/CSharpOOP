using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_Demo2___Indexes
{
    class Program
    {
        public static void Main(string[] args)
        {
            GenericList<int> ints = new GenericList<int>();
            GenericList<string> strings = new GenericList<string>();

            ints.Add(3);
            ints.Add(5);

            strings.Add("Pesho");

            Console.WriteLine(ints[0]);
            Console.WriteLine(strings[0]);
            Console.WriteLine(ints[5]);

        }
    }
}
