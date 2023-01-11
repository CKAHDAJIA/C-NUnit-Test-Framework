using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.Common.Header;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.LibertyCasino.Common.Header
{
    internal class LibertyCasinoLoginWidgetObject : BaseLoginWidgetObject
    {

        [FindsBy(How = How.XPath, Using = ".//span[normalize-space()='Sign Up / Login']")]
        public override IWebElement LoginDropdownButton { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email or Username']")]
        public override IWebElement Email { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        public override IWebElement Password { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public override IWebElement Submit { get ; set ; }

        public LibertyCasinoLoginWidgetObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
