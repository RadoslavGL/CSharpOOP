using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_StringBuilder.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string text = "This is a text for the method to text";
            sb.Append(text);

            var sbSubS = sb.Substring(30, 10);
            Console.WriteLine(sbSubS);
        }
    }
}
