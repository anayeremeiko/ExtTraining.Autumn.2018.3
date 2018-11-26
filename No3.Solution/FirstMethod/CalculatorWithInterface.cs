using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.FirstMethod
{
    public class CalculatorWithInterface
    {
        public double CalculateAverage(List<double> values, IAveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "can`t be null");
            }

            return averagingMethod.Calculate(values);
        }
    }
}
