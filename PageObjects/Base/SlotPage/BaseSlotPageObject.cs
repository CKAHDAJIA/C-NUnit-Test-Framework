using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.Base.SlotPage
{
    internal abstract class BaseSlotPageObject : BasePageObject
    {
        public abstract IWebElement IFrame { get; set; }

        protected BaseSlotPageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }
        public virtual void WaitIFrameDisplayed()
        {
            Wait.Until(driver => IFrame.Displayed);
        }
    }
}
