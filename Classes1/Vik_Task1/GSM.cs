using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik_Task1
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;

        //instance
        private static GSM iPhone4S = new GSM("Iphone4S", "Apple", 800, "Pesho",
            new Battery("Samsung", 400, 10, BatteryType.LiIon),
            new Display(400, 50));

        public static GSM Iphone4S
        {
            get
            {
                return Iphone4S;
            }
        }



        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null, null, null, null)
        {
        }

        //price nullable
        public GSM(string model, string manufacturer, decimal? price,
            string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Dispay = display;

        }


        //private fields; properties - as wrappers for the outer world
        //only value - this only props; fields - created automatically at the backend, hidden

            //validation at the setter - data should be always accessed from there!!
        public string Model
        {
            get
            {
                return this.model;

            }
            set
            {
                //validation!! ignore if bad data
                //if (!string.IsNullOrWhiteSpace(value)) // we valudate what comes in the prop, not the value in the field
                //    //value - value from the props, from the outer world;
                //{
                //    this.model = value; // only record if proper value
                //}

                //OR

                //validation exception
                if (string.IsNullOrWhiteSpace(value)) // we valudate what comes in the prop, not the value in the field
                                                      //value - value from the props, from the outer world;
                {
                    throw new ArgumentException("The model name should not be null or empty");
                }

                this.model = value;


            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;

            }
            set
            {
                
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The manufacturer name should not be null or empty");
                }

                this.manufacturer = value;


            }
        }

        //to make it nullable
        public decimal? Price
        {
            get
            {
                return this.price;

            }
            set
            {

                if (value.HasValue && value.Value < 0)
                {
                    throw new ArgumentException("The price should not be negative");
                }

                this.price = value;

            }
        }

        public string Owner
        {
            get
            {
                return this.owner;

            }
            set
            {

                if (value == string.Empty)
                {
                    throw new ArgumentException("The owner name should not be empty");
                }

                this.owner = value;


            }
        }

        public Battery Battery
        {
            get;
            set;
        }

        public Display Dispay
        {
            get;
            set;
        }


        public override string ToString()
        {
            return $"Model: {this.Model}\nManufacturer: {this.Manufacturer}\nPrice: {this.Price}\nDisplay: {this.Dispay}\nBattery: {this.Battery}";
        }

    }
}
