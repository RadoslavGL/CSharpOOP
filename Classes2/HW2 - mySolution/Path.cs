using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2___mySolution
{
    public class Path // to hold a sequace of point in 3d space??? 
        //"To Hold" - Property + Constructor
    {
        #region Constructor
        public Path(IEnumerable<Point3D> points)
        {
            this.Points = points;
        }
        #endregion

        #region Props
        public IEnumerable<Point3D> Points
        {
            get;
            set;
        }
        #endregion
    }
}
