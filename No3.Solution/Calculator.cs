using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public static class Calculator
    {
        public static double CalculateMeanAverage(this IEnumerable<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return CalculateAverage(values, new Func<IEnumerable<double>, double>((container) => container.Sum() / container.Count()));
        }

        public static double CalculateMedianAverage(this IEnumerable<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return CalculateAverage(values, MedianFunc);
        }

        private static double CalculateAverage(this IEnumerable<double> values, Func<IEnumerable<double>, double> predicate)
        {
            return predicate(values);
        }

        private static double MedianFunc(this IEnumerable<double> values)
        {
            var sortedValues = values.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}
