using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 10);
            rect.SetPosition(0, 0);
            Console.WriteLine(rect.CalculateSurface());
        }
    }
}
