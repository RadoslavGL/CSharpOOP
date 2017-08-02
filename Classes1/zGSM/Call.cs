using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zGSM
{
    public class Call
    {
        //fields - date, time, dialed number, duration (sec)
        private readonly string phoneNumber;
        private readonly DateTime callDateTime;
        private readonly TimeSpan callSpan;
        private readonly double callPrice;

        //ctor with all parameters
        public Call(string phoneNumber, DateTime callDateTime, TimeSpan callSpan, double callPrice)
        {
            this.phoneNumber = phoneNumber;
            this.callDateTime = callDateTime;
            this.callSpan = callSpan;
            this.callPrice = callPrice;
        }
        public double TotalCallsPrice()
        {
            return this.callSpan.TotalMinutes * this.callPrice;
        }


        #region Props
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
        }

        public DateTime CallDateTime
        {
            get
            {
                return this.callDateTime;
            }
        }

        public TimeSpan CallSpan
        {
            get
            {
                return this.callSpan;
            }
        }

        public double CallPrice
        {
            get
            {
                return this.callPrice;
            }
        }
        #endregion
    }
}
