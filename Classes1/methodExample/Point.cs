using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodExample
{
    public class Point
    {
        #region Fields
        private int xCord;
        private int yCord;
        #endregion


        #region Ctor
        public Point(int xCord, int yCord)
        {
            this.xCord = xCord;
            this.yCord = yCord;
        }
        #endregion

        #region Methods
        //instance methods that is called thru an instance of the class Point and requires a point to be passed in in order to work
        public double CalcDistance(Point p)
        {
            return Math.Sqrt(p.xCord - this.xCord) * (p.xCord - this.xCord) +
                (p.yCord - this.yCord) * (p.yCord - this.yCord);
        }

        #endregion
    }
}
