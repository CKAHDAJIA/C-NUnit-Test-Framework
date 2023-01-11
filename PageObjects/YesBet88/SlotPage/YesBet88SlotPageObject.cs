using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.SlotPage;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.YesBet88.SlotPage
{
    internal class YesBet88SlotPageObject : BaseSlotPageObject
    {

        [FindsBy(How = How.CssSelector, Using = ".game-iframe")]
        public override IWebElement IFrame { get ; set ; }

        public YesBet88SlotPageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

    }
}
