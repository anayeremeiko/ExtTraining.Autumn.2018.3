using System.Collections.Generic;

namespace No6
{
    using System;
    using System.Collections;

    public class RangeGenerator<T> : IEnumerable<T>
    {
        private T first, second, current;

        private readonly Func<T, T, T> rule;

        private int length;

        public RangeGenerator(T first, T second, Func<T, T, T> rule, int length)
        {
            this.first = first;
            this.second = second;
            this.rule = rule;
            this.length = length;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.length; i++)
            {
                if (i == 0)
                {
                    yield return this.first;
                }
                else if (i == 1)
                {
                    yield return this.second;
                }
                else
                {
                    this.current = this.rule(this.first, this.second);
                    this.first = this.second;
                    this.second = this.current;
                    yield return this.current;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
