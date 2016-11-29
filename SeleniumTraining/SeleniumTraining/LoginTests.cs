using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SeleniumTraining
{
    [TestClass]
    public class LoginTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void CheckLoginPage()
        {
            BaseTest.GoTo();
            Assert.IsTrue(
                BaseTest.IsAtPage("");
                //BaseTest. IsAtPage("Page down");
        }

        [TestMethod]
        public  void LogInAsAdmin()
        {
            BaseTest.GoTo();
            BaseTest.LoginAs("")
                .withPassword("")
                .Login();
        }
    }
}
