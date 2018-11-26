using System;

namespace No1.Solution.Tests
{
    class NumberPasswordValidator : IPasswordChecker
    {
        private const string NUMBERS = "1234567890";

        public (bool, string) Check(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            foreach (var c in password)
            {
                if (NUMBERS.IndexOf(c) != -1)
                {
                    return (false, $"{password} contains digits!");
                }
            }

            return (true, $"{password} is OK!");
        }
    }
}
