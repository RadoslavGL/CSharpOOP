using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonymousTypes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myCar = new
            {
                Color = "Red",
                Brand = "Nisan",
                Speed = 180
            };

            Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Brand);
            Console.WriteLine("It ran {0} km/h.", myCar.Speed);
            //Console.WriteLine(myCar);
            Console.WriteLine();

            var p = new
            {
                X = 3,
                Y = 5
            };

            var q = new
            {
                X = 3,
                Y = 5
            };
            Console.WriteLine(p);
            Console.WriteLine(q);

            Console.WriteLine(p == q);
            Console.WriteLine(p.Equals(q));

            Console.WriteLine();

            var combined = new
            {
                P = p,
                Q = q
            };

            Console.WriteLine(combined.P.X);
            Console.WriteLine(combined);

            Console.WriteLine();

            var arr = new[]
            {
                new { X = 3, Y = 5 },
                new { X = 1, Y = 2 },
                new { X = 0, Y = 7 }
            };

            foreach (var item in arr)
            {
                Console.WriteLine("({0}, {1})", item.X, item.Y);
            }

        }
    }
}
