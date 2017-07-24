using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_Demo2___Generics
{
    public class GenericList<T>
    {
        #region Fields
        private List<T> elements;
        #endregion

        #region Contructors
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

        #region Properties
        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }
        #endregion
    }
}
