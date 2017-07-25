using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher: INameable, IPeople
    {



        #region Props
        public string Name { get; set; }

        #endregion
    }
}
