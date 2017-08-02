using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zGSM
{
    public class Battery
    {
        #region Fields
        private string model = null;
        private int hourIdle = 0;
        private int hourTalk = 0;
        private BatteryType batteryType;
        #endregion

        public Battery(BatteryType batteryType, string model = null, int hourIdle = 0, int hoursTalk = 0)
        {
            this.Model = model;
            this.HoursIdle = hourIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = BatteryType;
        }

        #region Props
        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public int HoursIdle
        {
            get
            {
                return this.hourIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Idle hours have to be a positive number!");
                }
                this.hourIdle = value;
            }
        }

        public int HoursTalk
        {
            get
            {
                return this.hourTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Talk hours have to be a positive number!");
                }
                this.hourTalk = value;
            }
        }
        #endregion

        
    }
}
