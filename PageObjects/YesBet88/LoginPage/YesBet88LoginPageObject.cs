using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.LoginPage;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.YesBet88.LoginPage
{
    internal class YesBet88LoginPageObject : BaseLoginPageObject
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Username']")]
        public override IWebElement Email { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        public override IWebElement Password { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public override IWebElement Submit { get ; set ; }
        public YesBet88LoginPageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

    }
}
