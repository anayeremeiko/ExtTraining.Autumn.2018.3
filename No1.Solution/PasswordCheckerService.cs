using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No1.Solution
{
    public class PasswordCheckerService
    {
        private readonly IRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordCheckerService"/> class. 
        /// </summary>
        /// <param name="repository">
        /// Repository to store passwords
        /// </param>
        public PasswordCheckerService(IRepository repository)
        {
            this.repository = repository;
        }

        /// <summary>
        /// Checks if password is valid using given validators
        /// </summary>
        /// <param name="password">String password</param>
        /// <param name="validators">Collection of validators</param>
        /// <returns>Returns bool value indicating if password is correct and message</returns>
        public (bool, string) VerifyPassword(string password, IEnumerable<IPasswordChecker> validators)
        {
            foreach (var checker in validators)
            {
                var result = checker.Check(password);
                if (!result.Item1)
                {
                    return result;
                }
            }

            this.repository.Create(password);

            return (true, "Password is Ok. User was created");
        }
    }
}
