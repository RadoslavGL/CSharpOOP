using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListExampleZ
{
    public class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);

            Console.WriteLine("Number of elements: {0}", intList.Count);

            for (int i = 0; i < intList.Count; i++)
            {
                //int element = intList[i];
                Console.WriteLine(intList[i]);
            }

            //Console.WriteLine();

            //GenericList<string> stringList = new GenericList<string>();
            //stringList.Add("C#");
            //stringList.Add("Java");
            //stringList.Add("PHP");
            //stringList.Add("SQL");
            //Console.WriteLine("Number of elements: {0}", stringList.Count);
            //for (int i = 0; i < stringList.Count; i++)
            //{
            //    string element = stringList[i];
            //    Console.WriteLine(element);
            //}


        }
    }
}
