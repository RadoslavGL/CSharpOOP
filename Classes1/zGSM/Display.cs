using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zGSM
{
    public class Display
    {
        #region Fields
        private double size = 0;
        private int numberOfColors = 0;
        #endregion

        //with initialized fields
        public Display()
        {

        }
        //with vars from somewhere else
        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        #region Props
        public double Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value < 0 && value > 200.0)
                {
                    throw new ArgumentOutOfRangeException("The display size must be between 0 and 200");
                }
                this.size = value;
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of colors can't be negative!");
                }
                this.numberOfColors = value;
            }
        }

        #endregion
    }
}
