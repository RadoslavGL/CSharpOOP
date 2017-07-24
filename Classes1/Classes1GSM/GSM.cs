using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1GSM
{
    public class GSM
    {
        //props
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;

        //instances of Battery and Display
        private Battery battery;
        private Display display;

        //constructor all parameters
        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;

        }

        //constructor with model and manufacturer only mandatory; other parameters inhereted with 
        //default value of null
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {
        }

        //method to display info
        public override string ToString()
        {
            return String.Format("Model: {0}\nManufactorer: {1}\nPrice: {2}\nOwner: {3}" +
                "\nDisplay: {4}\nBattery: {5}", 
                this.model, this.manufacturer, this.price, this.owner, this.display, this.battery);
        }

    }
}
