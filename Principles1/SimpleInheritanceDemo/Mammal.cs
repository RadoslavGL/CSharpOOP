using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInheritanceDemo
{
    public class Mammal
    {
        #region Properties
        public int Age
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public Mammal(int age)
        {
            this.Age = age;
        }
        #endregion

        #region Methods
        public void Sleep()
        {
            Console.WriteLine("Sleep...");
        }
        #endregion
    }
}
