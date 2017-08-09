using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerExample
{
    public struct BitArray32
    {
        public const int BITS_COUNT = 32;
        private uint bitValues;


        //indexers declaration

        public int this[int index]
        {
            get
            {
                if ((index >= 0) && (index < BITS_COUNT))
                {
                    if ((bitValues & (1 << index)) == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Index {0} is invalid!",
                        index));
                }
            }
            set
            {
                if ((index < 0) || (index > BITS_COUNT-1))
                {
                    throw new IndexOutOfRangeException(String.Format(
                    "Index {0} is invalid!",
                    index));
                }
                if ((value < 0) || (value > 1))
                {
                    throw new IndexOutOfRangeException(String.Format(
                    "Value {0} is invalid!",
                    index));
                }

                bitValues &= ~((uint)(1 << index));

                bitValues |= (uint)(value << index);
            }

        }

    }
}
