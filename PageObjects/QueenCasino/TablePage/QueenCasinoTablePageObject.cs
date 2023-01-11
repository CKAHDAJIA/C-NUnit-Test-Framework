using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.Common.TablePage;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.QueenCasino.Common.TablePage
{
    internal class QueenCasinoTablePageObject : BaseTablePageObject
    {
        [FindsBy(How = How.CssSelector, Using = "iframe.game-iframe")]
        public override IWebElement IFrame { get ; set ; }
        public QueenCasinoTablePageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }


    }
}
