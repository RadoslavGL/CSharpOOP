using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles1_Demo01___Abstract_Classes
{
    public class Rectangle : MoveableShape
    {
        #region Fields
        private int width;
        private int height;
        #endregion

        #region Ctor
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        #endregion

        #region Methods
        public override int CalculateSurface()
        {
            return this.height * this.width;
        }

        #endregion
    }
}
