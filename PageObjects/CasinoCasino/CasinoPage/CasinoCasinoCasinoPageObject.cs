using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.CasinoPage;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.CasinoCasino.CasinoPage
{
    internal class CasinoCasinoCasinoPageObject : BaseCasinoPageObject
    {

        [FindsBy(How = How.CssSelector, Using = ".game-iframe")]
        public override IWebElement IFrame { get ; set ; }

        public CasinoCasinoCasinoPageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
