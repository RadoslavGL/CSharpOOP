using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3);
            Point p2 = new Point(4, 5);

            Console.WriteLine(p1.CalcDistance(p2));
        }
    }
}
