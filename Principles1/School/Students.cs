using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Students : INameable, IPeople
    {
        #region Fields
        private string uniqueId;
        #endregion

        #region Props
        public string UniqueId
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }

        #endregion
    }
}
