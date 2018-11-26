using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class Sequence
    {
        public static IEnumerable<T> GenerateSequence<T>(T first, T second, int count, Func<T,T,T> rule)
        {
            if (count < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(count));
            }

            if (rule == null)
            {
                throw new ArgumentNullException(nameof(rule));
            }

            return Generate();

            IEnumerable<T> Generate()
            {
                T previous = first, current = second;

                for (int i = 0; i < count; i++)
                {
                    yield return previous;
                    var temp = current;
                    current = rule(current, previous);
                    previous = temp;
                }
            }
        }
    }
}
