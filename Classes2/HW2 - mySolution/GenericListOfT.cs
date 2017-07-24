using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2___mySolution
{
    public class GenericList<T>
        where T : IComparable<T>
    {
        #region Fields
        private T[] elements;
        private int lastElementIndex;
        private int size;
        #endregion

        public GenericList(int size)
        {
            if (size < 0)
            {
                throw new ArgumentException("The size must be larger than zero!");
            }
            this.size = size;
            this.Clear();
        }

        #region Props
        public int Length
        {
            get
            {
                return this.lastElementIndex;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > this.lastElementIndex - 1)
                {
                    throw new ArgumentOutOfRangeException($"Index must be between 0 and {this.lastElementIndex}!");
                }

                return this.elements[index];
            }
        }

        #endregion

        #region Methods
        public void Clear()
        {
            this.elements = new T[this.size];
            this.lastElementIndex = 0;
        }

        public void Add(T element)
        {
            this.elements[lastElementIndex] = element;
            this.lastElementIndex++;
        }

        public void InsertAt(T element, int index)
        {
            if (this.lastElementIndex == index)
            {
                this.Add(element);
                return;
            }

            if (index < 0 || index > this.lastElementIndex /* - 1 */)
            {
                throw new ArgumentOutOfRangeException($"Index must be between 0 and {this.lastElementIndex}!");
            }

            this.Grow();

            T[] newElements = new T[this.size];
            for (int i = 0; i < index; i++)
            {
                newElements[i] = this.elements[i];
            }

            newElements[index] = element;

            for (int i = index; i < this.lastElementIndex; i++)
            {
                newElements[i + 1] = this.elements[i];
            }
            this.elements = newElements;
            this.lastElementIndex++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > this.lastElementIndex - 1)
            {
                throw new ArgumentOutOfRangeException($"Index must be between 0 and {this.lastElementIndex}!");
            }

            T[] newElements = new T[this.size];
            for (int i = 0; i < index; i++)
            {
                newElements[i] = this.elements[i];
            }

            for (int i = index; i < this.lastElementIndex; i++)
            {
                newElements[i] = this.elements[i + 1];
            }

            this.elements = newElements;
            this.lastElementIndex--;
        }

        public int IndexOf(T element)
        {
            int result = -1;
            for (int i = 0; i < this.lastElementIndex; i++)
            {
                if (this.elements[i].Equals(element))
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public T Min()
        {
            if (this.lastElementIndex == 0)
            {
                return default(T);
            }

            T result = this.elements[0];
            for (int i = 1; i < this.lastElementIndex; i++)
            {
                if (this.elements[i].CompareTo(result) < 0)
                {
                    result = this.elements[i];
                }
            }

            return result;
        }

        public void Grow()
        {
            if (this.lastElementIndex != this.size)
            {
                return;
            }

            T[] newElements = new T[this.size * 2];
            for (int i = 0; i < this.lastElementIndex; i++)
            {
                newElements[i] = elements[i];
            }

            this.elements = newElements;
            this.size = this.size * 2;
        }


        #endregion
    }
}
