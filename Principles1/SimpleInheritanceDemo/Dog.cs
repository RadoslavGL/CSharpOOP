using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritanceDemo
{
    public class Dog : Mammal
    {
        #region props
        public string Breed
        {
            get;
            set;
        }
        #endregion

        #region constr
        //constructor for dog that uses the local prop Breed, but takes Age from the constr of the base class Mammal
        public Dog(int age, string breed)
            :base(age)
        {
            this.Breed = breed;
        }
        #endregion

        #region Method
        public void WagTail()
        {
            Console.WriteLine("Tail ...");
        }
        #endregion
    }
}
