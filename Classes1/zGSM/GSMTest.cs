using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zGSM
{
    public class GSMTest
    {
        public static void Test()
        {
            GSM gsm1 = new GSM("G2", "LG", "Rado", 700m,
                new Battery("LG1", 40, 250, BatteryType.NiCd),
                new Display(5, 16000));

            GSM gsm2 = new GSM("One", "HTX", "Pesho", 750m,
                new Battery("HTC1", 50, 350, BatteryType.Other),
                new Display(6, 17000));

            GSM[] gsmArr = new GSM[] { gsm1, gsm2, GSM.IPhone4S};

            foreach (GSM gsm in gsmArr)
            {
                Console.WriteLine(gsm);
                Console.WriteLine();
            }

            

        }

    }
}
