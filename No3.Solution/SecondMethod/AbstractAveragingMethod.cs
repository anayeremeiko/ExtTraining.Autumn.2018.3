using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.SecondMethod
{
    public abstract class AbstractAveragingMethod
    {
        public double Calculate(IEnumerable<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "can`t be null");
            }

            return CalculateAverage(values);
        }

        public abstract double CalculateAverage(IEnumerable<double> values);
    }
}
