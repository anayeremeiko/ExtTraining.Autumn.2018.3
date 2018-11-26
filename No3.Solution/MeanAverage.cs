using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class MeanAverage : IAverage
    {
        private IEnumerable<double> values;

        public MeanAverage(IEnumerable<double> values)
        {
            this.values = values;
        }

        public double Average()
        {
            return values.Sum() / values.Count();
        }
    }
}
