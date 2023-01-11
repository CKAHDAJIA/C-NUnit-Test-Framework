using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.LoginPage;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.QueenCasino.LoginPage
{
    internal class QueenCasinoLoginPageObject : BaseLoginPageObject
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email or Username']")]
        public override IWebElement Email { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        public override IWebElement Password { get ; set ; }

        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        public override IWebElement Submit { get ; set ; }
        public QueenCasinoLoginPageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

    }
}
