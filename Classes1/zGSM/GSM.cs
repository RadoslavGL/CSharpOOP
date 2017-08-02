using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zGSM
{
    public class GSM
    {
        #region Fields
        private readonly string model;
        private readonly string manufacturer;
        private string owner;
        private decimal price;
        private static GSM iPhone4S;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;
        #endregion

        #region Ctors
        //Constructor for IPhone4S
        static GSM()
        {
            iPhone4S = new GSM("IPhone4S", "Apple");
            iPhone4S.price = 5000;
            iPhone4S.owner = "KoiCho";
            iPhone4S.battery = new Battery(BatteryType.NiCd, "Chinese first class", 5, 2);
            iPhone4S.display = new Display(4, 2);

        }

        public GSM(string model, string manufacturer)
        {
            //mandatory
            this.model = model;
            this.manufacturer = manufacturer;
            this.Price = 0;
            this.Owner = null;
            this.CallHistory = new List<Call>();
            this.battery = new Battery(BatteryType.Other);
            this.display = new Display();
        }

        public GSM(string model, string manufacturer, decimal price, string owner,
            Battery battery, Display display, List<Call> callHistory)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
            this.callHistory = callHistory;
        }

        #endregion

        #region Properties

        public List<Call> CallHistory
        {
            get
            {
                return new List<Call>(this.callHistory);
            }
            private set
            {

                this.callHistory = value;
            }
        }

        public static string IPhone4S
        {
            get
            {
                return iPhone4S.ToString();
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price should not be negative");
                }
                this.price = value;
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

        }
        #endregion

        #region Methods

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void DeleteCallAtIndex(int callIndex)
        {
            this.callHistory.RemoveAt(callIndex);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public void PrintCallHistory()
        {
            int counter = 0;
            foreach (Call call in callHistory)
            {
                Console.WriteLine("{0}.\nPhone number: {1}\nDuration: {2:F2}:{3:F2}:{4:F2}\n" +
                    "Date: {5}/{6}/{7}\nPrice: {8}",
                    ++counter, call.PhoneNumber, call.CallSpan.Hours, call.CallSpan.Minutes, call.CallSpan.Seconds,
                    call.CallDateTime.Year, call.CallDateTime.Month, call.CallDateTime.Day, call.CallPrice);
            }
        }


       

        //public override string ToString()
        //{
        //    return string.Format("Model: {0}\nManufacturer: {1}\nPrice: {2}\nOwner: {3}\nBattery: {4}\nDisplay: {5}",
        //        this.Model, this.Manufacturer, this.Price, this.Owner, this.Battery, this.Battery, this.Display);
        //}

        public override string ToString()
        {
            //TODO: Complete the return info
            return ($"model: {this.model}\nmanufacturer: {this.manufacturer}\nprice: {this.price:F2}\n" +
                $"owner: {this.owner}\nbattery model: {this.battery.Model}\n" +
                $"battery type: {this.battery.BatteryType}\nbattery hours idle: {this.battery.HoursIdle}\n" +
                $"battery hours of talk: {this.battery.HoursTalk}\ndisplay size: {this.display.Size}\n" +
                $"display colors: {this.display.NumberOfColors}\n");
        }

        #endregion 
    }
}
