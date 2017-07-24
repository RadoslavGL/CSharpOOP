using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik_Task1
{
    class ToStringPrint
    {
        static void Main(string[] args)
        {
            GSM gsm = new GSM("Galaxy Note 7", "Samsung", 1000M, "Viktor",
                new Battery("Samsung", 100, 40, BatteryType.LiIon),
                new Display(4.7, 1000));
            
            Console.WriteLine(gsm);
            Console.WriteLine(GSM.Iphone4S);
        }
        

    }
}
