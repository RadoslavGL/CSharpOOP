using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosSlides3___Enums
{
    public enum DaysOfWeek
    {
        Mon, 
        Tue,
        Wed,
        Thu,
        Fr,
        Sat,
        Sun
    }

    public class Program
    {
        static void Main()
        {
            DaysOfWeek day = DaysOfWeek.Mon;
            Console.WriteLine(day);

        }
    }
}
