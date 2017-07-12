using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes_Problem
{
    class GSM
    {

        //default to null
        private string model = null;
        private string manufactorer = null;
        private string price = null;
        private string owner = null;

        public GSM(string model, string manufactorer, string price, string owner)
        {
            this.model = model;
            this.manufactorer = manufactorer;
            this.price = price;
            this.owner = owner;
        }

        Battery battery = new Battery("XX", 300.0, 50.0);
        Display display = new Display(4.7, 16000000);
    }

    class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;

        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;

        }

    }

    class Display
    {
        private double size;
        private int numberOfColors;

        public Display(double size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;

        }


    }

    class DefineClasses
    {
        static void Main(string[] args)
        {
        }
    }
}
