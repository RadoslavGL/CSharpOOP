using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person anonymous = new Person();
            Console.WriteLine("Person 1: name: {0}, age: {1}",
                anonymous.Name ?? "[unnamed]", anonymous.Age);

            Person person = new Person("Pesho", 19);
            Console.WriteLine("Person 2: name: {0}, age: {1}",
                person.Name, person.Age);

            Console.WriteLine();

            AlarmClock defaultAlarm = new AlarmClock();
            Console.WriteLine("Wake up! It's {0:D2}:{1:D2} o'clock.",
                defaultAlarm.Hours, defaultAlarm.Minutes);

            Console.WriteLine();

            Point centerPoint = new Point();
            centerPoint.Name = "Center of the coordinate system.";
            Console.WriteLine("First point: ({0},{1}) has name '{2}'", 
                centerPoint.XCoord, centerPoint.YCoord, centerPoint.Name);

            Point point77 = new Point(7, 7);
            Console.WriteLine("Second point: ({0},{1}) has name '{2}'", 
                point77.XCoord, point77.YCoord, point77.Name);


        }
    }
}
