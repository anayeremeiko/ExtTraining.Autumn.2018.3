using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    /// <summary>
    /// The PasswordChecker interface.
    /// </summary>
    public interface IPasswordChecker
    {
        /// <summary>
        /// Checks if password is valid
        /// </summary>
        /// <param name="password">String password</param>
        /// <returns></returns>
        (bool, string) Check(string password);
    }
}
