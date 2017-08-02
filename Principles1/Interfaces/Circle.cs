using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Circle : IShape, IMoveable
    {
        #region Fields
        private int x;
        private int y;
        private int radius;
        #endregion

        #region Constr
        public Circle(int x, int y, int radius)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }
        #endregion

        #region Methods //implementation of the methods from the interfaces
        public void SetPosition(int x, int y) // from IShape
        {
            this.x = x;
            this.y = y;
        }

        public double CalculateSurface() //IShape
        {
            return Math.PI * radius * radius;
        }

        public void Move(int deltaX, int deltaY) //IMoveable
        {
            this.x += deltaX;
            this.y += deltaY;
        }

        #endregion
    }
}
