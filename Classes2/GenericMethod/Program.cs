using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            int j = 7;

            int min = GenericMethods.Min<int>(i, j);
            Console.WriteLine("Min({0}, {1}) = {2}", i, j, min);

            string firstString = "Rakiya";
            string secondString = "Beer";
            string minString = GenericMethods.Min<string>(firstString, secondString);
            Console.WriteLine("Min({0}, {1}) = {2}", firstString, secondString, minString);


        }
    }


}
