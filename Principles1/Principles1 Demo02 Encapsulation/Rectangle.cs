using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles1_Demo02_Encapsulation
{
    public class Rectangle
    {
        #region Fields
        private int width;
        private int height;

        #endregion

        #region Ctor
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        #endregion


        #region Props
        public int Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be less than or equal to 0");
                }
                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height cannot be less than or equal to 0");
                }
                this.height = value;
            }
        }

        #endregion

    }
}
