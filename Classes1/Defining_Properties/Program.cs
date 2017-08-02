using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRect = new Rectangle(5.5f, 1.0f);
            Console.WriteLine("Rectangle 1 is {0}x{1} and its area is {2}", 
                firstRect.Height, firstRect.Width, firstRect.Area);

            Rectangle secondRect = new Rectangle(3.5f, 4.4f);
            Console.WriteLine("Rectangle 2 is {0}x{1} and its area is {2}",
                secondRect.Height, secondRect.Width, secondRect.Area);

            //secondRect.Area = 5.5f;
            //no setter - prop is read-only
            //private setter - prop is inaccesible to edit;
            //just setter - read and write

            Console.WriteLine();

            UserProfile profile = new UserProfile(123456, "Stephen", "Wisnewski");
            Console.WriteLine(profile);
        }
    }
}
