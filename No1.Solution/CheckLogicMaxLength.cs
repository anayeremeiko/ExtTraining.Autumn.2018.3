using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class CheckLogicMaxLength
    {
        private int boundary;
        public CheckLogicMaxLength(int boundary)
        {
            this.boundary = boundary;
        }

        public (bool, string) Check(string password) => password.Length >= boundary ? (false, $"{password} length too long") : (true, "Password is OK.");
    }
}
