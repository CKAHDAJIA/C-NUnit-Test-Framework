using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.LoginPage;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.SportsLab.LoginPage
{
    internal class SportslabLoginPageObject : BaseLoginPageObject
    {

        [FindsBy(How = How.XPath, Using = "//input[@type='email']")]
        public override IWebElement Email { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//input[@type='password']")]
        public override IWebElement Password { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public override IWebElement Submit { get ; set ; }

        public SportslabLoginPageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
