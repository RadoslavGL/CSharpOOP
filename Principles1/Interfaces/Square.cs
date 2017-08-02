using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Square : IShape
    {

        #region Feidls
        private int x;
        private int y;
        private int size;
        #endregion

        #region Constr
        public Square(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
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
            return size * size;
        }

        #endregion

    }
}
