using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicType
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UsingDynamicDemo();
            ExpandoObjectDemo();

        }

        private static void UsingDynamicDemo()
        {
            //using dynamic for classes
            dynamic student = new Student();
            student.Name = "Pesho";
            Console.WriteLine(student.Name);

            //again using dynamic
            int result = Sum<int>(5, 6);
            decimal decimalResult = Sum<decimal>(16.6M, 15.15M);
            string text = Sum<string>("pesho", "gosho");
            Console.WriteLine(result);
            Console.WriteLine(decimalResult);
            Console.WriteLine(text);

            //compare
            int comparing = Compare(5, 6);
            Console.WriteLine(comparing);
        }

        private static T Sum<T>(dynamic first, dynamic second)
        {
            return first + second;
        }

        private static int Compare(dynamic first, dynamic second)
        {
            if (first == second)
            {
                return 0;
            }
            else if (first < second)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        private static void ExpandoObjectDemo()
        {
            //using dynamic expanding object
            dynamic expObj = new ExpandoObject();
            expObj.Result = 5;
            Console.WriteLine("Result: " + expObj.Result);

            expObj.FirstName = "Pesho";
            expObj.LastName = "Goshovski";

            expObj.SayHello = new Func<string>(() => 
            {
                return "I am " + expObj.FirstName + " " + expObj.LastName;
            }
            );
            Console.WriteLine(expObj.SayHello());

            // using ExpandoObject as Dictionary<TPropertyName, TPropertyValue>

            var properties = (IDictionary<string, object>)expObj;
            properties.Add("Age", 10);
            properties.Add("SayAge", new Func<string>(() =>
            {
                return "My age is " + properties["Age"];
            }
            ));

            Console.WriteLine(expObj.SayAge());

            properties.Add("ChangeAge", new Action<int>((age) =>
            {
                properties["Age"] = age;
            }
            ));

            expObj.ChangeAge(20);

            Console.WriteLine(expObj.SayAge());

            foreach (var pair in properties)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
        }
    }
}
