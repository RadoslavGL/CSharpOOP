using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericConstraints
{
    public class TestClass1 : BaseClass, IIntereface
    {
    }

    public class TestClass2: BaseClass
    {
    }

    public class TestClass3 : BaseClass, IIntereface
    {
    }

    class BaseClass
    {
    }

    public interface IIntereface
    {
    }

    public class GenericConstraintClass<T>
        where T : BaseClass, IIntereface, new()
    {
        public T Method1(T param)
        {
            return param;
        }
    }

}
