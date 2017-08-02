using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IShape
    {
        #region Methods
        void SetPosition(int x, int y);
        double CalculateSurface();
        #endregion

    }
}
