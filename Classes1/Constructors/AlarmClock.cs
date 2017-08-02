using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class AlarmClock
    {
        #region Fields
        private int hours = 9;
        private int minutes = 0;
        #endregion

        //parameterless ctor; left empty on purpose
        public AlarmClock()
        {
        }

        //with parameters
        public AlarmClock(int hour, int minutes)
        {
            this.Hours = hours;
            this.Minutes = minutes;
        }

        #region Properties
        public int Minutes
        {
            get { return this.minutes; }
            set { this.minutes = value; }
        }

        public int Hours
        {
            get { return this.hours; }
            set { this.hours = value; }
        }
        #endregion


    }
}
