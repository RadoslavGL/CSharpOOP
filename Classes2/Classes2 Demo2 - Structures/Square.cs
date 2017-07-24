using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_Demo2___Structures
{
    public struct Square
    {
        #region Constructor
        public Square(Point point, int size)
        {
            this.LowerLeftPoint = point;
            this.Size = size;
        }

        #endregion

        #region Fields
        public Point LowerLeftPoint
        {
            get;
            set;
        }

        public int Size
        {
            get;
            set;
        }

        #endregion
    }
}
