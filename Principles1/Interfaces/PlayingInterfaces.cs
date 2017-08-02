using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class PlayingInterfaces
    {
        static void Main(string[] args)
        {
            Square square = new Square(0, 0, 10);
            Rectangle rect = new Rectangle(0, 0, 5, 10);
            Circle circle = new Circle(0, 0, 5);

            if (square is IShape)
            {
                Console.WriteLine("{0} is IShape", square.GetType());
            }

            if (rect is IResizable)
            {
                Console.WriteLine("{0} is IResizable", rect.GetType());
            }

            if (circle is IMoveable)
            {
                Console.WriteLine("{0} is IMoveable", circle.GetType());
            }
            Console.WriteLine();

            IShape[] shapes = { square, rect, circle };
            foreach (IShape shape in shapes)
            {
                Console.WriteLine("Type : {0}\nSurface : {1}", 
                    shape.GetType(), shape.CalculateSurface());
                Console.WriteLine();
            }
        }
    }
}
