using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public static class OtherCalculator
    {
        public static double CalculateMeanAverageOther(this IEnumerable<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            MeanAverage median = new MeanAverage(values);
            return CalculateAverage(values, median);
        }

        public static double CalculateMedianAverageOther(this IEnumerable<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            MedianAverage median = new MedianAverage(values);
            return CalculateAverage(values, median);
        }

        private static double CalculateAverage(this IEnumerable<double> values, IAverage average)
        {
            return average.Average();
        }
    }
}
