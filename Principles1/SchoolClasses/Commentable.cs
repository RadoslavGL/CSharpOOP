using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Commentable
    {
        #region Field
        private string comment;
        #endregion

        #region Ctor
        public Commentable(string comment)
        {
            this.Comment = comment;
        }

        #endregion

        #region Props
        public string Comment
        {
            get
            {
                return this.comment;
            }
            private set
            {
                this.comment = value;
            }
        }
        #endregion
    }
}
