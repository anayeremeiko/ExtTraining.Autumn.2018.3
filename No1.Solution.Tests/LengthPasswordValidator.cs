using System;

namespace No1.Solution.Tests
{
    class LengthPasswordValidator : IPasswordChecker
    {
        private readonly int length;

        public LengthPasswordValidator(int length)
        {
            if (length <= 0)
            {
                throw new ArgumentException();
            }

            this.length = length;
        }

        public (bool, string) Check(string password)
        {
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            if (password.Length < this.length)
            {
                return (false, $"{password} is too short!");
            }

            return (true, $"{password} is OK!");
        }
    }
}
