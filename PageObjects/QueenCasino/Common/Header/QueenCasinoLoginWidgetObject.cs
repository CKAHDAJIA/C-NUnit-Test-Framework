using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.Common.Header;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.QueenCasino.Common.Header
{
    internal class QueenCasinoLoginWidgetObject : BaseLoginWidgetObject
    {

        [FindsBy(How = How.CssSelector, Using = ".btn-login.button")]
        public override IWebElement LoginDropdownButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email or Username']")]
        public override IWebElement Email { get ; set ; }

        [FindsBy(How = How.XPath,Using = "//input[@placeholder='Password']")]
        public override IWebElement Password { get ; set ; }

        [FindsBy(How = How.XPath,Using = "//button[@type='submit']")]
        public override IWebElement Submit { get; set; }

        

        public QueenCasinoLoginWidgetObject(IWebDriver driver,WebDriverWait wait) : base(driver,wait)
        {
        }


    }

}
