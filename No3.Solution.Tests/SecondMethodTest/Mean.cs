using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No3.Solution.SecondMethod;

namespace No3.Solution.Tests.SecondMethodTest
{
    public class Mean : AbstractAveragingMethod
    {
        public override double CalculateAverage(IEnumerable<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "can`t be null");
            }

            return values.Sum() / values.Count();
        }
    }
}
