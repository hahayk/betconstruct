using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class MyLinq
    {
        public static IEnumerable<TResult> Map<T, TResult>(this IEnumerable<T> values, Func<T, TResult> selector)
        {
            foreach (var item in values)
            {
                yield return selector(item);
            }
        }

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> values, Func<T, bool> predicate)
        {
            foreach (var item in values)
            {
                if (predicate(item))
                {
                    yield return item;
                }
            }
        }
    }
}
