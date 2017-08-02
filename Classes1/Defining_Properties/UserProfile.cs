using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Properties
{
    public class UserProfile
    {
        #region Props;
        public int UserId
        {
            get;
            private set;
        }

        public string FirstName
        {
            get;
            private set;
        }

        public string LastName
        {
            get;
            private set;
        }
        #endregion

        public UserProfile(int userID, string firstName, string lastName)
        {
            this.UserId = userID;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public override string ToString()
        {
            return string.Format("Id: {0}, First name: {1}, Last name: {2}",
                this.UserId, this.FirstName, this.LastName);
        }
    }
}
