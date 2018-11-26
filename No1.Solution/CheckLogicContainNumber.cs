using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class CheckLogicContainNumber
    {
        public (bool, string) Check(string password) => !password.Any(char.IsNumber) ? (false, $"{password} hasn't digits") : (true, "Password is OK.");
    }
}
