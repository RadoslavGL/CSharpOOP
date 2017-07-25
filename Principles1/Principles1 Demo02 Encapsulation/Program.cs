using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles1_Demo02_Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 10);
            Console.WriteLine(rect.Height);

            Rectangle rect1 = new Rectangle(0, 10);
        }

    }
}
