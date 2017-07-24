using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik_Task1
{
    public class Battery
    {

        public Battery()
            : this("Samsung", 100, 40, BatteryType.LiIon)
        {
            

        }

        public Battery(string model, int hoursIdle, int hoursTalk, BatteryType batteryType)
        {
            this.Model = model;
            this.HourIdle = hoursIdle;
            this.HourIdle = hoursTalk;
            this.BatteryType = batteryType;
        }


        public string Model
        {
            get;
            set;
        }

        public int HourIdle
        {
            get;
            set;
        }

        public int HourTalk
        {
            get;
            set;
        }

        public BatteryType BatteryType
        {
            get;
            set;
        }
    }
}
