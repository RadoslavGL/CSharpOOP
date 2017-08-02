using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Point
    {
         #region Fields
        private int xCoord;
        private int yCoord;
        private string name;
        #endregion

        public Point() : this(0, 0)
        {
        }

        public Point(int xCoord, int yCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
            this.name = string.Format(
                "Point({0},{1})",
                this.XCoord, this.YCoord);
        }

        #region Props
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int YCoord
        {
            get { return this.yCoord; }
            set { this.yCoord = value; }
        }

        public int XCoord
        {
            get { return this.xCoord; }
            set { this.xCoord = value; }
        }
        #endregion


    }
}
