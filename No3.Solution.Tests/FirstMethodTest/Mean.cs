using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No3.Solution.FirstMethod;

namespace No3.Solution.Tests.FirstMethodTest
{
    public class Mean : IAveragingMethod
    {
        public double Calculate(IEnumerable<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values), "can`t be null");
            }

            return values.Sum() / values.Count();
        }
    }
}
