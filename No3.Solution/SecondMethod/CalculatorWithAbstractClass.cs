using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.SecondMethod
{
    public class CalculatorWithAbstractClass
    {
        public double CalculateAverage(List<double> values, AbstractAveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "can`t be null");
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException(nameof(averagingMethod), "can`t be null");
            }

            return averagingMethod.Calculate(values);
        }
    }
}
