using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.Utilities;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.Base.LoginPage
{
    internal abstract class BaseLoginPageObject : BasePageObject
    {

        public abstract IWebElement Email { get; set; }
        public abstract IWebElement Password { get; set; }
        public abstract IWebElement Submit { get; set; }

        public String LoggedInCssSelector = "body.logged-in";
        protected BaseLoginPageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public virtual void LoginAction(String username, String password)
        {

            Wait.Until(diver => Email.Displayed);
            Email.SendKeys(username);
            Password.SendKeys(password);
            Wait.Until(driver => Submit.Displayed);
            Submit.Click();

        }

        public virtual void LoginActionWithJavascript(String username, String password) {
            Wait.Until(diver => Email.Displayed);
            Email.SendKeys(username);
            Password.SendKeys(password);
            Wait.Until(driver => Submit.Displayed);
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("document.getElementsByClassName('btn-log-in')[0].click()");
        }

        public virtual void WaitLoggedIn()
        {
            Driver.FindElement(By.CssSelector(LoggedInCssSelector), 20);
        }
    }
}
