using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Go_To_HomePage()
        {
            //start off by creating an API we want to use, remmber the tests are not dependent on Selenium.
            Pages.HomePage.Goto();
            Assert.IsTrue(Pages.HomePage.IsAt("Careify"));
        }

        [TestMethod]
        public void Can_Login_Careify()
        {
            Pages.HomePage.Goto();
            Pages.HomePage.clickLoginLink();
            Pages.HomePage.enterCredentials("sarahney001@gmail.com", "Password1!");
            Assert.IsTrue(Pages.HomePage.IsAt("Careify")); //It would be nice if each page had differing title i.e 'Dashboard' or 'Visits Index'...

        }

        //[TestCleanup()] *** for some reason the session id was getting messed up by this I may try using browser.quit() in the future?
        //public void CleanUp()
        //{
        //    Browser.Close();
        //}
    }
}
