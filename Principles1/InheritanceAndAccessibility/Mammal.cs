using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAccessibility
{
    public class Mammal : Creature
    {
        #region Props
        public int Age
        {
            get;
            set;
        }
        #endregion

        #region Constr
        public Mammal(string name, int age)
            : base(name)
        {
            this.Age = age;
        }
        #endregion

        #region Methods
        public void Sleep()
        {
            Console.WriteLine("Shhh! {0} is sleeping!", this.Name);
        }

    #endregion
}
}
