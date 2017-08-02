using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAccessibility
{
    public class Creature
    {
        #region Props
        protected string Name
        {
            get;
            private set;
        }
        #endregion

        #region Constr
        public Creature(string name)
        {
            this.Name = name;
        }
        #endregion

        #region Methods
        private void Talk()
        {
            Console.WriteLine("I am creature ...");
        }

        protected void Walk()
        {
            Console.WriteLine("Walking, walking, walking ....");
        }
        #endregion
    }
}
