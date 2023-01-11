using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using QnxTest.PageObjects.Base.SlotPage;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.Hachislot.SlotPage
{
    internal class HachislotSlotPageObject : BaseSlotPageObject
    {
        [FindsBy(How = How.CssSelector, Using = ".game-iframe")]
        public override IWebElement IFrame { get ; set ; }

        public HachislotSlotPageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
    }
}
