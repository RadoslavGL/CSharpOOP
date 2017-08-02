using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogMeeting
{
    public class Dog
    {
        #region Fields
        private string name;
        private string breed;
        #endregion

        public Dog()
        {
        }

        public Dog(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        #region Props
        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                this.breed = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        #endregion

        #region Methods
        public void SayBau()
        {
            Console.WriteLine("{0} says BAU!", this.Name ?? "[unnamed dog]");
        }

        #endregion
    }
}
