using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListExampleZ
{
    public class GenericList<T>
    {
        const int DefaultCapacity = 3;

        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            elements = new T[capacity];
        }

        public GenericList() : this(DefaultCapacity)
        {
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public void AutoGrow()
        {
            if (count >= elements.Length)
            {
                T[] newElements = new T[(elements.Length * 2)];
                for (int i = 0; i <= count; i++)
                {
                    newElements[i] = elements[i];
                }
                elements = newElements;
            }
        }

        public void Add(T element)
        {
            AutoGrow();
            //if (count >= elements.Length)
            //{
            //    throw new IndexOutOfRangeException(String.Format(
            //    "The list capacity of {0} was exceeded.", elements.Length));
            //}

            this.elements[count] = element;
            count++;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
                }

                T result = elements[index];
                return result;
            }

            set
            {
                if (index < 0)
                {
                    throw new IndexOutOfRangeException(String.Format(
                    "Invalid index: {0}.", index));
                }
            }
        }

    }
}
