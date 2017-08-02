using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeSize
{
    public class Coffee
    {
        private CoffeeSize size;

        public Coffee(CoffeeSize size)
        {
            this.Size = size;
        }

        public CoffeeSize Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

    }
}
