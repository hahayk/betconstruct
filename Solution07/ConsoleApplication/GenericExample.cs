using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class GenericExample<T> where T: Exception
    {
        public T F(T value)
        {
            return value;
        }
    }

    public class AnotherGenericExample<U, V, T> : GenericExample<T> where T : SystemException
    {

    }
}
