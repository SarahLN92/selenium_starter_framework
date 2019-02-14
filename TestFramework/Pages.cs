using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace TestFramework
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            { var homePage = new HomePage();
                PageFactory.InitElements(Browser.Driver, homePage);
            return homePage;
            }
        }
    }

    public partial class HomePage
    {
        static string Url = "http://evv-master.s3-website-us-east-1.amazonaws.com/login";
 
        public void Goto()
        {
            Browser.Goto(Url);
        }

        public bool IsAt(string pageTitle)
        {
            return Browser.Title == pageTitle;
        }

        [FindsBy(How = How.LinkText, Using = "Login")]
        private IWebElement loginLink;

        public void clickLoginLink()
        {
            loginLink.Click();
        }

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement userNameInput;

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement userPasswordInput;

        [FindsBy(How = How.ClassName, Using = "btn-primary")]
        private IWebElement loginSubmitButton;

        public void enterCredentials(string userName, string userPassword)
        {
            userNameInput.SendKeys(userName);
            userPasswordInput.SendKeys(userPassword);
            loginSubmitButton.Click();

        }

    }
}
