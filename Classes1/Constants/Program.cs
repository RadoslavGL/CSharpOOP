using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.PI);
            Constants c = new Constants(5);
            Console.WriteLine(c.Size);

            //c.Size = 15;
            //Console.WriteLine(Constants.Size);
        }
    }
}
