using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public class Generator<T>
    {
        private T FirstElement { get; }
        private T SecondElement { get; }
           
        private Func<T,T,T> RuleOfNExtElement { get; }

        public Generator(T first, T second, Func<T,T,T> rule)
        {
            CheckValidData(first, second, rule);

            this.FirstElement = first;
            this.SecondElement = second;
            this.RuleOfNExtElement = rule;
        }

        public IEnumerable<T> GenerateSequenece(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "can`t be less zero");
            }

            T a = this.FirstElement;
            T b = this.SecondElement;

            while (amount > 0)
            {
                yield return a;

                T temp = a;
                a = b;
                b = this.RuleOfNExtElement(b, temp);

                amount--;
            }


        }

        private void CheckValidData(T first, T second, Func<T,T,T> rule)
        {
            if (first == null)
            {
                throw new ArgumentNullException(nameof(first), "can`t be null");
            }
            else if (second == null)
            {
                throw new ArgumentNullException(nameof(second), "can`t be null");
            }
            else if (rule == null)
            {
                throw new ArgumentNullException(nameof(rule), "can`t be null");
            }
        }
    }
}
