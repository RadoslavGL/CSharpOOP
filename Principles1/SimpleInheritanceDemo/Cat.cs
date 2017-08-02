using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritanceDemo
{
    public class Cat : Mammal
    {
        #region Constr
        //constr for cat inherits the base constr for mammal w/o extending it with new own props
        public Cat(int age)
            : base(age)
        {
        }
        #endregion

        #region Methods
        public void SayMyau()
        {
            Console.WriteLine("Myau");
        }
        #endregion
    }
}
