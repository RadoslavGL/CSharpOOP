using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constants
{
    public class Constants
    {
        #region Fields
        public const double PI = 3.1415926535897932385;
        public readonly double Size;
        #endregion

        public Constants(int size)
        {
            this.Size = size;
        }

    }
}
