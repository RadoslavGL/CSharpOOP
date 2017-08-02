using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsTest
{
    public enum DayOfTheWeek
    {
        Mon = 12,
        Tue,
        Wed,
        Thu,
        Fri,
        Sat,
        Sun
    }

    public class Program
    {
        static void Main(string[] args)
        {
            DayOfTheWeek day = DayOfTheWeek.Mon;
            Console.WriteLine(day);

            Console.WriteLine((int)day);

            day = (DayOfTheWeek)Enum.Parse(typeof(DayOfTheWeek), "Fri");
            Console.WriteLine(day);
        }
    }
}
