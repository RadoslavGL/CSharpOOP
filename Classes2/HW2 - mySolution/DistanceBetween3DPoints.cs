using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2___mySolution
{
    public static class DistanceBetween3DPoints
    {
        #region Methods
        public static double CalculateDistanceBn3DPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double distance =
                Math.Sqrt(
                    Math.Pow(firstPoint.X - secondPoint.X, 2) +
                    Math.Pow(firstPoint.Y - secondPoint.Y, 2) +
                    Math.Pow(firstPoint.Z - secondPoint.Z, 2));

            return distance;
        }
        #endregion
    }
}
