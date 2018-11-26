using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerServiceTests
    {
        [Test]
        public static void TestCheckerService()
        {
            PasswordCheckerService service = new PasswordCheckerService();
            string password = "";
            Assert.False(service.VerifyPassword(password, new Predicate<string>[] { service.predicate2 }).Item1);
        }

        [Test]
        public static void TestCheckerService1()
        {
            PasswordCheckerService service = new PasswordCheckerService();
            string password = "1";
            Assert.True(service.VerifyPassword(password, new Predicate<string>[] { (str) =>  str.Length == 1 }).Item1);
        }
    }
}
