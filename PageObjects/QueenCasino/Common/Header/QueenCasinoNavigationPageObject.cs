using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.Common.Home_Page;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.QueenCasino.Common.Home_Page
{
    internal class QueenCasinoNavigationPageObject : BaseNavigationWidgetObject
    {


        [FindsBy(How=How.XPath, Using = "//a[@class='i-casino']")]
        public override IWebElement LiveCasino { get ; set ; }
        public override IWebElement Slots { get ; set ; }
        public override IWebElement TableGames { get ; set ; }
        public override IWebElement SportsBet { get ; set ; }
        public override IWebElement Esports { get ; set ; }
        public override IWebElement Virtual { get ; set ; }
        public override IWebElement Promotions { get ; set ; }
        public override IWebElement Deposits { get ; set ; }

        public QueenCasinoNavigationPageObject(IWebDriver driver, WebDriverWait wait) : base(driver,wait)
        {
        }

        internal void HomePageActions()
        {
            throw new NotImplementedException();
        }
    }
}
