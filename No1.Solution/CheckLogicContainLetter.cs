using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class CheckLogicContainLetter
    {
        public (bool, string) Check(string password) => !password.Any(char.IsLetter) ? (false, $"{password} hasn't alphanumerical chars") : (true, "Password is OK.");
    }
}
