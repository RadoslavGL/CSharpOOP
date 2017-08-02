using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Rectangle : IShape, IMoveable, IResizable
    {
        #region Fields
        private int x;
        private int y;
        private int width;
        private int height;

        #endregion

        #region Constr
        public Rectangle(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

        }
        #endregion

        #region Methods

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public double CalculateSurface()
        {
            return width * height;
        }
        public void Move(int deltaX, int deltaY)
        {
            this.x += deltaX;
            this.y += deltaY;
        }

        public void Resize(int weightX, int weightY)
        {
            width *= weightX;
            height *= weightY;
        }

        public void ResizeByX(int weightX)
        {
            width = width * weightX;
        }

        public void ResizeByY(int weightY)
        {
            height = height * weightY;
        }

        #endregion

    }
}
