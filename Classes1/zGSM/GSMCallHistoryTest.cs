using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zGSM
{
    public class GSMCallHistoryTest
    {
        private GSM gsmDevice;
        public void TestHistory()
        {
            gsmDevice = new GSM("LG G2", "LG");
        }

        public void GSMTestHist()
        {
            this.gsmDevice.AddCall(new Call("+359 86 4 121223", new DateTime(), new TimeSpan(0, 5, 1), 0.5));
            this.gsmDevice.AddCall(new Call("+359 86 6 555555", new DateTime(), new TimeSpan(0, 6, 1), 0.5));
            this.gsmDevice.AddCall(new Call("+359 86 6 434343", new DateTime(), new TimeSpan(0, 9, 1), 0.5));

        }
    }
}
