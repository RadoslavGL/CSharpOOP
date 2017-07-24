using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik_Task1
{
    public class Display
    {

        //constructors with default parameters
        public Display(double size = 0, int numberOfColors = 0)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;

        }



        //properties - display
        public double Size
        {
            get;
            set;

        }

        public int NumberOfColors
        {
            get;
            set;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
