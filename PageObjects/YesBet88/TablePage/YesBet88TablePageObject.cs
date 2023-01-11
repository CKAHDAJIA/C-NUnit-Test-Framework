using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.Common.TablePage;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.YesBet88.TablePage
{
    internal class YesBet88TablePageObject : BaseTablePageObject
    {
        [FindsBy(How = How.CssSelector, Using = ".game-iframe")]
        public override IWebElement IFrame { get ; set ; }

        public YesBet88TablePageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

    }
}
