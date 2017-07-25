using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles1_Demo01___Abstract_Classes
{
    public abstract class MoveableShape : IMoveable, IShape
    {
        #region Fields
        private int x;
        private int y;
        #endregion

        #region Methods
        public void Move(int deltaX, int deltaY)
        {
            this.x += deltaX;
            this.y += deltaY;
        }

        public void SetPosition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract int CalculateSurface();

        #endregion

    }


}
