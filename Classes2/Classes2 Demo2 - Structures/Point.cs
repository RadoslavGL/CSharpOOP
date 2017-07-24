using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_Demo2___Structures
{
    public struct Point
    {

        #region Props
        public int X
        {
            get;
            set;
        }

        public int Y
        {
            get;
            set;
        }

        #endregion

        #region Contructors
        public Point(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }

        #endregion
    }
}
