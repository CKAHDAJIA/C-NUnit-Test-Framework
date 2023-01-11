using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QnxTest.PageObjects.Base.VirtualPage
{
    internal abstract class BaseVirtualPageObject : BasePageObject
    {
        public abstract IWebElement IFrame { get; set; }
        protected BaseVirtualPageObject(IWebDriver driver, WebDriverWait wait) : base(driver, wait)
        {
        }

        public virtual void WaitIFrameDisplayed()
        {
            Wait.Until(driver => IFrame.Displayed);
        }

    }
}
