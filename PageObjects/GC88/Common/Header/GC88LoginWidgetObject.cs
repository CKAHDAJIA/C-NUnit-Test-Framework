using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.Common.Header;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.GC88.Common.Header
{
    internal class GC88LoginWidgetObject : BaseLoginWidgetObject
    {

        [FindsBy(How = How.XPath, Using = "//span[@class='icon icon-user']")]
        public override IWebElement LoginDropdownButton { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email or Username']")]
        public override IWebElement Email { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        public override IWebElement Password { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public override IWebElement Submit { get ; set ; }

        public GC88LoginWidgetObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
