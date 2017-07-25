using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles1
{
    public class Rectangle : IShape, IMoveable
    {
        #region Fields
        private int x;
        private int y;
        private int width;
        private int height;
        #endregion

        #region Constructors
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

        #region Methods
        public int CalculateSurface()
        {
            return this.width * this.height;
        }

        public void Move(int deltaX, int deltaY)
        {
            this.x += deltaX;
            this.y += deltaY;
        }
        #endregion

    }
}
