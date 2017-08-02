using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Properties
{
    public class Rectangle
    {
        #region Field;
        private float height;
        private float width;
        #endregion

        public Rectangle(float height, float width)
        {
            this.height = height;
            this.width = width;
        }

        #region Props;
        public float Height
        {
            get
            {
                return this.height;
            }
            set
            {
                this.height = value;
            }
        }

        public float Width
        {
            get
            {
                return this.width;
            }
            set
            {
                this.width = value;
            }
        }

        public float Area
        {
            get
            {
                return height * width;
            }
        }

        #endregion

    }
}
