using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_Demo2___Indexes
{
    class GenericList<T>
    {
        #region Fields
        private List<T> elements;

        #endregion

        #region Props
        public T this [int index]
        {
            get
            {
                if (index < 0 || index >= this.elements.Count)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Index {0} is out of range", index));
                }
                return this.elements[index];
            }
            set
            {
                if (index < 0 || index >= this.elements.Count)
                {
                    throw new ArgumentOutOfRangeException(string.Format("index {0} is invalid!", index));
                }
                this.elements[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }

        #endregion

        #region Constructors
        public GenericList(int capacity = 4)
        {
            this.elements = new List<T>(capacity);
        }

        #endregion

        #region Methods
        public void Add(T element)
        {
            this.elements.Add(element);
        }

        #endregion

    }
}
