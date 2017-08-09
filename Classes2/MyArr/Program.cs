using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArr
{
    class Program
    {
        static void Main(string[] args)
        {

            var myArr = new MyArray<int>();
            Console.WriteLine(myArr);

            myArr.Add(5);
            myArr.Add(5);
            myArr.Add(5);
            myArr.Add(5);
            myArr.Add(5);
            Console.WriteLine(myArr);


        }
    }
}
