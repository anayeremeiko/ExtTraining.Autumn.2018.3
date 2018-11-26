namespace No1.Solution.Tests
{
    using System.Collections.Generic;

    using NUnit.Framework;

    [TestFixture]
    class PasswordCheckerServiceTests
    {
        [TestCase("abcdefg", ExpectedResult = true)]
        [TestCase("abc", ExpectedResult = false)]
        [TestCase("abcdef2", ExpectedResult = false)]
        public bool VerifyPassword_ValidInput_ValidResult(string password)
        {
            List<IPasswordChecker> checkers = new List<IPasswordChecker>(2);
            checkers.Add(new LengthPasswordValidator(4));
            checkers.Add(new NumberPasswordValidator());
            SqlRepository repository = new SqlRepository();
            var service = new PasswordCheckerService(repository);
            return service.VerifyPassword(password, checkers).Item1;
        }
    }
}
