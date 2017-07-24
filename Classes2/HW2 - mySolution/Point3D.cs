using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2___mySolution
{
    public struct Point3D
    {
        #region Fields
        public static readonly Point3D startPoint = new Point3D(0, 0, 0);

        #endregion

        #region Constructor
        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}", this.X, this.Y, this.Z);
        }

        #endregion

        #region Props
        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }

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

        public int Z
        {
            get;
            set;
        }
        #endregion

    }
}
