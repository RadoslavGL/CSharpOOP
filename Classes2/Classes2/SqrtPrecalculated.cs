using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    public class SqrtPrecalculated
    {
        #region fields
        private const int maxValue = 10000;
        private static int[] sqrtValues;
        #endregion

        #region Constructors
        static SqrtPrecalculated()
        {
            sqrtValues = new int[maxValue + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }
        #endregion

        #region Methods
        public static int GetSqrt(int number)
        {
            if (number>= sqrtValues.Length || number < 0)
            {
                throw new IndexOutOfRangeException("Number is not present in the array");
            }
            return sqrtValues[number];

        }

        #endregion
    }
}
