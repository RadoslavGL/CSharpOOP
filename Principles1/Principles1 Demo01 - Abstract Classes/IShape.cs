using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principles1_Demo01___Abstract_Classes
{
    public interface IShape
    {
        void SetPosition(int x, int y);
        int CalculateSurface();
    }
}
