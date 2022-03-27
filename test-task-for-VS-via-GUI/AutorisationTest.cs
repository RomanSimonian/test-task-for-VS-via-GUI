using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_task_for_VS_via_GUI
{
    class AutorisationTest : BaseTest
    {
        [TestCase("User4", "testmail@gmail.com", true)]
        [TestCase("", "testmail@gmail.com", false)]
        [TestCase("User4", "", false)]
        public void LogInAplicationTest(string userName, string email, bool expectedResult)
        {
            HomePage homePage = new HomePage(driver);

            var actualResult = homePage.LogIn(userName, email);

            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
