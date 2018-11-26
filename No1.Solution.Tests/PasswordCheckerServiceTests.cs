using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [Test]
        public void PasswordCheckerService_NullChecker_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PasswordCheckerService(new SqlRepository(), (IChecker) null));
        }

        [Test]
        public void PasswordCheckerService_NullRepository_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PasswordCheckerService(null, new CheckLogic()));
        }

        [Test]
        public void PasswordCheckerService_NullDelegate_ThrowArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PasswordCheckerService(new SqlRepository(), (Func<string, (bool, string)>) null));
        }

        [Test]
        public void PasswordCheckerService_Success()
        {
            var service = new PasswordCheckerService(new SqlRepository(), new CheckLogic());
            var expected = (true, "Password is Ok. User was created");
            var actual = service.VerifyPassword("test1 password");
            Assert.AreEqual(expected.Item1, actual.Item1);
            Assert.AreEqual(expected.Item2, actual.Item2);
        }

        [TestCase("test password")]
        [TestCase("test")]
        [TestCase("big test password")]
        [TestCase("12345689")]
        public void PasswordCheckerService_False(string password)
        {
            var service = new PasswordCheckerService(new SqlRepository(), new CheckLogic());
            var expected = (false, "");
            var actual = service.VerifyPassword(password);
            Assert.AreEqual(expected.Item1, actual.Item1);
        }
    }
}
