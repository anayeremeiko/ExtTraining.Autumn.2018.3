using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace No1.Solution.Tests
{
    [TestFixture]
    public class PasswordCheckerTest
    {
        [TestCase(null, ExpectedResult =false)]
        [TestCase("", ExpectedResult = false)]
        [TestCase("222", ExpectedResult = false)]
        [TestCase("8562649633dsasdasadsadsad", ExpectedResult = false)]
        [TestCase("222222222222", ExpectedResult = false)]
        [TestCase("dsdssddsds", ExpectedResult = false)]
        public bool PasswordTest_WrongData_FalseResult(string password)
        {
            CustomPasswordValidator customValidator = new CustomPasswordValidator();

            try
            {
                customValidator.Validate(password);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
