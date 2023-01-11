using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.Common.Header;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.SportsLab.Common.Header
{
    internal class SportslabLoginWidgetObject : BaseLoginWidgetObject
    {
        [FindsBy(How = How.XPath, Using = "//button[@class='login-button']")]
        public override IWebElement LoginDropdownButton { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//input[@type='email']")]
        public override IWebElement Email { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//input[@type='password']")]
        public override IWebElement Password { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public override IWebElement Submit { get ; set ; }

        public SportslabLoginWidgetObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
