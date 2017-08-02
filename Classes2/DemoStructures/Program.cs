using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(
                new Point() { X = 5, Y = -3 },
                7, 
                new Color() { RedValue = 73, GreenValue = 55, BlueValue = 150 },
                new Color() { RedValue = 0, GreenValue = 255, BlueValue = 133 },
                Edges.Rounded
                );
            Console.WriteLine(square);

            square.Edges = Edges.Straight;
            square.BorderColor = new Color() { RedValue = 5, GreenValue = 17, BlueValue = 55 };
            Console.WriteLine(square);

            //square.Location.X = square.Location.X + 10;

            Point location = square.Location;
            location.X += 10;
            square.Location = location;
            Console.WriteLine(square);

        }
    }
}
