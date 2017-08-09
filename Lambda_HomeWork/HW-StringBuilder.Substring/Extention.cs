using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_StringBuilder.Substring
{
    public static class Extention
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            if (index + length < sb.Length)
            {
                string temp = sb.ToString().Substring(index, length);
                result.Append(temp);

                return result;
            }
            else if (index + length - sb.Length > 2)
            {
                string temp = sb.ToString().Substring(index, (sb.Length - index));
                result.Append(temp);

                return result;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid index or lenght");
            }

        }
    }
}
