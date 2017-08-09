using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_FirstBeforeLast
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstName, string lastName, int age)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

    }
}
