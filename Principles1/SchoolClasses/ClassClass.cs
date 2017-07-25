using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class ClassClass
    {
        #region Fields
        private string uniqueClassID;
        #endregion

        #region Ctor
        public ClassClass(string uniqueClassID)
        {
            this.UniqueClassID = uniqueClassID;
        }
        #endregion

        #region Props
        public string UniqueClassID
        {
            get
            {
                return this.uniqueClassID;
            }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Class ID should not be an empty string");
                }
                this.uniqueClassID = value;
            }
        }
        #endregion
    }
}
