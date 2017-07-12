using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosSlides___Object_State
{
    class Person
    {
        private string firstName;
        //private string lastName;

        public Person(string firstName)
        {
            this.firstName = firstName;
            //this.lastName = lastName;

        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First Name can't be null of empty space");
                }
                this.firstName = value;
            }
        }

        //public string LastName
        //{
        //    get
        //    {
        //        return this.lastName;
        //    }
        //    set
        //    {
        //        if (string.IsNullOrEmpty(value))
        //        {
        //            throw new ArgumentException("Last name can't be null of empty space");
        //        }
        //        this.lastName = value;
        //    }

        //}

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("Joe");
            Person person1 = new Person("");


        }
    }
}
