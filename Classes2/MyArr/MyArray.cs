using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArr
{
    public class MyArray<T> : IEnumerable<T>
    {
        private T[] arr;
        private const int InitialCapacity = 4;

        public int Count { get; private set; }

        public int Capacity { get; private set; }

        public MyArray()
        {
            this.Count = 0;
            this.Capacity = InitialCapacity;
            arr = new T[this.Capacity];
        }

        public void Add(T item)
        {
            if (this.Count == this.Capacity)
            {
                this.Capacity *= 2;
                var oldArr = this.arr;
                this.arr = new T[this.Capacity];

                Array.Copy(oldArr, this.arr, this.Count);
            }
            this.arr[this.Count] = item;
            this.Count++;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < this.Count; i++)
            {
                builder.Append(this.arr[i] + ", ");
            }
            return builder.ToString().Trim(new char[] {' ', ',' });
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.arr)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
