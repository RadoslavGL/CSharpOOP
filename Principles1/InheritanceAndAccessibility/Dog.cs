using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAccessibility
{
    public class Dog : Mammal
    {
        #region props
        public string Breed
        {
            get;
            private set;
        }
        #endregion

        #region Constr
        public Dog(string name, int age, string breed)
            : base(name, age)
        {
            this.Breed = breed;
        }
        #endregion

        

        #region Methods
        internal void Wagtail()
        {
            Console.WriteLine("{0} is {1} wagging his {2}-aged tail ...",
            this.Name, this.Breed, this.Age);
        }

        #endregion
    }
}
