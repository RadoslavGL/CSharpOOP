using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_FirstBeforeLast
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("John", "Achles", 21));
            students.Add(new Student("Lindsey", "Stirling", 27));
            students.Add(new Student("Gavin", "Draham", 24));
            students.Add(new Student("Charlie", "Joe", 28));
            students.Add(new Student("Davey", "Nickson", 21));
            students.Add(new Student("Gerry", "Patterson", 15));

            DisplayAll(students);

            var firstBeforeLast = from student in students
                                  where student.FirstName.CompareTo(student.LastName) < 0
                                  select student;

            Console.WriteLine();

            DisplayAll(firstBeforeLast.ToList());

            Console.WriteLine();

            var ageBetween20and24 = from student in students
                                    where student.Age > 19 && student.Age < 25
                                    select student;
            foreach (var item in ageBetween20and24)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
            Console.WriteLine();

            var orderStudentLambda = students.OrderBy(x => x.FirstName).ThenByDescending(x => x.LastName);
            DisplayAll(orderStudentLambda);
            Console.WriteLine();

            var orderStudentLinq = from student in students
                                   orderby student.FirstName ascending, student.LastName descending
                                   select student;
            DisplayAll(orderStudentLinq);
            Console.WriteLine();
        }


        private static void DisplayAll(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine("{0} {1} Age: {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }
}
